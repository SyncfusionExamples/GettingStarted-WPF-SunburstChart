using System.Collections.ObjectModel;

namespace SunburstChartWPF
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }
        public ViewModel()
        {
            Data = new ObservableCollection<Model>
            {
                new Model
                {
                    Country = "America", JobDescription = "Sales",
                    EmployeesCount = 70
                },
                new Model
                {
                    Country = "America", JobDescription = "Technical",
                    JobGroup = "Testers", EmployeesCount = 35
                },
                new Model
                {
                    Country = "America", JobDescription = "Technical",
                    JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 105
                },
                new Model
                {
                    Country = "America", JobDescription = "Technical",
                    JobGroup = "Developers", JobRole = "Web", EmployeesCount = 40
                },
                new Model
                {
                    Country = "America", JobDescription = "Management",
                    EmployeesCount = 40
                },
                new Model
                {
                    Country = "America", JobDescription = "Accounts",
                    EmployeesCount = 60
                },
                new Model
                {
                    Country = "India", JobDescription = "Technical",
                    JobGroup = "Testers", EmployeesCount = 25
                },
                new Model
                {
                    Country = "India", JobDescription = "Technical", JobGroup = "Developers",
                    JobRole = "Windows", EmployeesCount = 155
                },
                new Model
                {
                    Country = "India", JobDescription = "Technical", JobGroup = "Developers",
                    JobRole = "Web", EmployeesCount = 60
                },
                new Model
                {
                    Country = "Germany", JobDescription = "Sales", JobGroup = "Executive",
                    EmployeesCount = 30
                },
                new Model
                {
                    Country = "Germany", JobDescription = "Sales", JobGroup = "Analyst",
                    EmployeesCount = 40
                },
                new Model
                {
                    Country = "UK", JobDescription = "Technical", JobGroup = "Developers",
                    JobRole = "Windows", EmployeesCount = 100
                },
                new Model
                {
                    Country = "UK", JobDescription = "Technical", JobGroup = "Developers",
                    JobRole = "Web", EmployeesCount = 30
                },
                new Model
                {
                    Country = "UK", JobDescription = "HR Executives", EmployeesCount = 60
                },
                new Model
                {
                    Country = "UK", JobDescription = "Marketing", EmployeesCount = 40
                }
            };
        }
    }
}
