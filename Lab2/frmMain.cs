using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) 
        {
            DataTable dataTable = ReadMatrixDataTable();
            bindsrcMatrix.DataSource = dataTable;
            dtgridvMatrix.DataSource = bindsrcMatrix;

            MarkPrimeCells();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bindsrcMatrix.EndEdit();

            DataTable dataTable = (DataTable) bindsrcMatrix.DataSource;
            WriteMatrixDataTable(dataTable);
        }

        private void dtgridvMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgridvMatrix.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            if (IsCellPrimeNumber(cell))
            {
                MarkCellBold(cell);
            }
        }

        private DataTable ReadMatrixDataTable()
        {
            DataSet dataSet = new DataSet();

            var dataAdapter = new MatrixFileDataAdapter(GetFilePath());
            try
            {
                dataAdapter.Fill(dataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return ReadMatrixDataTable();
            }

            return dataSet.Tables[0];
        }

        private void WriteMatrixDataTable(DataTable table)
        {
            var dataAdapter = new MatrixFileDataAdapter(GetFilePath());
            try
            {
                dataAdapter.Update(table.DataSet);

                MessageBox.Show("Saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MarkPrimeCells()
        {
            var primeCells = dtgridvMatrix.Rows.OfType<DataGridViewRow>()
                .SelectMany(row => row.Cells.OfType<DataGridViewCell>())
                .Where(IsCellPrimeNumber);

            foreach (var cell in primeCells) { 
                MarkCellBold(cell); 
            }
        }

        private void MarkCellBold(DataGridViewCell cell)
        {
            cell.Style.Font = new Font(dtgridvMatrix.DefaultCellStyle.Font, FontStyle.Bold);
        }

        private bool IsCellPrimeNumber(DataGridViewCell cell) => int
            .TryParse((string) cell.Value, out int num) && IsPrimeNumber(num);

        private bool IsPrimeNumber(int num) => num > 1 && Enumerable
            .Range(2, num - 2)
            .All(i => num % i != 0);

        private string GetFilePath()
        {
            using OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files (*.txt)|*.txt";
            fileDialog.CheckFileExists = true;

            if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                return GetFilePath();
            }

            return fileDialog.FileName;
        }
    }
}
