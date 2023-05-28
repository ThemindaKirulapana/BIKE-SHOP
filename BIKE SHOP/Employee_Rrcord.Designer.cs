namespace BIKE_SHOP
{
    partial class Employee_Rrcord
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
            this.GridViewEmpRecord = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBCK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmpRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewEmpRecord
            // 
            this.GridViewEmpRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewEmpRecord.Location = new System.Drawing.Point(83, 149);
            this.GridViewEmpRecord.Name = "GridViewEmpRecord";
            this.GridViewEmpRecord.RowHeadersWidth = 51;
            this.GridViewEmpRecord.RowTemplate.Height = 24;
            this.GridViewEmpRecord.Size = new System.Drawing.Size(746, 394);
            this.GridViewEmpRecord.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("QuickType", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLOYEE RECORD";
            // 
            // buttonBCK
            // 
            this.buttonBCK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBCK.ForeColor = System.Drawing.Color.Lavender;
            this.buttonBCK.Location = new System.Drawing.Point(43, 13);
            this.buttonBCK.Name = "buttonBCK";
            this.buttonBCK.Size = new System.Drawing.Size(75, 23);
            this.buttonBCK.TabIndex = 2;
            this.buttonBCK.Text = "BACK";
            this.buttonBCK.UseVisualStyleBackColor = false;
            this.buttonBCK.Click += new System.EventHandler(this.buttonBCK_Click);
            // 
            // Employee_Rrcord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(926, 603);
            this.Controls.Add(this.buttonBCK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewEmpRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_Rrcord";
            this.Text = "Employee_Rrcord";
            this.Load += new System.EventHandler(this.Employee_Rrcord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmpRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewEmpRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBCK;
    }
}