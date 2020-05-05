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

namespace lesson_3_1
{
    /// <summary>
    /// Логика взаимодействия для SelectMode.xaml
    /// </summary>
    public partial class SelectMode : Window
    {
        int port;
        string server;
        string pass;
        string mail;

        public SelectMode(int Port, string Server, string Mail, string Pass)
        {
            InitializeComponent();
            port = Port;
            pass = Pass;
            server = Server;
            mail = Mail;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            send send = new send(port, server, mail, pass);
            send.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Sendler sendler = new Sendler(port, server, mail, pass);
            sendler.Show();
            Close();
        }
    }
}
