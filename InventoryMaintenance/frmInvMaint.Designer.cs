namespace InventoryMaintenance
{
    partial class frmInvMaint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstItems = new System.Windows.Forms.ListBox();
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 32;
            lstItems.Location = new System.Drawing.Point(28, 34);
            lstItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            lstItems.Name = "lstItems";
            lstItems.Size = new System.Drawing.Size(565, 324);
            lstItems.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(650, 36);
            btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(180, 53);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(650, 115);
            btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(180, 53);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(650, 194);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(180, 53);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmInvMaint
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(884, 399);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lstItems);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "frmInvMaint";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Jon Sanjuan's Inventory Maintenance Application";
            Load += frmInvMaint_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}

