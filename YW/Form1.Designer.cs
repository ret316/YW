﻿namespace YW
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.CDPage0 = new System.Windows.Forms.TabPage();
            this.songslistbox = new System.Windows.Forms.ListBox();
            this.btwritecd = new System.Windows.Forms.Button();
            this.ldrives = new System.Windows.Forms.Label();
            this.cbdrives = new System.Windows.Forms.ComboBox();
            this.btdelfiles = new System.Windows.Forms.Button();
            this.btaddfiles = new System.Windows.Forms.Button();
            this.btdeltab = new System.Windows.Forms.Button();
            this.bttabadd = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.CDPage0.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer1.Size = new System.Drawing.Size(401, 399);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btwritecd);
            this.splitContainer2.Panel2.Controls.Add(this.ldrives);
            this.splitContainer2.Panel2.Controls.Add(this.cbdrives);
            this.splitContainer2.Panel2.Controls.Add(this.btdelfiles);
            this.splitContainer2.Panel2.Controls.Add(this.btaddfiles);
            this.splitContainer2.Panel2.Controls.Add(this.btdeltab);
            this.splitContainer2.Panel2.Controls.Add(this.bttabadd);
            this.splitContainer2.Size = new System.Drawing.Size(401, 355);
            this.splitContainer2.SplitterDistance = 274;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.CDPage0);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(274, 355);
            this.tabControl.TabIndex = 0;
            // 
            // CDPage0
            // 
            this.CDPage0.Controls.Add(this.songslistbox);
            this.CDPage0.Location = new System.Drawing.Point(4, 22);
            this.CDPage0.Name = "CDPage0";
            this.CDPage0.Padding = new System.Windows.Forms.Padding(3);
            this.CDPage0.Size = new System.Drawing.Size(266, 329);
            this.CDPage0.TabIndex = 0;
            this.CDPage0.Text = "CD00";
            this.CDPage0.UseVisualStyleBackColor = true;
            // 
            // songslistbox
            // 
            this.songslistbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songslistbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songslistbox.FormattingEnabled = true;
            this.songslistbox.Location = new System.Drawing.Point(3, 3);
            this.songslistbox.Margin = new System.Windows.Forms.Padding(0);
            this.songslistbox.Name = "songslistbox";
            this.songslistbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.songslistbox.Size = new System.Drawing.Size(260, 323);
            this.songslistbox.TabIndex = 0;
            // 
            // btwritecd
            // 
            this.btwritecd.FlatAppearance.BorderSize = 0;
            this.btwritecd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btwritecd.Location = new System.Drawing.Point(80, 315);
            this.btwritecd.Name = "btwritecd";
            this.btwritecd.Size = new System.Drawing.Size(40, 20);
            this.btwritecd.TabIndex = 6;
            this.btwritecd.Text = "write";
            this.btwritecd.UseVisualStyleBackColor = true;
            this.btwritecd.Click += new System.EventHandler(this.btwritecd_Click);
            // 
            // ldrives
            // 
            this.ldrives.AutoSize = true;
            this.ldrives.Location = new System.Drawing.Point(11, 222);
            this.ldrives.Name = "ldrives";
            this.ldrives.Size = new System.Drawing.Size(37, 13);
            this.ldrives.TabIndex = 5;
            this.ldrives.Text = "Drives";
            // 
            // cbdrives
            // 
            this.cbdrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdrives.FormattingEnabled = true;
            this.cbdrives.Location = new System.Drawing.Point(58, 217);
            this.cbdrives.Name = "cbdrives";
            this.cbdrives.Size = new System.Drawing.Size(54, 21);
            this.cbdrives.TabIndex = 4;
            // 
            // btdelfiles
            // 
            this.btdelfiles.FlatAppearance.BorderSize = 0;
            this.btdelfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdelfiles.Location = new System.Drawing.Point(49, 51);
            this.btdelfiles.Name = "btdelfiles";
            this.btdelfiles.Size = new System.Drawing.Size(40, 20);
            this.btdelfiles.TabIndex = 3;
            this.btdelfiles.Text = "del";
            this.btdelfiles.UseVisualStyleBackColor = true;
            this.btdelfiles.Click += new System.EventHandler(this.btdelfiles_Click);
            // 
            // btaddfiles
            // 
            this.btaddfiles.FlatAppearance.BorderSize = 0;
            this.btaddfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btaddfiles.Location = new System.Drawing.Point(3, 51);
            this.btaddfiles.Name = "btaddfiles";
            this.btaddfiles.Size = new System.Drawing.Size(40, 20);
            this.btaddfiles.TabIndex = 2;
            this.btaddfiles.Text = "add";
            this.btaddfiles.UseVisualStyleBackColor = true;
            this.btaddfiles.Click += new System.EventHandler(this.btaddfiles_Click);
            // 
            // btdeltab
            // 
            this.btdeltab.FlatAppearance.BorderSize = 0;
            this.btdeltab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdeltab.Location = new System.Drawing.Point(49, 3);
            this.btdeltab.Name = "btdeltab";
            this.btdeltab.Size = new System.Drawing.Size(40, 20);
            this.btdeltab.TabIndex = 1;
            this.btdeltab.Text = "del";
            this.btdeltab.UseVisualStyleBackColor = true;
            // 
            // bttabadd
            // 
            this.bttabadd.FlatAppearance.BorderSize = 0;
            this.bttabadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttabadd.Location = new System.Drawing.Point(3, 3);
            this.bttabadd.Name = "bttabadd";
            this.bttabadd.Size = new System.Drawing.Size(40, 20);
            this.bttabadd.TabIndex = 0;
            this.bttabadd.Text = "add";
            this.bttabadd.UseVisualStyleBackColor = true;
            this.bttabadd.Click += new System.EventHandler(this.bttabadd_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(265, 29);
            this.progressBar1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 399);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.CDPage0.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage CDPage0;
        private System.Windows.Forms.ListBox songslistbox;
        private System.Windows.Forms.Button btdelfiles;
        private System.Windows.Forms.Button btaddfiles;
        private System.Windows.Forms.Button btdeltab;
        private System.Windows.Forms.Button bttabadd;
        private System.Windows.Forms.Label ldrives;
        private System.Windows.Forms.ComboBox cbdrives;
        private System.Windows.Forms.Button btwritecd;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

