namespace YW
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
            this.CDPage = new System.Windows.Forms.TabPage();
            this.songslistbox = new System.Windows.Forms.ListBox();
            this.btdelfiles = new System.Windows.Forms.Button();
            this.btaddfiles = new System.Windows.Forms.Button();
            this.btdeltab = new System.Windows.Forms.Button();
            this.bttabadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.CDPage.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(401, 387);
            this.splitContainer1.SplitterDistance = 342;
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
            this.splitContainer2.Panel2.Controls.Add(this.btdelfiles);
            this.splitContainer2.Panel2.Controls.Add(this.btaddfiles);
            this.splitContainer2.Panel2.Controls.Add(this.btdeltab);
            this.splitContainer2.Panel2.Controls.Add(this.bttabadd);
            this.splitContainer2.Size = new System.Drawing.Size(401, 342);
            this.splitContainer2.SplitterDistance = 274;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.CDPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(274, 342);
            this.tabControl.TabIndex = 0;
            // 
            // CDPage
            // 
            this.CDPage.Controls.Add(this.songslistbox);
            this.CDPage.Location = new System.Drawing.Point(4, 22);
            this.CDPage.Name = "CDPage";
            this.CDPage.Padding = new System.Windows.Forms.Padding(3);
            this.CDPage.Size = new System.Drawing.Size(266, 316);
            this.CDPage.TabIndex = 0;
            this.CDPage.Text = "CD00";
            this.CDPage.UseVisualStyleBackColor = true;
            // 
            // songslistbox
            // 
            this.songslistbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songslistbox.FormattingEnabled = true;
            this.songslistbox.Location = new System.Drawing.Point(3, 3);
            this.songslistbox.Name = "songslistbox";
            this.songslistbox.Size = new System.Drawing.Size(260, 310);
            this.songslistbox.TabIndex = 0;
            // 
            // btdelfiles
            // 
            this.btdelfiles.Location = new System.Drawing.Point(49, 51);
            this.btdelfiles.Name = "btdelfiles";
            this.btdelfiles.Size = new System.Drawing.Size(40, 20);
            this.btdelfiles.TabIndex = 3;
            this.btdelfiles.Text = "del";
            this.btdelfiles.UseVisualStyleBackColor = true;
            // 
            // btaddfiles
            // 
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
            this.btdeltab.Location = new System.Drawing.Point(49, 3);
            this.btdeltab.Name = "btdeltab";
            this.btdeltab.Size = new System.Drawing.Size(40, 20);
            this.btdeltab.TabIndex = 1;
            this.btdeltab.Text = "del";
            this.btdeltab.UseVisualStyleBackColor = true;
            // 
            // bttabadd
            // 
            this.bttabadd.Location = new System.Drawing.Point(3, 3);
            this.bttabadd.Name = "bttabadd";
            this.bttabadd.Size = new System.Drawing.Size(40, 20);
            this.bttabadd.TabIndex = 0;
            this.bttabadd.Text = "add";
            this.bttabadd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 387);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.CDPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage CDPage;
        private System.Windows.Forms.ListBox songslistbox;
        private System.Windows.Forms.Button btdelfiles;
        private System.Windows.Forms.Button btaddfiles;
        private System.Windows.Forms.Button btdeltab;
        private System.Windows.Forms.Button bttabadd;
    }
}

