using System;

namespace WorkersManagementApp
{
    public class Workers
    {
        public string Firstname;
        public string Lastname;
        public string StateOfOrigin;
        public string LGA;
        public string CurrentLocation;
        public string Street;
        public int HouseNumber;
        public string MaritalStatus;
        public string NextOfKin;
        public int Age;
        public string DateOfBirth;
        public string PhoneNumber;
        

        public void FullName()
        {
            Console.WriteLine(Firstname + " "+ Lastname);
        }

        public void Address()
        {
            Console.WriteLine(StateOfOrigin + "\n" + LGA + "\n" + CurrentLocation + "\n" + Street + "\n" + HouseNumber);
        }

        public void PersonalInfo()
        {
            Console.WriteLine(MaritalStatus + "\n" + NextOfKin + "\n" + Age + "\n" + DateOfBirth + "\n" + PhoneNumber);
        }
    

    }
}
