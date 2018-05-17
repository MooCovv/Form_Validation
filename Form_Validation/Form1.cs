using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool LetterCheck (string input)
        {
            bool isValue = true;

            foreach (char ch in input)
            {
                if (!char.IsLetter(ch))
                {
                    isValue = false;
                }
            }
            return isValue;
        }

        private bool PunctuationCheck(string input)
        {
            bool isValue = true;

            foreach (char ch in input)
            {
                if (char.IsPunctuation(ch))
                {
                    isValue = false;
                }
            }
            return isValue;
        }

        private bool DigitCheck(string input)
        {
            bool isValue = true;

            foreach (char ch in input)
            {
                if (!char.IsDigit(ch))
                {
                    isValue = false;
                }
            }
            return isValue;
        }

        private int LengthCheck(string input)
        {
            int isValue = 0;

            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    isValue++;
                }
            }
            return isValue;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string streetAdress = addressBox.Text;
            string city = cityBox.Text;
            string state = stateBox.Text;
            string zipCode = zipBox.Text;
            string phone = phoneBox.Text;

            if (!LetterCheck(firstName))
            {
                MessageBox.Show("First name invalid.");
            }

            if(!LetterCheck(lastName))
            {
                MessageBox.Show("last name invalid.");
            }

            if(!PunctuationCheck(streetAdress))
            {
                MessageBox.Show("Street address invalid.");
            }

            if(!LetterCheck(city))
            {
                MessageBox.Show("City invalid.");
            }

            if(!LetterCheck(state) || city.Length != 2)
            {
                MessageBox.Show("State invalid.");
            }

            if(!DigitCheck(zipCode) || zipCode.Length != 5)
            {
                MessageBox.Show("Zip Code invalid.");
            }

            if(!DigitCheck(phone) || phone.Length != 10)
            {
                MessageBox.Show("Phone number invalid.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
