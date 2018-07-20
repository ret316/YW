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
        }

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
    }
}
