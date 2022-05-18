using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace EL_App_01.Forms
{
    public partial class FormMyClasses : Form
    {
        public FormMyClasses()
        {
            InitializeComponent();
        }

        private void FormMyClasses_Load(object sender, EventArgs e)
        {
            //int startPosition = 100;
            //int endPosition = 1;

            for (int i = 0; i <= 15; i++)
            {
                Label l = addLabel(i);
                classFlowLayoutPanel.Controls.Add(l);
                l.Click += new System.EventHandler(this.labelClick);
            }
        }

        void labelClick(object sender, EventArgs e)
        {
            Label currentlable = (Label)sender;
            MessageBox.Show(currentlable.Text);
        }

        Label addLabel(int i)
        {
            Label l = new Label();
            l.Name = "Label " + i.ToString();
            l.Text = "Label " + i.ToString();
            l.ForeColor = Color.Yellow;
            l.BackColor = Color.Red;
            l.Font = new Font("Serif", 24, FontStyle.Bold);
            l.Width = 170;
            l.Height = 80;
            // l.Location = new Point(start, end);
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Margin = new Padding(5);

            return l;
        }

    }
}
