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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewWork = new System.Windows.Forms.DataGridView();
            this.ColumnWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPaul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelRollUp = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IntelligToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEx = new System.Windows.Forms.Label();
            this.label_ = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWork)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewWork
            // 
            this.dataGridViewWork.AllowUserToAddRows = false;
            this.dataGridViewWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnWork,
            this.ColumnName,
            this.ColumnPaul,
            this.ColumnAge,
            this.ColumnPosition});
            this.dataGridViewWork.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewWork.Location = new System.Drawing.Point(0, 31);
            this.dataGridViewWork.Name = "dataGridViewWork";
            this.dataGridViewWork.RowHeadersVisible = false;
            this.dataGridViewWork.RowHeadersWidth = 51;
            this.dataGridViewWork.RowTemplate.Height = 24;
            this.dataGridViewWork.Size = new System.Drawing.Size(800, 558);
            this.dataGridViewWork.TabIndex = 2;
            this.dataGridViewWork.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewWork_CellClick);
            this.dataGridViewWork.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewWork_CellEndEdit);
            this.dataGridViewWork.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataGridViewWork_EditingControlShowing);
            // 
            // ColumnWork
            // 
            this.ColumnWork.HeaderText = "Id";
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
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.DimGray;
            this.labelExit.Location = new System.Drawing.Point(780, 9);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(20, 19);
            this.labelExit.TabIndex = 3;
            this.labelExit.Text = "X";
            // 
            // labelRollUp
            // 
            this.labelRollUp.AutoSize = true;
            this.labelRollUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRollUp.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRollUp.ForeColor = System.Drawing.Color.DimGray;
            this.labelRollUp.Location = new System.Drawing.Point(748, 9);
            this.labelRollUp.Name = "labelRollUp";
            this.labelRollUp.Size = new System.Drawing.Size(26, 19);
            this.labelRollUp.TabIndex = 4;
            this.labelRollUp.Text = "—";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStrip1_MouseMove);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IntelligToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(44, 27);
            this.файлToolStripMenuItem.Text = "file";
            // 
            // IntelligToolStripMenuItem
            // 
            this.IntelligToolStripMenuItem.Name = "IntelligToolStripMenuItem";
            this.IntelligToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.IntelligToolStripMenuItem.Text = "Intelligence";
            this.IntelligToolStripMenuItem.Click += new System.EventHandler(this.IntelligToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // labelEx
            // 
            this.labelEx.AutoSize = true;
            this.labelEx.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEx.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEx.ForeColor = System.Drawing.Color.DimGray;
            this.labelEx.Location = new System.Drawing.Point(780, 9);
            this.labelEx.Name = "labelEx";
            this.labelEx.Size = new System.Drawing.Size(20, 19);
            this.labelEx.TabIndex = 6;
            this.labelEx.Text = "X";
            this.labelEx.Click += new System.EventHandler(this.LabelExit_Click);
            this.labelEx.MouseEnter += new System.EventHandler(this.LabelExit_MouseEnter);
            this.labelEx.MouseLeave += new System.EventHandler(this.LabelExit_MouseLeave);
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_.ForeColor = System.Drawing.Color.DimGray;
            this.label_.Location = new System.Drawing.Point(748, 9);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(26, 19);
            this.label_.TabIndex = 7;
            this.label_.Text = "—";
            this.label_.Click += new System.EventHandler(this.LabelRollUp_Click);
            this.label_.MouseEnter += new System.EventHandler(this.LabelRollUp_MouseEnter);
            this.label_.MouseLeave += new System.EventHandler(this.LabelRollUp_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 28);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.удалитьToolStripMenuItem.Text = "Delete";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.УдалитьToolStripMenuItem_Click);
            // 
            // FormWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.label_);
            this.Controls.Add(this.labelEx);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelRollUp);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.dataGridViewWork);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWork";
            this.Text = "FormWork";
            this.Load += new System.EventHandler(this.FormWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWork)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewWork;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelRollUp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IntelligToolStripMenuItem;
        private System.Windows.Forms.Label labelEx;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPaul;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosition;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}