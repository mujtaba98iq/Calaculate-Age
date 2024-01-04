namespace Calaculate_Age
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpChoseDate = new System.Windows.Forms.DateTimePicker();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblMonths = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNumberOfMinutesInAge = new System.Windows.Forms.Label();
            this.lblNumberOfHoursInAge = new System.Windows.Forms.Label();
            this.lblNumberOfDaysInAge = new System.Windows.Forms.Label();
            this.lblNumberOfWeeksInAge = new System.Windows.Forms.Label();
            this.lblNumberOfSecondsInAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Calaculate_Age.Properties.Resources._58079;
            this.pictureBox1.Location = new System.Drawing.Point(93, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(75, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "ضع تاريخ ميلادك";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(108, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "احسب";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpChoseDate
            // 
            this.dtpChoseDate.CustomFormat = "";
            this.dtpChoseDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChoseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpChoseDate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpChoseDate.Location = new System.Drawing.Point(22, 110);
            this.dtpChoseDate.Name = "dtpChoseDate";
            this.dtpChoseDate.Size = new System.Drawing.Size(265, 26);
            this.dtpChoseDate.TabIndex = 4;
            this.dtpChoseDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Red;
            this.lblAge.Location = new System.Drawing.Point(120, 204);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(19, 19);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "0";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMonths.Location = new System.Drawing.Point(120, 235);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(19, 19);
            this.lblMonths.TabIndex = 6;
            this.lblMonths.Text = "0";
            this.lblMonths.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.ForeColor = System.Drawing.Color.Red;
            this.lblDays.Location = new System.Drawing.Point(120, 267);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(19, 19);
            this.lblDays.TabIndex = 7;
            this.lblDays.Text = "0";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(248, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "عدد الايام";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(232, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "عدد الساعات";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(241, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "عدد الدقائق";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(241, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "عدد الثواني";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(236, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "عدد الاسابيع";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumberOfMinutesInAge
            // 
            this.lblNumberOfMinutesInAge.AutoSize = true;
            this.lblNumberOfMinutesInAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfMinutesInAge.ForeColor = System.Drawing.Color.Red;
            this.lblNumberOfMinutesInAge.Location = new System.Drawing.Point(136, 386);
            this.lblNumberOfMinutesInAge.Name = "lblNumberOfMinutesInAge";
            this.lblNumberOfMinutesInAge.Size = new System.Drawing.Size(19, 19);
            this.lblNumberOfMinutesInAge.TabIndex = 15;
            this.lblNumberOfMinutesInAge.Text = "0";
            this.lblNumberOfMinutesInAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumberOfHoursInAge
            // 
            this.lblNumberOfHoursInAge.AutoSize = true;
            this.lblNumberOfHoursInAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfHoursInAge.ForeColor = System.Drawing.Color.Red;
            this.lblNumberOfHoursInAge.Location = new System.Drawing.Point(136, 353);
            this.lblNumberOfHoursInAge.Name = "lblNumberOfHoursInAge";
            this.lblNumberOfHoursInAge.Size = new System.Drawing.Size(19, 19);
            this.lblNumberOfHoursInAge.TabIndex = 14;
            this.lblNumberOfHoursInAge.Text = "0";
            this.lblNumberOfHoursInAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumberOfDaysInAge
            // 
            this.lblNumberOfDaysInAge.AutoSize = true;
            this.lblNumberOfDaysInAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDaysInAge.ForeColor = System.Drawing.Color.Red;
            this.lblNumberOfDaysInAge.Location = new System.Drawing.Point(136, 322);
            this.lblNumberOfDaysInAge.Name = "lblNumberOfDaysInAge";
            this.lblNumberOfDaysInAge.Size = new System.Drawing.Size(19, 19);
            this.lblNumberOfDaysInAge.TabIndex = 13;
            this.lblNumberOfDaysInAge.Text = "0";
            this.lblNumberOfDaysInAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumberOfWeeksInAge
            // 
            this.lblNumberOfWeeksInAge.AutoSize = true;
            this.lblNumberOfWeeksInAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfWeeksInAge.ForeColor = System.Drawing.Color.Red;
            this.lblNumberOfWeeksInAge.Location = new System.Drawing.Point(136, 458);
            this.lblNumberOfWeeksInAge.Name = "lblNumberOfWeeksInAge";
            this.lblNumberOfWeeksInAge.Size = new System.Drawing.Size(19, 19);
            this.lblNumberOfWeeksInAge.TabIndex = 17;
            this.lblNumberOfWeeksInAge.Text = "0";
            this.lblNumberOfWeeksInAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumberOfSecondsInAge
            // 
            this.lblNumberOfSecondsInAge.AutoSize = true;
            this.lblNumberOfSecondsInAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfSecondsInAge.ForeColor = System.Drawing.Color.Red;
            this.lblNumberOfSecondsInAge.Location = new System.Drawing.Point(136, 422);
            this.lblNumberOfSecondsInAge.Name = "lblNumberOfSecondsInAge";
            this.lblNumberOfSecondsInAge.Size = new System.Drawing.Size(19, 19);
            this.lblNumberOfSecondsInAge.TabIndex = 16;
            this.lblNumberOfSecondsInAge.Text = "0";
            this.lblNumberOfSecondsInAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(313, 503);
            this.Controls.Add(this.lblNumberOfWeeksInAge);
            this.Controls.Add(this.lblNumberOfSecondsInAge);
            this.Controls.Add(this.lblNumberOfMinutesInAge);
            this.Controls.Add(this.lblNumberOfHoursInAge);
            this.Controls.Add(this.lblNumberOfDaysInAge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblMonths);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.dtpChoseDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainForm";
            this.Text = "frmMainForm";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpChoseDate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNumberOfMinutesInAge;
        private System.Windows.Forms.Label lblNumberOfHoursInAge;
        private System.Windows.Forms.Label lblNumberOfDaysInAge;
        private System.Windows.Forms.Label lblNumberOfWeeksInAge;
        private System.Windows.Forms.Label lblNumberOfSecondsInAge;
    }
}