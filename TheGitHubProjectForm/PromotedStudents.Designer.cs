namespace TheGitHubProjectForm
{
    partial class PromotedStudents
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
            this.txtPromoted = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPromoted
            // 
            this.txtPromoted.Location = new System.Drawing.Point(39, 26);
            this.txtPromoted.Multiline = true;
            this.txtPromoted.Name = "txtPromoted";
            this.txtPromoted.ReadOnly = true;
            this.txtPromoted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPromoted.Size = new System.Drawing.Size(399, 368);
            this.txtPromoted.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(168, 418);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // PromotedStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 468);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtPromoted);
            this.Name = "PromotedStudents";
            this.Text = "Promoted Students";
            this.Load += new System.EventHandler(this.PromotedStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPromoted;
        private System.Windows.Forms.Button btnClose;
    }
}