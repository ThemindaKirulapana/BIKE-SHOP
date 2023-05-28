namespace BIKE_SHOP
{
    partial class invoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIId = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtChas_num = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.txtbillFinal = new System.Windows.Forms.TextBox();
            this.bTNcal = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnupdat = new System.Windows.Forms.Button();
            this.BTNdlete = new System.Windows.Forms.Button();
            this.btnSeeiNVOICERecords = new System.Windows.Forms.Button();
            this.grdBikeStocks = new System.Windows.Forms.DataGridView();
            this.buttonSeeBike = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.GRDcusRecords = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCustomerSee = new System.Windows.Forms.Button();
            this.grdINVOICE = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdBikeStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRDcusRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdINVOICE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVOICE";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "INVOICE ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = " CUSTOMER NIC NUMBER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chassis Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "DISCOUNT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "PRICE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "FINAL BILL";
            // 
            // txtIId
            // 
            this.txtIId.Location = new System.Drawing.Point(344, 71);
            this.txtIId.Name = "txtIId";
            this.txtIId.Size = new System.Drawing.Size(240, 22);
            this.txtIId.TabIndex = 5;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(344, 108);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(240, 22);
            this.txtNIC.TabIndex = 5;
            // 
            // txtChas_num
            // 
            this.txtChas_num.Location = new System.Drawing.Point(344, 141);
            this.txtChas_num.Name = "txtChas_num";
            this.txtChas_num.Size = new System.Drawing.Size(240, 22);
            this.txtChas_num.TabIndex = 5;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(344, 182);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(240, 22);
            this.textprice.TabIndex = 5;
            // 
            // txtDis
            // 
            this.txtDis.Location = new System.Drawing.Point(344, 212);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(240, 22);
            this.txtDis.TabIndex = 5;
            // 
            // txtbillFinal
            // 
            this.txtbillFinal.Location = new System.Drawing.Point(344, 250);
            this.txtbillFinal.Name = "txtbillFinal";
            this.txtbillFinal.Size = new System.Drawing.Size(240, 22);
            this.txtbillFinal.TabIndex = 5;
            // 
            // bTNcal
            // 
            this.bTNcal.BackColor = System.Drawing.Color.Cyan;
            this.bTNcal.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTNcal.Location = new System.Drawing.Point(41, 294);
            this.bTNcal.Name = "bTNcal";
            this.bTNcal.Size = new System.Drawing.Size(126, 37);
            this.bTNcal.TabIndex = 6;
            this.bTNcal.Text = "CALCULATE";
            this.bTNcal.UseVisualStyleBackColor = false;
            this.bTNcal.Click += new System.EventHandler(this.bTNcal_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.Color.Cyan;
            this.btnSAVE.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.Location = new System.Drawing.Point(197, 294);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(128, 37);
            this.btnSAVE.TabIndex = 6;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnupdat
            // 
            this.btnupdat.BackColor = System.Drawing.Color.Cyan;
            this.btnupdat.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdat.Location = new System.Drawing.Point(357, 297);
            this.btnupdat.Name = "btnupdat";
            this.btnupdat.Size = new System.Drawing.Size(124, 34);
            this.btnupdat.TabIndex = 6;
            this.btnupdat.Text = "UPDATE";
            this.btnupdat.UseVisualStyleBackColor = false;
            this.btnupdat.Click += new System.EventHandler(this.btnupdat_Click);
            // 
            // BTNdlete
            // 
            this.BTNdlete.BackColor = System.Drawing.Color.Cyan;
            this.BTNdlete.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdlete.Location = new System.Drawing.Point(495, 297);
            this.BTNdlete.Name = "BTNdlete";
            this.BTNdlete.Size = new System.Drawing.Size(112, 34);
            this.BTNdlete.TabIndex = 6;
            this.BTNdlete.Text = "DELETE";
            this.BTNdlete.UseVisualStyleBackColor = false;
            this.BTNdlete.Click += new System.EventHandler(this.BTNdlete_Click);
            // 
            // btnSeeiNVOICERecords
            // 
            this.btnSeeiNVOICERecords.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSeeiNVOICERecords.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeiNVOICERecords.Location = new System.Drawing.Point(30, 559);
            this.btnSeeiNVOICERecords.Name = "btnSeeiNVOICERecords";
            this.btnSeeiNVOICERecords.Size = new System.Drawing.Size(95, 34);
            this.btnSeeiNVOICERecords.TabIndex = 6;
            this.btnSeeiNVOICERecords.Text = "REFRESH";
            this.btnSeeiNVOICERecords.UseVisualStyleBackColor = false;
            this.btnSeeiNVOICERecords.Click += new System.EventHandler(this.btnSeeiNVOICERecords_Click);
            // 
            // grdBikeStocks
            // 
            this.grdBikeStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBikeStocks.Location = new System.Drawing.Point(638, 320);
            this.grdBikeStocks.Name = "grdBikeStocks";
            this.grdBikeStocks.ReadOnly = true;
            this.grdBikeStocks.RowHeadersWidth = 51;
            this.grdBikeStocks.RowTemplate.Height = 24;
            this.grdBikeStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBikeStocks.Size = new System.Drawing.Size(446, 218);
            this.grdBikeStocks.TabIndex = 8;
            this.grdBikeStocks.SelectionChanged += new System.EventHandler(this.grdBikeStocks_SelectionChanged);
            // 
            // buttonSeeBike
            // 
            this.buttonSeeBike.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonSeeBike.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeeBike.Location = new System.Drawing.Point(989, 544);
            this.buttonSeeBike.Name = "buttonSeeBike";
            this.buttonSeeBike.Size = new System.Drawing.Size(95, 33);
            this.buttonSeeBike.TabIndex = 6;
            this.buttonSeeBike.Text = "REFRESH";
            this.buttonSeeBike.UseVisualStyleBackColor = false;
            this.buttonSeeBike.Click += new System.EventHandler(this.buttonSeeBike_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(634, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "BIKE RECORDS";
            // 
            // GRDcusRecords
            // 
            this.GRDcusRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRDcusRecords.Location = new System.Drawing.Point(638, 40);
            this.GRDcusRecords.Name = "GRDcusRecords";
            this.GRDcusRecords.RowHeadersWidth = 51;
            this.GRDcusRecords.RowTemplate.Height = 24;
            this.GRDcusRecords.Size = new System.Drawing.Size(438, 214);
            this.GRDcusRecords.TabIndex = 10;
            this.GRDcusRecords.SelectionChanged += new System.EventHandler(this.GRDcusRecords_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(634, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "CUSTOMER RECORDS";
            // 
            // buttonCustomerSee
            // 
            this.buttonCustomerSee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCustomerSee.Location = new System.Drawing.Point(983, 261);
            this.buttonCustomerSee.Name = "buttonCustomerSee";
            this.buttonCustomerSee.Size = new System.Drawing.Size(93, 36);
            this.buttonCustomerSee.TabIndex = 11;
            this.buttonCustomerSee.Text = "REFRESH";
            this.buttonCustomerSee.UseVisualStyleBackColor = false;
            this.buttonCustomerSee.Click += new System.EventHandler(this.buttonCustomerSee_Click);
            // 
            // grdINVOICE
            // 
            this.grdINVOICE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdINVOICE.Location = new System.Drawing.Point(30, 336);
            this.grdINVOICE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdINVOICE.Name = "grdINVOICE";
            this.grdINVOICE.RowHeadersWidth = 62;
            this.grdINVOICE.RowTemplate.Height = 28;
            this.grdINVOICE.Size = new System.Drawing.Size(501, 218);
            this.grdINVOICE.TabIndex = 12;
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1097, 608);
            this.Controls.Add(this.grdINVOICE);
            this.Controls.Add(this.buttonCustomerSee);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GRDcusRecords);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grdBikeStocks);
            this.Controls.Add(this.buttonSeeBike);
            this.Controls.Add(this.btnSeeiNVOICERecords);
            this.Controls.Add(this.BTNdlete);
            this.Controls.Add(this.btnupdat);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.bTNcal);
            this.Controls.Add(this.txtbillFinal);
            this.Controls.Add(this.txtDis);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.txtChas_num);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.txtIId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "invoice";
            this.Text = "invoice";
            ((System.ComponentModel.ISupportInitialize)(this.grdBikeStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRDcusRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdINVOICE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIId;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtChas_num;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.TextBox txtbillFinal;
        private System.Windows.Forms.Button bTNcal;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnupdat;
        private System.Windows.Forms.Button BTNdlete;
        private System.Windows.Forms.Button btnSeeiNVOICERecords;
        private System.Windows.Forms.DataGridView grdBikeStocks;
        private System.Windows.Forms.Button buttonSeeBike;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView GRDcusRecords;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCustomerSee;
        private System.Windows.Forms.DataGridView grdINVOICE;
    }
}