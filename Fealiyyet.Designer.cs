
namespace Elanlar
{
    partial class Fealiyyet
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
            this.btnYenile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbFealiyyetler = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKateqoriyalar = new System.Windows.Forms.Label();
            this.cmbKateqoriyalar = new System.Windows.Forms.ComboBox();
            this.btnElaveEt = new System.Windows.Forms.Button();
            this.lblFealiyyet = new System.Windows.Forms.Label();
            this.txtFealiyyet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYenile
            // 
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYenile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnYenile.Location = new System.Drawing.Point(533, 120);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(49, 51);
            this.btnYenile.TabIndex = 26;
            this.btnYenile.Text = "↺";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(10, 185);
            this.dataGridView1.TabIndex = 25;
            // 
            // cmbFealiyyetler
            // 
            this.cmbFealiyyetler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(166)))), ((int)(((byte)(115)))));
            this.cmbFealiyyetler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFealiyyetler.FormattingEnabled = true;
            this.cmbFealiyyetler.Location = new System.Drawing.Point(324, 138);
            this.cmbFealiyyetler.Name = "cmbFealiyyetler";
            this.cmbFealiyyetler.Size = new System.Drawing.Size(203, 28);
            this.cmbFealiyyetler.TabIndex = 24;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(98)))), ((int)(((byte)(168)))));
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.ForeColor = System.Drawing.Color.Yellow;
            this.btnSil.Location = new System.Drawing.Point(356, 200);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 40);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Fəaliyyəti sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(324, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fəaliyyətlər";
            // 
            // lblKateqoriyalar
            // 
            this.lblKateqoriyalar.AutoSize = true;
            this.lblKateqoriyalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblKateqoriyalar.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKateqoriyalar.Location = new System.Drawing.Point(192, 18);
            this.lblKateqoriyalar.Name = "lblKateqoriyalar";
            this.lblKateqoriyalar.Size = new System.Drawing.Size(81, 16);
            this.lblKateqoriyalar.TabIndex = 21;
            this.lblKateqoriyalar.Text = "Kateqoriyalar";
            // 
            // cmbKateqoriyalar
            // 
            this.cmbKateqoriyalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(166)))), ((int)(((byte)(115)))));
            this.cmbKateqoriyalar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbKateqoriyalar.FormattingEnabled = true;
            this.cmbKateqoriyalar.Location = new System.Drawing.Point(192, 37);
            this.cmbKateqoriyalar.Name = "cmbKateqoriyalar";
            this.cmbKateqoriyalar.Size = new System.Drawing.Size(203, 28);
            this.cmbKateqoriyalar.TabIndex = 20;
            // 
            // btnElaveEt
            // 
            this.btnElaveEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(98)))), ((int)(((byte)(168)))));
            this.btnElaveEt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElaveEt.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnElaveEt.ForeColor = System.Drawing.Color.Yellow;
            this.btnElaveEt.Location = new System.Drawing.Point(51, 200);
            this.btnElaveEt.Name = "btnElaveEt";
            this.btnElaveEt.Size = new System.Drawing.Size(159, 40);
            this.btnElaveEt.TabIndex = 19;
            this.btnElaveEt.Text = "Fəaliyyət əlavə et";
            this.btnElaveEt.UseVisualStyleBackColor = false;
            this.btnElaveEt.Click += new System.EventHandler(this.btnElaveEt_Click);
            // 
            // lblFealiyyet
            // 
            this.lblFealiyyet.AutoSize = true;
            this.lblFealiyyet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFealiyyet.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFealiyyet.Location = new System.Drawing.Point(31, 113);
            this.lblFealiyyet.Name = "lblFealiyyet";
            this.lblFealiyyet.Size = new System.Drawing.Size(89, 16);
            this.lblFealiyyet.TabIndex = 18;
            this.lblFealiyyet.Text = "Fəaliyyət yazın";
            // 
            // txtFealiyyet
            // 
            this.txtFealiyyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(166)))), ((int)(((byte)(115)))));
            this.txtFealiyyet.Font = new System.Drawing.Font("Ebrima", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFealiyyet.Location = new System.Drawing.Point(31, 131);
            this.txtFealiyyet.Multiline = true;
            this.txtFealiyyet.Name = "txtFealiyyet";
            this.txtFealiyyet.Size = new System.Drawing.Size(203, 35);
            this.txtFealiyyet.TabIndex = 17;
            // 
            // Fealiyyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(620, 294);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbFealiyyetler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKateqoriyalar);
            this.Controls.Add(this.cmbKateqoriyalar);
            this.Controls.Add(this.btnElaveEt);
            this.Controls.Add(this.lblFealiyyet);
            this.Controls.Add(this.txtFealiyyet);
            this.Name = "Fealiyyet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fealiyyet";
            this.Load += new System.EventHandler(this.Fealiyyet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbFealiyyetler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKateqoriyalar;
        private System.Windows.Forms.ComboBox cmbKateqoriyalar;
        private System.Windows.Forms.Button btnElaveEt;
        private System.Windows.Forms.Label lblFealiyyet;
        private System.Windows.Forms.TextBox txtFealiyyet;
    }
}