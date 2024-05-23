using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Session_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users = new List<User>();
        User authUser;
        DemoExamEntities db = new DemoExamEntities();
        public MainWindow()
        {
            InitializeComponent();
            users = db.User.ToList();
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            authUser = db.User.FirstOrDefault(user => user.Login == LoginTB.Text.ToString() && user.Password == PasswordPB.Password);
            if (authUser != null)
            {
                switch(authUser.Role_ID)
                {
                    case 1:
                        Customer customer = new Customer();
                        customer.Show();
                        break;
                    case 2:
                        Manager manager = new Manager();
                        manager.Show();
                        break;
                    case 3:
                        Skladovshik skladovshik = new Skladovshik();
                        skladovshik.Show();
                        break;
                    case 4:
                        Director director = new Director();
                        director.Show();
                        break;
                }
                Close();
            }
            else MessageBox.Show("Неверный логин или пароль!");
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
            Close();
        }
    }
}
