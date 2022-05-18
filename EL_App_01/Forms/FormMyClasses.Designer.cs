
namespace EL_App_01.Forms
{
    partial class FormMyClasses
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
            this.classFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // classFlowLayoutPanel
            // 
            this.classFlowLayoutPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.classFlowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.classFlowLayoutPanel.Name = "classFlowLayoutPanel";
            this.classFlowLayoutPanel.Size = new System.Drawing.Size(776, 426);
            this.classFlowLayoutPanel.TabIndex = 0;
            // 
            // FormMyClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.classFlowLayoutPanel);
            this.Name = "FormMyClasses";
            this.Text = "FormMyClasses";
            this.Load += new System.EventHandler(this.FormMyClasses_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel classFlowLayoutPanel;
    }
}