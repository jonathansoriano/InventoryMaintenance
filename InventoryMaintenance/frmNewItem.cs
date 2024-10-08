﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {
        //Jonathan Sanjuan
        public frmNewItem()
        {
            InitializeComponent();
        }

        private InvItem invItem = null;

        //Jonathan Sanjuan
        public InvItem GetNewItem()
        {
            LoadComboBox();
            this.ShowDialog();
            return invItem;
        }
        //Jonathan Sanjuan
        private void LoadComboBox()
        {
            cboSizeOrManufacturer.Items.Clear();
            if (rdoPlant.Checked)
            {
                cboSizeOrManufacturer.Items.Add("1 gallon");
                cboSizeOrManufacturer.Items.Add("5 gallon");
                cboSizeOrManufacturer.Items.Add("15 gallon");
                cboSizeOrManufacturer.Items.Add("24-inch box");
                cboSizeOrManufacturer.Items.Add("36-inch box");
            }
            else
            {
                cboSizeOrManufacturer.Items.Add("Bayer");
                cboSizeOrManufacturer.Items.Add("Jobe's");
                cboSizeOrManufacturer.Items.Add("Ortho");
                cboSizeOrManufacturer.Items.Add("Roundup");
                cboSizeOrManufacturer.Items.Add("Scotts");
            }
        }
        //Jonathan Sanjuan
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                //Here you should create a new item of the appropriate type using the data entered by the user (use the invItem as the item variable)
                this.Close();
                if (rdoPlant.Checked)
                {
                    invItem = new Plant(Convert.ToInt32(txtItemNo.Text), txtDescription.Text, Convert.ToDecimal(txtPrice.Text), cboSizeOrManufacturer.Text);
                }
                else
                {
                    invItem = new Supply(Convert.ToInt32(txtItemNo.Text), txtDescription.Text, Convert.ToDecimal(txtPrice.Text), cboSizeOrManufacturer.Text);
                }

            }
        }
        //Jonathan Sanjuan
        private bool IsValidData()
        {
            return Validator.IsPresent(txtItemNo) &&
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }
        //Jonathan Sanjuan
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Jonathan Sanjuan
        private void rdoPlant_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPlant.Checked)
            {
                lblSizeOrManufacturer.Text = "Size:";
            }
            else
            {
                lblSizeOrManufacturer.Text = "Manufacturer:";
            }
            LoadComboBox();
        }

    }
}
