
namespace EL_App_01.Forms
{
    partial class FormSelectedSubject
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblTest1 = new System.Windows.Forms.Label();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.lblTest3 = new System.Windows.Forms.Label();
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.txtTest3 = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.txtTest4 = new System.Windows.Forms.TextBox();
            this.lblMark4 = new System.Windows.Forms.Label();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(87, 46);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(44, 15);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "default";
            this.lblSubject.Click += new System.EventHandler(this.lblSubject_Click);
            // 
            // lblTest1
            // 
            this.lblTest1.AutoSize = true;
            this.lblTest1.Location = new System.Drawing.Point(88, 128);
            this.lblTest1.Name = "lblTest1";
            this.lblTest1.Size = new System.Drawing.Size(43, 15);
            this.lblTest1.TabIndex = 1;
            this.lblTest1.Text = "Mark 1";
            // 
            // lblTest2
            // 
            this.lblTest2.AutoSize = true;
            this.lblTest2.Location = new System.Drawing.Point(87, 167);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(43, 15);
            this.lblTest2.TabIndex = 2;
            this.lblTest2.Text = "Mark 2";
            // 
            // lblTest3
            // 
            this.lblTest3.AutoSize = true;
            this.lblTest3.Location = new System.Drawing.Point(87, 206);
            this.lblTest3.Name = "lblTest3";
            this.lblTest3.Size = new System.Drawing.Size(43, 15);
            this.lblTest3.TabIndex = 3;
            this.lblTest3.Text = "Mark 3";
            // 
            // txtTest1
            // 
            this.txtTest1.Location = new System.Drawing.Point(154, 120);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(168, 23);
            this.txtTest1.TabIndex = 4;
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(154, 159);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(168, 23);
            this.txtTest2.TabIndex = 5;
            // 
            // txtTest3
            // 
            this.txtTest3.Location = new System.Drawing.Point(154, 198);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(168, 23);
            this.txtTest3.TabIndex = 6;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(154, 317);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(168, 40);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View Total Marks";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtTest4
            // 
            this.txtTest4.Location = new System.Drawing.Point(154, 240);
            this.txtTest4.Name = "txtTest4";
            this.txtTest4.Size = new System.Drawing.Size(168, 23);
            this.txtTest4.TabIndex = 9;
            // 
            // lblMark4
            // 
            this.lblMark4.AutoSize = true;
            this.lblMark4.Location = new System.Drawing.Point(87, 248);
            this.lblMark4.Name = "lblMark4";
            this.lblMark4.Size = new System.Drawing.Size(43, 15);
            this.lblMark4.TabIndex = 8;
            this.lblMark4.Text = "Mark 4";
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Location = new System.Drawing.Point(353, 317);
            this.txtTotalMarks.Multiline = true;
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(210, 47);
            this.txtTotalMarks.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(154, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Update Marks";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormSelectedSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotalMarks);
            this.Controls.Add(this.txtTest4);
            this.Controls.Add(this.lblMark4);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtTest3);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.txtTest1);
            this.Controls.Add(this.lblTest3);
            this.Controls.Add(this.lblTest2);
            this.Controls.Add(this.lblTest1);
            this.Controls.Add(this.lblSubject);
            this.Name = "FormSelectedSubject";
            this.Text = "FormSelectedSubject";
            this.Load += new System.EventHandler(this.FormSelectedSubject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblTest1;
        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.Label lblTest3;
        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.TextBox txtTest3;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtTest4;
        private System.Windows.Forms.Label lblMark4;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.Button btnSave;
    }
}