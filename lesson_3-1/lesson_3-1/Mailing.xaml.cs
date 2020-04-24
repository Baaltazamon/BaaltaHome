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
        MailEntities db = new MailEntities();
        public Mailing()
        {
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            db.SaveChanges();
            dgMailing.ItemsSource = db.Mailing.ToList();
            cbMessage.ItemsSource = db.Messeage.ToList();
            cbRecipient.ItemsSource = db.Email.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mailing m = new Mailing
            {
                Writing = cbMessage.Text,
                Recipient = (cbRecipient.SelectedItem as Email).id
            };
            db.Mailing.Add(m);
            Update();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Mailing m = dgMailing.SelectedItem as Mailing;
            if (m == null)
                return;
            db.Mailing.Remove(m);
            Update();
        }
    }
}
