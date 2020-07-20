﻿using Generate_Logins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unique_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nbox_lengh_of_password.Value = 12;
        }

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var message = "This application is written by wajeht. \n";
                message += "\n https://www.github.com/wajeht";

            MessageBox.Show(message);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_copy_username_Click(object sender, EventArgs e)
        {

        }

        private void btn_copy_password_Click(object sender, EventArgs e)
        {

        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Random random = new Random();

            List<string> usernames = new List<string>();
            List<string> passwords = new List<string>();


            var generatedUsername = "";
            var generatedPassword = "";
            var lengthOfPassword = nbox_lengh_of_password.Value;
            var randomPassword = "";



            // usernames control flow below
            if (cbox_adjective.Checked)
            {
                usernames.Add(login.RandomAdjective());
            }

            if (cbox_animal.Checked)
            {
                usernames.Add(login.RandomAnimal());
            }

            if (cbox_noun.Checked)
            {
                usernames.Add(login.RandomNoun());
            }

            if (cbox_verb.Checked)
            {
                usernames.Add(login.RandomVerb());
            }

            foreach (string username in usernames)
            {
                generatedUsername += username;
            }

            tbox_username.Text = generatedUsername.ToString();




            // password contorl flow below
            if (cbox_uppercase.Checked)
            {
                passwords.Add(login.upercase);
            }

            if (cbox_lowercase.Checked)
            {
                passwords.Add(login.lowercase);
            }

            if (cbox_number.Checked)
            {
                passwords.Add(login.number);
            }

            if (cbox_special.Checked)
            {
                passwords.Add(login.special);
            }

            foreach (string password in passwords)
            {
                generatedPassword += password;
            }

            if (string.IsNullOrEmpty(generatedPassword))
            {
                MessageBox.Show("na");
            } else
            {
                for (var i = 0; i < lengthOfPassword; i++)
                {
                    randomPassword += generatedPassword[random.Next(generatedPassword.Length)];
                }

                tbox_password.Text = randomPassword.ToString();
            }







        }
    }
}
