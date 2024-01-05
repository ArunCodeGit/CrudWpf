using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace DsmSoftExercises.ApplicationDbContext
{
    public class Employee : INotifyPropertyChanged
    {
        int _empId;
        string _empName;
        string _designation;
        int _deptId;
        int _salary;

        public int EmpId
        {
            get { return _empId; }
            set { _empId = value; OnPropertyChanged("EmpId"); }
        }
        public string EmpName
        {
            get { return _empName; }
            set { _empName= value; OnPropertyChanged("EmpName"); }
        }
        public string Designation
        {
            get { return _designation; }
            set { _designation = value; OnPropertyChanged("Designation"); }
        }
        public int DeptId
        {
            get { return _deptId;}
            set { _deptId = value; OnPropertyChanged("DeptId"); }
        }
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; OnPropertyChanged("Salary"); }
        }

        static string connectionString = "DATA SOURCE=ARUNKUMAR\\SQLEXPRESS; INITIAL CATALOG=Company; Integrated security=True; TrustServerCertificate=True; ";
        
        SqlConnection Connection = new SqlConnection(connectionString);

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public Employee() { }

        public Employee(int Id)
        {
            this._empId = Id;
        }

        public Employee(string name, string design, int did, int salary)
        {
            this._empName = name;
            this._deptId = did;
            this._designation = design;
            this._salary = salary;
        }

        public Employee(int eid,string name, string design, int did, int salary)
        {
            this._empId = eid;
            this._empName = name;
            this._deptId = did;
            this._designation = design;
            this._salary = salary;
        }

        public void AddEmployee(Employee employee)
        {
            string empTbl = $"INSERT INTO Employee VALUES('" + employee.EmpName + "', '" + employee.Designation + "', " + employee.DeptId + ");";
            string SalaryTbl = $"INSERT INTO Salary VALUES(" + employee.Salary + ");";
            Execute_Non_query(empTbl);
            Execute_Non_query(SalaryTbl);
        }

        public void UpdateEmployee(Employee employee)
        {
            string empTbl = $"UPDATE Employee SET EmpName='{employee._empName}', Designation='{employee._designation}', DeptId={employee._deptId} WHERE EmpId={employee._empId}";
            string salaryTbl = $"UPDATE Salary SET Salary={employee._salary} WHERE EmpId={employee._empId};";
            Execute_Non_query(empTbl);
            Execute_Non_query(salaryTbl);
        }

        public void RemoveEmployee(Employee employee)
        {
            string salaryTbl = $"DELETE FROM Salary WHERE EmpID = {employee._empId};";
            string empTbl = $"DELETE FROM Employee WHERE EmpID = {employee._empId};";
            Execute_Non_query(salaryTbl);
            Execute_Non_query(empTbl);
        }

        public void Execute_Non_query(string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, Connection))
            {
                Connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { throw new Exception(ex.Message, ex.InnerException); }
                finally { Connection.Close(); } 
            }
        }
    }
}
