/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/17/2018
 * Time: 1:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Numerics;
namespace BigInt
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public bool IsNumber(string Snumber)
		{
			
			Regex regex = new Regex(@"^[-+0-9]*[-+0-9]$");
            return regex.IsMatch(Snumber);
		}
		void TxtNumber1TextChanged(object sender, EventArgs e)
		{
			string number1= txtNumber1.Text;
			if (number1.Length > 40 || IsNumber(number1) == false)
			{
				MessageBox.Show("Please input a valid number.", "Declare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtNumber1.Text = "";
			}
		}
		
		void TxtNumber2TextChanged(object sender, EventArgs e)
		{
			string number2 = txtNumber2.Text;
			
			if (number2.Length > 40 || IsNumber(number2) == false)
			{
				MessageBox.Show("Please input a valid number.", "Declare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtNumber2.Text = "";
			}
			
		}
		
		void BtnCaculatorClick(object sender, EventArgs e)
		{
			
			//txtResult.Text = "0";
			 
			string first = txtNumber1.Text;
			clsBigInt a = new clsBigInt();
			clsBigInt b = new clsBigInt();
			string second = txtNumber2.Text;
			if(first.ToCharArray()[0] == '-')
			{
				a.signum = -1;
				first = first.Substring(1, first.Length - 1);
			}
			if(first.ToCharArray()[0] == '+')
			{
				a.signum = 1;
				first = first.Substring(1, first.Length - 1);
			}
			foreach (char c in first.ToCharArray())
			{
				try
				{
					int.Parse(""+c);
				}catch
				{
					
				}
			}
			a.Value = first;
			
			if(second.ToCharArray()[0] == '-')
			{
				b.signum = -1;
				second = second.Substring(1, second.Length - 1);
			}
			if(second.ToCharArray()[0] == '+')
			{
				b.signum = 1;
				second = second.Substring(1, second.Length - 1);
			}
			foreach (char c in second.ToCharArray())
			{
				try
				{
					int.Parse(""+c);
				}catch
				{
					
				}
			}
			b.Value = second;
			clsBigInt result = new clsBigInt();
			
			txtResult.Text = result.Value;
			if(result.signum == -1)
			{
				txtResult.Text = "-" + txtResult.Text;
			}
			if(result.signum == 1)
			{
				txtResult.Text = "" + txtResult.Text;
			}
			BigInteger em = BigInteger.Parse(txtNumber1.Text);
			BigInteger d = BigInteger.Parse(txtNumber2.Text);
			BigInteger f = em-d;
			txtResult.Text = f.ToString();
		}
		
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
