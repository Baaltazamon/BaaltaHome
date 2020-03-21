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
        int port;
        string server;
        string mailSend;
        string passSend;
        public send(int Port, string Server, string Mail, string Pass)
        {
            InitializeComponent();
            port = Port;
            server = Server;
            mailSend = Mail;
            passSend = Pass;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTo.Text))
                return;
            try
            {
                SendMail.Send(mailSend, passSend, tbTo.Text, port, server, tbText.Text, tbTheme.Text);
            }
            catch (SmtpException)
            {

                MessageBox.Show("Ой, похоже Вы используете двухфакторную авторизацию. Данное приложение не поддерживает авторизацию подобного типа", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            MessageBox.Show("Готово");
        }
    }
}
