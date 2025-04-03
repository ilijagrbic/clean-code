namespace Victor.Training.Cleancode
{
    public class SRPExample
    {
        public void ComputePartialStatsAndLogIfNeeded(List<Employee> employees, int strartIndex, int endIndex, bool shouldLog, string computedStats)
        {
            double totalConsultantSalary = 0;
            List<int?> employeeIds = new List<int?>();

            for (int i = strartIndex; i<endIndex; i++)
            {
                var employee = employees[i];
                if (employee.Consultant)
                    totalConsultantSalary += employee.Salary ?? 0;
                employeeIds.Add(employee.Id);
            }

            if (shouldLog)
            {
                Console.WriteLine("Employee IDs: " + string.Join(", ", employeeIds));
            }

            computedStats = $"Total consultant salary: {totalConsultantSalary}; ids: {string.Join(", ", employeeIds)}";
        }
    }

    public class Employee
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public double? Salary { get; set; }
        public bool Consultant { get; set; }

        public Employee(int? id, string name, double? salary, bool consultant)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Consultant = consultant;
        }
    }


}

