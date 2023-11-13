namespace GPBookingSystem
{
    partial class MainPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            RescheduleButton = new Button();
            BookingDatePicker = new DateTimePicker();
            BookingTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSlateBlue;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(33, 20);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 0;
            label1.Text = "Bookings";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.GrayText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(144, 32);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(309, 195);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(18, 205);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(111, 22);
            button1.TabIndex = 2;
            button1.Text = "View all doctors";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(18, 163);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(111, 38);
            button2.TabIndex = 3;
            button2.Text = "Add a new booking";
            button2.UseVisualStyleBackColor = true;
            // 
            // RescheduleButton
            // 
            RescheduleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RescheduleButton.Location = new Point(18, 137);
            RescheduleButton.Margin = new Padding(3, 2, 3, 2);
            RescheduleButton.Name = "RescheduleButton";
            RescheduleButton.Size = new Size(111, 22);
            RescheduleButton.TabIndex = 4;
            RescheduleButton.Text = "Reschedule";
            RescheduleButton.UseVisualStyleBackColor = true;
            RescheduleButton.Click += RescheduleButton_Click;
            // 
            // BookingDatePicker
            // 
            BookingDatePicker.Location = new Point(144, 3);
            BookingDatePicker.Name = "BookingDatePicker";
            BookingDatePicker.Size = new Size(165, 23);
            BookingDatePicker.TabIndex = 5;
            // 
            // BookingTimePicker
            // 
            BookingTimePicker.Format = DateTimePickerFormat.Time;
            BookingTimePicker.Location = new Point(315, 3);
            BookingTimePicker.Name = "BookingTimePicker";
            BookingTimePicker.ShowUpDown = true;
            BookingTimePicker.Size = new Size(128, 23);
            BookingTimePicker.TabIndex = 6;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            Controls.Add(BookingTimePicker);
            Controls.Add(BookingDatePicker);
            Controls.Add(RescheduleButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainPage";
            Size = new Size(473, 244);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button RescheduleButton;
        private DateTimePicker BookingDatePicker;
        private DateTimePicker BookingTimePicker;
    }
}
