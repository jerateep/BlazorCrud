using System.Collections.Generic;
using System.Linq;
using BlazorCrud.Models;

namespace BlazorCrud.Data
{
    public class EmployeeService
    {
        private readonly AppDBContext _db;
        public EmployeeService(AppDBContext db)
        {
            _db = db;
        }
        // Get All Employee
        public List<Employee> GetEmployee()
        {
            var EmpList = _db.Employee.ToList();
            return EmpList;
        }
        // Insert
        public string Create(Employee objEmployee)
        {
            string Result = "";
            try
            {
                _db.Employee.Add(objEmployee);
                _db.SaveChanges();
                Result = "OK";                
            }
            catch (System.Exception ex)
            {                
                Result = ex.Message;
            }
            return Result;
        }
        // Get Employee By ID
        public Employee GetEmployeeById(int Empid)
        {
            Employee employee = _db.Employee.FirstOrDefault(c => c.EmpId == Empid);
            return employee;
        }
        // Update
        public string UpdateEmployee(Employee objEmployee)
        {
            string Result = "";
            try
            {
                _db.Employee.Update(objEmployee);
                _db.SaveChanges();
                Result = "OK";                
            }
            catch (System.Exception ex)
            {                
                Result = ex.Message;
            }
            return Result;
        }
        // Delete
        public string DeleteEmployee(Employee objEmployee)
        {
            string Result = "";
            try
            {
                _db.Employee.Remove(objEmployee);
                _db.SaveChanges();
                Result = "OK";                
            }
            catch (System.Exception ex)
            {                
                Result = ex.Message;
            }
            return Result;
        }

    }
}