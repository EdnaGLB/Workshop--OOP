namespace Domain
{
    abstract class User
    {
        private string Name;
        private int Age;
        private string Ssn;
        private string Role;

         public string GetName(string Name)
        {
            this.Name = Name;
            return Name;
        }
         public int GetAge(int Age)
        {
            this.Age = Age;
            return Age;
        }
         public string GetSsn(string Ssn)
        {
            this.Ssn = Ssn;
            return Ssn;
        }
         public string GetRole(string Role)
        {
            this.Role = Role;
            return Role;
        }
        public void UserInformation(string name, int age, string ssn, string role)
        {
            this.Name = name;
            this.Age = age;
            this.Ssn = ssn;
            this.Role = role;
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(ssn);
            Console.WriteLine(role);
        }
    }

}