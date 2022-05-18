
namespace EL_App_01
{
    partial class Subject
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_sub_desc = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_sub_desc
            // 
            this.lbl_sub_desc.AutoSize = true;
            this.lbl_sub_desc.Location = new System.Drawing.Point(184, 68);
            this.lbl_sub_desc.Name = "lbl_sub_desc";
            this.lbl_sub_desc.Size = new System.Drawing.Size(99, 15);
            this.lbl_sub_desc.TabIndex = 2;
            this.lbl_sub_desc.Text = "Some description";
            this.lbl_sub_desc.MouseEnter += new System.EventHandler(this.Subject_MouseEnter);
            this.lbl_sub_desc.MouseLeave += new System.EventHandler(this.Subject_MouseLeave);
            // 
            // lblSub
            // 
            this.lblSub.AutoEllipsis = true;
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSub.Location = new System.Drawing.Point(184, 17);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(132, 25);
            this.lblSub.TabIndex = 3;
            this.lblSub.Text = "Subject_Name";
            this.lblSub.Click += new System.EventHandler(this.lblSub_Click);
            this.lblSub.MouseEnter += new System.EventHandler(this.Subject_MouseEnter);
            this.lblSub.MouseLeave += new System.EventHandler(this.Subject_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 130);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Location = new System.Drawing.Point(3, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 5);
            this.panel2.TabIndex = 5;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lbl_sub_desc);
            this.Name = "Subject";
            this.Size = new System.Drawing.Size(539, 139);
            this.Load += new System.EventHandler(this.Subject_Load);
            this.Click += new System.EventHandler(this.Subject_Click);
            this.MouseEnter += new System.EventHandler(this.Subject_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Subject_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_sub_desc;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
