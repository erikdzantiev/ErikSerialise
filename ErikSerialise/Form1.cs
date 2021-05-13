using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErikSerialise
{
    public partial class Form1 : Form
    {
        ListMid lst = new ListMid();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            lst.SaveToFile();
        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {
            Mid m = new Mid(textBoxTime.Text, textBoxName.Text);
            lst.Add(m);
            listBoxMid.Items.Add(m);
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            lst.LoadFromFile();
            lst.ViewToListBox(listBoxMid);
        }
    }
}
