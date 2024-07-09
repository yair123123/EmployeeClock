namespace EmployeeClock
{
    partial class PasswordChangeForm
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
            button_confirm_new_password = new Button();
            label_confirm_new_form = new Label();
            label_new_password = new Label();
            label_old_password = new Label();
            label_Id = new Label();
            linkLabel_cancel = new LinkLabel();
            textBox_ID = new TextBox();
            textBox_old_password = new TextBox();
            textBox_new_password = new TextBox();
            textBox_confirm_new_form = new TextBox();
            SuspendLayout();
            // 
            // button_confirm_new_password
            // 
            button_confirm_new_password.BackColor = SystemColors.Info;
            button_confirm_new_password.Font = new Font("Segoe UI", 11F);
            button_confirm_new_password.Location = new Point(25, 367);
            button_confirm_new_password.Name = "button_confirm_new_password";
            button_confirm_new_password.Size = new Size(218, 40);
            button_confirm_new_password.TabIndex = 0;
            button_confirm_new_password.Text = "ביצוע החלפת סיסמא";
            button_confirm_new_password.UseVisualStyleBackColor = false;
            // 
            // label_confirm_new_form
            // 
            label_confirm_new_form.AutoSize = true;
            label_confirm_new_form.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label_confirm_new_form.Location = new Point(254, 306);
            label_confirm_new_form.Name = "label_confirm_new_form";
            label_confirm_new_form.Size = new Size(264, 37);
            label_confirm_new_form.TabIndex = 1;
            label_confirm_new_form.Text = "אישור סיסמא חדשה";
            label_confirm_new_form.TextAlign = ContentAlignment.TopCenter;

            // 
            // label_new_password
            // 
            label_new_password.AutoSize = true;
            label_new_password.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label_new_password.Location = new Point(335, 224);
            label_new_password.Name = "label_new_password";
            label_new_password.Size = new Size(183, 37);
            label_new_password.TabIndex = 2;
            label_new_password.Text = "סיסמא חדשה";
            label_new_password.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_old_password
            // 
            label_old_password.AutoSize = true;
            label_old_password.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label_old_password.Location = new Point(348, 139);
            label_old_password.Name = "label_old_password";
            label_old_password.Size = new Size(170, 37);
            label_old_password.TabIndex = 3;
            label_old_password.Text = "סיסמא ישנה";
            label_old_password.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_Id
            // 
            label_Id.AutoSize = true;
            label_Id.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label_Id.Location = new Point(359, 52);
            label_Id.Name = "label_Id";
            label_Id.Size = new Size(159, 37);
            label_Id.TabIndex = 4;
            label_Id.Text = "תעודת זהות";
            label_Id.TextAlign = ContentAlignment.TopCenter;
            // 
            // linkLabel_cancel
            // 
            linkLabel_cancel.AutoSize = true;
            linkLabel_cancel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            linkLabel_cancel.Location = new Point(411, 379);
            linkLabel_cancel.Name = "linkLabel_cancel";
            linkLabel_cancel.Size = new Size(62, 28);
            linkLabel_cancel.TabIndex = 5;
            linkLabel_cancel.TabStop = true;
            linkLabel_cancel.Text = "ביטול";
            linkLabel_cancel.LinkClicked += linkLabel_cancel_LinkClicked;
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(25, 49);
            textBox_ID.MinimumSize = new Size(0, 40);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(218, 40);
            textBox_ID.TabIndex = 6;
            // 
            // textBox_old_password
            // 
            textBox_old_password.Location = new Point(25, 136);
            textBox_old_password.MinimumSize = new Size(0, 40);
            textBox_old_password.Name = "textBox_old_password";
            textBox_old_password.Size = new Size(218, 40);
            textBox_old_password.TabIndex = 7;
            // 
            // textBox_new_password
            // 
            textBox_new_password.BackColor = SystemColors.Info;
            textBox_new_password.Location = new Point(25, 221);
            textBox_new_password.MinimumSize = new Size(0, 40);
            textBox_new_password.Name = "textBox_new_password";
            textBox_new_password.Size = new Size(218, 40);
            textBox_new_password.TabIndex = 8;
            // 
            // textBox_confirm_new_form
            // 
            textBox_confirm_new_form.BackColor = SystemColors.Info;
            textBox_confirm_new_form.Location = new Point(25, 303);
            textBox_confirm_new_form.MinimumSize = new Size(0, 40);
            textBox_confirm_new_form.Name = "textBox_confirm_new_form";
            textBox_confirm_new_form.Size = new Size(218, 40);
            textBox_confirm_new_form.TabIndex = 9;
            // 
            // PasswordChangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 450);
            Controls.Add(textBox_confirm_new_form);
            Controls.Add(textBox_new_password);
            Controls.Add(textBox_old_password);
            Controls.Add(textBox_ID);
            Controls.Add(linkLabel_cancel);
            Controls.Add(label_Id);
            Controls.Add(label_old_password);
            Controls.Add(label_new_password);
            Controls.Add(label_confirm_new_form);
            Controls.Add(button_confirm_new_password);
            Name = "PasswordChangeForm";
            Text = "PasswordChangeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_confirm_new_password;
        private Label label_confirm_new_form;
        private Label label_new_password;
        private Label label_old_password;
        private Label label_Id;
        private LinkLabel linkLabel_cancel;
        private TextBox textBox_ID;
        private TextBox textBox_old_password;
        private TextBox textBox_new_password;
        private TextBox textBox_confirm_new_form;
    }
}