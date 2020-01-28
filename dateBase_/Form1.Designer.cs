namespace dateBase_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelErorr = new System.Windows.Forms.Label();
            this.labelRollUp = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl_actions = new System.Windows.Forms.TabControl();
            this.tabPage_INSERT = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxDateAdd = new System.Windows.Forms.TextBox();
            this.textBoxWorkAdd = new System.Windows.Forms.TextBox();
            this.textBoxNameAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_DELETE = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl_actions.SuspendLayout();
            this.tabPage_INSERT.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelErorr);
            this.panel1.Controls.Add(this.labelRollUp);
            this.panel1.Controls.Add(this.labelExit);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 34);
            this.panel1.TabIndex = 2;
            // 
            // labelErorr
            // 
            this.labelErorr.AutoSize = true;
            this.labelErorr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelErorr.Location = new System.Drawing.Point(278, 9);
            this.labelErorr.Name = "labelErorr";
            this.labelErorr.Size = new System.Drawing.Size(0, 17);
            this.labelErorr.TabIndex = 3;
            this.labelErorr.Visible = false;
            // 
            // labelRollUp
            // 
            this.labelRollUp.AutoSize = true;
            this.labelRollUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRollUp.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRollUp.ForeColor = System.Drawing.Color.DimGray;
            this.labelRollUp.Location = new System.Drawing.Point(942, 9);
            this.labelRollUp.Name = "labelRollUp";
            this.labelRollUp.Size = new System.Drawing.Size(26, 19);
            this.labelRollUp.TabIndex = 2;
            this.labelRollUp.Text = "—";
            this.labelRollUp.Click += new System.EventHandler(this.LabelRollUp_Click);
            this.labelRollUp.MouseEnter += new System.EventHandler(this.LabelRollUp_MouseEnter);
            this.labelRollUp.MouseLeave += new System.EventHandler(this.LabelRollUp_MouseLeave);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.DimGray;
            this.labelExit.Location = new System.Drawing.Point(974, 9);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(20, 19);
            this.labelExit.TabIndex = 1;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.LabelExit_Click);
            this.labelExit.MouseEnter += new System.EventHandler(this.LabelExit_MouseEnter);
            this.labelExit.MouseLeave += new System.EventHandler(this.LabelExit_MouseLeave);
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
            this.menuStrip1.Size = new System.Drawing.Size(997, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStrip1_MouseMove);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(44, 30);
            this.файлToolStripMenuItem.Text = "file";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.выходToolStripMenuItem.Text = "Exit";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl_actions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 108);
            this.panel2.TabIndex = 3;
            // 
            // tabControl_actions
            // 
            this.tabControl_actions.Controls.Add(this.tabPage_INSERT);
            this.tabControl_actions.Controls.Add(this.tabPage_DELETE);
            this.tabControl_actions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_actions.Location = new System.Drawing.Point(0, 0);
            this.tabControl_actions.Name = "tabControl_actions";
            this.tabControl_actions.SelectedIndex = 0;
            this.tabControl_actions.Size = new System.Drawing.Size(997, 108);
            this.tabControl_actions.TabIndex = 0;
            // 
            // tabPage_INSERT
            // 
            this.tabPage_INSERT.Controls.Add(this.buttonAdd);
            this.tabPage_INSERT.Controls.Add(this.textBoxDateAdd);
            this.tabPage_INSERT.Controls.Add(this.textBoxWorkAdd);
            this.tabPage_INSERT.Controls.Add(this.textBoxNameAdd);
            this.tabPage_INSERT.Controls.Add(this.label3);
            this.tabPage_INSERT.Controls.Add(this.label2);
            this.tabPage_INSERT.Controls.Add(this.label1);
            this.tabPage_INSERT.Location = new System.Drawing.Point(4, 25);
            this.tabPage_INSERT.Name = "tabPage_INSERT";
            this.tabPage_INSERT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_INSERT.Size = new System.Drawing.Size(989, 79);
            this.tabPage_INSERT.TabIndex = 0;
            this.tabPage_INSERT.Text = "INSERT";
            this.tabPage_INSERT.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(702, 25);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(71, 27);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxDateAdd
            // 
            this.textBoxDateAdd.Location = new System.Drawing.Point(510, 27);
            this.textBoxDateAdd.Name = "textBoxDateAdd";
            this.textBoxDateAdd.Size = new System.Drawing.Size(153, 22);
            this.textBoxDateAdd.TabIndex = 1;
            // 
            // textBoxWorkAdd
            // 
            this.textBoxWorkAdd.Location = new System.Drawing.Point(291, 27);
            this.textBoxWorkAdd.Name = "textBoxWorkAdd";
            this.textBoxWorkAdd.Size = new System.Drawing.Size(153, 22);
            this.textBoxWorkAdd.TabIndex = 1;
            // 
            // textBoxNameAdd
            // 
            this.textBoxNameAdd.Location = new System.Drawing.Point(69, 27);
            this.textBoxNameAdd.Name = "textBoxNameAdd";
            this.textBoxNameAdd.Size = new System.Drawing.Size(153, 22);
            this.textBoxNameAdd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Work";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage_DELETE
            // 
            this.tabPage_DELETE.Location = new System.Drawing.Point(4, 25);
            this.tabPage_DELETE.Name = "tabPage_DELETE";
            this.tabPage_DELETE.Size = new System.Drawing.Size(989, 79);
            this.tabPage_DELETE.TabIndex = 2;
            this.tabPage_DELETE.Text = "DELETE";
            this.tabPage_DELETE.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 430);
            this.panel3.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnWork,
            this.ColumnDate});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(997, 430);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellEndEdit);
            // 
            // ColumnId
            // 
            this.ColumnId.FillWeight = 50F;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.ContextMenuStrip = this.contextMenuStrip1;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnWork
            // 
            this.ColumnWork.ContextMenuStrip = this.contextMenuStrip1;
            this.ColumnWork.HeaderText = "Work";
            this.ColumnWork.MinimumWidth = 6;
            this.ColumnWork.Name = "ColumnWork";
            // 
            // ColumnDate
            // 
            this.ColumnDate.ContextMenuStrip = this.contextMenuStrip1;
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.MinimumWidth = 6;
            this.ColumnDate.Name = "ColumnDate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 572);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Working with databases";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl_actions.ResumeLayout(false);
            this.tabPage_INSERT.ResumeLayout(false);
            this.tabPage_INSERT.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl_actions;
        private System.Windows.Forms.TabPage tabPage_INSERT;
        private System.Windows.Forms.TabPage tabPage_DELETE;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxWorkAdd;
        private System.Windows.Forms.TextBox textBoxNameAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxDateAdd;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelRollUp;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelErorr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
    }
}

