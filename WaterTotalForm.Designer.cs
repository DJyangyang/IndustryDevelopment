namespace ChartMenuBar
{
    partial class WaterTotalForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnBrowser3 = new System.Windows.Forms.Button();
            this.cmbxTableNames4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btClose2 = new System.Windows.Forms.Button();
            this.btDraw2 = new System.Windows.Forms.Button();
            this.txbxEndRowNum4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbxStartRowNum4 = new System.Windows.Forms.TextBox();
            this.cmbxValueDescribe34 = new System.Windows.Forms.TextBox();
            this.cmbxValueDescribe33 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbxY4Field3 = new System.Windows.Forms.ComboBox();
            this.cmbxY3Field3 = new System.Windows.Forms.ComboBox();
            this.cmbxValueDescribe32 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbxY2Field3 = new System.Windows.Forms.ComboBox();
            this.cmbxValueDescribe31 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbxY1Field3 = new System.Windows.Forms.ComboBox();
            this.cmbxXField3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(917, 535);
            this.splitContainer1.SplitterDistance = 552;
            this.splitContainer1.TabIndex = 0;
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
            this.splitContainer2.Panel1.Controls.Add(this.btnBrowser3);
            this.splitContainer2.Panel1.Controls.Add(this.cmbxTableNames4);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView4);
            this.splitContainer2.Size = new System.Drawing.Size(552, 535);
            this.splitContainer2.SplitterDistance = 36;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnBrowser3
            // 
            this.btnBrowser3.Location = new System.Drawing.Point(474, 9);
            this.btnBrowser3.Name = "btnBrowser3";
            this.btnBrowser3.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser3.TabIndex = 2;
            this.btnBrowser3.Text = "浏览";
            this.btnBrowser3.UseVisualStyleBackColor = true;
            this.btnBrowser3.Click += new System.EventHandler(this.btnBrowser3_Click);
            // 
            // cmbxTableNames4
            // 
            this.cmbxTableNames4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTableNames4.FormattingEnabled = true;
            this.cmbxTableNames4.Location = new System.Drawing.Point(68, 10);
            this.cmbxTableNames4.Name = "cmbxTableNames4";
            this.cmbxTableNames4.Size = new System.Drawing.Size(400, 20);
            this.cmbxTableNames4.TabIndex = 1;
            this.cmbxTableNames4.SelectedIndexChanged += new System.EventHandler(this.cmbxTableNames4_SelectedIndexChanged);
            this.cmbxTableNames4.TextChanged += new System.EventHandler(this.cmbxTableNames4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "表名：";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(552, 495);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView4_RowStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btClose2);
            this.groupBox1.Controls.Add(this.btDraw2);
            this.groupBox1.Controls.Add(this.txbxEndRowNum4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txbxStartRowNum4);
            this.groupBox1.Controls.Add(this.cmbxValueDescribe34);
            this.groupBox1.Controls.Add(this.cmbxValueDescribe33);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbxY4Field3);
            this.groupBox1.Controls.Add(this.cmbxY3Field3);
            this.groupBox1.Controls.Add(this.cmbxValueDescribe32);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbxY2Field3);
            this.groupBox1.Controls.Add(this.cmbxValueDescribe31);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbxY1Field3);
            this.groupBox1.Controls.Add(this.cmbxXField3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图表参数";
            // 
            // btClose2
            // 
            this.btClose2.Location = new System.Drawing.Point(262, 353);
            this.btClose2.Name = "btClose2";
            this.btClose2.Size = new System.Drawing.Size(75, 32);
            this.btClose2.TabIndex = 23;
            this.btClose2.Text = "关闭";
            this.btClose2.UseVisualStyleBackColor = true;
            this.btClose2.Click += new System.EventHandler(this.btClose2_Click);
            // 
            // btDraw2
            // 
            this.btDraw2.Location = new System.Drawing.Point(80, 355);
            this.btDraw2.Name = "btDraw2";
            this.btDraw2.Size = new System.Drawing.Size(75, 30);
            this.btDraw2.TabIndex = 22;
            this.btDraw2.Text = "绘图";
            this.btDraw2.UseVisualStyleBackColor = true;
            this.btDraw2.Click += new System.EventHandler(this.btDraw2_Click);
            // 
            // txbxEndRowNum4
            // 
            this.txbxEndRowNum4.Location = new System.Drawing.Point(262, 270);
            this.txbxEndRowNum4.Name = "txbxEndRowNum4";
            this.txbxEndRowNum4.Size = new System.Drawing.Size(61, 26);
            this.txbxEndRowNum4.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(219, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "至：";
            // 
            // txbxStartRowNum4
            // 
            this.txbxStartRowNum4.Location = new System.Drawing.Point(130, 270);
            this.txbxStartRowNum4.Name = "txbxStartRowNum4";
            this.txbxStartRowNum4.Size = new System.Drawing.Size(59, 26);
            this.txbxStartRowNum4.TabIndex = 19;
            // 
            // cmbxValueDescribe34
            // 
            this.cmbxValueDescribe34.Location = new System.Drawing.Point(262, 220);
            this.cmbxValueDescribe34.Name = "cmbxValueDescribe34";
            this.cmbxValueDescribe34.Size = new System.Drawing.Size(87, 26);
            this.cmbxValueDescribe34.TabIndex = 18;
            // 
            // cmbxValueDescribe33
            // 
            this.cmbxValueDescribe33.Location = new System.Drawing.Point(262, 171);
            this.cmbxValueDescribe33.Name = "cmbxValueDescribe33";
            this.cmbxValueDescribe33.Size = new System.Drawing.Size(87, 26);
            this.cmbxValueDescribe33.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "值：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "值：";
            // 
            // cmbxY4Field3
            // 
            this.cmbxY4Field3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxY4Field3.FormattingEnabled = true;
            this.cmbxY4Field3.Location = new System.Drawing.Point(80, 220);
            this.cmbxY4Field3.Name = "cmbxY4Field3";
            this.cmbxY4Field3.Size = new System.Drawing.Size(109, 28);
            this.cmbxY4Field3.TabIndex = 14;
            this.cmbxY4Field3.TextChanged += new System.EventHandler(this.cmbxY4Field3_TextChanged);
            // 
            // cmbxY3Field3
            // 
            this.cmbxY3Field3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxY3Field3.FormattingEnabled = true;
            this.cmbxY3Field3.Location = new System.Drawing.Point(80, 174);
            this.cmbxY3Field3.Name = "cmbxY3Field3";
            this.cmbxY3Field3.Size = new System.Drawing.Size(109, 28);
            this.cmbxY3Field3.TabIndex = 13;
            this.cmbxY3Field3.TextChanged += new System.EventHandler(this.cmbxY3Field3_TextChanged);
            // 
            // cmbxValueDescribe32
            // 
            this.cmbxValueDescribe32.Location = new System.Drawing.Point(262, 123);
            this.cmbxValueDescribe32.Name = "cmbxValueDescribe32";
            this.cmbxValueDescribe32.Size = new System.Drawing.Size(87, 26);
            this.cmbxValueDescribe32.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "值：";
            // 
            // cmbxY2Field3
            // 
            this.cmbxY2Field3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxY2Field3.FormattingEnabled = true;
            this.cmbxY2Field3.Location = new System.Drawing.Point(80, 129);
            this.cmbxY2Field3.Name = "cmbxY2Field3";
            this.cmbxY2Field3.Size = new System.Drawing.Size(109, 28);
            this.cmbxY2Field3.TabIndex = 10;
            this.cmbxY2Field3.TextChanged += new System.EventHandler(this.cmbxY2Field3_TextChanged);
            // 
            // cmbxValueDescribe31
            // 
            this.cmbxValueDescribe31.Location = new System.Drawing.Point(262, 79);
            this.cmbxValueDescribe31.Name = "cmbxValueDescribe31";
            this.cmbxValueDescribe31.Size = new System.Drawing.Size(87, 26);
            this.cmbxValueDescribe31.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "值：";
            // 
            // cmbxY1Field3
            // 
            this.cmbxY1Field3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxY1Field3.FormattingEnabled = true;
            this.cmbxY1Field3.Location = new System.Drawing.Point(80, 80);
            this.cmbxY1Field3.Name = "cmbxY1Field3";
            this.cmbxY1Field3.Size = new System.Drawing.Size(109, 28);
            this.cmbxY1Field3.TabIndex = 7;
            this.cmbxY1Field3.TextChanged += new System.EventHandler(this.cmbxY1Field3_TextChanged);
            // 
            // cmbxXField3
            // 
            this.cmbxXField3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxXField3.FormattingEnabled = true;
            this.cmbxXField3.Location = new System.Drawing.Point(80, 32);
            this.cmbxXField3.Name = "cmbxXField3";
            this.cmbxXField3.Size = new System.Drawing.Size(269, 28);
            this.cmbxXField3.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "从：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "因变量Y4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "因变量Y3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "因变量Y2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "因变量Y1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "自变量X:";
            // 
            // WaterTotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 535);
            this.Controls.Add(this.splitContainer1);
            this.Name = "WaterTotalForm";
            this.Text = "WaterTotalForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxTableNames4;
        private System.Windows.Forms.Button btnBrowser3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbxXField3;
        private System.Windows.Forms.ComboBox cmbxY1Field3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cmbxValueDescribe31;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbxY2Field3;
        private System.Windows.Forms.TextBox cmbxValueDescribe32;
        private System.Windows.Forms.ComboBox cmbxY3Field3;
        private System.Windows.Forms.ComboBox cmbxY4Field3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cmbxValueDescribe33;
        private System.Windows.Forms.TextBox cmbxValueDescribe34;
        private System.Windows.Forms.TextBox txbxStartRowNum4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbxEndRowNum4;
        private System.Windows.Forms.Button btClose2;
        private System.Windows.Forms.Button btDraw2;

    }
}