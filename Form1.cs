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
            this.checkBox1.CheckedChanged -= new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox2.CheckedChanged -= new System.EventHandler(this.checkBox2_CheckedChanged);
            this.checkBox3.CheckedChanged -= new System.EventHandler(this.checkBox3_CheckedChanged);
            this.checkBox4.CheckedChanged -= new System.EventHandler(this.checkBox4_CheckedChanged);

            checkBox1.Checked = listView1.LargeImageList != null;
            checkBox2.Checked = listView1.SmallImageList != null;
            checkBox3.Checked = listView1.StateImageList?.Images.Count > 0;
            checkBox4.Checked = listView1.CheckBoxes;

            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
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
