using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckState1();
        }

        private void CheckState1()
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

        private void CheckState2()
        {
            this.checkBox5.CheckedChanged -= new System.EventHandler(this.checkBox5_CheckedChanged);
            this.checkBox6.CheckedChanged -= new System.EventHandler(this.checkBox6_CheckedChanged);
            this.checkBox7.CheckedChanged -= new System.EventHandler(this.checkBox7_CheckedChanged);
            this.checkBox8.CheckedChanged -= new System.EventHandler(this.checkBox8_CheckedChanged);

            checkBox5.Checked = listView2.LargeImageList != null;
            checkBox6.Checked = listView2.SmallImageList != null;
            checkBox7.Checked = listView2.StateImageList?.Images.Count > 0;
            checkBox8.Checked = listView2.CheckBoxes;

            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            listView1.LargeImageList = checkBox1.Checked ? imageListLarge : null;
            CheckState1();
        }

        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            listView1.SmallImageList = checkBox2.Checked ? imageListSmall : null;
            CheckState1();
        }

        private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
        {
            listView1.StateImageList = checkBox3.Checked ? imageListState1 : null;
            CheckState1();
        }

        private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
        {
            listView1.CheckBoxes = !listView1.CheckBoxes;
            CheckState1();
        }

        private void checkBox5_CheckedChanged(object sender, System.EventArgs e)
        {
            listView1.LargeImageList = checkBox5.Checked ? imageListLarge : null;
            CheckState2();
        }

        private void checkBox6_CheckedChanged(object sender, System.EventArgs e)
        {
            listView2.SmallImageList = checkBox6.Checked ? imageListSmall : null;
            CheckState2();
        }

        private void checkBox7_CheckedChanged(object sender, System.EventArgs e)
        {
            listView2.StateImageList = checkBox7.Checked ? imageListState1 : null;
            CheckState2();
        }

        private void checkBox8_CheckedChanged(object sender, System.EventArgs e)
        {
            listView2.CheckBoxes = !listView2.CheckBoxes;
            CheckState2();
        }
    }
}
