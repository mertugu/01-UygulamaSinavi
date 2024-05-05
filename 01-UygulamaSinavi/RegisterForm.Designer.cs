namespace _01_UygulamaSinavi
{
    partial class RegisterForm
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtNewUsername = new TextBox();
            txtNewPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtRepeatPassword = new TextBox();
            label7 = new Label();
            btnNewRegister = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnNewRegister);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtRepeatPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNewPassword);
            groupBox1.Controls.Add(txtNewUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(85, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 357);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 1;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(33, 56);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(33, 79);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(195, 27);
            txtNewUsername.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(33, 157);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(195, 27);
            txtNewPassword.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(33, 134);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(113, 56);
            label4.Name = "label4";
            label4.Size = new Size(16, 20);
            label4.TabIndex = 4;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(113, 134);
            label5.Name = "label5";
            label5.Size = new Size(16, 20);
            label5.TabIndex = 5;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(33, 212);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 6;
            label6.Text = "Repeat Password:";
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Location = new Point(33, 235);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.Size = new Size(195, 27);
            txtRepeatPassword.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(162, 212);
            label7.Name = "label7";
            label7.Size = new Size(16, 20);
            label7.TabIndex = 8;
            label7.Text = "*";
            // 
            // btnNewRegister
            // 
            btnNewRegister.BackColor = Color.DarkCyan;
            btnNewRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnNewRegister.ForeColor = Color.Transparent;
            btnNewRegister.Location = new Point(35, 283);
            btnNewRegister.Name = "btnNewRegister";
            btnNewRegister.Size = new Size(94, 38);
            btnNewRegister.TabIndex = 9;
            btnNewRegister.Text = "Register";
            btnNewRegister.UseVisualStyleBackColor = false;
            btnNewRegister.Click += btnNewRegister_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(445, 615);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNewPassword;
        private TextBox txtNewUsername;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox txtRepeatPassword;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnNewRegister;
    }
}