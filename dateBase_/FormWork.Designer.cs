namespace dateBase_
{
    partial class FormWork
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
            this.tabControlInsert = new System.Windows.Forms.TabControl();
            this.tabPageInsert = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewWork = new System.Windows.Forms.DataGridView();
            this.ColumnWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPaul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArranged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlInsert.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWork)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlInsert
            // 
            this.tabControlInsert.Controls.Add(this.tabPageInsert);
            this.tabControlInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlInsert.Location = new System.Drawing.Point(0, 30);
            this.tabControlInsert.Name = "tabControlInsert";
            this.tabControlInsert.SelectedIndex = 0;
            this.tabControlInsert.Size = new System.Drawing.Size(800, 136);
            this.tabControlInsert.TabIndex = 0;
            // 
            // tabPageInsert
            // 
            this.tabPageInsert.Location = new System.Drawing.Point(4, 25);
            this.tabPageInsert.Name = "tabPageInsert";
            this.tabPageInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInsert.Size = new System.Drawing.Size(792, 107);
            this.tabPageInsert.TabIndex = 1;
            this.tabPageInsert.Text = "INSERT";
            this.tabPageInsert.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // dataGridViewWork
            // 
            this.dataGridViewWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnWork,
            this.ColumnName,
            this.ColumnPaul,
            this.ColumnAge,
            this.ColumnPosition,
            this.ColumnArranged,
            this.ColumnTime});
            this.dataGridViewWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWork.Location = new System.Drawing.Point(0, 166);
            this.dataGridViewWork.Name = "dataGridViewWork";
            this.dataGridViewWork.RowHeadersVisible = false;
            this.dataGridViewWork.RowHeadersWidth = 51;
            this.dataGridViewWork.RowTemplate.Height = 24;
            this.dataGridViewWork.Size = new System.Drawing.Size(800, 423);
            this.dataGridViewWork.TabIndex = 2;
            // 
            // ColumnWork
            // 
            this.ColumnWork.HeaderText = "Login";
            this.ColumnWork.MinimumWidth = 6;
            this.ColumnWork.Name = "ColumnWork";
            this.ColumnWork.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnPaul
            // 
            this.ColumnPaul.HeaderText = "Paul";
            this.ColumnPaul.MinimumWidth = 6;
            this.ColumnPaul.Name = "ColumnPaul";
            // 
            // ColumnAge
            // 
            this.ColumnAge.HeaderText = "Age";
            this.ColumnAge.MinimumWidth = 6;
            this.ColumnAge.Name = "ColumnAge";
            // 
            // ColumnPosition
            // 
            this.ColumnPosition.HeaderText = "Position";
            this.ColumnPosition.MinimumWidth = 6;
            this.ColumnPosition.Name = "ColumnPosition";
            // 
            // ColumnArranged
            // 
            this.ColumnArranged.HeaderText = "Arranged";
            this.ColumnArranged.MinimumWidth = 6;
            this.ColumnArranged.Name = "ColumnArranged";
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Time";
            this.ColumnTime.MinimumWidth = 6;
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.Visible = false;
            // 
            // FormWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.dataGridViewWork);
            this.Controls.Add(this.tabControlInsert);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormWork";
            this.Text = "FormWork";
            this.Load += new System.EventHandler(this.FormWork_Load);
            this.tabControlInsert.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlInsert;
        private System.Windows.Forms.TabPage tabPageInsert;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPaul;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArranged;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
    }
}