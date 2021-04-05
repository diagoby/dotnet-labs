using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
            DataView dataView = GetMatrixDataView();
            bindsrcMatrix.DataSource = dataView;
            dtgridvMatrix.DataSource = bindsrcMatrix;
        }

        private DataView GetMatrixDataView()
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

                return GetMatrixDataView();
            }

            return new DataView(dataSet.Tables[0]);
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
