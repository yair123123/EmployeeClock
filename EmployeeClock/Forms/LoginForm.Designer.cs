namespace EmployeeClock
{
    partial class LoginForm
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
            button_change_password = new Button();
            button_enter = new Button();
            label_Password = new Label();
            label_ID = new Label();
            textBox_Id = new TextBox();
            textBox_Password = new TextBox();
            SuspendLayout();
            // 
            // button_change_password
            // 
            button_change_password.DialogResult = DialogResult.OK;
            button_change_password.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button_change_password.Location = new Point(121, 372);
            button_change_password.Name = "button_change_password";
            button_change_password.Size = new Size(211, 46);
            button_change_password.TabIndex = 0;
            button_change_password.Text = "החלפת סיסמא";
            button_change_password.UseVisualStyleBackColor = true;
            button_change_password.Click += button_change_password_Click;
            // 
            // button_enter
            // 
            button_enter.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button_enter.Location = new Point(121, 293);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(211, 46);
            button_enter.TabIndex = 1;
            button_enter.Text = "כניסה";
            button_enter.UseVisualStyleBackColor = true;
            button_enter.Click += button_enter_Click;
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label_Password.Location = new Point(178, 121);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(102, 37);
            label_Password.TabIndex = 2;
            label_Password.Text = "סיסמא";
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label_ID.Location = new Point(144, 31);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(159, 37);
            label_ID.TabIndex = 3;
            label_ID.Text = "תעודת זהות";
            // 
            // textBox_Id
            // 
            textBox_Id.Location = new Point(121, 71);
            textBox_Id.Multiline = true;
            textBox_Id.Name = "textBox_Id";
            textBox_Id.Size = new Size(211, 38);
            textBox_Id.TabIndex = 4;
            textBox_Id.TextChanged += textBox_Id_TextChanged;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(121, 161);
            textBox_Password.Multiline = true;
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(211, 39);
            textBox_Password.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 450);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Id);
            Controls.Add(label_ID);
            Controls.Add(label_Password);
            Controls.Add(button_enter);
            Controls.Add(button_change_password);
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_change_password;
        private Button button_enter;
        private Label label_Password;
        private Label label_ID;
        private TextBox textBox_Id;
        private TextBox textBox_Password;
    }
}