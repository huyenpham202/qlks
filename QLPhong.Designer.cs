namespace QLKS
{
    partial class QLPhong
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
            this.txtMaloai = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gvp = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gvlp = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSonguoi = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlp)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaloai
            // 
            this.txtMaloai.Location = new System.Drawing.Point(127, 124);
            this.txtMaloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaloai.Name = "txtMaloai";
            this.txtMaloai.Size = new System.Drawing.Size(161, 24);
            this.txtMaloai.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbLoaiPhong);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.gvp);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMaphong);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(689, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(132, 202);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(161, 26);
            this.cbLoaiPhong.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("#9Slide03 AllRoundGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(214, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Danh sách phòng";
            // 
            // gvp
            // 
            this.gvp.AllowUserToAddRows = false;
            this.gvp.AllowUserToDeleteRows = false;
            this.gvp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvp.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvp.Location = new System.Drawing.Point(315, 75);
            this.gvp.MultiSelect = false;
            this.gvp.Name = "gvp";
            this.gvp.ReadOnly = true;
            this.gvp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvp.Size = new System.Drawing.Size(349, 298);
            this.gvp.TabIndex = 4;
            this.gvp.Click += new System.EventHandler(this.gvp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phòng";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(132, 150);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(161, 24);
            this.txtMaphong.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Giá";
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(127, 230);
            this.txtgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(161, 24);
            this.txtgia.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("#9Slide03 AllRoundGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(266, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Loại phòng";
            // 
            // gvlp
            // 
            this.gvlp.AllowUserToAddRows = false;
            this.gvlp.AllowUserToDeleteRows = false;
            this.gvlp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvlp.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvlp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvlp.Location = new System.Drawing.Point(306, 59);
            this.gvlp.MultiSelect = false;
            this.gvlp.Name = "gvlp";
            this.gvlp.ReadOnly = true;
            this.gvlp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvlp.Size = new System.Drawing.Size(316, 297);
            this.gvlp.TabIndex = 13;
            this.gvlp.Click += new System.EventHandler(this.gvlp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số người";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Loại phòng";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtgia);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.gvlp);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtSonguoi);
            this.tabPage2.Controls.Add(this.txtMaloai);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(689, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý loại phòng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSonguoi
            // 
            this.txtSonguoi.Location = new System.Drawing.Point(127, 176);
            this.txtSonguoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSonguoi.Name = "txtSonguoi";
            this.txtSonguoi.Size = new System.Drawing.Size(161, 24);
            this.txtSonguoi.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 429);
            this.tabControl1.TabIndex = 1;
            // 
            // QLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 455);
            this.Controls.Add(this.tabControl1);
            this.Name = "QLPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.QLPhong_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlp)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaloai;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvlp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSonguoi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
    }
}