﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LabAss3
{
    public partial class frmCustomerPerview : Form
    {
        public frmCustomerPerview()
        {
            InitializeComponent();
        }

        public void SetValues(String Name, String Country, String Gender, String Hobby, String Status)
        {
            lblName.Text = Name;
            lblCountry.Text = Country;
            lblGender.Text = Gender;
            lblHobby.Text = Hobby;
            lblStatus.Text = Status;
        }

    }
}
