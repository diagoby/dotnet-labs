using System;
using System.Data;
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bindsrcMatrix.EndEdit();

            DataTable dataTable = (DataTable) bindsrcMatrix.DataSource;
            WriteMatrixDataTable(dataTable);
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

        private string GetFilePath()
        {
            using OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files (*.txt)|*.txt";
            fileDialog.CheckFileExists = true;

            if(fileDialog.ShowDialog() != DialogResult.OK)
            {
                return GetFilePath();
            }

            return fileDialog.FileName;
        }
    }
}
