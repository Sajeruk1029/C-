﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace App4
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();

            Data.MinDate = DateTimeOffset.Now.AddYears(-80);
            Data.MaxDate = DateTimeOffset.Now;

            Data.Date = DateTimeOffset.MinValue;

            domen.SelectedIndex = 0;

            Next.IsEnabled = false;

        }

        private void Name_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            Name.Text = Name.Text.Replace("0", "");
            Name.Text = Name.Text.Replace("1", "");
            Name.Text = Name.Text.Replace("2", "");
            Name.Text = Name.Text.Replace("3", "");
            Name.Text = Name.Text.Replace("4", "");
            Name.Text = Name.Text.Replace("5", "");
            Name.Text = Name.Text.Replace("6", "");
            Name.Text = Name.Text.Replace("7", "");
            Name.Text = Name.Text.Replace("8", "");
            Name.Text = Name.Text.Replace("9", "");
            
            Name.Text = Name.Text.Replace("!", "");
            Name.Text = Name.Text.Replace("@", "");
            Name.Text = Name.Text.Replace("#", "");
            Name.Text = Name.Text.Replace("$", "");
            Name.Text = Name.Text.Replace("%", "");
            Name.Text = Name.Text.Replace("^", "");
            Name.Text = Name.Text.Replace("&", "");
            Name.Text = Name.Text.Replace("*", "");
            Name.Text = Name.Text.Replace("(", "");
            Name.Text = Name.Text.Replace(")", "");
            Name.Text = Name.Text.Replace("-", "");
            Name.Text = Name.Text.Replace("=", "");
            Name.Text = Name.Text.Replace("`", "");
            Name.Text = Name.Text.Replace("~", "");
            Name.Text = Name.Text.Replace("+", "");
            Name.Text = Name.Text.Replace("|", "");
            Name.Text = Name.Text.Replace(@"\", "");
            Name.Text = Name.Text.Replace("/", "");
            Name.Text = Name.Text.Replace(",", "");
            Name.Text = Name.Text.Replace(".", "");
            Name.Text = Name.Text.Replace(">", "");
            Name.Text = Name.Text.Replace("<", "");
            Name.Text = Name.Text.Replace(" ", "-");
            Name.Text = Name.Text.Replace("_", "");

            if (Name.Text.Length > 0)
            {
                if (Name.Text[0] == '-')
                {
                    Name.Text = "";
                }

            }


        }

        private void Surname_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            Surname.Text = Surname.Text.Replace("0", "");
            Surname.Text = Surname.Text.Replace("1", "");
            Surname.Text = Surname.Text.Replace("2", "");
            Surname.Text = Surname.Text.Replace("3", "");
            Surname.Text = Surname.Text.Replace("4", "");
            Surname.Text = Surname.Text.Replace("5", "");
            Surname.Text = Surname.Text.Replace("6", "");
            Surname.Text = Surname.Text.Replace("7", "");
            Surname.Text = Surname.Text.Replace("8", "");
            Surname.Text = Surname.Text.Replace("9", "");

            Surname.Text = Surname.Text.Replace("!", "");
            Surname.Text = Surname.Text.Replace("@", "");
            Surname.Text = Surname.Text.Replace("#", "");
            Surname.Text = Surname.Text.Replace("$", "");
            Surname.Text = Surname.Text.Replace("%", "");
            Surname.Text = Surname.Text.Replace("^", "");
            Surname.Text = Surname.Text.Replace("&", "");
            Surname.Text = Surname.Text.Replace("*", "");
            Surname.Text = Surname.Text.Replace("(", "");
            Surname.Text = Surname.Text.Replace(")", "");
            Surname.Text = Surname.Text.Replace("-", "");
            Surname.Text = Surname.Text.Replace("=", "");
            Surname.Text = Surname.Text.Replace("`", "");
            Surname.Text = Surname.Text.Replace("~", "");
            Surname.Text = Surname.Text.Replace("+", "");
            Surname.Text = Surname.Text.Replace("|", "");
            Surname.Text = Surname.Text.Replace(@"\", "");
            Surname.Text = Surname.Text.Replace("/", "");
            Surname.Text = Surname.Text.Replace(",", "");
            Surname.Text = Surname.Text.Replace(".", "");
            Surname.Text = Surname.Text.Replace(">", "");
            Surname.Text = Surname.Text.Replace("<", "");
            Surname.Text = Surname.Text.Replace(" ", "-");
            Surname.Text = Surname.Text.Replace("_", "");

            if (Surname.Text.Length > 0)
            {
                if (Surname.Text[0] == '-')
                {
                    Surname.Text = "";
                }

            }
        }

        private void Otchestvo_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            Otchestvo.Text = Otchestvo.Text.Replace("0", "");
            Otchestvo.Text = Otchestvo.Text.Replace("1", "");
            Otchestvo.Text = Otchestvo.Text.Replace("2", "");
            Otchestvo.Text = Otchestvo.Text.Replace("3", "");
            Otchestvo.Text = Otchestvo.Text.Replace("4", "");
            Otchestvo.Text = Otchestvo.Text.Replace("5", "");
            Otchestvo.Text = Otchestvo.Text.Replace("6", "");
            Otchestvo.Text = Otchestvo.Text.Replace("7", "");
            Otchestvo.Text = Otchestvo.Text.Replace("8", "");
            Otchestvo.Text = Otchestvo.Text.Replace("9", "");

            Otchestvo.Text = Otchestvo.Text.Replace("!", "");
            Otchestvo.Text = Otchestvo.Text.Replace("@", "");
            Otchestvo.Text = Otchestvo.Text.Replace("#", "");
            Otchestvo.Text = Otchestvo.Text.Replace("$", "");
            Otchestvo.Text = Otchestvo.Text.Replace("%", "");
            Otchestvo.Text = Otchestvo.Text.Replace("^", "");
            Otchestvo.Text = Otchestvo.Text.Replace("&", "");
            Otchestvo.Text = Otchestvo.Text.Replace("*", "");
            Otchestvo.Text = Otchestvo.Text.Replace("(", "");
            Otchestvo.Text = Otchestvo.Text.Replace(")", "");
            Otchestvo.Text = Otchestvo.Text.Replace("-", "");
            Otchestvo.Text = Otchestvo.Text.Replace("=", "");
            Otchestvo.Text = Otchestvo.Text.Replace("`", "");
            Otchestvo.Text = Otchestvo.Text.Replace("~", "");
            Otchestvo.Text = Otchestvo.Text.Replace("+", "");
            Otchestvo.Text = Otchestvo.Text.Replace("|", "");
            Otchestvo.Text = Otchestvo.Text.Replace(@"\", "");
            Otchestvo.Text = Otchestvo.Text.Replace("/", "");
            Otchestvo.Text = Otchestvo.Text.Replace(",", "");
            Otchestvo.Text = Otchestvo.Text.Replace(".", "");
            Otchestvo.Text = Otchestvo.Text.Replace(">", "");
            Otchestvo.Text = Otchestvo.Text.Replace("<", "");
            Otchestvo.Text = Otchestvo.Text.Replace(" ", "-");
            Otchestvo.Text = Otchestvo.Text.Replace("_", "");

            if (Otchestvo.Text.Length > 0)
            {
                if (Otchestvo.Text[0] == '-')
                {
                    Otchestvo.Text = "";
                }

            }
        }

        private void email_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            email.Text = email.Text.Replace("!", "");
            email.Text = email.Text.Replace("@", "");
            email.Text = email.Text.Replace("#", "");
            email.Text = email.Text.Replace("$", "");
            email.Text = email.Text.Replace("%", "");
            email.Text = email.Text.Replace("^", "");
            email.Text = email.Text.Replace("&", "");
            email.Text = email.Text.Replace("*", "");
            email.Text = email.Text.Replace("(", "");
            email.Text = email.Text.Replace(")", "");
            email.Text = email.Text.Replace("-", "");
            email.Text = email.Text.Replace("=", "");
            email.Text = email.Text.Replace("`", "");
            email.Text = email.Text.Replace("~", "");
            email.Text = email.Text.Replace("+", "");
            email.Text = email.Text.Replace("|", "");
            email.Text = email.Text.Replace(@"\", "");
            email.Text = email.Text.Replace("/", "");
            email.Text = email.Text.Replace(",", "");
            email.Text = email.Text.Replace(">", "");
            email.Text = email.Text.Replace("<", "");
            email.Text = email.Text.Replace(" ", "-");

            if (email.Text.Length > 0)
            {
                if (email.Text[0] == '-')
                {
                    email.Text = "";
                }

            }
        }

        private void login_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            login.Text = login.Text.Replace("!", "");
            login.Text = login.Text.Replace("@", "");
            login.Text = login.Text.Replace("#", "");
            login.Text = login.Text.Replace("$", "");
            login.Text = login.Text.Replace("%", "");
            login.Text = login.Text.Replace("^", "");
            login.Text = login.Text.Replace("&", "");
            login.Text = login.Text.Replace("*", "");
            login.Text = login.Text.Replace("(", "");
            login.Text = login.Text.Replace(")", "");
            login.Text = login.Text.Replace("-", "");
            login.Text = login.Text.Replace("=", "");
            login.Text = login.Text.Replace("`", "");
            login.Text = login.Text.Replace("~", "");
            login.Text = login.Text.Replace("+", "");
            login.Text = login.Text.Replace("|", "");
            login.Text = login.Text.Replace(@"\", "");
            login.Text = login.Text.Replace("/", "");
            login.Text = login.Text.Replace(",", "");
            login.Text = login.Text.Replace(".", "");
            login.Text = login.Text.Replace(">", "");
            login.Text = login.Text.Replace("<", "");
            login.Text = login.Text.Replace(" ", "-");
            login.Text = login.Text.Replace("_", "");

            if (login.Text.Length > 0)
            {
                if (login.Text[0] == '-')
                {
                    login.Text = "";
                }

            }
        }

        private void password_PasswordChanging(PasswordBox sender, PasswordBoxPasswordChangingEventArgs args)
        {

        }

        private async void rec_Click(object sender, RoutedEventArgs e)
        {
            int kolU = 0, kolS = 0;

            if (password.Password.Length > 0)
            {
                for (int count = 0; count < password.Password.Length; count++)
                {
                    if (password.Password[count] == password.Password[count].ToString().ToUpper()[0])
                    {

                        kolU++;

                    }
                }

                for (int count = 0; count < password.Password.Length; count++)
                {
                    if ((password.Password[count] == '~') || (password.Password[count] == '`') || (password.Password[count] == '!') || (password.Password[count] == '@') || (password.Password[count] == '#') || (password.Password[count] == '$') || (password.Password[count] == '%') || (password.Password[count] == '^') || (password.Password[count] == '&') || (password.Password[count] == '*') || (password.Password[count] == '(') || (password.Password[count] == ')') || (password.Password[count] == '-') || (password.Password[count] == '=') || (password.Password[count] == '_') || (password.Password[count] == '+') || (password.Password[count] == '|') || (password.Password[count] == @"\"[0]) || (password.Password[count] == '/') || (password.Password[count] == '<') || (password.Password[count] == '?') || (password.Password[count] == '>') || (password.Password[count] == '.') || (password.Password[count] == ','))
                    {

                        kolS++;

                    }
                }

            }

            if(Name.Text.Length == 0)
            {
                var message = new MessageDialog("Поле имени не может быть пустым.").ShowAsync();
                return;
            }

            if(Surname.Text.Length == 0)
            {
                var message = new MessageDialog("Поле фамилии не может быть пустым.").ShowAsync();
                return;
            }

            if(Otchestvo.Text.Length == 0)
            {
                var message = new MessageDialog("Поле отчтества не может быть пустым.").ShowAsync();
                return;
            }

            if(email.Text.Length == 0)
            {
                var message = new MessageDialog("Поле Емаил не может быть пустым.").ShowAsync();
                return;
            }

            if(login.Text.Length == 0)
            {
                var message = new MessageDialog("Поле логина не может быть пустым.").ShowAsync();
                return;
            }

            if(password.Password.Length < 8)
            {
                var message = new MessageDialog("Пароль должен содержать не менее 8 символов.").ShowAsync();
                return;
            }

            if(kolU < 1)
            {
                var message = new MessageDialog("Пароль должен содержать символы верхнего регистра.").ShowAsync();
                return;
            }

            if(kolS < 1)
            {
                var message = new MessageDialog("Пароль должен содержать спец символы.").ShowAsync();
                return;
            }
            

            if(!((Man.IsChecked.Value) || (Woman.IsChecked.Value)))
            {
                var message = new MessageDialog("Не выбран пол.").ShowAsync();
                return;
            }

            var mes = new MessageDialog("Успех.").ShowAsync();
            Next.IsEnabled = true;

        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BlankPage1));
        }

        private void Name_LostFocus(object sender, RoutedEventArgs e)
        {
            char symbol;

            if (Name.Text.Length > 0)
            {
                symbol = Name.Text[0];
                Name.Text = symbol.ToString().ToUpper() + Name.Text.Remove(0, 1);
            }
        }

        private void Surname_LostFocus(object sender, RoutedEventArgs e)
        {
            char symbol;

            if (Surname.Text.Length > 0)
            {
                symbol = Surname.Text[0];
                Surname.Text = symbol.ToString().ToUpper() + Surname.Text.Remove(0, 1);
            }
        }

        private void Otchestvo_LostFocus(object sender, RoutedEventArgs e)
        {
            char symbol;

            if (Otchestvo.Text.Length > 0)
            {
                symbol = Otchestvo.Text[0];
                Otchestvo.Text = symbol.ToString().ToUpper() + Otchestvo.Text.Remove(0, 1);
            }
        }
    }
}