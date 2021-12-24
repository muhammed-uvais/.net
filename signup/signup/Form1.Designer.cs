
namespace signup
{
    partial class Form1
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
            this.txtboxfirstname = new System.Windows.Forms.TextBox();
            this.txtboxlastname = new System.Windows.Forms.TextBox();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtboxusername = new System.Windows.Forms.TextBox();
            this.txtboxpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnsignup = new System.Windows.Forms.Button();
            this.lblusernamelogin = new System.Windows.Forms.Label();
            this.txtboxusernamelogin = new System.Windows.Forms.TextBox();
            this.lblpasswordlogin = new System.Windows.Forms.Label();
            this.txtboxpasswordlogin = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(22, 155);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(70, 16);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "First name";
            this.lblfirstname.Click += new System.EventHandler(this.lblfirstname_Click);
            // 
            // txtboxfirstname
            // 
            this.txtboxfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxfirstname.Location = new System.Drawing.Point(109, 155);
            this.txtboxfirstname.Name = "txtboxfirstname";
            this.txtboxfirstname.Size = new System.Drawing.Size(235, 22);
            this.txtboxfirstname.TabIndex = 1;
            // 
            // txtboxlastname
            // 
            this.txtboxlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxlastname.Location = new System.Drawing.Point(109, 207);
            this.txtboxlastname.Name = "txtboxlastname";
            this.txtboxlastname.Size = new System.Drawing.Size(235, 22);
            this.txtboxlastname.TabIndex = 2;
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(22, 213);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(70, 16);
            this.lbllastname.TabIndex = 3;
            this.lbllastname.Text = "Last name";
            this.lbllastname.Click += new System.EventHandler(this.lbllastname_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(21, 269);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(68, 16);
            this.lblusername.TabIndex = 4;
            this.lblusername.Text = "username";
            // 
            // txtboxusername
            // 
            this.txtboxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxusername.Location = new System.Drawing.Point(109, 263);
            this.txtboxusername.Name = "txtboxusername";
            this.txtboxusername.Size = new System.Drawing.Size(235, 22);
            this.txtboxusername.TabIndex = 5;
            // 
            // txtboxpassword
            // 
            this.txtboxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxpassword.Location = new System.Drawing.Point(109, 316);
            this.txtboxpassword.Name = "txtboxpassword";
            this.txtboxpassword.Size = new System.Drawing.Size(235, 22);
            this.txtboxpassword.TabIndex = 6;
            this.txtboxpassword.TextChanged += new System.EventHandler(this.txtboxpassword_TextChanged);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(22, 322);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(67, 16);
            this.lblpassword.TabIndex = 7;
            this.lblpassword.Text = "password";
            this.lblpassword.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.DarkBlue;
            this.btnsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsignup.Location = new System.Drawing.Point(255, 367);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(89, 27);
            this.btnsignup.TabIndex = 8;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // lblusernamelogin
            // 
            this.lblusernamelogin.AutoSize = true;
            this.lblusernamelogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusernamelogin.Location = new System.Drawing.Point(202, 38);
            this.lblusernamelogin.Name = "lblusernamelogin";
            this.lblusernamelogin.Size = new System.Drawing.Size(68, 16);
            this.lblusernamelogin.TabIndex = 9;
            this.lblusernamelogin.Text = "username";
            this.lblusernamelogin.Click += new System.EventHandler(this.lblusernamelogin_Click);
            // 
            // txtboxusernamelogin
            // 
            this.txtboxusernamelogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxusernamelogin.Location = new System.Drawing.Point(276, 30);
            this.txtboxusernamelogin.Name = "txtboxusernamelogin";
            this.txtboxusernamelogin.Size = new System.Drawing.Size(235, 22);
            this.txtboxusernamelogin.TabIndex = 10;
            this.txtboxusernamelogin.TextChanged += new System.EventHandler(this.txtboxusernamelogin_TextChanged);
            // 
            // lblpasswordlogin
            // 
            this.lblpasswordlogin.AutoSize = true;
            this.lblpasswordlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasswordlogin.Location = new System.Drawing.Point(530, 33);
            this.lblpasswordlogin.Name = "lblpasswordlogin";
            this.lblpasswordlogin.Size = new System.Drawing.Size(67, 16);
            this.lblpasswordlogin.TabIndex = 11;
            this.lblpasswordlogin.Text = "password";
            // 
            // txtboxpasswordlogin
            // 
            this.txtboxpasswordlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxpasswordlogin.Location = new System.Drawing.Point(603, 27);
            this.txtboxpasswordlogin.Name = "txtboxpasswordlogin";
            this.txtboxpasswordlogin.Size = new System.Drawing.Size(235, 22);
            this.txtboxpasswordlogin.TabIndex = 12;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.DarkBlue;
            this.btnlogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnlogin.Location = new System.Drawing.Point(866, 27);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(89, 27);
            this.btnlogin.TabIndex = 13;
            this.btnlogin.Text = "Log in";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtboxpasswordlogin);
            this.Controls.Add(this.lblpasswordlogin);
            this.Controls.Add(this.txtboxusernamelogin);
            this.Controls.Add(this.lblusernamelogin);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtboxpassword);
            this.Controls.Add(this.txtboxusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.txtboxlastname);
            this.Controls.Add(this.txtboxfirstname);
            this.Controls.Add(this.lblfirstname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox txtboxfirstname;
        private System.Windows.Forms.TextBox txtboxlastname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtboxusername;
        private System.Windows.Forms.TextBox txtboxpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Label lblusernamelogin;
        private System.Windows.Forms.TextBox txtboxusernamelogin;
        private System.Windows.Forms.Label lblpasswordlogin;
        private System.Windows.Forms.TextBox txtboxpasswordlogin;
        private System.Windows.Forms.Button btnlogin;
    }
}

