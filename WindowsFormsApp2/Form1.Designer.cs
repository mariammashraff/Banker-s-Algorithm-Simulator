
namespace WindowsFormsApp2
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
            this.DGV_max = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_process = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_res = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NumericUpDown_ResNo = new System.Windows.Forms.NumericUpDown();
            this.DGV_allot = new System.Windows.Forms.DataGridView();
            this.DGV_total = new System.Windows.Forms.DataGridView();
            this.DGV_avaliable = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.SampleEmaple_btn = new System.Windows.Forms.Button();
            this.FillTable_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_ResNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_allot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_avaliable)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_max
            // 
            this.DGV_max.AllowUserToAddRows = false;
            this.DGV_max.AllowUserToDeleteRows = false;
            this.DGV_max.AllowUserToResizeColumns = false;
            this.DGV_max.AllowUserToResizeRows = false;
            this.DGV_max.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_max.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_max.Location = new System.Drawing.Point(12, 106);
            this.DGV_max.Name = "DGV_max";
            this.DGV_max.RowHeadersVisible = false;
            this.DGV_max.RowHeadersWidth = 51;
            this.DGV_max.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_max.Size = new System.Drawing.Size(337, 142);
            this.DGV_max.TabIndex = 5;
            this.DGV_max.VirtualMode = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Max Needed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Current Allocation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Avaliable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Process";
            // 
            // comboBox_process
            // 
            this.comboBox_process.FormattingEnabled = true;
            this.comboBox_process.Location = new System.Drawing.Point(208, 37);
            this.comboBox_process.Name = "comboBox_process";
            this.comboBox_process.Size = new System.Drawing.Size(50, 21);
            this.comboBox_process.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Requests";
            // 
            // comboBox_res
            // 
            this.comboBox_res.FormattingEnabled = true;
            this.comboBox_res.Location = new System.Drawing.Point(463, 37);
            this.comboBox_res.Name = "comboBox_res";
            this.comboBox_res.Size = new System.Drawing.Size(50, 21);
            this.comboBox_res.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Resource";
            // 
            // NumericUpDown_ResNo
            // 
            this.NumericUpDown_ResNo.Location = new System.Drawing.Point(332, 38);
            this.NumericUpDown_ResNo.Name = "NumericUpDown_ResNo";
            this.NumericUpDown_ResNo.Size = new System.Drawing.Size(55, 20);
            this.NumericUpDown_ResNo.TabIndex = 27;
            // 
            // DGV_allot
            // 
            this.DGV_allot.AllowUserToAddRows = false;
            this.DGV_allot.AllowUserToDeleteRows = false;
            this.DGV_allot.AllowUserToResizeColumns = false;
            this.DGV_allot.AllowUserToResizeRows = false;
            this.DGV_allot.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_allot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_allot.Location = new System.Drawing.Point(423, 106);
            this.DGV_allot.Name = "DGV_allot";
            this.DGV_allot.RowHeadersVisible = false;
            this.DGV_allot.RowHeadersWidth = 51;
            this.DGV_allot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_allot.Size = new System.Drawing.Size(337, 142);
            this.DGV_allot.TabIndex = 28;
            // 
            // DGV_total
            // 
            this.DGV_total.AllowUserToAddRows = false;
            this.DGV_total.AllowUserToDeleteRows = false;
            this.DGV_total.AllowUserToResizeColumns = false;
            this.DGV_total.AllowUserToResizeRows = false;
            this.DGV_total.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_total.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_total.Location = new System.Drawing.Point(423, 334);
            this.DGV_total.Name = "DGV_total";
            this.DGV_total.RowHeadersVisible = false;
            this.DGV_total.RowHeadersWidth = 51;
            this.DGV_total.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_total.Size = new System.Drawing.Size(337, 68);
            this.DGV_total.TabIndex = 29;
            // 
            // DGV_avaliable
            // 
            this.DGV_avaliable.AllowUserToAddRows = false;
            this.DGV_avaliable.AllowUserToDeleteRows = false;
            this.DGV_avaliable.AllowUserToResizeColumns = false;
            this.DGV_avaliable.AllowUserToResizeRows = false;
            this.DGV_avaliable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_avaliable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_avaliable.Location = new System.Drawing.Point(12, 334);
            this.DGV_avaliable.Name = "DGV_avaliable";
            this.DGV_avaliable.RowHeadersVisible = false;
            this.DGV_avaliable.RowHeadersWidth = 51;
            this.DGV_avaliable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_avaliable.Size = new System.Drawing.Size(337, 68);
            this.DGV_avaliable.TabIndex = 30;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 414);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 26);
            this.button3.TabIndex = 45;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SampleEmaple_btn
            // 
            this.SampleEmaple_btn.Location = new System.Drawing.Point(656, 33);
            this.SampleEmaple_btn.Name = "SampleEmaple_btn";
            this.SampleEmaple_btn.Size = new System.Drawing.Size(120, 27);
            this.SampleEmaple_btn.TabIndex = 46;
            this.SampleEmaple_btn.Text = "Sample Example 2";
            this.SampleEmaple_btn.UseVisualStyleBackColor = true;
            this.SampleEmaple_btn.Click += new System.EventHandler(this.SampleEmaple_btn_Click);
            // 
            // FillTable_lbl
            // 
            this.FillTable_lbl.AutoSize = true;
            this.FillTable_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.FillTable_lbl.Location = new System.Drawing.Point(302, 421);
            this.FillTable_lbl.Name = "FillTable_lbl";
            this.FillTable_lbl.Size = new System.Drawing.Size(170, 15);
            this.FillTable_lbl.TabIndex = 47;
            this.FillTable_lbl.Text = "*Please fill out the entire form.";
            this.FillTable_lbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.FillTable_lbl);
            this.Controls.Add(this.SampleEmaple_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DGV_avaliable);
            this.Controls.Add(this.DGV_total);
            this.Controls.Add(this.DGV_allot);
            this.Controls.Add(this.NumericUpDown_ResNo);
            this.Controls.Add(this.comboBox_res);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_process);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV_max);
            this.Name = "Form1";
            this.Text = "The Question";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_ResNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_allot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_avaliable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_process;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_res;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NumericUpDown_ResNo;
        private System.Windows.Forms.DataGridView DGV_allot;
        private System.Windows.Forms.DataGridView DGV_total;
        private System.Windows.Forms.DataGridView DGV_avaliable;
        internal System.Windows.Forms.DataGridView DGV_max;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SampleEmaple_btn;
        private System.Windows.Forms.Label FillTable_lbl;
    }
}

