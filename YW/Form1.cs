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
        TabPage tabPage;
        ListBox lb;
        ListBox selectedlb;
        List<string> cdsongs = new List<string>();
        
        public class SongFullPath
        {
            public List<string> cdname = new List<string>();
            public List<string> Fullpath = new List<string>();
        }
        SongFullPath sfp1 = new SongFullPath();

        private void btaddfiles_Click(object sender, EventArgs e)
        {
            selectedlb = (ListBox)tabControl.SelectedTab.Controls.Cast<Control>().FirstOrDefault(x => x is ListBox);

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
                                selectedlb.Items.Add(Path.GetFileName(file));
                                //cdsongs.Add(file);
                                sfp1.cdname.Add(tabControl.SelectedTab.Text);
                                sfp1.Fullpath.Add(file);
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
            selectedlb = (ListBox)tabControl.SelectedTab.Controls.Cast<Control>().FirstOrDefault(x => x is ListBox);

            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(selectedlb);
            selectedItems = selectedlb.SelectedItems;

            if (selectedlb.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    selectedlb.Items.Remove(selectedItems[i]);
                    //cdsongs.RemoveAt(i);
                    sfp1.cdname.RemoveAt(i);
                    sfp1.Fullpath.RemoveAt(i);
                }
            }
            else
                MessageBox.Show("something wrong");
        }

        private void btwritecd_Click(object sender, EventArgs e)
        {
            List<string> dirstocreate = new List<string>();
            for (int i = 0; i < tabControl.TabCount; i++)
            {
                dirstocreate.Add(tabControl.TabPages[i].Text);
                Directory.CreateDirectory(cbdrives.SelectedItem.ToString() + tabControl.TabPages[i].Text);
            }

            //string directorytocreate = cbdrives.SelectedItem.ToString() + tabControl.SelectedTab.Text;
            //Directory.CreateDirectory(directorytocreate);
            //for (int i = 0; i < cdsongs.Count; i++)
            //{
            //    string pathtowrite = directorytocreate + "\\" + songslistbox.Items[i].ToString();
            //    File.Copy(cdsongs[i], pathtowrite);
            //}

            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = sfp1.Fullpath.Count;
            progressBar1.Value = 1;
            progressBar1.Step = 1;
            string pathtowrite;
            //for (int i = 1; i < cdsongs.Count; i++)
            for (int i = 1; i < sfp1.Fullpath.Count; i++)
            {
                try
                {
                    //pathtowrite = cbdrives.SelectedItem + sfp1.cdname[i] + "\\" + sfp1.Fullpath[i];
                    pathtowrite = cbdrives.SelectedItem + sfp1.cdname[i] + "\\" + Path.GetFileName(sfp1.Fullpath[i]);
                    //string pathtowrite = directorytocreate + "\\" + songslistbox.Items[i].ToString();
                    File.Copy(sfp1.Fullpath[i], pathtowrite);
                    progressBar1.PerformStep();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not write file on disk. Original error: " + ex.Message);
                }
                if (i == sfp1.Fullpath.Count-1)
                {
                    MessageBox.Show("writing completed");
                }
            }
            progressBar1.Value = 1;
        }

        int cdcount = 1;
        private void bttabadd_Click(object sender, EventArgs e)
        {

            
            if (cdcount < 10)
            {
                tabPage = new TabPage("CD0" + cdcount);
                tabPage.Name = "CDPage0" + cdcount;
            }
            else
            {
                tabPage = new TabPage("CD" + cdcount);
                tabPage.Name = "CDPage" + cdcount;
            }
                
            lb = new ListBox();
            lb.BorderStyle = BorderStyle.None;
            lb.Name = "songslistbox" + (cdcount + 1);
            lb.Dock = DockStyle.Fill;
            lb.MultiColumn = false;
            lb.SelectionMode = SelectionMode.MultiExtended;
            //lb.Items.Add("hoho");
            tabPage.Controls.Add(lb);
            tabControl.TabPages.Add(tabPage);
            
            cdcount++;
        }
    }
}
