using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EL_App_01.Forms;

namespace EL_App_01.Forms
{
    public partial class FormSelectedSubject : Form
    {
        public FormSelectedSubject()
        {
            InitializeComponent();
        }

        string selectedSub = Subject.instance.subName;

        //
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-143KBPT\SQLEXPRESS;Initial Catalog=ELearning_Proj_DB;Integrated Security=True;Pooling=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        //Subject subject = new Subject();
        private void FormSelectedSubject_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Hello World " + selectedSub);
            lblSubject.Text = selectedSub;
            //

            con.Open();
            string markSql = "SELECT mark1, mark2,mark3,mark4 FROM student a1 JOIN tbl_stud_subj a2 on a1.id=a2.student_id JOIN tbl_subject a3 on a3.subject_id=a2.subject_id WHERE a1.id=1";
            cmd = new SqlCommand(markSql, con);
            //cmd.Parameters.AddWithValue("@ID", activeUId);



            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {


                txtTest1.Text = dr.GetValue(0).ToString();
                txtTest2.Text = dr.GetValue(1).ToString();
                txtTest3.Text = dr.GetValue(2).ToString();
                txtTest4.Text = dr.GetValue(3).ToString();

            }
            con.Close();

        }

        private void lblSubject_Click(object sender, EventArgs e)
        {
           
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            double avg = 0;
            double sum = 0;
            int count = 0;

            if (txtTest1 != null && txtTest1.Text !="")
            {

                sum += double.Parse(txtTest1.Text);
                count++;
            }
            if (txtTest2 != null && txtTest2.Text != "")
            {
                sum += double.Parse(txtTest2.Text);
                count++;
            }
            if (txtTest3 != null && txtTest3.Text != "")
            {
                sum += double.Parse(txtTest3.Text);
                count++;
            }
            if (txtTest4 != null && txtTest4.Text != "")
            {
                sum += double.Parse(txtTest4.Text);
                count++;
            }
            if (count > 0)
            {
                avg = sum / count;
            }
            else
            {
                avg = 0;
            }
            txtTotalMarks.Text = avg.ToString();

            MessageBox.Show(" "+txtTotalMarks.Text);


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            string addMark = "UPDATE tbl_subject SET mark1 ="+ txtTest1.Text+",mark2 ="+txtTest2.Text+",mark3 = "+txtTest3.Text+",mark4 = "+txtTest4.Text+" WHERE subject_id = 1";
            cmd = new SqlCommand(addMark, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
