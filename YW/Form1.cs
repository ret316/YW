using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetDrives();
        }

        private void GetDrives()
        {
            string[] Drives = Environment.GetLogicalDrives();
            foreach (string s in Drives)
            {
                cbdrives.Items.Add(s);

            }
        }


        List<string> cdsongs = new List<string>();

        private void btaddfiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "add songs (*.mp3)|*.mp3";
            op.InitialDirectory = "E:\\Media\\car\\all";
            op.Multiselect = true;

            Stream myStream = null;

            if (op.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in op.FileNames)
                {
                    try
                    {
                        if ((myStream = op.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                songslistbox.Items.Add(Path.GetFileName(file));
                                cdsongs.Add(file);
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }

        private void btdelfiles_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(songslistbox);
            selectedItems = songslistbox.SelectedItems;

            if (songslistbox.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    songslistbox.Items.Remove(selectedItems[i]);
                    cdsongs.RemoveAt(i);
                }
            }
            else
                MessageBox.Show("something wrong");
        }

        private void btwritecd_Click(object sender, EventArgs e)
        {
            string directorytocreate = cbdrives.SelectedItem.ToString() + tabControl.SelectedTab.Text;
            Directory.CreateDirectory(directorytocreate);
            //for (int i = 0; i < cdsongs.Count; i++)
            //{
            //    string pathtowrite = directorytocreate + "\\" + songslistbox.Items[i].ToString();
            //    File.Copy(cdsongs[i], pathtowrite);
            //}

            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = cdsongs.Count;
            progressBar1.Value = 1;
            progressBar1.Step = 1;

            for (int i = 1; i < cdsongs.Count; i++)
            {
                try
                {
                    string pathtowrite = directorytocreate + "\\" + songslistbox.Items[i].ToString();
                    File.Copy(cdsongs[i], pathtowrite);
                    progressBar1.PerformStep();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not write file on disk. Original error: " + ex.Message);
                }
            }
            progressBar1.Value = 1;
        }

        int cdcount = 1;
        private void bttabadd_Click(object sender, EventArgs e)
        {
            
            TabPage tabPage;
            if (cdcount <10)
                tabPage = new TabPage("CD0" + cdcount);
            else
                tabPage = new TabPage("CD" + cdcount);
            ListBox lb = new ListBox();
            lb.BorderStyle = BorderStyle.None;
            lb.Name = "songslistbox" + (cdcount + 1);
            lb.Dock = DockStyle.Fill;
            lb.MultiColumn = false;
            lb.SelectionMode = SelectionMode.MultiExtended;
            lb.Items.Add("hoho");
            tabPage.Controls.Add(lb);
            tabControl.TabPages.Add(tabPage);


            cdcount++;
        }
    }
}
