﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
	public static class Validator
	{
		private static string title = "Entry Error";
        //Jonathan Sanjuan
        public static string Title
		{
			get => title;
			set => title = value;
		}
        //Jonathan Sanjuan
        public static bool IsPresent(TextBox textBox)
		{
			if (textBox.Text == "")
			{
				MessageBox.Show(textBox.Tag + " is a required field.", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}
        //Jonathan Sanjuan
        public static bool IsDecimal(TextBox textBox)
		{
			decimal number = 0m;
			if (Decimal.TryParse(textBox.Text, out number))
			{
				return true;
			}
			else
			{
				MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
				textBox.Focus();
				return false;
			}
		}
        //Jonathan Sanjuan
        public static bool IsInt32(TextBox textBox)
		{
			int number = 0;
			if (Int32.TryParse(textBox.Text, out number))
			{
				return true;
			}
			else
			{
				MessageBox.Show(textBox.Tag + " must be an integer.", Title);
				textBox.Focus();
				return false;
			}
		}
        //Jonathan Sanjuan
        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
		{
			decimal number = Convert.ToDecimal(textBox.Text);
			if (number < min || number > max)
			{
				MessageBox.Show(textBox.Tag + " must be between " + min
					+ " and " + max + ".", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}
	}
}
