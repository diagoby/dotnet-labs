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

        private List<int> aArr = new();

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
				/*aArr = Regex.Split(tboxArrA.Text, ",?\\s").Select(int.Parse).ToList();*/
				IEnumerable<int> enumerable = Regex.Split(tboxArrA.Text, ",?\\s*")
					.Where(token => !string.IsNullOrWhiteSpace(token))
					.Select(int.Parse);

				aArr = new List<int>(enumerable);

				Debug.WriteLine(aArr.ToString());
			}
		}

		private bool IsArrayStringValid(string arr) => new Regex(NUBMERS_LIST_PATTERN).IsMatch(arr);
	}
}
