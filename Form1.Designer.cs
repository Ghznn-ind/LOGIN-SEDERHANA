namespace LoginSederhana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            fileSystemWatcher1 = new FileSystemWatcher();
            pictureBox1 = new PictureBox();
            formlogin = new Panel();
            btnlogin = new Button();
            txtpassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtusername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            formlogin.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(312, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // formlogin
            // 
            formlogin.BackColor = Color.FromArgb(224, 224, 224);
            formlogin.Controls.Add(btnlogin);
            formlogin.Controls.Add(txtpassword);
            formlogin.Controls.Add(label2);
            formlogin.Controls.Add(label1);
            formlogin.Controls.Add(txtusername);
            formlogin.Location = new Point(146, 247);
            formlogin.Name = "formlogin";
            formlogin.Size = new Size(488, 321);
            formlogin.TabIndex = 1;
            // 
            // btnlogin
            // 
            btnlogin.AccessibleName = "btn.login";
            btnlogin.BackColor = Color.Yellow;
            btnlogin.Font = new Font("Clarendon Blk BT", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(318, 254);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(148, 46);
            btnlogin.TabIndex = 4;
            btnlogin.Tag = "";
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtpassword
            // 
            txtpassword.AccessibleName = "txt.password";
            txtpassword.Location = new Point(49, 188);
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Masukkan Password";
            txtpassword.Size = new Size(391, 31);
            txtpassword.TabIndex = 3;
            txtpassword.Tag = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 147);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(49, 40);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // txtusername
            // 
            txtusername.AccessibleName = "txt.username";
            txtusername.Location = new Point(49, 78);
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Masukkan Username";
            txtusername.Size = new Size(391, 31);
            txtusername.TabIndex = 0;
            txtusername.Tag = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 599);
            Controls.Add(formlogin);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Sederhana";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            formlogin.ResumeLayout(false);
            formlogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private PictureBox pictureBox1;
        private Panel formlogin;
        private TextBox txtpassword;
        private Label label2;
        private Label label1;
        private TextBox txtusername;
        private Button btnlogin;
    }
}
