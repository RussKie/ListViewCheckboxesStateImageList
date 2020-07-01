using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckState();
        }

        private void CheckState()
        {
            checkBox1.Checked = listView1.LargeImageList != null;
            checkBox2.Checked = listView1.SmallImageList != null;
            checkBox3.Checked = listView1.StateImageList != null;
            checkBox4.Checked = listView1.CheckBoxes;

        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            listView1.LargeImageList = checkBox1.Checked ? imageListLarge : null;
            CheckState();
        }

        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            listView1.SmallImageList = checkBox2.Checked ? imageListSmall : null;
            CheckState();
        }

        private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
        {
            listView1.StateImageList = checkBox3.Checked ? imageListState : null;
            CheckState();
        }

        private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
        {
            listView1.CheckBoxes = !listView1.CheckBoxes;
            CheckState();
        }
    }
}
