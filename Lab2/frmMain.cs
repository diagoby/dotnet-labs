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
            DataSet dataSet = new DataSet();
            MatrixFileDataAdapter dataAdapter = new MatrixFileDataAdapter();
            dataAdapter.Fill(dataSet);

            DataView dataView = new DataView(dataSet.Tables[0]);
            bindsrcMatrix.DataSource = dataView;
            dtgridvMatrix.DataSource = bindsrcMatrix;
        }
    }
}
