
namespace AdminUsers_System
{
    partial class frmLogs
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
            this.ReturnMenu = new System.Windows.Forms.Label();
            this.dataGridViewInfoLogs = new System.Windows.Forms.DataGridView();
            this.labelMyInfoLogsAdmin = new System.Windows.Forms.Label();
            this.metroToggleMyInfoLogsAdmin = new MetroFramework.Controls.MetroToggle();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnMenu
            // 
            this.ReturnMenu.AutoSize = true;
            this.ReturnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnMenu.ForeColor = System.Drawing.Color.DimGray;
            this.ReturnMenu.Location = new System.Drawing.Point(286, 28);
            this.ReturnMenu.Name = "ReturnMenu";
            this.ReturnMenu.Size = new System.Drawing.Size(50, 20);
            this.ReturnMenu.TabIndex = 0;
            this.ReturnMenu.Text = "Menu";
            this.ReturnMenu.Click += new System.EventHandler(this.ReturnMenu_Click);
            // 
            // dataGridViewInfoLogs
            // 
            this.dataGridViewInfoLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfoLogs.Location = new System.Drawing.Point(60, 89);
            this.dataGridViewInfoLogs.Name = "dataGridViewInfoLogs";
            this.dataGridViewInfoLogs.RowHeadersWidth = 51;
            this.dataGridViewInfoLogs.RowTemplate.Height = 24;
            this.dataGridViewInfoLogs.Size = new System.Drawing.Size(666, 288);
            this.dataGridViewInfoLogs.TabIndex = 1;
            // 
            // labelMyInfoLogsAdmin
            // 
            this.labelMyInfoLogsAdmin.AutoSize = true;
            this.labelMyInfoLogsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyInfoLogsAdmin.Location = new System.Drawing.Point(488, 410);
            this.labelMyInfoLogsAdmin.Name = "labelMyInfoLogsAdmin";
            this.labelMyInfoLogsAdmin.Size = new System.Drawing.Size(105, 20);
            this.labelMyInfoLogsAdmin.TabIndex = 2;
            this.labelMyInfoLogsAdmin.Text = "My Sessions";
            // 
            // metroToggleMyInfoLogsAdmin
            // 
            this.metroToggleMyInfoLogsAdmin.AutoSize = true;
            this.metroToggleMyInfoLogsAdmin.Location = new System.Drawing.Point(623, 410);
            this.metroToggleMyInfoLogsAdmin.Name = "metroToggleMyInfoLogsAdmin";
            this.metroToggleMyInfoLogsAdmin.Size = new System.Drawing.Size(80, 21);
            this.metroToggleMyInfoLogsAdmin.TabIndex = 3;
            this.metroToggleMyInfoLogsAdmin.Text = "Off";
            this.metroToggleMyInfoLogsAdmin.UseCustomBackColor = true;
            this.metroToggleMyInfoLogsAdmin.UseSelectable = true;
            this.metroToggleMyInfoLogsAdmin.CheckedChanged += new System.EventHandler(this.metroToggleMyInfoLogsAdmin_CheckedChanged);
            // 
            // frmLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroToggleMyInfoLogsAdmin);
            this.Controls.Add(this.labelMyInfoLogsAdmin);
            this.Controls.Add(this.dataGridViewInfoLogs);
            this.Controls.Add(this.ReturnMenu);
            this.Name = "frmLogs";
            this.Text = "Information Logs";
            this.Load += new System.EventHandler(this.frmLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReturnMenu;
        private System.Windows.Forms.DataGridView dataGridViewInfoLogs;
        private System.Windows.Forms.Label labelMyInfoLogsAdmin;
        private MetroFramework.Controls.MetroToggle metroToggleMyInfoLogsAdmin;
    }
}