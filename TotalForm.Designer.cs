namespace ChartMenuBar
{
    partial class TotalForm
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
            this.btnBrowser2 = new System.Windows.Forms.Button();
            this.cmbxTableNames3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbxValueDescribe22 = new System.Windows.Forms.TextBox();
            this.cmbxValueDescribe23 = new System.Windows.Forms.TextBox();
            this.cmbxValueDescribe21 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btDraw = new System.Windows.Forms.Button();
            this.txbxEndRowNum2 = new System.Windows.Forms.TextBox();
            this.txbxStartRowNum2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbxY3Field2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxY2Field2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxY1Field2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxXField2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(948, 530);
            this.splitContainer1.SplitterDistance = 579;
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
            this.splitContainer2.Panel1.Controls.Add(this.btnBrowser2);
            this.splitContainer2.Panel1.Controls.Add(this.cmbxTableNames3);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView3);
            this.splitContainer2.Size = new System.Drawing.Size(579, 530);
            this.splitContainer2.SplitterDistance = 38;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnBrowser2
            // 
            this.btnBrowser2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrowser2.Location = new System.Drawing.Point(501, 9);
            this.btnBrowser2.Name = "btnBrowser2";
            this.btnBrowser2.Size = new System.Drawing.Size(75, 26);
            this.btnBrowser2.TabIndex = 2;
            this.btnBrowser2.Text = "浏览";
            this.btnBrowser2.UseVisualStyleBackColor = true;
            this.btnBrowser2.Click += new System.EventHandler(this.btnBrowser2_Click);
            // 
            // cmbxTableNames3
            // 
            this.cmbxTableNames3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTableNames3.FormattingEnabled = true;
            this.cmbxTableNames3.Location = new System.Drawing.Point(85, 10);
            this.cmbxTableNames3.Name = "cmbxTableNames3";
            this.cmbxTableNames3.Size = new System.Drawing.Size(355, 20);
            this.cmbxTableNames3.TabIndex = 1;
            this.cmbxTableNames3.SelectedIndexChanged += new System.EventHandler(this.cmbxTableNames3_SelectedIndexChanged);
            this.cmbxTableNames3.TextChanged += new System.EventHandler(this.cmbxTableNames3_TextChanged);
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
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(579, 488);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView3_RowStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbxValueDescribe22);
            this.groupBox1.Controls.Add(this.cmbxValueDescribe23);
            this.groupBox1.Controls.Add(this.cmbxValueDescribe21);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btDraw);
            this.groupBox1.Controls.Add(this.txbxEndRowNum2);
            this.groupBox1.Controls.Add(this.txbxStartRowNum2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbxY3Field2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbxY2Field2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbxY1Field2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbxXField2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 530);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图表参数";
            // 
            // cmbxValueDescribe22
            // 
            this.cmbxValueDescribe22.Location = new System.Drawing.Point(245, 155);
            this.cmbxValueDescribe22.Name = "cmbxValueDescribe22";
            this.cmbxValueDescribe22.Size = new System.Drawing.Size(100, 29);
            this.cmbxValueDescribe22.TabIndex = 21;
            // 
            // cmbxValueDescribe23
            // 
            this.cmbxValueDescribe23.Location = new System.Drawing.Point(245, 210);
            this.cmbxValueDescribe23.Name = "cmbxValueDescribe23";
            this.cmbxValueDescribe23.Size = new System.Drawing.Size(100, 29);
            this.cmbxValueDescribe23.TabIndex = 20;
            // 
            // cmbxValueDescribe21
            // 
            this.cmbxValueDescribe21.Location = new System.Drawing.Point(245, 104);
            this.cmbxValueDescribe21.Name = "cmbxValueDescribe21";
            this.cmbxValueDescribe21.Size = new System.Drawing.Size(100, 29);
            this.cmbxValueDescribe21.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btDraw
            // 
            this.btDraw.Location = new System.Drawing.Point(127, 421);
            this.btDraw.Name = "btDraw";
            this.btDraw.Size = new System.Drawing.Size(75, 33);
            this.btDraw.TabIndex = 17;
            this.btDraw.Text = "绘图";
            this.btDraw.UseVisualStyleBackColor = true;
            this.btDraw.Click += new System.EventHandler(this.btDraw_Click);
            // 
            // txbxEndRowNum2
            // 
            this.txbxEndRowNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxEndRowNum2.Location = new System.Drawing.Point(246, 274);
            this.txbxEndRowNum2.Name = "txbxEndRowNum2";
            this.txbxEndRowNum2.Size = new System.Drawing.Size(100, 29);
            this.txbxEndRowNum2.TabIndex = 16;
            // 
            // txbxStartRowNum2
            // 
            this.txbxStartRowNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxStartRowNum2.Location = new System.Drawing.Point(102, 274);
            this.txbxStartRowNum2.Name = "txbxStartRowNum2";
            this.txbxStartRowNum2.Size = new System.Drawing.Size(100, 29);
            this.txbxStartRowNum2.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(209, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "至：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "从：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "值：";
            // 
            // cmbxY3Field2
            // 
            this.cmbxY3Field2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxY3Field2.FormattingEnabled = true;
            this.cmbxY3Field2.Location = new System.Drawing.Point(102, 213);
            this.cmbxY3Field2.Name = "cmbxY3Field2";
            this.cmbxY3Field2.Size = new System.Drawing.Size(101, 29);
            this.cmbxY3Field2.TabIndex = 10;
            this.cmbxY3Field2.TextChanged += new System.EventHandler(this.cmbxY3Field2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "因变量Y3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "值：";
            // 
            // cmbxY2Field2
            // 
            this.cmbxY2Field2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxY2Field2.FormattingEnabled = true;
            this.cmbxY2Field2.Location = new System.Drawing.Point(102, 158);
            this.cmbxY2Field2.Name = "cmbxY2Field2";
            this.cmbxY2Field2.Size = new System.Drawing.Size(101, 29);
            this.cmbxY2Field2.TabIndex = 6;
            this.cmbxY2Field2.TextChanged += new System.EventHandler(this.cmbxY2Field2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "因变量Y2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "值：";
            // 
            // cmbxY1Field2
            // 
            this.cmbxY1Field2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxY1Field2.FormattingEnabled = true;
            this.cmbxY1Field2.Location = new System.Drawing.Point(102, 101);
            this.cmbxY1Field2.Name = "cmbxY1Field2";
            this.cmbxY1Field2.Size = new System.Drawing.Size(101, 29);
            this.cmbxY1Field2.TabIndex = 3;
            this.cmbxY1Field2.TextChanged += new System.EventHandler(this.cmbxY1Field2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "因变量Y1:";
            // 
            // cmbxXField2
            // 
            this.cmbxXField2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxXField2.FormattingEnabled = true;
            this.cmbxXField2.Location = new System.Drawing.Point(102, 42);
            this.cmbxXField2.Name = "cmbxXField2";
            this.cmbxXField2.Size = new System.Drawing.Size(250, 29);
            this.cmbxXField2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "自变量X:";
            // 
            // TotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 530);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TotalForm";
            this.Text = "分行业生产总值";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnBrowser2;
        private System.Windows.Forms.ComboBox cmbxTableNames3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btDraw;
        private System.Windows.Forms.TextBox txbxEndRowNum2;
        private System.Windows.Forms.TextBox txbxStartRowNum2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbxY3Field2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxY2Field2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxY1Field2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxXField2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cmbxValueDescribe21;
        private System.Windows.Forms.TextBox cmbxValueDescribe22;
        private System.Windows.Forms.TextBox cmbxValueDescribe23;
    }
}