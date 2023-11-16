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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewDoctorsButton = new System.Windows.Forms.Button();
            this.AddNewBookingButton = new System.Windows.Forms.Button();
            this.RescheduleButton = new System.Windows.Forms.Button();
            this.BookingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BookingTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ViewBookingsButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.locationBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bookings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(218, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(560, 305);
            this.dataGridView1.TabIndex = 1;
            // 
            // ViewDoctorsButton
            // 
            this.ViewDoctorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewDoctorsButton.Location = new System.Drawing.Point(26, 418);
            this.ViewDoctorsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ViewDoctorsButton.Name = "ViewDoctorsButton";
            this.ViewDoctorsButton.Size = new System.Drawing.Size(159, 37);
            this.ViewDoctorsButton.TabIndex = 2;
            this.ViewDoctorsButton.Text = "View all doctors";
            this.ViewDoctorsButton.UseVisualStyleBackColor = true;
            this.ViewDoctorsButton.Click += new System.EventHandler(this.ViewDoctorsButton_Click);
            // 
            // AddNewBookingButton
            // 
            this.AddNewBookingButton.Location = new System.Drawing.Point(4, 104);
            this.AddNewBookingButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddNewBookingButton.Name = "AddNewBookingButton";
            this.AddNewBookingButton.Size = new System.Drawing.Size(163, 37);
            this.AddNewBookingButton.TabIndex = 3;
            this.AddNewBookingButton.Text = "Add new booking";
            this.AddNewBookingButton.UseVisualStyleBackColor = true;
            this.AddNewBookingButton.Click += new System.EventHandler(this.AddNewBookingButton_Click);
            // 
            // RescheduleButton
            // 
            this.RescheduleButton.Location = new System.Drawing.Point(4, 69);
            this.RescheduleButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RescheduleButton.Name = "RescheduleButton";
            this.RescheduleButton.Size = new System.Drawing.Size(250, 37);
            this.RescheduleButton.TabIndex = 4;
            this.RescheduleButton.Text = "Reschedule Selected Booking";
            this.RescheduleButton.UseVisualStyleBackColor = true;
            this.RescheduleButton.Click += new System.EventHandler(this.RescheduleButton_Click);
            // 
            // BookingDatePicker
            // 
            this.BookingDatePicker.Location = new System.Drawing.Point(260, 69);
            this.BookingDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BookingDatePicker.Name = "BookingDatePicker";
            this.BookingDatePicker.Size = new System.Drawing.Size(234, 31);
            this.BookingDatePicker.TabIndex = 5;
            // 
            // BookingTimePicker
            // 
            this.BookingTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BookingTimePicker.Location = new System.Drawing.Point(502, 69);
            this.BookingTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BookingTimePicker.Name = "BookingTimePicker";
            this.BookingTimePicker.ShowUpDown = true;
            this.BookingTimePicker.Size = new System.Drawing.Size(181, 31);
            this.BookingTimePicker.TabIndex = 6;
            // 
            // ViewBookingsButton
            // 
            this.ViewBookingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewBookingsButton.Location = new System.Drawing.Point(26, 375);
            this.ViewBookingsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ViewBookingsButton.Name = "ViewBookingsButton";
            this.ViewBookingsButton.Size = new System.Drawing.Size(159, 37);
            this.ViewBookingsButton.TabIndex = 7;
            this.ViewBookingsButton.Text = "View all bookings";
            this.ViewBookingsButton.UseVisualStyleBackColor = true;
            this.ViewBookingsButton.Click += new System.EventHandler(this.ViewBookingsButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(253, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Doctor";
            // 
            // locationBox
            // 
            this.locationBox.FormattingEnabled = true;
            this.locationBox.Location = new System.Drawing.Point(451, 107);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(159, 33);
            this.locationBox.TabIndex = 10;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ViewBookingsButton);
            this.Controls.Add(this.BookingTimePicker);
            this.Controls.Add(this.BookingDatePicker);
            this.Controls.Add(this.RescheduleButton);
            this.Controls.Add(this.AddNewBookingButton);
            this.Controls.Add(this.ViewDoctorsButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(807, 483);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button ViewDoctorsButton;
        private Button AddNewBookingButton;
        private Button RescheduleButton;
        private DateTimePicker BookingDatePicker;
        private DateTimePicker BookingTimePicker;
        private Button ViewBookingsButton;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox locationBox;
    }
}
