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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lesson_3_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] servers = new string[] {"mail.ru", "list.ru", "inbox.ru", "bk.ru", "gmail.com", "yandex.ru" };
        string mail;
        string server;
        int port = 587;
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < servers.Length; i++)
            {
                cbMail.Items.Add("@"+servers[i]);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbMail.Text) || string.IsNullOrEmpty(pbPass.Password))
                return;
            mail = $"{tbMail.Text}{cbMail.Text}";
            if (cbMail.SelectedIndex >= 0 && cbMail.SelectedIndex <= 3)
            {
                server = "smtp.mail.ru";

            }
            else if (cbMail.SelectedIndex == 4)
            {
                server = "smtp.gmail.com";
                
            }
            else
            {
                server = "smtp.yandex.ru";
                port = 25;
            }
            SelectMode g = new SelectMode(port, server, mail, pbPass.Password);
            g.Show();
            Close();
        }
    }
}
