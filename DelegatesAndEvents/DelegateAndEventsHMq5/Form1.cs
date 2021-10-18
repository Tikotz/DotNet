using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DelegateAndEventsHMq5;

namespace DelegateAndEventsHMq5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SuccessLogin()
        {
            MessageBox.Show("You Logged successfully!");
        }
        public void WrongUserName()
        {
            MessageBox.Show("Username Does not exist");
        }
        public void WrongPassword()
        {
            MessageBox.Show("Wrong Password");
        }

        public void SuccessDeposit()
        {
            MessageBox.Show("The deposit was successful.");
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (var user in BankAccounts.bankAccounts)
            {
                if (user.UserName != UsernametextBox1.Text)
                {
                    count++;
                    if (user.Password != int.Parse(PasswordtextBox2.Text))
                    {
                        if(user.UserName == UsernametextBox1.Text)
                        {
                            UnsuccessfulLoginEvent -= WrongPassword;
                            UnsuccessfulLoginEvent -= WrongUserName;
                            UnsuccessfulLoginEvent += WrongPassword;
                            UnsuccessfulLoginEvent();
                            break;
                        }
                        
                       
                    }
                }
                else if(user.UserName == UsernametextBox1.Text && user.Password != int.Parse(PasswordtextBox2.Text))
                {
                    UnsuccessfulLoginEvent -= WrongPassword;
                    UnsuccessfulLoginEvent -= WrongUserName;
                    UnsuccessfulLoginEvent += WrongPassword;
                    UnsuccessfulLoginEvent();
                    break;
                }
                if (user.UserName == UsernametextBox1.Text && user.Password == int.Parse(PasswordtextBox2.Text))
                {
                    SuccessLoginEvent -= SuccessLogin;
                    UnsuccessfulLoginEvent -= WrongUserName;
                    UnsuccessfulLoginEvent -= WrongPassword;
                    SuccessLoginEvent += SuccessLogin;
                    SuccessLoginEvent();
                    user.IsLoggedIn = true;
                    break;
                }
                if(count == BankAccounts.bankAccounts.Count)
                {
                    UnsuccessfulLoginEvent -= WrongUserName;
                    UnsuccessfulLoginEvent -= WrongPassword;

                    UnsuccessfulLoginEvent += WrongUserName;
                    UnsuccessfulLoginEvent();
                    break;
                }

            }

        }
        public static event LoginDelegate SuccessLoginEvent;
        public static event LoginDelegate UnsuccessfulLoginEvent;
        public static event DepositDelegate SuccessDepositEvent;

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var user in BankAccounts.bankAccounts)
            {
                if (user.IsLoggedIn && user.UserName == UsernametextBox1.Text)
                {
                    user.MyMoney += int.Parse(DepositTextBox1.Text);
                    BankAccounts.BankMoney += int.Parse(DepositTextBox1.Text);
                    SuccessDepositEvent -= SuccessDeposit;
                    SuccessDepositEvent += SuccessDeposit;
                    SuccessDepositEvent();
                    listBox1.Items.Add($"the username is: {user.UserName} ,\n the deposit amount is: {user.MyMoney}");
                    BankMoneytextBox1.Text = BankAccounts.BankMoney.ToString();
                    break;
                }
                else
                {
                    if (user.UserName == UsernametextBox1.Text)
                    {
                        MessageBox.Show("you need to login first");
                        break;
                    }
                    else if (UsernametextBox1.Text == "")
                    {
                        MessageBox.Show("you need to enter a username");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                    
                    
                }
            }
        }
    }
    

}
