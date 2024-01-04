using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calaculate_Age
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }
        struct stAgeUserInfo
        {
            public int Age;
            public int Month;
            public int Days;
        }
        stAgeUserInfo AgeUserInfo;
        DateTime UserDate;
    
        DateTime TimeNow()
        {
            DateTime now = DateTime.Now;
            return now;
        }


        private void frmMainForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UserDate= dtpChoseDate.Value;
            
        }
        int CalculateAge(int Year)
        {
            return TimeNow().Year - Year;
        }
        int CalculateMonths(int Month)
        {
            return TimeNow().Month - Month;
        }
        int CalculateDays(int Days)
        {
            return TimeNow().Day - Days;
        }
        int NumberOfDaysInAge()
        {
            return (AgeUserInfo.Age* 365) + (AgeUserInfo.Month* 30) + (AgeUserInfo.Days);
        }
        int NumberOfHoursInAge()
        {
            return NumberOfDaysInAge()*24;
        }
        int NumberOfMinutesInAge()
        {
            return NumberOfHoursInAge() * 60;
        }
        int NumberOfSecondsInAge()
        {
            return NumberOfMinutesInAge() * 60;
        }
        int NumberOfWeeksInAge()
        {
            return NumberOfDaysInAge() /7;
        }
        void ShowTheAge()
        {
            AgeUserInfo.Age = CalculateAge(UserDate.Year);
            AgeUserInfo.Month = CalculateMonths(UserDate.Month);
            AgeUserInfo.Days = CalculateDays(UserDate.Month);
            lblAge.Text= " عمرك هو " + AgeUserInfo.Age.ToString()+" سنه ";
            lblMonths.Text= " و " +AgeUserInfo.Month.ToString()+" اشهر ";
            lblDays.Text= " و " + AgeUserInfo.Days.ToString()+" يوم ";
            
        }
        void ShowDetelsCalculate()
        {
            lblNumberOfDaysInAge.Text = NumberOfDaysInAge().ToString();
            lblNumberOfHoursInAge.Text = NumberOfHoursInAge().ToString();
            lblNumberOfMinutesInAge.Text= NumberOfMinutesInAge().ToString();
            lblNumberOfSecondsInAge.Text=NumberOfSecondsInAge().ToString();
            lblNumberOfWeeksInAge.Text= NumberOfWeeksInAge().ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowTheAge();
            ShowDetelsCalculate();
        }
    }
}
