using GabesConsoleApp.HR;

namespace GabesConsoleApp.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void PerformWork_Adds_NumberOfHours()
        {
            Employee employee = new Employee("Maday", "Guzman", "mdygbrl@gmail.com", new DateTime(2000, 8, 21), 30);

            int numberOfHours = 3;

            employee.PerformWork(numberOfHours);

            Assert.Equal(numberOfHours, employee.NumberOfHoursWorked);
        }

        [Fact]
        public void PerformWork_Adds_DefaultNumberOfHours_IfNoValueSpecified()
        {
            Employee employee = new Employee("Maday", "Guzman", "mdygbrl@gmail.com", new DateTime(2000, 8, 21), 30);

            employee.PerformWork();

            Assert.Equal(1, employee.NumberOfHoursWorked);
        }
    }
}