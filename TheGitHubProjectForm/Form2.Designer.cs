namespace TheGitHubProjectForm
{
    partial class Form2
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
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblITgrade = new System.Windows.Forms.Label();
            this.lblPhysicsgrade = new System.Windows.Forms.Label();
            this.lblMathsgrades = new System.Windows.Forms.Label();
            this.lblSchorlarship = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtITgrade = new System.Windows.Forms.TextBox();
            this.txtPhysicsgrade = new System.Windows.Forms.TextBox();
            this.txtMathsgrade = new System.Windows.Forms.TextBox();
            this.btnMale = new System.Windows.Forms.RadioButton();
            this.btnFemale = new System.Windows.Forms.RadioButton();
            this.btnYes = new System.Windows.Forms.RadioButton();
            this.btnNo = new System.Windows.Forms.RadioButton();
            this.lblHead = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNotification = new System.Windows.Forms.Label();
            this.grpBoxSchorlarship = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpBoxSchorlarship.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblfirstname
            // 
            this.lblfirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(77, 90);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(83, 16);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "First Name";
            // 
            // lblsurname
            // 
            this.lblsurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsurname.AutoSize = true;
            this.lblsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsurname.Location = new System.Drawing.Point(77, 115);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(69, 16);
            this.lblsurname.TabIndex = 1;
            this.lblsurname.Text = "Surname";
            this.lblsurname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblgender
            // 
            this.lblgender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(77, 142);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(59, 16);
            this.lblgender.TabIndex = 2;
            this.lblgender.Text = "Gender";
            this.lblgender.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDOB
            // 
            this.lblDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(77, 168);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(93, 16);
            this.lblDOB.TabIndex = 3;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblITgrade
            // 
            this.lblITgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblITgrade.AutoSize = true;
            this.lblITgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITgrade.Location = new System.Drawing.Point(77, 197);
            this.lblITgrade.Name = "lblITgrade";
            this.lblITgrade.Size = new System.Drawing.Size(130, 16);
            this.lblITgrade.TabIndex = 4;
            this.lblITgrade.Text = "Informatics Grade";
            // 
            // lblPhysicsgrade
            // 
            this.lblPhysicsgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhysicsgrade.AutoSize = true;
            this.lblPhysicsgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhysicsgrade.Location = new System.Drawing.Point(77, 223);
            this.lblPhysicsgrade.Name = "lblPhysicsgrade";
            this.lblPhysicsgrade.Size = new System.Drawing.Size(109, 16);
            this.lblPhysicsgrade.TabIndex = 5;
            this.lblPhysicsgrade.Text = "Physics Grade";
            // 
            // lblMathsgrades
            // 
            this.lblMathsgrades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMathsgrades.AutoSize = true;
            this.lblMathsgrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathsgrades.Location = new System.Drawing.Point(77, 251);
            this.lblMathsgrades.Name = "lblMathsgrades";
            this.lblMathsgrades.Size = new System.Drawing.Size(142, 16);
            this.lblMathsgrades.TabIndex = 6;
            this.lblMathsgrades.Text = "Mathematics Grade";
            // 
            // lblSchorlarship
            // 
            this.lblSchorlarship.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSchorlarship.AutoSize = true;
            this.lblSchorlarship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchorlarship.Location = new System.Drawing.Point(77, 278);
            this.lblSchorlarship.Name = "lblSchorlarship";
            this.lblSchorlarship.Size = new System.Drawing.Size(95, 16);
            this.lblSchorlarship.TabIndex = 7;
            this.lblSchorlarship.Text = "Schorlarship";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(169, 89);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(278, 22);
            this.txtFirstname.TabIndex = 8;
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(169, 117);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(278, 22);
            this.txtSurname.TabIndex = 9;
            // 
            // txtDOB
            // 
            this.txtDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(169, 168);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(219, 22);
            this.txtDOB.TabIndex = 11;
            this.txtDOB.TextChanged += new System.EventHandler(this.txtDOB_TextChanged);
            // 
            // txtITgrade
            // 
            this.txtITgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtITgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtITgrade.Location = new System.Drawing.Point(225, 195);
            this.txtITgrade.Name = "txtITgrade";
            this.txtITgrade.Size = new System.Drawing.Size(81, 22);
            this.txtITgrade.TabIndex = 12;
            // 
            // txtPhysicsgrade
            // 
            this.txtPhysicsgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhysicsgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhysicsgrade.Location = new System.Drawing.Point(225, 223);
            this.txtPhysicsgrade.Name = "txtPhysicsgrade";
            this.txtPhysicsgrade.Size = new System.Drawing.Size(81, 22);
            this.txtPhysicsgrade.TabIndex = 13;
            // 
            // txtMathsgrade
            // 
            this.txtMathsgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMathsgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMathsgrade.Location = new System.Drawing.Point(225, 251);
            this.txtMathsgrade.Name = "txtMathsgrade";
            this.txtMathsgrade.Size = new System.Drawing.Size(81, 22);
            this.txtMathsgrade.TabIndex = 14;
            // 
            // btnMale
            // 
            this.btnMale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMale.AutoSize = true;
            this.btnMale.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMale.Location = new System.Drawing.Point(169, 145);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(60, 23);
            this.btnMale.TabIndex = 15;
            this.btnMale.TabStop = true;
            this.btnMale.Text = "Male";
            this.btnMale.UseVisualStyleBackColor = true;
            this.btnMale.CheckedChanged += new System.EventHandler(this.btnMale_CheckedChanged);
            // 
            // btnFemale
            // 
            this.btnFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFemale.AutoSize = true;
            this.btnFemale.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFemale.Location = new System.Drawing.Point(260, 145);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(75, 23);
            this.btnFemale.TabIndex = 16;
            this.btnFemale.TabStop = true;
            this.btnFemale.Text = "Female";
            this.btnFemale.UseVisualStyleBackColor = true;
            this.btnFemale.CheckedChanged += new System.EventHandler(this.btnFemale_CheckedChanged);
            // 
            // btnYes
            // 
            this.btnYes.AutoSize = true;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(6, 8);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(53, 20);
            this.btnYes.TabIndex = 17;
            this.btnYes.TabStop = true;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.CheckedChanged += new System.EventHandler(this.btnYes_CheckedChanged);
            // 
            // btnNo
            // 
            this.btnNo.AutoSize = true;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(97, 8);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(46, 20);
            this.btnNo.TabIndex = 18;
            this.btnNo.TabStop = true;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.CheckedChanged += new System.EventHandler(this.btnNo_CheckedChanged);
            // 
            // lblHead
            // 
            this.lblHead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(114, 26);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(248, 31);
            this.lblHead.TabIndex = 19;
            this.lblHead.Text = "Student Info Form";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(69, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(214, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 36);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(363, 345);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 36);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.Location = new System.Drawing.Point(211, 317);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(0, 16);
            this.lblNotification.TabIndex = 23;
            // 
            // grpBoxSchorlarship
            // 
            this.grpBoxSchorlarship.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxSchorlarship.Controls.Add(this.btnNo);
            this.grpBoxSchorlarship.Controls.Add(this.btnYes);
            this.grpBoxSchorlarship.Location = new System.Drawing.Point(172, 271);
            this.grpBoxSchorlarship.Name = "grpBoxSchorlarship";
            this.grpBoxSchorlarship.Size = new System.Drawing.Size(153, 36);
            this.grpBoxSchorlarship.TabIndex = 24;
            this.grpBoxSchorlarship.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(214, 345);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 36);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(511, 407);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpBoxSchorlarship);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnFemale);
            this.Controls.Add(this.btnMale);
            this.Controls.Add(this.txtMathsgrade);
            this.Controls.Add(this.txtPhysicsgrade);
            this.Controls.Add(this.txtITgrade);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblSchorlarship);
            this.Controls.Add(this.lblMathsgrades);
            this.Controls.Add(this.lblPhysicsgrade);
            this.Controls.Add(this.lblITgrade);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblsurname);
            this.Controls.Add(this.lblfirstname);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpBoxSchorlarship.ResumeLayout(false);
            this.grpBoxSchorlarship.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblITgrade;
        private System.Windows.Forms.Label lblPhysicsgrade;
        private System.Windows.Forms.Label lblMathsgrades;
        private System.Windows.Forms.Label lblSchorlarship;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtITgrade;
        private System.Windows.Forms.TextBox txtPhysicsgrade;
        private System.Windows.Forms.TextBox txtMathsgrade;
        private System.Windows.Forms.RadioButton btnMale;
        private System.Windows.Forms.RadioButton btnFemale;
        private System.Windows.Forms.RadioButton btnYes;
        private System.Windows.Forms.RadioButton btnNo;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.GroupBox grpBoxSchorlarship;
        private System.Windows.Forms.Button btnReset;
    }
}