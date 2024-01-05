using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer;

namespace DsmSoftExercises.ApplicationDbContext
{
    public class DbContext
    {
        static string connectionString = "DATA SOURCE=ARUNKUMAR\\SQLEXPRESS; INITIAL CATALOG=Company; Integrated security=True; TrustServerCertificate=True; ";

        public ObservableCollection<Employee> employees { get; set; }
        public ObservableCollection<Department> departments { get; set; }
        SqlConnection Connection = new SqlConnection(connectionString);
        Exception exp = new Exception();

        public DbContext()
        {
            employees = new ObservableCollection<Employee>();
            departments = new ObservableCollection<Department>();
            Load_Employees();
            Load_Department();
        }

        public void Load_Employees(int id = 0)
        {
            string query = string.Empty;
            if(id == 0)
            {
                query = "SELECT E.EmpId, E.EmpName, E.Designation, E.DeptId, S.Salary FROM Employee E INNER JOIN Salary S ON E.EmpId = S.EmpId;";
            }
            else
            {
                query = $"SELECT E.EmpId, E.EmpName, E.Designation, E.DeptId, S.Salary FROM Employee E INNER JOIN Salary S ON E.EmpId = S.EmpId WHERE DeptID = {id};";
            }
            using (SqlCommand cmd = new SqlCommand(query, Connection))
            {
                employees.Clear();
                try
                {
                    Connection.Open();
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        employees.Add(new Employee()
                        { 
                            EmpId = reader.GetInt32(0), 
                            EmpName = reader.GetString(1), 
                            Designation = reader.GetString(2), 
                            DeptId = reader.GetInt32(3),
                            Salary = reader.GetInt32(4)
                        });
                        
                    }
                }
                catch
                {
                    throw new Exception(exp.Message, exp.InnerException);
                }
                finally { Connection.Close(); }
            }
        }

        public DataTable Load_Department()
        {
            string query = query = "SELECT * FROM Department;";
            DataTable dataTable = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query, Connection))
            {
                try
                {
                    Connection.Open();
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        departments.Add(new Department()
                        {
                            DeptId = reader.GetInt32(0),
                            DeptName = reader.GetString(1)
                        });
                    }
                }
                catch
                {
                    throw new Exception(exp.Message, exp.InnerException);
                }
                finally { Connection.Close(); }
            }
            return dataTable;
        }
    }
}
