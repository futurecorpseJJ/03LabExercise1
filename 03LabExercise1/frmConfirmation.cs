﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03LabExercise1
{
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString();
            lblName.Text=StudentInformationClass.SetFullName.ToString();
            lblProgram.Text=StudentInformationClass.SetProgram.ToString();
            lblBirthday.Text=StudentInformationClass.SetBirthday.ToString();
            lblGender.Text=StudentInformationClass.SetGender.ToString();
            lblContactNo.Text=StudentInformationClass.SetContactNo.ToString();
            lblAge.Text=StudentInformationClass.SetAge.ToString();
        }
    }
}
