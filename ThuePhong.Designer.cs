namespace QLKS
{
    partial class ThuePhong
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
            this.label8 = new System.Windows.Forms.Label();
            this.gvthue = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvthue)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("#9Slide03 AllRoundGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(176, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 28);
            this.label8.TabIndex = 67;
            this.label8.Text = "Phiếu thuê phòng";
            // 
            // gvthue
            // 
            this.gvthue.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvthue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvthue.Location = new System.Drawing.Point(30, 123);
            this.gvthue.Name = "gvthue";
            this.gvthue.Size = new System.Drawing.Size(507, 307);
            this.gvthue.TabIndex = 69;
            
            // 
            // ThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 454);
            this.Controls.Add(this.gvthue);
            this.Controls.Add(this.label8);
            this.Name = "ThuePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu thuê phòng";
            this.Load += new System.EventHandler(this.ThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvthue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gvthue;
    }
}