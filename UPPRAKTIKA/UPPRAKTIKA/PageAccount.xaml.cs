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
    /// Логика взаимодействия для PageAccount.xaml
    /// </summary>
    public partial class PageAccount : Page
    {

        public static Dohod_Kl_Ist202_VavilonskyEntities1 DataEntitiesEmployee { get; set; }
        public ObservableCollection<Счёт> ListAccount { get; }

        private bool isDirty = true;

        public PageAccount()
        {
            InitializeComponent();
            DataEntitiesEmployee = new Dohod_Kl_Ist202_VavilonskyEntities1();
            ListAccount = new ObservableCollection<Счёт>();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GetEmployees();
            DataGridEmployee.SelectedIndex = 0;
        }


        private void GetEmployees()
        {
            var accountt = DataEntitiesEmployee.Account;
            var queryAccount = from employee in accountt
                                orderby employee.Валюта
                                select employee;
            foreach (Счёт emp in queryAccount)
            {
                ListAccount.Add(emp);
            }
            DataGridEmployee.ItemsSource = ListAccount;
        }

        private void RewriteAccount()
        {
            DataEntitiesEmployee = new Dohod_Kl_Ist202_VavilonskyEntities1();
            ListAccount.Clear();
            GetEmployees();
        }

        private void UndoCommandBinding_Executed(object sender,
ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Отмена");

            isDirty = true;
            RewriteAccount();
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

            var accountt = new Счёт();
            accountt.СуммаСчёта = -1;
            accountt.Валюта = "не задано";
            
            try
            {
                DataGridEmployee.IsReadOnly = false;
                DataGridEmployee.BeginEdit();
                DataEntitiesEmployee.Account.Add(accountt);
                ListAccount.Add(accountt);
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

            Счёт emp = DataGridEmployee.SelectedItem as Счёт;
            if (emp != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные ",
               "Предупреждение", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    DataEntitiesEmployee.Account.Remove(emp);
                    DataGridEmployee.SelectedIndex =
                    DataGridEmployee.SelectedIndex == 0 ? 1 :
                   DataGridEmployee.SelectedIndex - 1;
                    ListAccount.Remove(emp);
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
            RewriteAccount();
            DataGridEmployee.IsReadOnly = false;
            isDirty = true;
            BorderFind.Visibility = Visibility.Hidden;
        }




    }
}
