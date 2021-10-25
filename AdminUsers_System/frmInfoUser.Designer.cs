
namespace AdminUsers_System
{
    partial class frmInfoUser
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
            this.labelUserNameProfileUser = new System.Windows.Forms.Label();
            this.labelRegisterDateProfileUser = new System.Windows.Forms.Label();
            this.labelEmailProfileUser = new System.Windows.Forms.Label();
            this.labelFirstNameProfileUser = new System.Windows.Forms.Label();
            this.labelLastNameProfileUser = new System.Windows.Forms.Label();
            this.metroTileUser = new MetroFramework.Controls.MetroTile();
            this.ReturnMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUserNameProfileUser
            // 
            this.labelUserNameProfileUser.AutoSize = true;
            this.labelUserNameProfileUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNameProfileUser.Location = new System.Drawing.Point(376, 50);
            this.labelUserNameProfileUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserNameProfileUser.Name = "labelUserNameProfileUser";
            this.labelUserNameProfileUser.Size = new System.Drawing.Size(129, 29);
            this.labelUserNameProfileUser.TabIndex = 11;
            this.labelUserNameProfileUser.Text = "UserName";
            // 
            // labelRegisterDateProfileUser
            // 
            this.labelRegisterDateProfileUser.AutoSize = true;
            this.labelRegisterDateProfileUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterDateProfileUser.Location = new System.Drawing.Point(270, 271);
            this.labelRegisterDateProfileUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegisterDateProfileUser.Name = "labelRegisterDateProfileUser";
            this.labelRegisterDateProfileUser.Size = new System.Drawing.Size(135, 25);
            this.labelRegisterDateProfileUser.TabIndex = 10;
            this.labelRegisterDateProfileUser.Text = "Register Date:";
            // 
            // labelEmailProfileUser
            // 
            this.labelEmailProfileUser.AutoSize = true;
            this.labelEmailProfileUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailProfileUser.Location = new System.Drawing.Point(270, 219);
            this.labelEmailProfileUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmailProfileUser.Name = "labelEmailProfileUser";
            this.labelEmailProfileUser.Size = new System.Drawing.Size(73, 25);
            this.labelEmailProfileUser.TabIndex = 9;
            this.labelEmailProfileUser.Text = "E-mail:";
            // 
            // labelFirstNameProfileUser
            // 
            this.labelFirstNameProfileUser.AutoSize = true;
            this.labelFirstNameProfileUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstNameProfileUser.Location = new System.Drawing.Point(269, 110);
            this.labelFirstNameProfileUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstNameProfileUser.Name = "labelFirstNameProfileUser";
            this.labelFirstNameProfileUser.Size = new System.Drawing.Size(107, 25);
            this.labelFirstNameProfileUser.TabIndex = 8;
            this.labelFirstNameProfileUser.Text = "FirstName:";
            // 
            // labelLastNameProfileUser
            // 
            this.labelLastNameProfileUser.AutoSize = true;
            this.labelLastNameProfileUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastNameProfileUser.Location = new System.Drawing.Point(270, 163);
            this.labelLastNameProfileUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastNameProfileUser.Name = "labelLastNameProfileUser";
            this.labelLastNameProfileUser.Size = new System.Drawing.Size(107, 25);
            this.labelLastNameProfileUser.TabIndex = 7;
            this.labelLastNameProfileUser.Text = "LastName:";
            // 
            // metroTileUser
            // 
            this.metroTileUser.ActiveControl = null;
            this.metroTileUser.BackColor = System.Drawing.Color.White;
            this.metroTileUser.ForeColor = System.Drawing.Color.Black;
            this.metroTileUser.Location = new System.Drawing.Point(17, 88);
            this.metroTileUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTileUser.Name = "metroTileUser";
            this.metroTileUser.Size = new System.Drawing.Size(218, 215);
            this.metroTileUser.TabIndex = 6;
            this.metroTileUser.Text = "Profile User";
            this.metroTileUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileUser.TileImage = global::AdminUsers_System.Properties.Resources.profile_user_avatar;
            this.metroTileUser.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileUser.UseCustomBackColor = true;
            this.metroTileUser.UseCustomForeColor = true;
            this.metroTileUser.UseSelectable = true;
            this.metroTileUser.UseTileImage = true;
            // 
            // ReturnMenu
            // 
            this.ReturnMenu.AutoSize = true;
            this.ReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnMenu.ForeColor = System.Drawing.Color.DimGray;
            this.ReturnMenu.Location = new System.Drawing.Point(177, 21);
            this.ReturnMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReturnMenu.Name = "ReturnMenu";
            this.ReturnMenu.Size = new System.Drawing.Size(43, 17);
            this.ReturnMenu.TabIndex = 12;
            this.ReturnMenu.Text = "Menu";
            this.ReturnMenu.Click += new System.EventHandler(this.ReturnMenu_Click);
            // 
            // frmInfoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 366);
            this.Controls.Add(this.ReturnMenu);
            this.Controls.Add(this.labelUserNameProfileUser);
            this.Controls.Add(this.labelRegisterDateProfileUser);
            this.Controls.Add(this.labelEmailProfileUser);
            this.Controls.Add(this.labelFirstNameProfileUser);
            this.Controls.Add(this.labelLastNameProfileUser);
            this.Controls.Add(this.metroTileUser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInfoUser";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Profile User";
            this.Load += new System.EventHandler(this.frmInfoUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserNameProfileUser;
        private System.Windows.Forms.Label labelRegisterDateProfileUser;
        private System.Windows.Forms.Label labelEmailProfileUser;
        private System.Windows.Forms.Label labelFirstNameProfileUser;
        private System.Windows.Forms.Label labelLastNameProfileUser;
        private MetroFramework.Controls.MetroTile metroTileUser;
        private System.Windows.Forms.Label ReturnMenu;
    }
}