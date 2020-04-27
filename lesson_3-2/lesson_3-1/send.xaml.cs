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
    /// Логика взаимодействия для send.xaml
    /// </summary>
    public partial class send : Window
    {
        MailEntities db = new MailEntities();
        int port;
        string server;
        string mailSend;
        string passSend;
        string mailTo;
        string theme;

        public send(int Port, string Server, string Mail, string Pass)
        {
            InitializeComponent();
            port = Port;
            server = Server;
            mailSend = Mail;
            passSend = Pass;
            cbMials.ItemsSource = db.Email.ToList();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            if (tbTo.IsVisible)
            {
                if (string.IsNullOrEmpty(tbTo.Text))
                    return;
                mailTo = tbTo.Text;

            }
            else
            {
                if (string.IsNullOrEmpty(cbMials.Text))
                    return;
                mailTo = (cbMials.SelectedItem as Email).Value;
            }
            if (string.IsNullOrEmpty(tbTheme.Text))
                theme = "Без темы";
            try
            {
                SendMail.Send(mailSend, passSend, mailTo, port, server, tbText.Text, theme);
            }
            catch (SmtpException)
            {

                MessageBox.Show("Ой, похоже Вы используете двухфакторную авторизацию. Данное приложение не поддерживает авторизацию подобного типа", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            MessageBox.Show("Готово");
        }

        private void btChange_Click(object sender, RoutedEventArgs e)
        {
            if (tbTo.IsVisible)
            {
                tbTo.Visibility = Visibility.Hidden;
                btChange.Content = "Ввести";
            }
            else
            {
                tbTo.Visibility = Visibility.Visible;
                btChange.Content = "Выбрать";
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
    }
}
