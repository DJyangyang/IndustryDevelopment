namespace ChartMenuBar
{
    partial class TableForm
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
            this.btBrowse = new System.Windows.Forms.Button();
            this.cmbxTableNames1 = new System.Windows.Forms.ComboBox();
            this.cmbxXField1 = new System.Windows.Forms.ComboBox();
            this.cmbxYField1 = new System.Windows.Forms.ComboBox();
            this.cmbxValueDescribe1 = new System.Windows.Forms.TextBox();
            this.txbxStartRowNum1 = new System.Windows.Forms.TextBox();
            this.txbxEndRowNum1 = new System.Windows.Forms.TextBox();
            this.btnChart1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(310, 16);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 0;
            this.btBrowse.Text = "浏览";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // cmbxTableNames1
            // 
            this.cmbxTableNames1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTableNames1.FormattingEnabled = true;
            this.cmbxTableNames1.Location = new System.Drawing.Point(76, 15);
            this.cmbxTableNames1.Name = "cmbxTableNames1";
            this.cmbxTableNames1.Size = new System.Drawing.Size(210, 20);
            this.cmbxTableNames1.TabIndex = 1;
            this.cmbxTableNames1.SelectedIndexChanged += new System.EventHandler(this.cmbxTableNames1_SelectedIndexChanged);
            this.cmbxTableNames1.TextChanged += new System.EventHandler(this.cmbxTableNames1_TextChanged);
            // 
            // cmbxXField1
            // 
            this.cmbxXField1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxXField1.FormattingEnabled = true;
            this.cmbxXField1.Location = new System.Drawing.Point(88, 45);
            this.cmbxXField1.Name = "cmbxXField1";
            this.cmbxXField1.Size = new System.Drawing.Size(121, 29);
            this.cmbxXField1.TabIndex = 2;
            // 
            // cmbxYField1
            // 
            this.cmbxYField1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxYField1.FormattingEnabled = true;
            this.cmbxYField1.Location = new System.Drawing.Point(90, 91);
            this.cmbxYField1.Name = "cmbxYField1";
            this.cmbxYField1.Size = new System.Drawing.Size(121, 29);
            this.cmbxYField1.TabIndex = 3;
            this.cmbxYField1.TextChanged += new System.EventHandler(this.cmbxYField1_TextChanged);
            // 
            // cmbxValueDescribe1
            // 
            this.cmbxValueDescribe1.Location = new System.Drawing.Point(90, 134);
            this.cmbxValueDescribe1.Name = "cmbxValueDescribe1";
            this.cmbxValueDescribe1.Size = new System.Drawing.Size(121, 29);
            this.cmbxValueDescribe1.TabIndex = 4;
            // 
            // txbxStartRowNum1
            // 
            this.txbxStartRowNum1.Location = new System.Drawing.Point(46, 187);
            this.txbxStartRowNum1.Name = "txbxStartRowNum1";
            this.txbxStartRowNum1.Size = new System.Drawing.Size(42, 29);
            this.txbxStartRowNum1.TabIndex = 5;
            // 
            // txbxEndRowNum1
            // 
            this.txbxEndRowNum1.Location = new System.Drawing.Point(121, 187);
            this.txbxEndRowNum1.Name = "txbxEndRowNum1";
            this.txbxEndRowNum1.Size = new System.Drawing.Size(42, 29);
            this.txbxEndRowNum1.TabIndex = 6;
            // 
            // btnChart1
            // 
            this.btnChart1.Location = new System.Drawing.Point(18, 328);
            this.btnChart1.Name = "btnChart1";
            this.btnChart1.Size = new System.Drawing.Size(75, 31);
            this.btnChart1.TabIndex = 7;
            this.btnChart1.Text = "绘图";
            this.btnChart1.UseVisualStyleBackColor = true;
            this.btnChart1.Click += new System.EventHandler(this.btnChart1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(412, 529);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "表名：";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(670, 586);
            this.splitContainer1.SplitterDistance = 412;
            this.splitContainer1.TabIndex = 10;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cmbxTableNames1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.btBrowse);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(412, 586);
            this.splitContainer2.SplitterDistance = 53;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbxEndRowNum1);
            this.groupBox1.Controls.Add(this.btnChart1);
            this.groupBox1.Controls.Add(this.txbxStartRowNum1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbxXField1);
            this.groupBox1.Controls.Add(this.cmbxValueDescribe1);
            this.groupBox1.Controls.Add(this.cmbxYField1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 586);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(94, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "至";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(14, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "从";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(14, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "值描述：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "因变量Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "自变量X:";
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 586);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TableForm";
            this.Text = "数据图表";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.ComboBox cmbxTableNames1;
        private System.Windows.Forms.ComboBox cmbxXField1;
        private System.Windows.Forms.ComboBox cmbxYField1;
        private System.Windows.Forms.TextBox cmbxValueDescribe1;
        private System.Windows.Forms.TextBox txbxStartRowNum1;
        private System.Windows.Forms.TextBox txbxEndRowNum1;
        private System.Windows.Forms.Button btnChart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}