using EL_App_01.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Documents;
using System.Windows.Forms;
using EL_App_01.Forms;

namespace EL_App_01.Forms
{
    public partial class FormClasses : Form
    {
        //
       // public static FormClasses instance;
        //public string subName = "";
        public FormClasses()
        {
            InitializeComponent();
            //instance = this;
        }
        

        //
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-143KBPT\SQLEXPRESS;Initial Catalog=ELearning_Proj_DB;Integrated Security=True;Pooling=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void FormClasses_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        //create items
        private void populateItems()
        {

            //
            string activeUId=frmLogin.instance.uId;

            Subject[] subjects = new Subject[10];

            con.Open();
            string subjectsData = "SELECT subject_name, subject_desc FROM student a1 JOIN tbl_stud_subj a2 on a1.id=a2.student_id JOIN tbl_subject a3 on a3.subject_id=a2.subject_id WHERE a1.id=@ID";
            //string subjectsData = "SELECT subject_name FROM tbl_subject where subject_id=@ID";
            cmd = new SqlCommand(subjectsData, con);
            cmd.Parameters.AddWithValue("@ID", activeUId);
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                subjects[i] = new Subject();
                subjects[i].IconImg = Resources.reading_icon;
                subjects[i].iconBackCol = Color.BlueViolet;
                subjects[i].mySubject = dr.GetValue(0).ToString();
                subjects[i].Description = dr.GetValue(1).ToString();
                //Add to flow layout
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(subjects[i]);
                }
            }
            con.Close();




            //Subject[] subjects = new Subject[20];
            // loop through each item
            //for (int i = 0; i < subjects.Length; i++)
            //{
            //    subjects[i] = new Subject();
            //    subjects[i].IconImg = Resources.reading_icon;
            //    subjects[i].iconBackCol = Color.BlueViolet;
            //    subjects[i].mySubject = "English";
            //    subjects[i].Description = "This is a westen language";
            //    Add to flow layout
            //    if (flowLayoutPanel1.Controls.Count < 0)
            //    {
            //        flowLayoutPanel1.Controls.Clear();
            //    }
            //    else
            //    {
            //        flowLayoutPanel1.Controls.Add(subjects[i]);
            //    }

            //}

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void subject1_Load(object sender, EventArgs e)
        {

        }
    }
}
