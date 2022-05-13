using AppDbFirst.Models;
using System;
using System.Linq;
using System.Text;

namespace AppDbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SoftUniContext();
            //var result_zad1 = AllEmployeesNames(context);
            //Console.WriteLine(result_zad1);

            //var result2 = HighestSalary(context);
            //Console.WriteLine(result2);

            //var result3_zad2 = GetEmployeesWithSalaryOver50000(context);
            //Console.WriteLine(result3_zad2);

            //var result4_zad3 = AllEmployeesFromResearchAndDevelopmentDepartment(context);
            //Console.WriteLine(result4_zad3);

            //var result6_zad4 = NumberOfEmployees(context);
            //Console.WriteLine(result6_zad4);

            //var result6_zad5 = GetEmployeesWithFirstNameStartWithN(context);
            //Console.WriteLine(result6_zad5);

            //var result5_zad6 = GetFirstTenEmployeesWithDepartment(context);
            //Console.WriteLine(result5_zad6);

            //var result5_zad7 = GetEmployeesFromSalesAndMarketing(context);
            //Console.WriteLine(result5_zad7);

            //var result5_zad8 = GetAllEmployeesWorkingOnClassicVestProject(context);
            //Console.WriteLine(result5_zad8);

            //AddNewProject(context);
            AddEmployeeWithProject(context);
        }

        public static void AddEmployeeWithProject(SoftUniContext context)
        {
            var employee = new Employee
            {
                FirstName = "Ani",
                LastName = "Ivanova",
                JobTitle = "Designer",
                HireDate = DateTime.UtcNow,
                Salary = 2000,
                DepartmentId = 2
            };
            context.Employees.Add(employee);
            employee.EmployeesProjects.Add(new EmployeesProject
            {
                Project = new Project
                {
                    Name = "TTT",
                    StartDate = DateTime.UtcNow
                }
            });
            context.SaveChanges();
        }

        public static void AddNewProject(SoftUniContext context)
        {
            var project = new Project()
            {
                Name = "Judge System",
                StartDate = DateTime.UtcNow
            };
            context.Projects.Add(project);
            context.SaveChanges();
        }

        public static string GetAllEmployeesWorkingOnClassicVestProject(SoftUniContext context)
        {
            var emloyees = context.EmployeesProjects.OrderBy(x => x.ProjectId)
                .Select(x => new
                {
                    employeeName = x.Employee.FirstName + " " + x.Employee.LastName,
                    projectName = x.Project.Name
                }
                )
                .Where(x => x.projectName == "Classic Vest").ToList();

            var sb = new StringBuilder();
            foreach (var employee in emloyees)
            {
                sb.AppendLine($"{employee.employeeName} {employee.projectName}");
            }
            return sb.ToString().TrimEnd();
        }

        private static object GetEmployeesFromSalesAndMarketing(SoftUniContext context)
        {
            var listOfSalaries = context.Employees
                .Where(x => x.Department.Name == "Sales" || x.Department.Name == "Marketing")
                .Select(x => new { x.FirstName, x.LastName, DepartmentName = x.Department.Name, x.Salary })
                .OrderBy(x => x.DepartmentName).ThenByDescending(x => x.Salary).ToList();
            var sb = new StringBuilder();
            foreach (var s in listOfSalaries)
            {
                sb.AppendLine($"{s.FirstName} {s.LastName} from {s.DepartmentName} - ${s.Salary:F2}");
            }
            return sb.ToString().TrimEnd();
        }

        private static object GetEmployeesWithFirstNameStartWithN(SoftUniContext context)
        {
            var employees = context.Employees.Where(x => x.FirstName.StartsWith("N"))
                .Select(x => new { x.FirstName, x.LastName, x.Salary })
                .OrderByDescending(x => x.Salary).ToList();

            var sb = new StringBuilder();
            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.Salary:f2}");
            }
            return sb.ToString().TrimEnd();


        }

        private static int NumberOfEmployees(SoftUniContext context)
        {
            var numberOfEmployees = context.Employees.Count();
            return numberOfEmployees;
        }

        private static object GetFirstTenEmployeesWithDepartment(SoftUniContext context)
        {
            var employees = context.Employees.Select(x => new { x.FirstName, x.LastName, DepartmentName = x.Department.Name })
                .OrderBy(x => x.FirstName).ThenBy(x => x.LastName).Take(10).ToList();

            var sb = new StringBuilder();
            foreach (var employee in employees)
            {
                sb.Append($"{employee.FirstName} {employee.LastName} {employee.DepartmentName}");
            }
            return sb.ToString().TrimEnd();
        }

        private static object AllEmployeesFromResearchAndDevelopmentDepartment(SoftUniContext context)
        {
            var listOfSalaries = context.Employees.Where(x => x.Department.Name == "Research and Development").Select(x => new { x.FirstName, x.LastName, x.Salary, DepartmentName = x.Department.Name, }).OrderBy(x => x.Salary).OrderByDescending(x => x.FirstName).ToList();
            var sb = new StringBuilder();
            foreach (var s in listOfSalaries)
            {
                sb.AppendLine($"{s.FirstName} {s.LastName} from {s.DepartmentName} - ${s.Salary:F2}");
            }
            return sb.ToString().TrimEnd();
        }

        private static object GetEmployeesWithSalaryOver50000_3(SoftUniContext context)
        {
            var listOfSalaries = context.Employees.Select(x => new { x.FirstName, x.Salary, }).OrderBy(x => x.FirstName).Where(x => x.Salary > 50000).ToList();
            var sb = new StringBuilder();
            foreach (var s in listOfSalaries)
            {
                sb.AppendLine($"{s.FirstName} - {s.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }

        private static object HighestSalary2(SoftUniContext context)
        {
            var listOfSalaries = context.Employees.Select(x => new { x.FirstName, x.JobTitle, x.Salary, x.DepartmentId }).OrderByDescending(x => x.Salary).ToList();
            var sb = new StringBuilder();
            foreach (var s in listOfSalaries)
            {
                sb.AppendLine($"{s.FirstName} {s.JobTitle} {s.Salary} {s.DepartmentId}");
            }
            return sb.ToString().TrimEnd();
        }

        private static object AllEmployeesNames(SoftUniContext context)
        {
            var listOfEmployees = context.Employees
                .Select(x => new
                { x.EmployeeId, x.FirstName, x.LastName, x.MiddleName, })
                .OrderBy(x => x.EmployeeId).ToList();
            var sb = new StringBuilder();
            foreach (var e in listOfEmployees)
            {
                sb.AppendLine($"{e.EmployeeId} {e.FirstName} {e.LastName} {e.MiddleName}");
            }
            return sb.ToString().TrimEnd();
        }



    }
}
