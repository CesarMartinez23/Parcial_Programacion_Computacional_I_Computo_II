
namespace AdminUsers_System
{
    partial class frmMenu
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButtonRight = new System.Windows.Forms.ToolStripSplitButton();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTilefrmInfoLogs = new MetroFramework.Controls.MetroTile();
            this.metroTilefrmInfoUsers = new MetroFramework.Controls.MetroTile();
            this.metroTilefrmProfileUser = new MetroFramework.Controls.MetroTile();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButtonRight});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(733, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButtonRight
            // 
            this.toolStripSplitButtonRight.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSplitButtonRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonRight.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem,
            this.signInToolStripMenuItem});
            this.toolStripSplitButtonRight.Image = global::AdminUsers_System.Properties.Resources.config_profile;
            this.toolStripSplitButtonRight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripSplitButtonRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonRight.Name = "toolStripSplitButtonRight";
            this.toolStripSplitButtonRight.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButtonRight.Text = "toolStripSplitButton1";
            this.toolStripSplitButtonRight.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripSplitButtonRight.ToolTipText = "Config Profile";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            this.myProfileToolStripMenuItem.Click += new System.EventHandler(this.myProfileToolStripMenuItem_Click);
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.signInToolStripMenuItem.Text = "Log Out";
            this.signInToolStripMenuItem.Click += new System.EventHandler(this.signInToolStripMenuItem_Click);
            // 
            // metroTilefrmInfoLogs
            // 
            this.metroTilefrmInfoLogs.ActiveControl = null;
            this.metroTilefrmInfoLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTilefrmInfoLogs.ForeColor = System.Drawing.Color.Black;
            this.metroTilefrmInfoLogs.Location = new System.Drawing.Point(517, 135);
            this.metroTilefrmInfoLogs.Name = "metroTilefrmInfoLogs";
            this.metroTilefrmInfoLogs.Size = new System.Drawing.Size(217, 235);
            this.metroTilefrmInfoLogs.TabIndex = 3;
            this.metroTilefrmInfoLogs.Text = "Information Logs";
            this.metroTilefrmInfoLogs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTilefrmInfoLogs.TileImage = global::AdminUsers_System.Properties.Resources.log_users_Register;
            this.metroTilefrmInfoLogs.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTilefrmInfoLogs.UseCustomBackColor = true;
            this.metroTilefrmInfoLogs.UseCustomForeColor = true;
            this.metroTilefrmInfoLogs.UseSelectable = true;
            this.metroTilefrmInfoLogs.UseTileImage = true;
            this.metroTilefrmInfoLogs.Click += new System.EventHandler(this.metroTilefrmInfoLogs_Click);
            // 
            // metroTilefrmInfoUsers
            // 
            this.metroTilefrmInfoUsers.ActiveControl = null;
            this.metroTilefrmInfoUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTilefrmInfoUsers.ForeColor = System.Drawing.Color.Black;
            this.metroTilefrmInfoUsers.Location = new System.Drawing.Point(278, 135);
            this.metroTilefrmInfoUsers.Name = "metroTilefrmInfoUsers";
            this.metroTilefrmInfoUsers.Size = new System.Drawing.Size(217, 235);
            this.metroTilefrmInfoUsers.TabIndex = 2;
            this.metroTilefrmInfoUsers.Text = "Registers User";
            this.metroTilefrmInfoUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTilefrmInfoUsers.TileImage = global::AdminUsers_System.Properties.Resources.group_users_register;
            this.metroTilefrmInfoUsers.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTilefrmInfoUsers.UseCustomBackColor = true;
            this.metroTilefrmInfoUsers.UseCustomForeColor = true;
            this.metroTilefrmInfoUsers.UseSelectable = true;
            this.metroTilefrmInfoUsers.UseTileImage = true;
            this.metroTilefrmInfoUsers.Click += new System.EventHandler(this.metroTilefrmInfoUsers_Click);
            // 
            // metroTilefrmProfileUser
            // 
            this.metroTilefrmProfileUser.ActiveControl = null;
            this.metroTilefrmProfileUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTilefrmProfileUser.ForeColor = System.Drawing.Color.Black;
            this.metroTilefrmProfileUser.Location = new System.Drawing.Point(40, 135);
            this.metroTilefrmProfileUser.Name = "metroTilefrmProfileUser";
            this.metroTilefrmProfileUser.Size = new System.Drawing.Size(217, 235);
            this.metroTilefrmProfileUser.TabIndex = 1;
            this.metroTilefrmProfileUser.Text = "Profile User";
            this.metroTilefrmProfileUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTilefrmProfileUser.TileImage = global::AdminUsers_System.Properties.Resources.profile_user_avatar;
            this.metroTilefrmProfileUser.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTilefrmProfileUser.UseCustomBackColor = true;
            this.metroTilefrmProfileUser.UseCustomForeColor = true;
            this.metroTilefrmProfileUser.UseSelectable = true;
            this.metroTilefrmProfileUser.UseTileImage = true;
            this.metroTilefrmProfileUser.Click += new System.EventHandler(this.metroTilefrmProfileUser_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 418);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.metroTilefrmInfoLogs);
            this.Controls.Add(this.metroTilefrmInfoUsers);
            this.Controls.Add(this.metroTilefrmProfileUser);
            this.Name = "frmMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTilefrmProfileUser;
        private MetroFramework.Controls.MetroTile metroTilefrmInfoUsers;
        private MetroFramework.Controls.MetroTile metroTilefrmInfoLogs;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonRight;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
    }
}