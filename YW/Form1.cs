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
            wtf();
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


        //test
        //public class SongFullPathListList : List<SongFullPathList> { }

        public class SongFullPathListList
        {
            public List<SongFullPathList> Sfpll = new List<SongFullPathList>();
        }

        //public class SongFullPathList : List<SongFullPath>{ }
        public class SongFullPathList
        {
            public string cdname { get; set; }
            public List<SongFullPath> Sfplist = new List<SongFullPath>();
        }
        public class SongFullPath
        {
            public List<string> Fullpath = new List<string>();
        }
        //test

        private void wtf()
        {
            SongFullPath sfp1 = new SongFullPath();
            SongFullPathList sfpl1 = new SongFullPathList();
            SongFullPathListList sfpll1 = new SongFullPathListList();
            sfp1.Fullpath.Add("E\\olala\\lala1");
            sfp1.Fullpath.Add("E\\olala\\lala2");
            sfp1.Fullpath.Add("E\\olala\\lala3");


            sfpl1.cdname = "cd01";
            sfpl1.Sfplist.Add(sfp1);
            sfpll1.Sfpll.Add(sfpl1);

            sfp1 = new SongFullPath();
            sfp1.Fullpath.Add("E\\olala\\lala4");
            sfp1.Fullpath.Add("E\\olala\\lala5");
            sfp1.Fullpath.Add("E\\olala\\lala6");

            sfpl1 = new SongFullPathList();
            sfpl1.cdname = "cd02";
            sfpl1.Sfplist.Add(sfp1);
            sfpll1.Sfpll.Add(sfpl1);
        }


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
            selectedlb = (ListBox)tabControl.SelectedTab.Controls.Cast<Control>().FirstOrDefault(x => x is ListBox);

            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(selectedlb);
            selectedItems = selectedlb.SelectedItems;

            if (selectedlb.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    selectedlb.Items.Remove(selectedItems[i]);
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
