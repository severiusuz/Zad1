namespace Zad1
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
            this.components = new System.ComponentModel.Container();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DisplayBox = new System.Windows.Forms.TextBox();
            this.setAlarm = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.alarmBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(197, 226);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.OnCloseBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_TickAsync);
            // 
            // DisplayBox
            // 
            this.DisplayBox.Location = new System.Drawing.Point(13, 13);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.ReadOnly = true;
            this.DisplayBox.Size = new System.Drawing.Size(259, 20);
            this.DisplayBox.TabIndex = 1;
            // 
            // setAlarm
            // 
            this.setAlarm.Location = new System.Drawing.Point(107, 83);
            this.setAlarm.Name = "setAlarm";
            this.setAlarm.Size = new System.Drawing.Size(75, 23);
            this.setAlarm.TabIndex = 6;
            this.setAlarm.Text = "Set Alarm";
            this.setAlarm.UseVisualStyleBackColor = true;
            this.setAlarm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.setAlarm_MouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd - HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(49, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // alarmBox
            // 
            this.alarmBox.BackColor = System.Drawing.SystemColors.Window;
            this.alarmBox.Location = new System.Drawing.Point(13, 131);
            this.alarmBox.Name = "alarmBox";
            this.alarmBox.ShortcutsEnabled = false;
            this.alarmBox.Size = new System.Drawing.Size(259, 20);
            this.alarmBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.alarmBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.setAlarm);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.CloseBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox DisplayBox;
        private System.Windows.Forms.Button setAlarm;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox alarmBox;
    }
}

