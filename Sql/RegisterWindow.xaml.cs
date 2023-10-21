using Microsoft.IdentityModel.Tokens;
using SocialNetwork.Data;
using SocialNetwork.Data.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SocialNetwork.Sql
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private DataContext dataContext;

        public RegisterWindow()
        {
            InitializeComponent();
            this.dataContext = new();
            this.DataContext = this;
        }

        
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private bool IsFields()
        {
            //if(LoginBox.Text.Length < 6 && LoginBox.Text.Length > 25)
            //{
            //    return false;
            //}
            

            return true;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(LoginBox.Text);
            //var temp = new User
            //{
            //    Id = Guid.NewGuid(),
            //    Login = LoginBox.Text,
            //    FirstName = "adasd",
            //    LastName = "sdasd",
            //    Password = PasswordBox.Text,
            //    Email = EmailBox.Text,
            //    EmailConfirmed = false
            //};
            //dataContext.User.Add(temp);
            //dataContext.SaveChanges();
            //MessageBox.Show("Add ");

            MailAddress from = new MailAddress("dasbalan14@gmail.com");
            MailAddress to = new MailAddress("ceriized@gmail.com");
            MailMessage message = new MailMessage(from, to) // Формируем сообщение с нужными заголовками
                                                            // Заголовок "от кого" ныне часто игнорируется,
                                                            // и на его место ставится реальный адрес отправителя,
                                                            // так что подписаться миллионером дядей Петей не получится
            {
                Subject = "Твое приложение оценили!",
                IsBodyHtml = false,
                Body = $"Your mark is"
            };
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("dasbalan14@gmail.com", "18934589a"),
                EnableSsl = true
            };
            smtp.Send(message);

        }
    }
}
