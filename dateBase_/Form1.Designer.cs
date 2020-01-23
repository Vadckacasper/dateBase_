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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl_actions = new System.Windows.Forms.TabControl();
            this.tabPage_INSERT = new System.Windows.Forms.TabPage();
            this.tabPage_UPDATE = new System.Windows.Forms.TabPage();
            this.tabPage_DELETE = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox_Wiew = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl_actions.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 34);
            this.panel1.TabIndex = 2;
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
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 30);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
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
            this.tabControl_actions.Controls.Add(this.tabPage_UPDATE);
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
            this.tabPage_INSERT.Location = new System.Drawing.Point(4, 25);
            this.tabPage_INSERT.Name = "tabPage_INSERT";
            this.tabPage_INSERT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_INSERT.Size = new System.Drawing.Size(989, 79);
            this.tabPage_INSERT.TabIndex = 0;
            this.tabPage_INSERT.Text = "INSERT";
            this.tabPage_INSERT.UseVisualStyleBackColor = true;
            // 
            // tabPage_UPDATE
            // 
            this.tabPage_UPDATE.Location = new System.Drawing.Point(4, 25);
            this.tabPage_UPDATE.Name = "tabPage_UPDATE";
            this.tabPage_UPDATE.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_UPDATE.Size = new System.Drawing.Size(989, 71);
            this.tabPage_UPDATE.TabIndex = 1;
            this.tabPage_UPDATE.Text = "UPDATE";
            this.tabPage_UPDATE.UseVisualStyleBackColor = true;
            // 
            // tabPage_DELETE
            // 
            this.tabPage_DELETE.Location = new System.Drawing.Point(4, 25);
            this.tabPage_DELETE.Name = "tabPage_DELETE";
            this.tabPage_DELETE.Size = new System.Drawing.Size(989, 71);
            this.tabPage_DELETE.TabIndex = 2;
            this.tabPage_DELETE.Text = "DELETE";
            this.tabPage_DELETE.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox_Wiew);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 430);
            this.panel3.TabIndex = 4;
            // 
            // listBox_Wiew
            // 
            this.listBox_Wiew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Wiew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Wiew.FormattingEnabled = true;
            this.listBox_Wiew.ItemHeight = 16;
            this.listBox_Wiew.Location = new System.Drawing.Point(0, 0);
            this.listBox_Wiew.Name = "listBox_Wiew";
            this.listBox_Wiew.Size = new System.Drawing.Size(997, 430);
            this.listBox_Wiew.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 572);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl_actions.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage_UPDATE;
        private System.Windows.Forms.TabPage tabPage_DELETE;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox_Wiew;
    }
}

