using System;

namespace OOPLab4._1
{
    class Student
    {
        private string Name;
        private string LastName;
        private string Group;
        private int Year;
        private string Adress;
        private double Passport;
        private int Age;
        private string Telephon;
        private double Rating;
        public Student()
        {

        }
        public void setName()
        {
            Name = "Олександр";
        }
        public string getName()
        {
            return Name;
        }
        public void setLastName()
        {                   
            LastName = "Симулик";            
        }
        public string getLastName()
        {
            return LastName;
        }
        public void setGroup()
        {            
            Group = "IТ-11";            
        }
        public string getGroup()
        {
            return Group;
        }
        public void setYear()
        {                                               
            Year = 2019;            
        }
        public int getYear()
        {
            return Year;
        }
        public void setAdress()
        {           
             Adress = "Мечнiкова, 31";           
        }
        public string getAdress()
        {
            return Adress;
        }
        public void setPassport()
        {           
            Passport = 7668;            
        }
        public double getPassport()
        {
            return Passport;
        }
        public void setAge()
        {           
             Age = 17;            
        }
        public int getAge()
        {
            return Age;
        }
        public void setTelephon()
        {                        
             Telephon = "+380500758979";            
        }
        public string getTelephon()
        {
            return Telephon;
        }
        public void setRating()
        {                 
             Rating = 84.83;            
        }
        public double getRating()
        {
            return Rating;
        }
        public void print()
        {
            Console.WriteLine("Iм'я: " + Name);
            Console.WriteLine("Прiзвище: " + LastName);
            Console.WriteLine("Група: " + Group);
            Console.WriteLine("Рiк: " + Year);
            Console.WriteLine("Адреса: " + Adress);
            Console.WriteLine("ID паспорту: " + Passport);
            Console.WriteLine("Вiк: " + Age);
            Console.WriteLine("Телефон: " + Telephon);
            Console.WriteLine("Рейтинг: " + Rating);

        }
        public void StudentRating()
        {
            double R = Rating;
            if (R >= 90) Console.WriteLine("\nВітаємо відмінника!");
            else if ((R >= 75) && (R < 90)) Console.WriteLine("\nМожна вчитися краще");
            else Console.WriteLine("\nВарто бiльше уваги придiляти навчанню");            
        }
        public static void Main()
        {
            Student s1 = new Student();
            s1.setName();
            s1.getName();
            s1.setLastName();
            s1.getLastName();
            s1.setGroup();
            s1.getGroup();
            s1.setYear();
            s1.getYear();
            s1.setAdress();
            s1.getAdress();
            s1.setPassport();
            s1.getPassport();
            s1.setAge();
            s1.getAge();
            s1.setTelephon();
            s1.getTelephon();
            s1.setRating();
            s1.getRating();
            s1.print();
            s1.StudentRating();
        }
    }
}
