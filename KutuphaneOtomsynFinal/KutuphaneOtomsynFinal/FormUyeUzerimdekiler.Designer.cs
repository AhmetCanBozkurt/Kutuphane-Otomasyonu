﻿
namespace KutuphaneOtomsynFinal
{
    partial class FormUyeUzerimdekiler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.uzatBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_15 = new System.Windows.Forms.Button();
            this.button_30 = new System.Windows.Forms.Button();
            this.dateTimePicker_TeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.textBoxid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 156;
            this.label3.Text = "Kaç Gün Kaldı: ";
            // 
            // uzatBtn
            // 
            this.uzatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uzatBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.uzatBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.uzatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uzatBtn.Location = new System.Drawing.Point(842, 164);
            this.uzatBtn.Margin = new System.Windows.Forms.Padding(4);
            this.uzatBtn.Name = "uzatBtn";
            this.uzatBtn.Size = new System.Drawing.Size(277, 43);
            this.uzatBtn.TabIndex = 154;
            this.uzatBtn.Text = "Süre Uzat";
            this.uzatBtn.UseVisualStyleBackColor = true;
            this.uzatBtn.Click += new System.EventHandler(this.uzatBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(167, 215);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 70;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(1027, 322);
            this.dataGridView1.TabIndex = 153;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.SystemColors.Window;
            this.button_7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_7.Location = new System.Drawing.Point(842, 107);
            this.button_7.Margin = new System.Windows.Forms.Padding(4);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(89, 49);
            this.button_7.TabIndex = 157;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_15
            // 
            this.button_15.BackColor = System.Drawing.SystemColors.Window;
            this.button_15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.button_15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_15.Location = new System.Drawing.Point(939, 107);
            this.button_15.Margin = new System.Windows.Forms.Padding(4);
            this.button_15.Name = "button_15";
            this.button_15.Size = new System.Drawing.Size(85, 49);
            this.button_15.TabIndex = 158;
            this.button_15.Text = "15";
            this.button_15.UseVisualStyleBackColor = false;
            this.button_15.Click += new System.EventHandler(this.button_15_Click);
            // 
            // button_30
            // 
            this.button_30.BackColor = System.Drawing.SystemColors.Window;
            this.button_30.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.button_30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_30.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_30.Location = new System.Drawing.Point(1032, 107);
            this.button_30.Margin = new System.Windows.Forms.Padding(4);
            this.button_30.Name = "button_30";
            this.button_30.Size = new System.Drawing.Size(87, 49);
            this.button_30.TabIndex = 159;
            this.button_30.Text = "30";
            this.button_30.UseVisualStyleBackColor = false;
            this.button_30.Click += new System.EventHandler(this.button_30_Click);
            // 
            // dateTimePicker_TeslimTarihi
            // 
            this.dateTimePicker_TeslimTarihi.Enabled = false;
            this.dateTimePicker_TeslimTarihi.Location = new System.Drawing.Point(267, 134);
            this.dateTimePicker_TeslimTarihi.Name = "dateTimePicker_TeslimTarihi";
            this.dateTimePicker_TeslimTarihi.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_TeslimTarihi.TabIndex = 160;
            // 
            // textBoxid
            // 
            this.textBoxid.Enabled = false;
            this.textBoxid.Location = new System.Drawing.Point(267, 174);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(100, 22);
            this.textBoxid.TabIndex = 161;
            // 
            // FormUyeUzerimdekiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1356, 700);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.dateTimePicker_TeslimTarihi);
            this.Controls.Add(this.button_30);
            this.Controls.Add(this.button_15);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uzatBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUyeUzerimdekiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUyeUzerimdekiler";
            this.Load += new System.EventHandler(this.FormUyeUzerimdekiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uzatBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_15;
        private System.Windows.Forms.Button button_30;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TeslimTarihi;
        private System.Windows.Forms.TextBox textBoxid;
    }
}