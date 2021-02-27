namespace WorkersManagementApp
{
    class Company
    {
        public string Name;
        public string Address;
        public string Email;
        public string NumberOfDept;
        public string ListOfDept;
        public string PhoneNumber;
        public int YearFounded;

        public Company(string empName, string empAddress, string empEmail, string empNumberOfDept, string empListOfDept, string empPhoneNumber, int empYearFounded)
        {
            Name = empName;
            Address = empAddress;
            Email = empEmail;
            NumberOfDept = empNumberOfDept;
            ListOfDept = empListOfDept;
            PhoneNumber = empPhoneNumber;
            YearFounded = empYearFounded;
        }


    }
}
