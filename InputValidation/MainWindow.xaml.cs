using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace InputValidation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSave_OnClick(object sender, RoutedEventArgs e)
        {
            if (!ValidName(TxtName.Text))
            {
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");
                return;
            }

            if (!ValidPhone(TxtPhone.Text))
            {
                MessageBox.Show("The phone number is invalid (it must be 10 digit number without spaces)");
                return;
            }
            else
            {
                if (!Regex.IsMatch(TxtPhone.Text, @"^\((\d{3})\)[\s\-](\d{3})\-(\d{4})$"))
                {
                    TxtPhone.Text = ReformatPhone(TxtPhone.Text);
                }
            }

            if (!ValidEmail(TxtEmail.Text))
            {
                MessageBox.Show("The email is invalid (use valid email address)");
            }


            
        }

        private bool ValidName(string name)
        {
            return Regex.IsMatch(name, @"^([A-Za-z]+\s*)+$");
        }
        
        private bool ValidPhone(string number)
        {
            return Regex.IsMatch(number, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$"); 
        }
        
        private bool ValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                                        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
        }

        private string ReformatPhone(string number)
        {
            return $"({number.Substring(0, 3)}) {number.Substring(3, 3)}-{number.Substring(6, 4)}";
                 }
    }
}