namespace ChartMenuBar
{
    partial class AccessChartTableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxMdbFileFullPath = new System.Windows.Forms.TextBox();
            this.btnMdbBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbxZField = new System.Windows.Forms.ComboBox();
            this.cmbxValueDescribe1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbxEndRowNum = new System.Windows.Forms.TextBox();
            this.txbxStartRowNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportTable = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.cmbxValueDescribe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxYField = new System.Windows.Forms.ComboBox();
            this.cmbxXField = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxTableNames = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "mdb文件：";
            // 
            // txbxMdbFileFullPath
            // 
            this.txbxMdbFileFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxMdbFileFullPath.Enabled = false;
            this.txbxMdbFileFullPath.Location = new System.Drawing.Point(82, 10);
            this.txbxMdbFileFullPath.Name = "txbxMdbFileFullPath";
            this.txbxMdbFileFullPath.Size = new System.Drawing.Size(694, 21);
            this.txbxMdbFileFullPath.TabIndex = 1;
            this.txbxMdbFileFullPath.TextChanged += new System.EventHandler(this.txbxMdbFileFullPath_TextChanged);
            // 
            // btnMdbBrowse
            // 
            this.btnMdbBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMdbBrowse.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnMdbBrowse.Location = new System.Drawing.Point(782, 8);
            this.btnMdbBrowse.Name = "btnMdbBrowse";
            this.btnMdbBrowse.Size = new System.Drawing.Size(56, 25);
            this.btnMdbBrowse.TabIndex = 2;
            this.btnMdbBrowse.Text = "浏览";
            this.btnMdbBrowse.UseVisualStyleBackColor = true;
            this.btnMdbBrowse.Click += new System.EventHandler(this.btnMdbBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbxZField);
            this.groupBox1.Controls.Add(this.cmbxValueDescribe1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbxEndRowNum);
            this.groupBox1.Controls.Add(this.txbxStartRowNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnExportTable);
            this.groupBox1.Controls.Add(this.btnChart);
            this.groupBox1.Controls.Add(this.cmbxValueDescribe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbxYField);
            this.groupBox1.Controls.Add(this.cmbxXField);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox1.Location = new System.Drawing.Point(622, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 358);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计图表";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(110, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "值描述：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "因变量（Z）:";
            // 
            // cmbxZField
            // 
            this.cmbxZField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxZField.FormattingEnabled = true;
            this.cmbxZField.Location = new System.Drawing.Point(113, 100);
            this.cmbxZField.Name = "cmbxZField";
            this.cmbxZField.Size = new System.Drawing.Size(68, 25);
            this.cmbxZField.TabIndex = 12;
            this.cmbxZField.TextChanged += new System.EventHandler(this.cmbxZField_TextChanged);
            // 
            // cmbxValueDescribe1
            // 
            this.cmbxValueDescribe1.Location = new System.Drawing.Point(113, 156);
            this.cmbxValueDescribe1.Name = "cmbxValueDescribe1";
            this.cmbxValueDescribe1.Size = new System.Drawing.Size(100, 23);
            this.cmbxValueDescribe1.TabIndex = 11;
            this.cmbxValueDescribe1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "到";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "行";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "行";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "从";
            // 
            // txbxEndRowNum
            // 
            this.txbxEndRowNum.Location = new System.Drawing.Point(64, 237);
            this.txbxEndRowNum.Name = "txbxEndRowNum";
            this.txbxEndRowNum.Size = new System.Drawing.Size(98, 23);
            this.txbxEndRowNum.TabIndex = 9;
            this.txbxEndRowNum.Text = "2";
            // 
            // txbxStartRowNum
            // 
            this.txbxStartRowNum.Location = new System.Drawing.Point(64, 211);
            this.txbxStartRowNum.Name = "txbxStartRowNum";
            this.txbxStartRowNum.Size = new System.Drawing.Size(98, 23);
            this.txbxStartRowNum.TabIndex = 9;
            this.txbxStartRowNum.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "成图范围：";
            // 
            // btnExportTable
            // 
            this.btnExportTable.Location = new System.Drawing.Point(118, 319);
            this.btnExportTable.Name = "btnExportTable";
            this.btnExportTable.Size = new System.Drawing.Size(75, 25);
            this.btnExportTable.TabIndex = 7;
            this.btnExportTable.Text = "生成表";
            this.btnExportTable.UseVisualStyleBackColor = true;
            this.btnExportTable.Click += new System.EventHandler(this.btnExportTable_Click);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(26, 319);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(75, 25);
            this.btnChart.TabIndex = 7;
            this.btnChart.Text = "生成图";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // cmbxValueDescribe
            // 
            this.cmbxValueDescribe.Location = new System.Drawing.Point(24, 155);
            this.cmbxValueDescribe.Multiline = true;
            this.cmbxValueDescribe.Name = "cmbxValueDescribe";
            this.cmbxValueDescribe.Size = new System.Drawing.Size(68, 24);
            this.cmbxValueDescribe.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "因变量(Y)：";
            // 
            // cmbxYField
            // 
            this.cmbxYField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxYField.FormattingEnabled = true;
            this.cmbxYField.Location = new System.Drawing.Point(24, 100);
            this.cmbxYField.Name = "cmbxYField";
            this.cmbxYField.Size = new System.Drawing.Size(68, 25);
            this.cmbxYField.TabIndex = 3;
            this.cmbxYField.TextChanged += new System.EventHandler(this.cmbxYField_TextChanged);
            // 
            // cmbxXField
            // 
            this.cmbxXField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxXField.FormattingEnabled = true;
            this.cmbxXField.Location = new System.Drawing.Point(24, 42);
            this.cmbxXField.Name = "cmbxXField";
            this.cmbxXField.Size = new System.Drawing.Size(68, 25);
            this.cmbxXField.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "值描述：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "自变量(X)：";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnClose.Location = new System.Drawing.Point(763, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 60;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(598, 318);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "表名：";
            // 
            // cmbxTableNames
            // 
            this.cmbxTableNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTableNames.FormattingEnabled = true;
            this.cmbxTableNames.Location = new System.Drawing.Point(82, 45);
            this.cmbxTableNames.Name = "cmbxTableNames";
            this.cmbxTableNames.Size = new System.Drawing.Size(188, 20);
            this.cmbxTableNames.TabIndex = 10;
            this.cmbxTableNames.TextChanged += new System.EventHandler(this.cmbxTableNames_TextChanged);
            // 
            // AccessChartTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 430);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxTableNames);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMdbBrowse);
            this.Controls.Add(this.txbxMdbFileFullPath);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(515, 405);
            this.Name = "AccessChartTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据图表";
            this.Load += new System.EventHandler(this.AccessChartTableForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxMdbFileFullPath;
        private System.Windows.Forms.Button btnMdbBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExportTable;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.TextBox cmbxValueDescribe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxYField;
        private System.Windows.Forms.ComboBox cmbxXField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxTableNames;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbxEndRowNum;
        private System.Windows.Forms.TextBox txbxStartRowNum;
        private System.Windows.Forms.ComboBox cmbxZField;
        private System.Windows.Forms.TextBox cmbxValueDescribe1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}