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
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        private Log _currentReg = new Log();

        public PageRegistration()
        {
            InitializeComponent();
            DataContext = _currentReg;
            FUsers1 = DBCon.db.КодовоеСлово.ToList();
            noname.ItemsSource = Dohod_Kl_Ist202_VavilonskyEntities1.GetContext().КодовоеСлово.ToList();
        }

        public List<КодовоеСлово> FUsers1 = new List<КодовоеСлово>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowReg личныйКабинет = new WindowReg();
            личныйКабинет.Show();
         

            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentReg.Фамилия))
                errors.AppendLine("Укажите фамилию");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentReg.КодПользователя != 10)
                Dohod_Kl_Ist202_VavilonskyEntities1.GetContext().Logs.Add(_currentReg);
            else
            {
                _currentReg.КодПользователя++;
                Dohod_Kl_Ist202_VavilonskyEntities1.GetContext().Logs.Add(_currentReg);
            }

            try
            {
                Dohod_Kl_Ist202_VavilonskyEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
