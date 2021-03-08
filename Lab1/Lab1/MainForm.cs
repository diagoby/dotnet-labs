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
		private const string NUBMERS_LIST_SEPARATOR_PATTERN = "[^\\d-]+";

		private int[] arrB;
		private double[] arrA;

		public MainForm()
		{
			InitializeComponent();
		}

		private void tstripFileExit_Click(object sender, EventArgs e) => Close();

		private void tboxArrA_TextChanged(object sender, EventArgs e)
		{
			if (!IsArrayStringValid(tboxArrB.Text))
			{
				/* Set validation provider error */
				errpvdArrA.SetError(tboxArrB, @"Enter list of numbers should be separated by "", "" and(or) whitespaces");

				return;
			}

			/* Clear validation provider errors */
			errpvdArrA.Clear();

			arrB = NumbersStringToArray(tboxArrB.Text);

			double[] seq = GenerateSequence(arrB);
			double[] positiveSeq = seq.Where(num => num > 0).ToArray();

			if(positiveSeq.Length > 0)
			{
				arrA = seq.Where(num => num < positiveSeq.Average()).ToArray();
				tboxArrA.Text = string.Join(", ", arrA.Select(num => num.ToString("F4")));
			} else
			{
				tboxArrA.Clear();
			}
		}

		private bool IsArrayStringValid(string arr) => new Regex(NUBMERS_LIST_PATTERN).IsMatch(arr);

		private int[] NumbersStringToArray(string arr) => Regex
			.Split(tboxArrB.Text, NUBMERS_LIST_SEPARATOR_PATTERN)
			.Where(token => !string.IsNullOrWhiteSpace(token))
			.Select(int.Parse)
			.ToArray();

		private double[] GenerateSequence(int[] arr) 
		{
			double[] sequence = new double[arr.Length];

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0, sin = 1; j < i + 1; j += 1, sin += 2)
				{
					if(j % 2 == 0)
					{
						sequence[i] += arr[j] * Math.Pow(Math.Sin(sin), j + 1);
					} else
					{
						sequence[i] -= arr[j] * Math.Pow(Math.Cos(sin), j + 1);
					}
				}
			}

			return sequence;
		}
	}
}
