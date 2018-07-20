﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ContestEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            City.Text = "";
            EmailAddress.Text = "";
            PostalCode.Text = "";
            Province.SelectedIndex = 0;
            Terms.Checked = false;
            CheckAnswer.Text = "";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string firstname = FirstName.Text;
            string lastname = LastName.Text;
            string streetaddress1 = StreetAddress1.Text;
            string streetaddress2 = StreetAddress2.Text;
            string city = City.Text;
            string email = EmailAddress.Text;
            string pc = PostalCode.Text;
            string province = Province.SelectedValue;
            bool terms = Terms.Checked;
            string answer = CheckAnswer.Text;

            Message.Text = firstname + " " + lastname;
        }
    }
}