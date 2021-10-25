
namespace AdminUsers_System
{
    partial class frmInfoRegisterUsers
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
            this.components = new System.ComponentModel.Container();
            this.ReturnMenu = new System.Windows.Forms.Label();
            this.dataGridViewInfoUsers = new System.Windows.Forms.DataGridView();
            this.options = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMyInfo = new System.Windows.Forms.Label();
            this.metroToggleShowInfoAdmin = new MetroFramework.Controls.MetroToggle();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoUsers)).BeginInit();
            this.options.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReturnMenu
            // 
            this.ReturnMenu.AutoSize = true;
            this.ReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnMenu.ForeColor = System.Drawing.Color.DimGray;
            this.ReturnMenu.Location = new System.Drawing.Point(185, 24);
            this.ReturnMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReturnMenu.Name = "ReturnMenu";
            this.ReturnMenu.Size = new System.Drawing.Size(43, 17);
            this.ReturnMenu.TabIndex = 1;
            this.ReturnMenu.Text = "Menu";
            this.ReturnMenu.Click += new System.EventHandler(this.ReturnMenu_Click);
            // 
            // dataGridViewInfoUsers
            // 
            this.dataGridViewInfoUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfoUsers.ContextMenuStrip = this.options;
            this.dataGridViewInfoUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewInfoUsers.Location = new System.Drawing.Point(40, 76);
            this.dataGridViewInfoUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInfoUsers.Name = "dataGridViewInfoUsers";
            this.dataGridViewInfoUsers.RowHeadersWidth = 51;
            this.dataGridViewInfoUsers.RowTemplate.Height = 24;
            this.dataGridViewInfoUsers.Size = new System.Drawing.Size(516, 255);
            this.dataGridViewInfoUsers.TabIndex = 2;
            // 
            // options
            // 
            this.options.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit,
            this.delete});
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(181, 70);
            // 
            // edit
            // 
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(180, 22);
            this.edit.Text = "Edit";
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(180, 22);
            this.delete.Text = "Delete";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // labelMyInfo
            // 
            this.labelMyInfo.AutoSize = true;
            this.labelMyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyInfo.Location = new System.Drawing.Point(413, 358);
            this.labelMyInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyInfo.Name = "labelMyInfo";
            this.labelMyInfo.Size = new System.Drawing.Size(53, 17);
            this.labelMyInfo.TabIndex = 3;
            this.labelMyInfo.Text = "My Info";
            // 
            // metroToggleShowInfoAdmin
            // 
            this.metroToggleShowInfoAdmin.AutoSize = true;
            this.metroToggleShowInfoAdmin.Location = new System.Drawing.Point(480, 357);
            this.metroToggleShowInfoAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.metroToggleShowInfoAdmin.Name = "metroToggleShowInfoAdmin";
            this.metroToggleShowInfoAdmin.Size = new System.Drawing.Size(80, 17);
            this.metroToggleShowInfoAdmin.TabIndex = 4;
            this.metroToggleShowInfoAdmin.Text = "Off";
            this.metroToggleShowInfoAdmin.UseCustomBackColor = true;
            this.metroToggleShowInfoAdmin.UseSelectable = true;
            this.metroToggleShowInfoAdmin.CheckedChanged += new System.EventHandler(this.metroToggleShowInfoAdmin_CheckedChanged);
            // 
            // frmInfoRegisterUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 399);
            this.Controls.Add(this.metroToggleShowInfoAdmin);
            this.Controls.Add(this.labelMyInfo);
            this.Controls.Add(this.dataGridViewInfoUsers);
            this.Controls.Add(this.ReturnMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInfoRegisterUsers";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Registers User";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoUsers)).EndInit();
            this.options.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReturnMenu;
        private System.Windows.Forms.DataGridView dataGridViewInfoUsers;
        private System.Windows.Forms.Label labelMyInfo;
        private MetroFramework.Controls.MetroToggle metroToggleShowInfoAdmin;
        private MetroFramework.Controls.MetroContextMenu options;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem delete;
    }
}