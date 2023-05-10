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
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Objects;


namespace UPPRAKTIKA
{
    /// <summary>
    /// Логика взаимодействия для PageEmployee.xaml
    /// </summary>
    public partial class PageEmployee : Page
    {
        public static Dohod_Kl_Ist202_VavilonskyEntities1 DataEntitiesEmployee { get; set; }
        public ObservableCollection<Сотрудник> ListEmployee { get; }

       
        private bool isDirty = true;
        

        public PageEmployee()
        {

            InitializeComponent();
            DataEntitiesEmployee = new Dohod_Kl_Ist202_VavilonskyEntities1();
            ListEmployee = new ObservableCollection<Сотрудник>();            


        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GetEmployees();
            DataGridEmployee.SelectedIndex = 0;
        }

        private void GetEmployees()
        {
            var employees = DataEntitiesEmployee.Employees;
            var queryEmployee = from employee in employees
                                orderby employee.Фамилия
                                select employee;
            foreach (Сотрудник emp in queryEmployee)
            {
                ListEmployee.Add(emp);
            }
            DataGridEmployee.ItemsSource = ListEmployee;
        }

        private void RewriteEmployee()
        {
            DataEntitiesEmployee = new Dohod_Kl_Ist202_VavilonskyEntities1();
            ListEmployee.Clear();
            GetEmployees();
        }

        private void UndoCommandBinding_Executed(object sender,
ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Отмена");

            isDirty = true;
            RewriteEmployee();
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

            var employee = new Сотрудник();
            employee.КодСотрудника = -1;
            employee.Имя = "не задано";
            employee.Фамилия = "не задано";
            employee.ДатаРождения = DateTime.ParseExact("01.01.1970", "dd/MM/yyyy", null);
            employee.КодДолжности = -1;
            employee.Телефон = "не задано";
            employee.Отчество = "не задано";
            try
            {
                DataGridEmployee.IsReadOnly = false;
                DataGridEmployee.BeginEdit();
                DataEntitiesEmployee.Employees.Add(employee);
                ListEmployee.Add(employee);
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
            catch(Exception ex)
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

            Сотрудник emp = DataGridEmployee.SelectedItem as Сотрудник;
            if (emp != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные ",
               "Предупреждение", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    DataEntitiesEmployee.Employees.Remove(emp);
                    DataGridEmployee.SelectedIndex =
                    DataGridEmployee.SelectedIndex == 0 ? 1 :
                   DataGridEmployee.SelectedIndex - 1;
                    ListEmployee.Remove(emp);
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

        private void ButtonFindSurname_Click(object sender, RoutedEventArgs e)
        {
            string surname = TextBoxSurname.Text;
            DataEntitiesEmployee = new Dohod_Kl_Ist202_VavilonskyEntities1();
            ListEmployee.Clear();
            var employees = DataEntitiesEmployee.Employees;
            var queryEmployee = from employee in employees
                                where employee.Фамилия == surname
                                select employee;
            foreach (Сотрудник emp in queryEmployee)
            {
                ListEmployee.Add(emp);
            }
            if (ListEmployee.Count > 0)
            {
                DataGridEmployee.ItemsSource = ListEmployee;
                ButtonFindSurname.IsEnabled = true;
                ButtonFindTitle.IsEnabled = false;
            }
            else
                MessageBox.Show("Сотрудник с фамилией \n" + surname + "\n не найдан",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void ComboBoxTitle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonFindTitle.IsEnabled = true;
            ButtonFindSurname.IsEnabled = false;
            TextBoxSurname.Text = "";
        }

        private void ButtonFindTitle_Click(object sender, RoutedEventArgs e)
        {
            DataEntitiesEmployee = new Dohod_Kl_Ist202_VavilonskyEntities1();
            ListEmployee.Clear();

            Должность title = ComboBoxTitle.SelectedItem as Должность;
            var employees = DataEntitiesEmployee.Employees;
            var queryEmployee = from employee in employees
                                where employee.КодДолжности == title.КодДолжности
                                orderby employee.Фамилия
                                select employee;
            foreach (Сотрудник emp in queryEmployee)
            {
                ListEmployee.Add(emp);
            }
            DataGridEmployee.ItemsSource = ListEmployee;
        }

        private void RefreshCommandBinding_Executed(object sender,
ExecutedRoutedEventArgs e)
        {
            RewriteEmployee();
            DataGridEmployee.IsReadOnly = false;
            isDirty = true;
            BorderFind.Visibility = Visibility.Hidden;
        }

        private void TextBoxSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            ButtonFindSurname.IsEnabled = true;
            ButtonFindTitle.IsEnabled = false;
            ComboBoxTitle.SelectedIndex = -1;
        }
    }
}
