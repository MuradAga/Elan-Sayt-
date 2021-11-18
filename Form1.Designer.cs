
namespace Elanlar
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
			this.btnUser = new System.Windows.Forms.Button();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnUser
			// 
			this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(98)))), ((int)(((byte)(168)))));
			this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUser.FlatAppearance.BorderSize = 0;
			this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnUser.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnUser.ForeColor = System.Drawing.Color.Yellow;
			this.btnUser.Location = new System.Drawing.Point(121, 144);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(166, 38);
			this.btnUser.TabIndex = 3;
			this.btnUser.Text = "User";
			this.btnUser.UseVisualStyleBackColor = false;
			this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
			// 
			// btnAdmin
			// 
			this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(98)))), ((int)(((byte)(168)))));
			this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdmin.FlatAppearance.BorderSize = 0;
			this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAdmin.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnAdmin.ForeColor = System.Drawing.Color.Yellow;
			this.btnAdmin.Location = new System.Drawing.Point(121, 82);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(166, 38);
			this.btnAdmin.TabIndex = 2;
			this.btnAdmin.Text = "Admin";
			this.btnAdmin.UseVisualStyleBackColor = false;
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(411, 270);
			this.Controls.Add(this.btnUser);
			this.Controls.Add(this.btnAdmin);
			this.Name = "login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.login_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnAdmin;
    }
}

