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
    /// Логика взаимодействия для Mailing.xaml
    /// </summary>
    public partial class Mailing : Window
    {
        Nullable<TimeSpan> ts = null;
        MailEntities db = new MailEntities();
        int port;
        string server;
        string mailSend;
        string passSend;
        public Mailing(int Port, string Server, string Mail, string Pass)
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
            dgMailing.ItemsSource = db.MailingMessage.ToList();
            cbMessage.ItemsSource = db.Messeage.ToList();
            cbRecipient.ItemsSource = db.Email.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ts == null)
            {
                MessageBox.Show("Выберите дату и время!");
                return;
            }
            MailingMessage m = new MailingMessage
            {
                Writing = cbMessage.Text,
                Recipient = (cbRecipient.SelectedItem as Email).id,
                DateSending = (CldrDateSending.SelectedDate ?? DateTime.Today).Add(ts?? TimeSpan.Parse("00:00"))
            };
            db.MailingMessage.Add(m);
            Update();
            ts = null;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MailingMessage m = dgMailing.SelectedItem as MailingMessage;
            if (m == null)
                return;
            db.MailingMessage.Remove(m);
            Update();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
            if ((sender as TextBox).Text.Length == 2)
            {
                (sender as TextBox).Text += ":";
                (sender as TextBox).CaretIndex = 3;
            }
       
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                ts = TimeSpan.Parse(tbTime.Text);
            }
            catch (OverflowException)
            {
                tbTime.Clear();
                MessageBox.Show("Введите время корректно");
            }
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            List<MailingMessage> mm = db.MailingMessage.ToList();
            int g = 0;
            foreach (var c in mm)
            {
                if (c.DateSending <= DateTime.Now)
                {
                    c.DateSending = c.DateSending.AddDays(7);
                    if (c.DateSending < DateTime.Now)
                    {
                        c.DateSending = DateTime.Now;
                    }
                    g++;
                    SendMail.Send(mailSend, passSend, c.Email.Value, port, server, c.Messeage.Text, c.Messeage.Title);
                    db.SaveChanges();
                    
                }
            }
            MessageBox.Show($"Отправлено {g} сообщений");
        }
    }
}
