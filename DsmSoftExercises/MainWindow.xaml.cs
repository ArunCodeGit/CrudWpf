using DsmSoftExercises.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace DsmSoftExercises
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationDbContext.DbContext context;
        Employee employee;
        public MainWindow()
        {
            InitializeComponent();
            context = new DbContext();
            employee = new Employee();

            this.DataContext = context;
        }

        private void SelectDept(object sender, SelectionChangedEventArgs e)
        {
            var value = sender as ComboBox;
            int tempID = 0;
            var obj = value.SelectedValue as Department;
            if (obj != null)
            {
                tempID = obj.DeptId;
            }
            context.Load_Employees(tempID);
        }

        private void InsertNew(object sender, RoutedEventArgs e)
        {
            string Name = TxtEmpName.Text;
            string Design = TxtDesign.Text;
            int deptID = Convert.ToInt32(TxtDeptID.Text);
            int salary = Convert.ToInt32(TxtSalary.Text);

            employee = new Employee(Name, Design, deptID, salary);

            employee.AddEmployee(employee);
            this.DataContext = new DbContext();
            MessageBox.Show("Record Inserted successfully.");
            Clear();
        }

        private void UpdateExists(object sender, RoutedEventArgs e)
        {
            int ID = Convert.ToInt32(TxtEmpId.Text);
            string Name = TxtEmpName.Text;
            string Design = TxtDesign.Text;
            int deptID = Convert.ToInt32(TxtDeptID.Text);
            int salary = Convert.ToInt32(TxtSalary.Text);

            employee = new Employee(ID, Name, Design, deptID, salary);
            employee.UpdateEmployee(employee);
            this.DataContext = new DbContext();
            MessageBox.Show("Employee records updated.");
            Clear();
        }

        private void RemoveExists(object sender, RoutedEventArgs e)
        {
            int ID = Convert.ToInt32(TxtEmpId.Text);

            employee = new Employee(ID);
            employee.RemoveEmployee(employee);
            this.DataContext = new DbContext();
            MessageBox.Show("Employee records removed.");
            Clear();
        }

        private void ClearTxt(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        public void Clear()
        {

            TxtDeptID.Text = " ";
            TxtEmpId.Text = " ";
            TxtEmpName.Text = " ";
            TxtSalary.Text = " ";
            TxtDesign.Text = " ";
        }
    }
}
