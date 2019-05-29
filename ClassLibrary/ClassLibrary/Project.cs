using System.Collections.Generic;

namespace Company
{
    public class Team
    {
        public int CountTeams = 0;
        public int CountMembers = 0;

        public Team(string a, string b)
        {
            string NameOfTeam = a;
            new SomeProject(NameOfTeam, b);
            CountTeams++;
        }

        List<Employee> NameOfTeam = new List<Employee>();
        
        public void Add(string name, string surname, int age, string company)
        {
            NameOfTeam.Add(new Employee(name, surname, age, company));
            CountMembers++;
        }

        public void Remove(int number)
        {
            int index = number - 1;
            NameOfTeam.RemoveAt(index);
            CountMembers--;
        }
    }


    public class SomeProject
    {
        public string NameOfTeam;
        public string NameOfProject;
        public SomeProject(string TeamName, string ProjectName)
        {
            NameOfTeam = TeamName;
            NameOfProject = ProjectName;
            CreateDataBase(NameOfProject, NameOfTeam);
        }

        Dictionary<string, string> projects = new Dictionary<string, string>();

        public void CreateDataBase(string NameOfProject, string NameOfTeam)
        {
            projects.Add(NameOfProject, NameOfTeam);
        }
    }

    public class Person
    {
        public string Name;
        public string Surname;
        public int Age;

        public Person(string Name, string Surname, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }
    }

    public class Employee:Person
    {
        public string Company;

        public Employee(string Name, string Surname, int Age, string Company):base(Name, Surname, Age)
        {
            this.Company = Company;
        }       
    }   
}
