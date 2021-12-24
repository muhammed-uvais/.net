
namespace uv
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
            this.lblcontactid = new System.Windows.Forms.Label();
            this.txtboxcontactid = new System.Windows.Forms.TextBox();
            this.txtboxfirstname = new System.Windows.Forms.TextBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblcontactno = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtboxlastname = new System.Windows.Forms.TextBox();
            this.txtboxcontactno = new System.Windows.Forms.TextBox();
            this.txtboxaddress = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.dgvcontactlist = new System.Windows.Forms.DataGridView();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtboxsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontactlist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcontactid
            // 
            this.lblcontactid.AutoSize = true;
            this.lblcontactid.BackColor = System.Drawing.Color.Transparent;
            this.lblcontactid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontactid.Location = new System.Drawing.Point(7, 62);
            this.lblcontactid.Name = "lblcontactid";
            this.lblcontactid.Size = new System.Drawing.Size(96, 20);
            this.lblcontactid.TabIndex = 0;
            this.lblcontactid.Text = "Contact ID";
            this.lblcontactid.Click += new System.EventHandler(this.lblcontactid_Click);
            // 
            // txtboxcontactid
            // 
            this.txtboxcontactid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxcontactid.Location = new System.Drawing.Point(137, 56);
            this.txtboxcontactid.Name = "txtboxcontactid";
            this.txtboxcontactid.ReadOnly = true;
            this.txtboxcontactid.Size = new System.Drawing.Size(206, 26);
            this.txtboxcontactid.TabIndex = 1;
            this.txtboxcontactid.TextChanged += new System.EventHandler(this.txtboxcontactid_TextChanged);
            // 
            // txtboxfirstname
            // 
            this.txtboxfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxfirstname.Location = new System.Drawing.Point(137, 105);
            this.txtboxfirstname.Name = "txtboxfirstname";
            this.txtboxfirstname.Size = new System.Drawing.Size(206, 26);
            this.txtboxfirstname.TabIndex = 2;
            this.txtboxfirstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.BackColor = System.Drawing.Color.Transparent;
            this.lblfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(7, 111);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(96, 20);
            this.lblfirstname.TabIndex = 3;
            this.lblfirstname.Text = "First Name";
            this.lblfirstname.Click += new System.EventHandler(this.lblfirstname_Click);
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(7, 166);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(95, 20);
            this.lbllastname.TabIndex = 4;
            this.lbllastname.Text = "Last Name";
            // 
            // lblcontactno
            // 
            this.lblcontactno.AutoSize = true;
            this.lblcontactno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontactno.Location = new System.Drawing.Point(7, 220);
            this.lblcontactno.Name = "lblcontactno";
            this.lblcontactno.Size = new System.Drawing.Size(109, 20);
            this.lblcontactno.TabIndex = 5;
            this.lblcontactno.Text = "Contact No. ";
            this.lblcontactno.Click += new System.EventHandler(this.lblcontactno_Click);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(7, 267);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(75, 20);
            this.lbladdress.TabIndex = 6;
            this.lbladdress.Text = "Address";
            // 
            // txtboxlastname
            // 
            this.txtboxlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxlastname.Location = new System.Drawing.Point(137, 166);
            this.txtboxlastname.Name = "txtboxlastname";
            this.txtboxlastname.Size = new System.Drawing.Size(206, 26);
            this.txtboxlastname.TabIndex = 7;
            // 
            // txtboxcontactno
            // 
            this.txtboxcontactno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxcontactno.Location = new System.Drawing.Point(137, 214);
            this.txtboxcontactno.Name = "txtboxcontactno";
            this.txtboxcontactno.Size = new System.Drawing.Size(206, 26);
            this.txtboxcontactno.TabIndex = 8;
            // 
            // txtboxaddress
            // 
            this.txtboxaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxaddress.Location = new System.Drawing.Point(137, 264);
            this.txtboxaddress.Multiline = true;
            this.txtboxaddress.Name = "txtboxaddress";
            this.txtboxaddress.Size = new System.Drawing.Size(206, 113);
            this.txtboxaddress.TabIndex = 9;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(7, 413);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(69, 20);
            this.lblgender.TabIndex = 10;
            this.lblgender.Text = "Gender";
            this.lblgender.Click += new System.EventHandler(this.lblgender_Click);
            // 
            // cmbgender
            // 
            this.cmbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmbgender.Location = new System.Drawing.Point(137, 405);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(206, 28);
            this.cmbgender.TabIndex = 11;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnadd.Location = new System.Drawing.Point(51, 464);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(119, 33);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdate.Location = new System.Drawing.Point(246, 465);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(109, 32);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.LightPink;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(454, 465);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(103, 32);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.LightSalmon;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclear.Location = new System.Drawing.Point(677, 464);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(98, 32);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // dgvcontactlist
            // 
            this.dgvcontactlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcontactlist.Location = new System.Drawing.Point(381, 105);
            this.dgvcontactlist.Name = "dgvcontactlist";
            this.dgvcontactlist.Size = new System.Drawing.Size(394, 328);
            this.dgvcontactlist.TabIndex = 16;
            this.dgvcontactlist.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcontactlist_RowHeaderMouseClick);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(390, 61);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(66, 20);
            this.lblsearch.TabIndex = 17;
            this.lblsearch.Text = "Search";
            this.lblsearch.Click += new System.EventHandler(this.lblsearch_Click);
            // 
            // txtboxsearch
            // 
            this.txtboxsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxsearch.Location = new System.Drawing.Point(482, 61);
            this.txtboxsearch.Name = "txtboxsearch";
            this.txtboxsearch.Size = new System.Drawing.Size(293, 26);
            this.txtboxsearch.TabIndex = 18;
            this.txtboxsearch.TextChanged += new System.EventHandler(this.txtboxsearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 513);
            this.Controls.Add(this.txtboxsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.dgvcontactlist);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.txtboxaddress);
            this.Controls.Add(this.txtboxcontactno);
            this.Controls.Add(this.txtboxlastname);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblcontactno);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.txtboxfirstname);
            this.Controls.Add(this.txtboxcontactid);
            this.Controls.Add(this.lblcontactid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontactlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcontactid;
        private System.Windows.Forms.TextBox txtboxcontactid;
        private System.Windows.Forms.TextBox txtboxfirstname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblcontactno;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtboxlastname;
        private System.Windows.Forms.TextBox txtboxcontactno;
        private System.Windows.Forms.TextBox txtboxaddress;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DataGridView dgvcontactlist;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtboxsearch;
    }
}

