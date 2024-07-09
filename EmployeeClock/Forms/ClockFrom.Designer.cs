namespace EmployeeClock
{
    partial class ClockFrom
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
            label_date_exit_var = new Label();
            label_date_exit = new Label();
            label_date_enter_var = new Label();
            label_date_enter = new Label();
            label_id_ver = new Label();
            label_ID = new Label();
            linkLabel_cancel = new LinkLabel();
            button_exit = new Button();
            button_enter = new Button();
            SuspendLayout();
            // 
            // label_date_exit_var
            // 
            label_date_exit_var.AutoSize = true;
            label_date_exit_var.BackColor = SystemColors.ButtonHighlight;
            label_date_exit_var.Cursor = Cursors.AppStarting;
            label_date_exit_var.Font = new Font("Segoe UI", 15F);
            label_date_exit_var.ForeColor = Color.MediumAquamarine;
            label_date_exit_var.Location = new Point(180, 235);
            label_date_exit_var.Name = "label_date_exit_var";
            label_date_exit_var.Size = new Size(65, 28);
            label_date_exit_var.TabIndex = 0;
            label_date_exit_var.Text = "label1";
            // 
            // label_date_exit
            // 
            label_date_exit.AutoSize = true;
            label_date_exit.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            label_date_exit.Location = new Point(95, 197);
            label_date_exit.Name = "label_date_exit";
            label_date_exit.Size = new Size(191, 28);
            label_date_exit.TabIndex = 1;
            label_date_exit.Text = "תאריך יציאה אחרון";
            // 
            // label_date_enter_var
            // 
            label_date_enter_var.AutoSize = true;
            label_date_enter_var.BackColor = SystemColors.ButtonHighlight;
            label_date_enter_var.Cursor = Cursors.AppStarting;
            label_date_enter_var.Font = new Font("Segoe UI", 15F);
            label_date_enter_var.ForeColor = Color.MediumAquamarine;
            label_date_enter_var.Location = new Point(180, 154);
            label_date_enter_var.Name = "label_date_enter_var";
            label_date_enter_var.Size = new Size(65, 28);
            label_date_enter_var.TabIndex = 2;
            label_date_enter_var.Text = "label3";
            // 
            // label_date_enter
            // 
            label_date_enter.AutoSize = true;
            label_date_enter.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            label_date_enter.Location = new Point(95, 99);
            label_date_enter.Name = "label_date_enter";
            label_date_enter.Size = new Size(192, 28);
            label_date_enter.TabIndex = 3;
            label_date_enter.Text = "תאריך כניסה אחרון";
            // 
            // label_id_ver
            // 
            label_id_ver.AutoSize = true;
            label_id_ver.BackColor = SystemColors.ButtonHighlight;
            label_id_ver.Cursor = Cursors.AppStarting;
            label_id_ver.Font = new Font("Segoe UI", 15F);
            label_id_ver.ForeColor = Color.MediumAquamarine;
            label_id_ver.Location = new Point(243, 40);
            label_id_ver.Name = "label_id_ver";
            label_id_ver.Size = new Size(65, 28);
            label_id_ver.TabIndex = 4;
            label_id_ver.Text = "label5";
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label_ID.Location = new Point(95, 40);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(121, 28);
            label_ID.TabIndex = 5;
            label_ID.Text = "זהות העובד:";
            // 
            // linkLabel_cancel
            // 
            linkLabel_cancel.AutoSize = true;
            linkLabel_cancel.Font = new Font("Segoe UI", 15F);
            linkLabel_cancel.Location = new Point(187, 279);
            linkLabel_cancel.Name = "linkLabel_cancel";
            linkLabel_cancel.Size = new Size(58, 28);
            linkLabel_cancel.TabIndex = 6;
            linkLabel_cancel.TabStop = true;
            linkLabel_cancel.Text = "ביטול";
            linkLabel_cancel.LinkClicked += linkLabel_cancel_LinkClicked;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.OrangeRed;
            button_exit.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button_exit.Location = new Point(48, 321);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(100, 100);
            button_exit.TabIndex = 7;
            button_exit.Text = "יציאה";
            button_exit.UseVisualStyleBackColor = false;
            // 
            // button_enter
            // 
            button_enter.BackColor = Color.SpringGreen;
            button_enter.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button_enter.Location = new Point(290, 321);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(100, 100);
            button_enter.TabIndex = 8;
            button_enter.Text = "כניסה";
            button_enter.UseVisualStyleBackColor = false;
            // 
            // ClockFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            Controls.Add(button_enter);
            Controls.Add(button_exit);
            Controls.Add(linkLabel_cancel);
            Controls.Add(label_ID);
            Controls.Add(label_id_ver);
            Controls.Add(label_date_enter);
            Controls.Add(label_date_enter_var);
            Controls.Add(label_date_exit);
            Controls.Add(label_date_exit_var);
            Name = "ClockFrom";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "ClockFrom";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_date_exit_var;
        private Label label_date_exit;
        private Label label_date_enter_var;
        private Label label_date_enter;
        private Label label_id_ver;
        private Label label_ID;
        private LinkLabel linkLabel_cancel;
        private Button button_exit;
        private Button button_enter;
    }
}