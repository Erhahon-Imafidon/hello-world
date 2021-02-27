namespace WorkersManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Workers();
            employee.Firstname = "John";
            employee.Lastname = "Doe";
            employee.FullName();


            var address = new Workers();
            address.StateOfOrigin = "Edo";
            address.LGA = "Igueben";
            address.CurrentLocation = "Abuja";
            address.Street = "Oyomon";
            address.HouseNumber = 82;
            address.Address();


            var personalInfo = new Workers();
            personalInfo.MaritalStatus = "Single";
            personalInfo.NextOfKin = "Jane Doe";
            personalInfo.Age = 30;
            personalInfo.DateOfBirth = "01 - 10 - 1991";
            personalInfo.PhoneNumber = "0804-555-7849";
            personalInfo.PersonalInfo();

            System.Console.WriteLine();
            System.Console.WriteLine("Company:");


                var company = new Company("Sky Holdings, NIG.LTD.", "NO.2, Old Agbor Road Uromi Edo State", "skyholdings@gmail.com", "3", "Accounting, H.R, Safety", "0807-555-6029", 1992);

            System.Console.WriteLine(company.Name);
            System.Console.WriteLine(company.Address);
            System.Console.WriteLine(company.Email);
            System.Console.WriteLine(company.NumberOfDept);
            System.Console.WriteLine(company.ListOfDept);
            System.Console.WriteLine(company.PhoneNumber);
            System.Console.WriteLine(company.YearFounded);
        }
    }
}
