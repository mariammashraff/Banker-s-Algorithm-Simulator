
namespace WindowsFormsApp2
{
    partial class Form3
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
            this.DGV_rem = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.DGV_visiblity = new System.Windows.Forms.DataGridView();
            this.DGV_avaliable = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.safeSeq_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_rem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_visiblity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_avaliable)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_rem
            // 
            this.DGV_rem.AllowUserToAddRows = false;
            this.DGV_rem.AllowUserToDeleteRows = false;
            this.DGV_rem.AllowUserToResizeColumns = false;
            this.DGV_rem.AllowUserToResizeRows = false;
            this.DGV_rem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_rem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_rem.Location = new System.Drawing.Point(107, 139);
            this.DGV_rem.Name = "DGV_rem";
            this.DGV_rem.RowHeadersVisible = false;
            this.DGV_rem.RowHeadersWidth = 51;
            this.DGV_rem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_rem.Size = new System.Drawing.Size(337, 150);
            this.DGV_rem.TabIndex = 6;
            this.DGV_rem.VirtualMode = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Remaining Need";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 355);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 26);
            this.button1.TabIndex = 35;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(231, 342);
            this.result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(10, 15);
            this.result.TabIndex = 36;
            this.result.Text = " ";
            // 
            // DGV_visiblity
            // 
            this.DGV_visiblity.AllowUserToAddRows = false;
            this.DGV_visiblity.AllowUserToDeleteRows = false;
            this.DGV_visiblity.AllowUserToResizeColumns = false;
            this.DGV_visiblity.AllowUserToResizeRows = false;
            this.DGV_visiblity.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_visiblity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_visiblity.Location = new System.Drawing.Point(491, 139);
            this.DGV_visiblity.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_visiblity.Name = "DGV_visiblity";
            this.DGV_visiblity.RowHeadersVisible = false;
            this.DGV_visiblity.RowHeadersWidth = 51;
            this.DGV_visiblity.RowTemplate.Height = 24;
            this.DGV_visiblity.Size = new System.Drawing.Size(96, 150);
            this.DGV_visiblity.TabIndex = 37;
            // 
            // DGV_avaliable
            // 
            this.DGV_avaliable.AllowUserToAddRows = false;
            this.DGV_avaliable.AllowUserToDeleteRows = false;
            this.DGV_avaliable.AllowUserToResizeColumns = false;
            this.DGV_avaliable.AllowUserToResizeRows = false;
            this.DGV_avaliable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_avaliable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_avaliable.Location = new System.Drawing.Point(107, 30);
            this.DGV_avaliable.Name = "DGV_avaliable";
            this.DGV_avaliable.RowHeadersVisible = false;
            this.DGV_avaliable.RowHeadersWidth = 51;
            this.DGV_avaliable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_avaliable.Size = new System.Drawing.Size(337, 68);
            this.DGV_avaliable.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(8, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 29);
            this.label5.TabIndex = 40;
            this.label5.Text = "Avaliable";
            // 
            // safeSeq_label
            // 
            this.safeSeq_label.AutoSize = true;
            this.safeSeq_label.Location = new System.Drawing.Point(231, 292);
            this.safeSeq_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.safeSeq_label.Name = "safeSeq_label";
            this.safeSeq_label.Size = new System.Drawing.Size(0, 15);
            this.safeSeq_label.TabIndex = 43;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(523, 317);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 26);
            this.button2.TabIndex = 44;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 392);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.safeSeq_label);
            this.Controls.Add(this.DGV_avaliable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGV_visiblity);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGV_rem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "The Answer";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_rem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_visiblity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_avaliable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DGV_rem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.DataGridView DGV_visiblity;
        private System.Windows.Forms.DataGridView DGV_avaliable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label safeSeq_label;
        private System.Windows.Forms.Button button2;
    }
}