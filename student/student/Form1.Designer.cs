
namespace student
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
            this.txtboxstudentname = new System.Windows.Forms.TextBox();
            this.lblstudentname = new System.Windows.Forms.Label();
            this.rdbnbiologyscience = new System.Windows.Forms.RadioButton();
            this.rdbncommerce = new System.Windows.Forms.RadioButton();
            this.rdbtncomputerscience = new System.Windows.Forms.RadioButton();
            this.rdbtnhumanities = new System.Windows.Forms.RadioButton();
            this.lblstudentmobileno = new System.Windows.Forms.Label();
            this.txtboxmobileno = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtboxaddress = new System.Windows.Forms.TextBox();
            this.lblcourse = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxstudentname
            // 
            this.txtboxstudentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxstudentname.Location = new System.Drawing.Point(143, 9);
            this.txtboxstudentname.Name = "txtboxstudentname";
            this.txtboxstudentname.Size = new System.Drawing.Size(227, 26);
            this.txtboxstudentname.TabIndex = 0;
            // 
            // lblstudentname
            // 
            this.lblstudentname.AutoSize = true;
            this.lblstudentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentname.Location = new System.Drawing.Point(16, 15);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(112, 20);
            this.lblstudentname.TabIndex = 1;
            this.lblstudentname.Text = "Student Name";
            // 
            // rdbnbiologyscience
            // 
            this.rdbnbiologyscience.AutoSize = true;
            this.rdbnbiologyscience.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbnbiologyscience.Location = new System.Drawing.Point(126, 110);
            this.rdbnbiologyscience.Name = "rdbnbiologyscience";
            this.rdbnbiologyscience.Size = new System.Drawing.Size(122, 20);
            this.rdbnbiologyscience.TabIndex = 2;
            this.rdbnbiologyscience.TabStop = true;
            this.rdbnbiologyscience.Text = "Biology science\r\n";
            this.rdbnbiologyscience.UseVisualStyleBackColor = true;
            this.rdbnbiologyscience.CheckedChanged += new System.EventHandler(this.rdbnbiologyscience_CheckedChanged);
            // 
            // rdbncommerce
            // 
            this.rdbncommerce.AutoSize = true;
            this.rdbncommerce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbncommerce.Location = new System.Drawing.Point(268, 159);
            this.rdbncommerce.Name = "rdbncommerce";
            this.rdbncommerce.Size = new System.Drawing.Size(92, 20);
            this.rdbncommerce.TabIndex = 3;
            this.rdbncommerce.TabStop = true;
            this.rdbncommerce.Text = "Commerce";
            this.rdbncommerce.UseVisualStyleBackColor = true;
            this.rdbncommerce.CheckedChanged += new System.EventHandler(this.rdbncommerce_CheckedChanged);
            // 
            // rdbtncomputerscience
            // 
            this.rdbtncomputerscience.AutoSize = true;
            this.rdbtncomputerscience.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtncomputerscience.Location = new System.Drawing.Point(126, 159);
            this.rdbtncomputerscience.Name = "rdbtncomputerscience";
            this.rdbtncomputerscience.Size = new System.Drawing.Size(136, 20);
            this.rdbtncomputerscience.TabIndex = 4;
            this.rdbtncomputerscience.TabStop = true;
            this.rdbtncomputerscience.Text = "Computer Science";
            this.rdbtncomputerscience.UseVisualStyleBackColor = true;
            this.rdbtncomputerscience.CheckedChanged += new System.EventHandler(this.rdbtncomputerscience_CheckedChanged);
            // 
            // rdbtnhumanities
            // 
            this.rdbtnhumanities.AutoSize = true;
            this.rdbtnhumanities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnhumanities.Location = new System.Drawing.Point(267, 110);
            this.rdbtnhumanities.Name = "rdbtnhumanities";
            this.rdbtnhumanities.Size = new System.Drawing.Size(93, 20);
            this.rdbtnhumanities.TabIndex = 5;
            this.rdbtnhumanities.TabStop = true;
            this.rdbtnhumanities.Text = "Humanities";
            this.rdbtnhumanities.UseVisualStyleBackColor = true;
            this.rdbtnhumanities.CheckedChanged += new System.EventHandler(this.rdbtnhumanities_CheckedChanged);
            // 
            // lblstudentmobileno
            // 
            this.lblstudentmobileno.AutoSize = true;
            this.lblstudentmobileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentmobileno.Location = new System.Drawing.Point(16, 59);
            this.lblstudentmobileno.Name = "lblstudentmobileno";
            this.lblstudentmobileno.Size = new System.Drawing.Size(79, 20);
            this.lblstudentmobileno.TabIndex = 6;
            this.lblstudentmobileno.Text = "Mobile No";
            // 
            // txtboxmobileno
            // 
            this.txtboxmobileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxmobileno.Location = new System.Drawing.Point(143, 59);
            this.txtboxmobileno.Name = "txtboxmobileno";
            this.txtboxmobileno.Size = new System.Drawing.Size(227, 26);
            this.txtboxmobileno.TabIndex = 7;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(16, 221);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(68, 20);
            this.lbladdress.TabIndex = 8;
            this.lbladdress.Text = "Address";
            // 
            // txtboxaddress
            // 
            this.txtboxaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxaddress.Location = new System.Drawing.Point(143, 218);
            this.txtboxaddress.Multiline = true;
            this.txtboxaddress.Name = "txtboxaddress";
            this.txtboxaddress.Size = new System.Drawing.Size(227, 123);
            this.txtboxaddress.TabIndex = 9;
            this.txtboxaddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourse.Location = new System.Drawing.Point(16, 110);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(60, 20);
            this.lblcourse.TabIndex = 10;
            this.lblcourse.Text = "Course";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnadd.Location = new System.Drawing.Point(143, 367);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(82, 23);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.MistyRose;
            this.btnclear.ForeColor = System.Drawing.Color.Black;
            this.btnclear.Location = new System.Drawing.Point(267, 367);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(82, 23);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 402);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblcourse);
            this.Controls.Add(this.txtboxaddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtboxmobileno);
            this.Controls.Add(this.lblstudentmobileno);
            this.Controls.Add(this.rdbtnhumanities);
            this.Controls.Add(this.rdbtncomputerscience);
            this.Controls.Add(this.rdbncommerce);
            this.Controls.Add(this.rdbnbiologyscience);
            this.Controls.Add(this.lblstudentname);
            this.Controls.Add(this.txtboxstudentname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxstudentname;
        private System.Windows.Forms.Label lblstudentname;
        private System.Windows.Forms.RadioButton rdbnbiologyscience;
        private System.Windows.Forms.RadioButton rdbncommerce;
        private System.Windows.Forms.RadioButton rdbtncomputerscience;
        private System.Windows.Forms.RadioButton rdbtnhumanities;
        private System.Windows.Forms.Label lblstudentmobileno;
        private System.Windows.Forms.TextBox txtboxmobileno;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtboxaddress;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclear;
    }
}

