using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class MainForm : Form
    {
        private readonly List<int> bArr = new();

        private readonly List<int> aArr = new();

        public MainForm()
        {
            InitializeComponent();
        }

		private void tstripFileExit_Click(object sender, EventArgs e) => Close();

		private void tboxArrA_Validating(object sender, CancelEventArgs e)
        {
            /*if(!IsArrayStringValid(tboxArrA.Text))
			{
				MessageBox.Show("Invalid array syntax");
				e.Cancel = true;
			}*/
        }

        private bool IsArrayStringValid(string arr)
        {
			Regex arrayPattern = new Regex("^(-?\\d+|\\s|,)*$");
            return arrayPattern.IsMatch(arr);
        }

		private void tboxArrA_TextChanged(object sender, EventArgs e)
		{
            errpvdArrA.SetError(tboxArrA, !IsArrayStringValid(tboxArrA.Text) ? "Enter a valid list" : "");
		}
	}
}
