﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03LabExercise1
{
    public partial class frmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;


        public frmRegistration()
        {
            InitializeComponent();
        }
        public long StudentNumber(string studNum)
        {
            _StudentNo = long.Parse(studNum);
            return _StudentNo;
        }
        public long ContactNo(string Contact)
        {
            try
            {
                if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
                {
                    _ContactNo = long.Parse(Contact);
                }
                else
                {
                    throw new IndexOutOfRangeException("index out of range");
                }
            }
            catch (Exception e)
            {
                Console.Write(e);

            }
            finally
            {
                Console.WriteLine("input 11 index or ");
            }
            return _ContactNo;

        }
        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            try
            {
                if (Regex.IsMatch(LastName, @"^[a-zA-Z+$]") || Regex.IsMatch(FirstName, @"^[a-zA-Z+$]") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z+$]"))
                {
                    _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
                }
                else
                {
                    throw new ArgumentNullException("lastname, firstname, or middleinitial textbox is empty");
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            finally
            {
                Console.WriteLine("Do no leave the lastname, firstname, and middleinitial textbox empty");

            }
            return _FullName;
        }
        public int Age(string age)
        {
            try
            {
                if (!Regex.IsMatch(age, @"^[0-9]{10,11}$"))
                {
                    _Age = Int32.Parse(age);
                }
                else
                {
                    throw new OverflowException("Invalid Input");

                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            finally
            {
                Console.WriteLine("Enter Integer Only");
            }
            return _Age;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformationClass.SetStudentNo = (int)StudentNumber(txtStudentNo.Text);
            StudentInformationClass.SetProgram = cbPrograms.Text;
            StudentInformationClass.SetGender = cbGender.Text;
            StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
            StudentInformationClass.SetAge = Age(txtAge.Text);
            StudentInformationClass.SetBirthday = dateTimePickerBirthday.Value.ToString("yyyy-MM-dd");

            frmConfirmation frm = new frmConfirmation();
            frm.ShowDialog();
        }


        private void frmRegistration_Load_1(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                 "BS Computer Science",
                  "BS Information System",
                   "BS in Accountancy",
                    "BS in Hospitality Management",
                     "BS in Tourism Management",
            };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
            string[] ListOfGender = new string[]
            {
                "Male",
                "Female"
            };
            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(ListOfGender[i].ToString());
            }
        }
    }
} 
