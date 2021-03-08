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
		private const string NUBMERS_LIST_PATTERN = "^(-?\\d+|\\s|,)*$";
		private List<int> bArr = new();

        private int[] aArr;

        public MainForm()
        {
            InitializeComponent();
        }

		private void tstripFileExit_Click(object sender, EventArgs e) => Close();

		private void tboxArrA_TextChanged(object sender, EventArgs e)
		{
            errpvdArrA.SetError(tboxArrA, !IsArrayStringValid(tboxArrA.Text) ? "Enter a valid list" : "");

			if(IsArrayStringValid(tboxArrA.Text))
			{
				aArr = Regex.Split(tboxArrA.Text, "\\D+")
					.Where(token => !string.IsNullOrWhiteSpace(token))
					.Select(int.Parse)
					.ToArray();
			}
		}

		private bool IsArrayStringValid(string arr) => new Regex(NUBMERS_LIST_PATTERN).IsMatch(arr);
	}
}
