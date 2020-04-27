using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Net;
using System.Net.Mail;

namespace lesson_3_1
{
    /// <summary>
    /// Логика взаимодействия для Sendler.xaml
    /// </summary>
    public partial class Sendler : Window
    {
        MailEntities db = new MailEntities();
        int port;
        string server;
        string mailSend;
        string passSend;
        string theme = null;
        string text = null;
        public Sendler(int Port, string Server, string Mail, string Pass)
        {
            InitializeComponent();
            port = Port;
            server = Server;
            mailSend = Mail;
            passSend = Pass;

            Update();
        }

        public void Update()
        {
            db.SaveChanges();
            dgMails.ItemsSource = db.Email.ToList();
            dgMesseage.ItemsSource = db.Messeage.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbMail.Text))
                MessageBox.Show("Заполните поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            Email mail = new Email
            {
                Value = tbMail.Text,
                Name = tbName.Text
            };
            db.Email.Add(mail);
            Update();
        }

        private void dgMails_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Email mail = dgMails.SelectedItem as Email;
            if (mail == null)
                return;
            tbMail_Copy.Text = mail.Value;
            tbName_Copy.Text = mail.Name;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Email mail = dgMails.SelectedItem as Email;
            if (mail == null)
                return;
            mail.Name = tbName_Copy.Text;
            mail.Value = tbMail_Copy.Text;
            Update();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Email mail = dgMails.SelectedItem as Email;
            if (mail == null)
                return;
            db.Email.Remove(mail);
            Update();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string g;
            if (theme == null || text == null)
            {
                MessageBox.Show("Выберите сообщение!");
                return;
            }
            foreach (var c in dgMails.Items)
            {
                g = (c as Email).Value;
                try
                {
                    SendMail.Send(mailSend, passSend, g, port, server, text, theme);
                }
                catch (SmtpException)
                {

                    MessageBox.Show("Ой, похоже Вы используете двухфакторную авторизацию. Данное приложение не поддерживает авторизацию подобного типа", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                MessageBox.Show("Готово");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string g;
            if (theme == null || text == null)
            {
                MessageBox.Show("Выберите сообщение!");
                return;
            }
            foreach (var c in dgMails.SelectedItems)
            {
                g = (c as Email).Value;
                try
                {
                    SendMail.Send(mailSend, passSend, g, port, server, text, theme);
                }
                catch (SmtpException)
                {

                    MessageBox.Show("Ой, похоже Вы используете двухфакторную авторизацию. Данное приложение не поддерживает авторизацию подобного типа", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                MessageBox.Show("Готово");
            }
        }

       

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTitle.Text) || string.IsNullOrEmpty(tbText.Text))
                MessageBox.Show("Заполните поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            Messeage msg = new Messeage
            {
                Title = tbTitle.Text,
                Text = tbText.Text
            };
            db.Messeage.Add(msg);
            Update();
        }

        private void dgMesseage_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Messeage msg = dgMesseage.SelectedItem as Messeage;
            if (msg != null)
            {
                theme = msg.Title;
                tbTitle.Text = msg.Title;
                text = msg.Text;
                tbText.Text = msg.Text;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Messeage msg = dgMesseage.SelectedItem as Messeage;
            if (msg == null)
                return;
            msg.Title = tbTitle.Text;
            msg.Text = tbText.Text;
            Update();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            tbTitle.Clear();
            tbText.Clear();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Messeage msg = dgMesseage.SelectedItem as Messeage;
            if (msg == null)
                return;
            db.Messeage.Remove(msg);
            Update();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ChangeMailing.IsSelected)
            {
                (sender as TabControl).SelectedIndex = 0;
                Mailing m = new Mailing(port, server, mailSend, passSend);
                m.ShowDialog();
                
            }
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            SelectMode sm = new SelectMode(port, server, mailSend, passSend);
            sm.Show();
            Close();
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgMails.ItemsSource = db.Email.Where(c => c.Name.Contains(search.Text)).ToList(); ;
        }
    }
}
