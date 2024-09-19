namespace InventoryMaintenance
{
    partial class frmNewItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            txtItemNo = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtPrice = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            cboSizeOrManufacturer = new System.Windows.Forms.ComboBox();
            lblSizeOrManufacturer = new System.Windows.Forms.Label();
            rdoPlant = new System.Windows.Forms.RadioButton();
            rdoSupply = new System.Windows.Forms.RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 105);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 32);
            label1.TabIndex = 0;
            label1.Text = "Item no:";
            // 
            // txtItemNo
            // 
            txtItemNo.Location = new System.Drawing.Point(201, 100);
            txtItemNo.Margin = new System.Windows.Forms.Padding(4);
            txtItemNo.Name = "txtItemNo";
            txtItemNo.Size = new System.Drawing.Size(193, 39);
            txtItemNo.TabIndex = 3;
            txtItemNo.Tag = "Item no";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(33, 166);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(140, 32);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(201, 162);
            txtDescription.Margin = new System.Windows.Forms.Padding(4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(349, 39);
            txtDescription.TabIndex = 5;
            txtDescription.Tag = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(33, 294);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 32);
            label3.TabIndex = 4;
            label3.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(201, 290);
            txtPrice.Margin = new System.Windows.Forms.Padding(4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(193, 39);
            txtPrice.TabIndex = 9;
            txtPrice.Tag = "Price";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(201, 384);
            btnSave.Margin = new System.Windows.Forms.Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(145, 53);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(407, 384);
            btnCancel.Margin = new System.Windows.Forms.Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(145, 53);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cboSizeOrManufacturer
            // 
            cboSizeOrManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboSizeOrManufacturer.FormattingEnabled = true;
            cboSizeOrManufacturer.Location = new System.Drawing.Point(201, 226);
            cboSizeOrManufacturer.Margin = new System.Windows.Forms.Padding(4);
            cboSizeOrManufacturer.Name = "cboSizeOrManufacturer";
            cboSizeOrManufacturer.Size = new System.Drawing.Size(236, 40);
            cboSizeOrManufacturer.TabIndex = 7;
            // 
            // lblSizeOrManufacturer
            // 
            lblSizeOrManufacturer.AutoSize = true;
            lblSizeOrManufacturer.Location = new System.Drawing.Point(33, 228);
            lblSizeOrManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSizeOrManufacturer.Name = "lblSizeOrManufacturer";
            lblSizeOrManufacturer.Size = new System.Drawing.Size(62, 32);
            lblSizeOrManufacturer.TabIndex = 9;
            lblSizeOrManufacturer.Text = "Size:";
            // 
            // rdoPlant
            // 
            rdoPlant.AutoSize = true;
            rdoPlant.Checked = true;
            rdoPlant.Location = new System.Drawing.Point(201, 30);
            rdoPlant.Margin = new System.Windows.Forms.Padding(4);
            rdoPlant.Name = "rdoPlant";
            rdoPlant.Size = new System.Drawing.Size(98, 36);
            rdoPlant.TabIndex = 0;
            rdoPlant.TabStop = true;
            rdoPlant.Text = "Plant";
            rdoPlant.UseVisualStyleBackColor = true;
            rdoPlant.CheckedChanged += rdoPlant_CheckedChanged;
            // 
            // rdoSupply
            // 
            rdoSupply.AutoSize = true;
            rdoSupply.Location = new System.Drawing.Point(357, 30);
            rdoSupply.Margin = new System.Windows.Forms.Padding(4);
            rdoSupply.Name = "rdoSupply";
            rdoSupply.Size = new System.Drawing.Size(118, 36);
            rdoSupply.TabIndex = 1;
            rdoSupply.Text = "Supply";
            rdoSupply.UseVisualStyleBackColor = true;
            // 
            // frmNewItem
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(589, 463);
            ControlBox = false;
            Controls.Add(rdoSupply);
            Controls.Add(rdoPlant);
            Controls.Add(lblSizeOrManufacturer);
            Controls.Add(cboSizeOrManufacturer);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtItemNo);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewItem";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "New Inventory Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboSizeOrManufacturer;
        private System.Windows.Forms.Label lblSizeOrManufacturer;
        private System.Windows.Forms.RadioButton rdoPlant;
        private System.Windows.Forms.RadioButton rdoSupply;
    }
}