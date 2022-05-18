using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EL_App_01.Forms;

namespace EL_App_01
{
    public partial class Subject : UserControl
    {
        public static Subject instance;
        public string subName = "";
        public Subject()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Color _iconBackCol;
        private string _subject;
        private string _description;
        private Image _iconImg;

        [Category("Custom Props")]
        public string mySubject
        {
            get { return _subject; }
            set { _subject = value; lblSub.Text = value; }
        }

        [Category("Custom Props")]
        public Color iconBackCol
        {
            get { return _iconBackCol; }
            set { _iconBackCol = value; panel1.BackColor = value; }
        }


        [Category("Custom Props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; lbl_sub_desc.Text = value; }
        }


        [Category("Custom Props")]
        public Image IconImg
        {
            get { return _iconImg; }
            set { _iconImg = value; pictureBox1.Image = value; }
        }

        private void Subject_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void Subject_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lblSub_Click(object sender, EventArgs e)
        {

        }

        private void Subject_Load(object sender, EventArgs e)
        {

        }

        private void Subject_Click(object sender, EventArgs e)
        {
            subName = _subject;
            //MessageBox.Show("Hello World "+ subName + " "+_description);
            new FormSelectedSubject().Show();
            this.Hide();
        }
    }
}
