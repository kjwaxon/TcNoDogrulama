
namespace TcNo
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
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(180, 91);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(176, 20);
            this.txt_tc.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(180, 143);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(176, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(180, 200);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(176, 20);
            this.txt_surname.TabIndex = 2;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(180, 247);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(176, 20);
            this.txt_year.TabIndex = 3;
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(73, 98);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(68, 13);
            this.lbl_tc.TabIndex = 4;
            this.lbl_tc.Text = "TC Kimlik No";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(73, 143);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(25, 13);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "İsim";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(73, 200);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(42, 13);
            this.lbl_surname.TabIndex = 6;
            this.lbl_surname.Text = "Soyisim";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(73, 247);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(18, 13);
            this.lbl_year.TabIndex = 7;
            this.lbl_year.Text = "Yıl";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(180, 309);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(176, 23);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "Gönder";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 427);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_tc);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_tc);
            this.Name = "Form1";
            this.Text = "TC Kimlik Sorgulama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Button btn_send;
    }
}

