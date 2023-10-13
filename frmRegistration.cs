using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Organization_Profile
{
    public partial class frmRegistration : MetroFramework.Forms.MetroForm
    {
        private string FullName;
        private int Age;
        private long ContactNum;
        private long StudentNo;
        public frmRegistration()
        {
            InitializeComponent();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            StudentInformationClass.SetFullName = Fullname(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
            StudentInformationClass.SetProgram = cbProgram.Text;

            StudentInformationClass.SetGender = cbGender.Text;
            StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
            StudentInformationClass.SetAge = age(txtAge.Text);
            StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyyMM-dd");
            frmConfirmation frm = new frmConfirmation();
            frm.ShowDialog();
        }
        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
           {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
           };
            for (int i = 0; i < 6; i++)
            {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
            }
        }
        public long StudentNumber(string studNum)
        {
            try { 
                  StudentNo = long.Parse(studNum);
                } 
            catch(FormatException a)
                {
                StudentNo = 0;
                MessageBox.Show("Student Number Invalid: " + a.Message);
                }
            catch(ArgumentException b)
                {
                MessageBox.Show(b.Message);
                }
            catch (OverflowException c)
                {
                MessageBox.Show(c.Message);
                }
            catch(IndexOutOfRangeException d)
                {
                MessageBox.Show(d.Message);
                }
            finally
            {

            }

            return StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                ContactNum = long.Parse(Contact);
            }

            return ContactNum;
        }

        public string Fullname(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return FullName;
        }

        public int age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                Age = Int32.Parse(age);
            }

            return Age;
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            StudentInformationClass.SetFullName = Fullname(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
            StudentInformationClass.SetProgram = cbProgram.Text;

            StudentInformationClass.SetGender = cbGender.Text;
            StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
            StudentInformationClass.SetAge = age(txtAge.Text);
            StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyyMM-dd");
            frmConfirmation frm = new frmConfirmation();
            frm.ShowDialog();
        }
    }
}
