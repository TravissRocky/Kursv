using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace UPPRAKTIKA
{
    /// <summary>
    /// Логика взаимодействия для PageContract.xaml
    /// </summary>
    public partial class PageContract : Page
    {

        public static Dohod_Kl_Ist202_VavilonskyEntities1 DataEntitiesEmployee { get; set; }
        public ObservableCollection<Договор> ListContract { get; }

        private bool isDirty = true;

        public PageContract()
        {

            InitializeComponent();
            DataEntitiesEmployee = new Dohod_Kl_Ist202_VavilonskyEntities1();
            ListContract = new ObservableCollection<Договор>();
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GetEmployees();
            DataGridEmployee.SelectedIndex = 0;
        }

        private void GetEmployees()
        {
            var contractt = DataEntitiesEmployee.Contract;
            var queryContract = from employee in contractt
                                orderby employee.МестоРаботы
                                select employee;
            foreach (Договор emp in queryContract)
            {
                ListContract.Add(emp);
            }
            DataGridEmployee.ItemsSource = ListContract;
        }

        private void RewriteContract()
        {
            DataEntitiesEmployee = new Dohod_Kl_Ist202_VavilonskyEntities1();
            ListContract.Clear();
            GetEmployees();
        }

        private void UndoCommandBinding_Executed(object sender,
ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Отмена");

            isDirty = true;
            RewriteContract();
            DataGridEmployee.IsReadOnly = true;
        }

        private void UndoCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }

        private void NewCommandBinding_Executed(object sender,
ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Создание");

            var contractt = new Договор();
            contractt.КодКлиента = -1;
            contractt.МестоРаботы = "не задано";
            contractt.Зарплата = -1;
            try
            {
                DataGridEmployee.IsReadOnly = false;
                DataGridEmployee.BeginEdit();
                DataEntitiesEmployee.Contract.Add(contractt);
                ListContract.Add(contractt);
                isDirty = false;
            }
            catch
            {
                throw new ApplicationException(
               "Ошибка добавления данных");
            }
        }

        private void NewCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void EditCommandBinding_Executed(object sender,
ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Редактирование");
            DataGridEmployee.IsReadOnly = false;
            DataGridEmployee.BeginEdit();

            isDirty = false;
        }

        private void EditCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void SaveCommandBinding_Executed(object sender,
ExecutedRoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("Сохранение");
                DataEntitiesEmployee.SaveChanges();
                isDirty = true;
                DataGridEmployee.IsReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void SaveCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;

        }

        private void FindCommandBinding_Executed(object sender,
ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Поиск");
            BorderFind.Visibility = Visibility.Visible;
            isDirty = false;
        }

        private void FindCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void DeleteCommandBinding_Executed(object sender,
ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Удаление");

            Договор emp = DataGridEmployee.SelectedItem as Договор;
            if (emp != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные ",
               "Предупреждение", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    DataEntitiesEmployee.Contract.Remove(emp);
                    DataGridEmployee.SelectedIndex =
                    DataGridEmployee.SelectedIndex == 0 ? 1 :
                   DataGridEmployee.SelectedIndex - 1;
                    ListContract.Remove(emp);
                    DataEntitiesEmployee.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }

        private void DeleteCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

       

        private void RefreshCommandBinding_Executed(object sender,
 ExecutedRoutedEventArgs e)
        {
            RewriteContract();
            DataGridEmployee.IsReadOnly = false;
            isDirty = true;
            BorderFind.Visibility = Visibility.Hidden;
        }
    }
}
