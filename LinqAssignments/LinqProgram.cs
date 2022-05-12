
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignments
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    internal class LinqProgram
    {
        public static List<Employee> empList = new List<Employee>
{
//new Employee() {EmployeeID = 1001,FirstName = "Malcolm",LastName = "Daruwalla",Title = "Manager",DOB = DateTime.Parse("1984-01-02"),DOJ = DateTime.Parse("2011-08-09"),City = "Mumbai"},
//new Employee() {EmployeeID = 1002,FirstName = "Asdin",LastName = "Dhalla",Title = "AsstManager",DOB = DateTime.Parse("1984-08-20"),DOJ = DateTime.Parse("2012-7-7"),City = "Mumbai"},
//new Employee() {EmployeeID = 1003,FirstName = "Madhavi",LastName = "Oza",Title = "Consultant",DOB = DateTime.Parse("1987/11/14"),DOJ = DateTime.Parse("2015/4/12"),City = "Pune"},
//new Employee() {EmployeeID = 1004,FirstName = "Saba",LastName = "Shaikh",Title = "SE",DOB = DateTime.Parse("1990/6/3"),DOJ = DateTime.Parse("2016/2/2"),City = "Pune"},
//new Employee() {EmployeeID = 1005,FirstName = "Nazia",LastName = "Shaikh",Title = "SE",DOB = DateTime.Parse("1991/3/8"),DOJ = DateTime.Parse("2016/2/2"),City = "Mumbai"},
//new Employee() {EmployeeID = 1006,FirstName = "Suresh",LastName = "Pathak",Title = "Consultant",DOB = DateTime.Parse("1998/11/7"),DOJ = DateTime.Parse("2014/8/8"),City = "Chennai"},
//new Employee() {EmployeeID = 1007,FirstName = "Vijay",LastName = "Natrajan",Title = "Consultant",DOB = DateTime.Parse("1989/12/2"),DOJ = DateTime.Parse("2015/6/1"),City = "Mumbai"},
//new Employee() {EmployeeID = 1008,FirstName = "Rahul",LastName = "Dubey",Title = "Associate",DOB = DateTime.Parse("1993/11/11"),DOJ = DateTime.Parse("2014/11/6"),City = "Chennai"},
//new Employee() {EmployeeID = 1009,FirstName = "Amit",LastName = "Mistry",Title = "Associate",DOB = DateTime.Parse("1992/8/12"),DOJ = DateTime.Parse("2014/12/3"),City = "Chennai"},
//new Employee() {EmployeeID = 1010,FirstName = "Sumit",LastName = "Shah",Title = "Manager",DOB = DateTime.Parse("1991/4/12"),DOJ = DateTime.Parse("2016/1/2"),City = "Pune"},



new Employee() {EmployeeID = 1001,FirstName = "Malcolm",LastName = "Daruwalla",Title = "Manager",DOB = DateTime.Parse("1984-01-02"),DOJ = DateTime.Parse("2011-08-09"),City = "Mumbai"},
new Employee() {EmployeeID = 1002,FirstName = "Asdin",LastName = "Dhalla",Title = "AsstManager",DOB = DateTime.Parse("1984-08-20"),DOJ = DateTime.Parse("2012-7-7"),City = "Mumbai"},
new Employee() {EmployeeID = 1003,FirstName = "Madhavi",LastName = "Oza",Title = "Consultant",DOB = DateTime.Parse("1987-11-14"),DOJ = DateTime.Parse("2015-4-12"),City = "Pune"},
new Employee() {EmployeeID = 1004,FirstName = "Saba",LastName = "Shaikh",Title = "SE",DOB = DateTime.Parse("6/3/1990"),DOJ = DateTime.Parse("2/2/2016"),City = "Pune"},
new Employee() {EmployeeID = 1005,FirstName = "Nazia",LastName = "Shaikh",Title = "SE",DOB = DateTime.Parse("3/8/1991"),DOJ = DateTime.Parse("2/2/2016"),City = "Mumbai"},
new Employee() {EmployeeID = 1006,FirstName = "Suresh",LastName = "Pathak",Title = "Consultant",DOB = DateTime.Parse("11/7/1989"),DOJ = DateTime.Parse("8/8/2014"),City = "Chennai"},
new Employee() {EmployeeID = 1007,FirstName = "Vijay",LastName = "Natrajan",Title = "Consultant",DOB = DateTime.Parse("12/2/1989"),DOJ = DateTime.Parse("6/1/2015"),City = "Mumbai"},
new Employee() {EmployeeID = 1008,FirstName = "Rahul",LastName = "Dubey",Title = "Associate",DOB = DateTime.Parse("11/11/1993"),DOJ = DateTime.Parse("11/6/2014"),City = "Chennai"},
new Employee() {EmployeeID = 1009,FirstName = "Amit",LastName = "Mistry",Title = "Associate",DOB = DateTime.Parse("8/12/1992"),DOJ = DateTime.Parse("12/3/2014"),City = "Chennai"},
new Employee() {EmployeeID = 1010,FirstName = "Sumit",LastName = "Shah",Title = "Manager",DOB = DateTime.Parse("4/12/1991"),DOJ = DateTime.Parse("1/2/2016"),City = "Pune"},




};
        static void Main(string[] args)
        {
            Console.WriteLine("\n-----------Display All Employee--------------\n");
            DisplayAll();
            Console.WriteLine("\n-----------Location Not Mumbai------------\n");
            NotMumbai();
            Console.WriteLine("\n------------Title AsstManager------------\n");
            TitleAsstManager();
            Console.WriteLine("\n--------------Last Name Start with S-------------\n");
            LastNameS();
            Console.WriteLine("\n--------------Joined Date before 1/1/2015-------------\n");
            JoinedDateBefore();
            Console.WriteLine("\n--------------Date of Birth After 1/1/1990-------------\n");
            DOBAfter();
            Console.WriteLine("\n----------Designation is Consultant and Associate-------\n");
            Designation();
            Console.WriteLine("\n----------Total number of Employees-------\n");
            TotalNoEmployee();
            Console.WriteLine("\n----------Employees belonging to Chennai-------\n");
            BelongChennai();
            Console.WriteLine("\n----------Highest Employee Id-------\n");
            HighEmpId();
            Console.WriteLine("\n----------Total no of Employees joined after 1/1/2015-------\n");
            EmpJoinedAfter();
            Console.WriteLine("\n----------Employeee whose designation is not Associate-------\n");
            NotAssociate();
            Console.WriteLine("\n----------Total Employees based on City-------\n");
            TotalEmpBasedCity();
            Console.WriteLine("\n----------Total Employees based on City and Title-------\n");
            TotalEmpBasedCitynTitle();

            Console.ReadKey();
        }
        public static void DisplayAll()
        {
            var displayallemployee = from emp in empList
                        select emp;
            foreach (var emp in displayallemployee)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB + " " + emp.DOJ + " " + emp.City);
            }
        }
        public static void NotMumbai()
        {
            var NotMumbaiList = (from emp in empList where emp.City != "Mumbai" select emp);
            foreach (var emp in NotMumbaiList)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB + " " + emp.DOJ + " " + emp.City);
            }

        }
        public static void TitleAsstManager()
        {
            var TitleAsstManagerlist = (from emp in empList where emp.Title == "AsstManager" select emp);
            foreach (var emp in TitleAsstManagerlist)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB + " " + emp.DOJ + " " + emp.City);
            }

        }
        public static void LastNameS()
        {
            var LastNameSList = (from emp in empList where emp.LastName.StartsWith('S'+"") select emp);
            foreach (var emp in LastNameSList)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB + " " + emp.DOJ + " " + emp.City);

            }
        }
        public static void JoinedDateBefore()
        {
            var JoinedDateBeforeList = (from emp in empList where emp.DOJ < DateTime.Parse("1/1/2015") select emp);
            foreach (var emp in JoinedDateBeforeList)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB + " " + emp.DOJ + " " + emp.City);

            }
        }
        public static void DOBAfter()
        {
            var JoinedDateBeforeList = (from emp in empList where emp.DOB > DateTime.Parse("1/1/1990") select emp);
            foreach (var emp in JoinedDateBeforeList)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB + " " + emp.DOJ + " " + emp.City);

            }
        }
        public static void Designation()
        {
            var DesignationList = (from emp in empList where emp.Title == "Consultant"  select emp);
            foreach (var emp in DesignationList)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB + " " + emp.DOJ + " " + emp.City);               
            }
            var DesignationList2 = (from emp in empList where emp.Title == "Associate" select emp);
            foreach (var emp in DesignationList2)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB + " " + emp.DOJ + " " + emp.City);
            }
        }
        public static void TotalNoEmployee()
        {
            var TotalNoEmployee = empList.Count();
            Console.WriteLine("Total No. Of Employees: {0}",TotalNoEmployee);   
        }
        public static void BelongChennai()
        {
            var BelongChennaiList = (from emp in empList where emp.City == "Chennai" select emp);
            foreach (var emp in BelongChennaiList)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB + " " + emp.DOJ + " " + emp.City);
            }
        }
         public static void HighEmpId()
         {
             //var HighEmpId = empList.Max();
             //var oldest = studentList.Max(s => s.Age);
             //var HighEmpId = (from emp in empList where emp.EmployeeID =Max() select emp);
             var HighEmpId = empList.Max(emp => emp.EmployeeID);
             Console.WriteLine("Highest Employee Id: {0}", HighEmpId);
         }
        
        public static void EmpJoinedAfter()
        {
            var JoinedDateBeforeList = (from emp in empList where emp.DOJ > DateTime.Parse("1/1/2015") select emp);
            foreach (var emp in JoinedDateBeforeList)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB + " " + emp.DOJ + " " + emp.City);               
            }
            Console.WriteLine("\n Total No. Of Employees Joined after 1/1/2015: {0}", JoinedDateBeforeList.Count());
        }
        public static void NotAssociate()
        {
            var NotAssociateList = (from emp in empList where emp.Title != "Associate" select emp);
            foreach (var emp in NotAssociateList)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB + " " + emp.DOJ + " " + emp.City);
            }
        }
        public static void TotalEmpBasedCity()
        {
            var TotalEmpBasedCityList = (from emp in empList group emp by emp.City);

            //iterate each group        
            foreach (var CityGroup in TotalEmpBasedCityList)
            {
                Console.WriteLine("\nCity Group: {0}", CityGroup.Key); //Each group has a key 

                foreach (var emp in CityGroup) // Each group has inner collection
                    Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB + " " + emp.DOJ + " " + emp.City);
            }
        }
        public static void TotalEmpBasedCitynTitle()
        {
            var TotalEmpBasedCityList = (from emp in empList group emp by emp.City);

            //iterate each group        
            foreach (var CityGroup in TotalEmpBasedCityList)
            {
                Console.WriteLine("\nCity Group: {0}", CityGroup.Key); //Each group has a key 

                foreach (var emp in CityGroup) // Each group has inner collection
                    Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB + " " + emp.DOJ + " " + emp.City);
            }
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - -");
            var TotalEmpBasedCityList2 = (from emp in empList group emp by emp.Title);
            //iterate each group        
            foreach (var TitleGroup in TotalEmpBasedCityList2)
            {
                Console.WriteLine("\nTitle Group: {0}", TitleGroup.Key); //Each group has a key 

                foreach (var emp in TitleGroup) // Each group has inner collection
                    Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB + " " + emp.DOJ + " " + emp.City);
            }

        }

    }
}
