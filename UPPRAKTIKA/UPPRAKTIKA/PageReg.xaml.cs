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
using UPPRAKTIKA.DB;

namespace UPPRAKTIKA
{
    /// <summary>
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {

        static string symbols = "1gfh14j5g1j5f1f5j4f5g15";
        static Random r = new Random();

        public PageMain pageMain;

        public PageReg()
        {
            InitializeComponent();

            FUsers = DBCon.db.Logs.ToList();

          

           
            
        }

        public List<Log> FUsers = new List<Log>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var searchdata = FUsers.Find(item => item.login == login.Text);


          

            if (login.Text == string.Empty || password.Text == string.Empty || password.Text == string.Empty)
            {
                MessageBox.Show("Все поля должны быть заполнены! ");
            }

            else if (searchdata.login != login.Text)
            {
                MessageBox.Show("Такого логина нет в системе! ");
            }

            else if (searchdata.password != password.Text)
            {
                MessageBox.Show("Пароль введен неверно! ");
            }

            else
            {
                MessageBox.Show("Авторизация прошла успешно! ");

                WindowReg авторизация1 = new WindowReg();
                авторизация1.Close();
                

                MainWindow личныйКабинет = new MainWindow();
                личныйКабинет.Show();

             
                

            } 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowRegistration авторизация = new WindowRegistration();
            авторизация.Show();
        }
    }
}
