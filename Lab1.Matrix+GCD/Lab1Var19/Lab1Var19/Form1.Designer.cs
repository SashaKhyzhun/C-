namespace Lab1Var19
{
    partial class Form1
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
            this.OutputDGV = new System.Windows.Forms.DataGridView();
            this.nNumUD = new System.Windows.Forms.NumericUpDown();
            this.mNumUD = new System.Windows.Forms.NumericUpDown();
            this.nLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.DoBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OutputDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputDGV
            // 
            this.OutputDGV.AllowUserToAddRows = false;
            this.OutputDGV.AllowUserToDeleteRows = false;
            this.OutputDGV.AllowUserToResizeColumns = false;
            this.OutputDGV.AllowUserToResizeRows = false;
            this.OutputDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OutputDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputDGV.ColumnHeadersVisible = false;
            this.OutputDGV.Location = new System.Drawing.Point(13, 13);
            this.OutputDGV.Name = "OutputDGV";
            this.OutputDGV.ReadOnly = true;
            this.OutputDGV.RowHeadersVisible = false;
            this.OutputDGV.Size = new System.Drawing.Size(259, 150);
            this.OutputDGV.TabIndex = 0;
            // 
            // nNumUD
            // 
            this.nNumUD.Location = new System.Drawing.Point(31, 169);
            this.nNumUD.Name = "nNumUD";
            this.nNumUD.Size = new System.Drawing.Size(43, 20);
            this.nNumUD.TabIndex = 1;
            this.nNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mNumUD
            // 
            this.mNumUD.Location = new System.Drawing.Point(31, 195);
            this.mNumUD.Name = "mNumUD";
            this.mNumUD.Size = new System.Drawing.Size(43, 20);
            this.mNumUD.TabIndex = 2;
            this.mNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(9, 171);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(16, 13);
            this.nLabel.TabIndex = 3;
            this.nLabel.Text = "n:";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(9, 197);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(18, 13);
            this.mLabel.TabIndex = 4;
            this.mLabel.Text = "m:";
            // 
            // DoBtn
            // 
            this.DoBtn.Location = new System.Drawing.Point(209, 169);
            this.DoBtn.Name = "DoBtn";
            this.DoBtn.Size = new System.Drawing.Size(63, 46);
            this.DoBtn.TabIndex = 5;
            this.DoBtn.Text = "DO";
            this.DoBtn.UseVisualStyleBackColor = true;
            this.DoBtn.Click += new System.EventHandler(this.DoBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(140, 169);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(63, 46);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 224);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.DoBtn);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.mNumUD);
            this.Controls.Add(this.nNumUD);
            this.Controls.Add(this.OutputDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "GCD For Matrix";
            ((System.ComponentModel.ISupportInitialize)(this.OutputDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OutputDGV;
        private System.Windows.Forms.NumericUpDown nNumUD;
        private System.Windows.Forms.NumericUpDown mNumUD;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Button DoBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}

