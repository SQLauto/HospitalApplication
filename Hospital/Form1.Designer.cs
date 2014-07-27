namespace Hospital
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
            this.button1 = new System.Windows.Forms.Button();
            this.d_nametext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.lnametext = new System.Windows.Forms.TextBox();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.addresstext = new System.Windows.Forms.TextBox();
            this.specialitytext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hospitaltext = new System.Windows.Forms.TextBox();
            this.locationtext = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.insertbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deletebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fetch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // d_nametext
            // 
            this.d_nametext.Location = new System.Drawing.Point(135, 13);
            this.d_nametext.Name = "d_nametext";
            this.d_nametext.Size = new System.Drawing.Size(92, 20);
            this.d_nametext.TabIndex = 1;
            this.d_nametext.TextChanged += new System.EventHandler(this.d_nametext_TextChanged);
            this.d_nametext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.d_nametext_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "LastName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doctor.id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Speciality:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 9;
            // 
            // idtext
            // 
            this.idtext.Location = new System.Drawing.Point(117, 58);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(100, 20);
            this.idtext.TabIndex = 10;
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(117, 84);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(100, 20);
            this.nametext.TabIndex = 11;
            // 
            // lnametext
            // 
            this.lnametext.Location = new System.Drawing.Point(117, 110);
            this.lnametext.Name = "lnametext";
            this.lnametext.Size = new System.Drawing.Size(100, 20);
            this.lnametext.TabIndex = 12;
            // 
            // phonetext
            // 
            this.phonetext.Location = new System.Drawing.Point(117, 140);
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(100, 20);
            this.phonetext.TabIndex = 13;
            // 
            // addresstext
            // 
            this.addresstext.Location = new System.Drawing.Point(117, 167);
            this.addresstext.Name = "addresstext";
            this.addresstext.Size = new System.Drawing.Size(100, 20);
            this.addresstext.TabIndex = 14;
            // 
            // specialitytext
            // 
            this.specialitytext.Location = new System.Drawing.Point(117, 194);
            this.specialitytext.Name = "specialitytext";
            this.specialitytext.Size = new System.Drawing.Size(100, 20);
            this.specialitytext.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hospital:";
            // 
            // hospitaltext
            // 
            this.hospitaltext.Location = new System.Drawing.Point(117, 220);
            this.hospitaltext.Name = "hospitaltext";
            this.hospitaltext.Size = new System.Drawing.Size(100, 20);
            this.hospitaltext.TabIndex = 17;
            // 
            // locationtext
            // 
            this.locationtext.Location = new System.Drawing.Point(117, 246);
            this.locationtext.Name = "locationtext";
            this.locationtext.Size = new System.Drawing.Size(100, 20);
            this.locationtext.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Location:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(342, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(54, 69);
            this.listBox1.TabIndex = 20;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // insertbutton
            // 
            this.insertbutton.Location = new System.Drawing.Point(314, 12);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(75, 23);
            this.insertbutton.TabIndex = 22;
            this.insertbutton.Text = "Insert";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "address",
            "b_date",
            "e_area",
            "h_location",
            "h_name",
            "id",
            "image",
            "lname",
            "name",
            "salary",
            "tel"});
            this.comboBox1.Location = new System.Drawing.Point(28, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(223, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(396, 11);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 25;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 336);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.locationtext);
            this.Controls.Add(this.hospitaltext);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.specialitytext);
            this.Controls.Add(this.addresstext);
            this.Controls.Add(this.phonetext);
            this.Controls.Add(this.lnametext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.d_nametext);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox d_nametext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox lnametext;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.TextBox addresstext;
        private System.Windows.Forms.TextBox specialitytext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox hospitaltext;
        private System.Windows.Forms.TextBox locationtext;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button deletebutton;
    }
}

