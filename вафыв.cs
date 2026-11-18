using System;
using System.Collections.Generic;
using System.Linq;

// ==================== 1. ANIMALS ====================

class Animal1
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog1 : Animal1
{
    public override void Speak()
    {
        Console.WriteLine("Dog says: Woof!");
    }
}

class Cat1 : Animal1
{
    public override void Speak()
    {
        Console.WriteLine("Cat says: Meow!");
    }
}


// ==================== 2. TRANSPORT ====================

class Vehicle2
{
    public string Brand;
    public int Speed;

    public Vehicle2(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }
}

class Car2 : Vehicle2
{
    public int Doors;

    public Car2(string brand, int speed, int doors)
        : base(brand, speed)
    {
        Doors = doors;
    }
}

class Motorcycle2 : Vehicle2
{
    public bool HasSidecar;

    public Motorcycle2(string brand, int speed, bool hasSidecar)
        : base(brand, speed)
    {
        HasSidecar = hasSidecar;
    }
}


// ==================== 3. PERSON AND STUDENT ====================

class Person3
{
    public string Name;
    public int Age;

    public Person3(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Student3 : Person3
{
    public string Major;
    public int Course;

    public Student3(string name, int age, string major, int course)
        : base(name, age)
    {
        Major = major;
        Course = course;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Major: {Major}, Course: {Course}");
    }
}


// ==================== 4. EMPLOYEES ====================

class Employee4
{
    public string Name;
    public double Salary;

    public Employee4(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
}

class Manager4 : Employee4
{
    public int TeamSize;

    public Manager4(string name, double salary, int teamSize)
        : base(name, salary)
    {
        TeamSize = teamSize;
    }
}

class Developer4 : Employee4
{
    public string ProgrammingLanguage;

    public Developer4(string name, double salary, string language)
        : base(name, salary)
    {
        ProgrammingLanguage = language;
    }
}


// ==================== 5. SHAPES ====================

class Shape5
{
    public virtual double GetArea()
    {
        return 0;
    }
}

class Rectangle5 : Shape5
{
    public double Width;
    public double Height;

    public Rectangle5(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Circle5 : Shape5
{
    public double Radius;

    public Circle5(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}


// ==================== 6. TRANSPORT MOVEMENT ====================

class Vehicle6
{
    public virtual void Move()
    {
        Console.WriteLine("Vehicle is moving");
    }
}

class Car6 : Vehicle6
{
    public override void Move()
    {
        Console.WriteLine("Car drives on the road");
    }
}

class Bus6 : Vehicle6
{
    public override void Move()
    {
        Console.WriteLine("Bus carries passengers");
    }
}

class Train6 : Vehicle6
{
    public override void Move()
    {
        Console.WriteLine("Train moves on rails");
    }
}


// ==================== 7. STORE WORKERS ====================

class Worker7
{
    public string Name;
    public string Position;

    public Worker7(string name, string position)
    {
        Name = name;
        Position = position;
    }
}

class Cashier7 : Worker7
{
    public Cashier7(string name)
        : base(name, "Cashier")
    {
    }
}

class Seller7 : Worker7
{
    public Seller7(string name)
        : base(name, "Seller")
    {
    }
}


// ==================== 8. COMPUTERS ====================

class Computer8
{
    public string Processor;
    public int RAM;

    public Computer8(string processor, int ram)
    {
        Processor = processor;
        RAM = ram;
    }
}

class Laptop8 : Computer8
{
    public double ScreenSize;

    public Laptop8(string processor, int ram, double screenSize)
        : base(processor, ram)
    {
        ScreenSize = screenSize;
    }
}

class Desktop8 : Computer8
{
    public bool HasRGB;

    public Desktop8(string processor, int ram, bool hasRGB)
        : base(processor, ram)
    {
        HasRGB = hasRGB;
    }
}


// ==================== 9. BOOKS ====================

class Book9
{
    public string Title;
    public string Author;

    public Book9(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

class PaperBook9 : Book9
{
    public int Pages;

    public PaperBook9(string title, string author, int pages)
        : base(title, author)
    {
        Pages = pages;
    }
}

class EBook9 : Book9
{
    public double FileSize;

    public EBook9(string title, string author, double fileSize)
        : base(title, author)
    {
        FileSize = fileSize;
    }
}


// ==================== 10. PETS ====================

class Pet10
{
    public virtual void Eat()
    {
        Console.WriteLine("Pet is eating");
    }
}

class Dog10 : Pet10
{
    public override void Eat()
    {
        Console.WriteLine("Dog eats meat");
    }
}

class Cat10 : Pet10
{
    public override void Eat()
    {
        Console.WriteLine("Cat eats fish");
    }
}

class Parrot10 : Pet10
{
    public override void Eat()
    {
        Console.WriteLine("Parrot eats seeds");
    }
}


// ==================== 11. BANK ACCOUNTS ====================

class BankAccount11
{
    protected double Balance;

    public BankAccount11(double balance)
    {
        Balance = balance;
    }

    public virtual void Deposit(double amount)
    {
        Balance += amount;
    }

    public virtual void Withdraw(double amount)
    {
        if (amount <= Balance)
            Balance -= amount;
        else
            Console.WriteLine("Not enough money");
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Balance: {Balance}");
    }
}

class SavingsAccount11 : BankAccount11
{
    public double InterestRate = 0.05;

    public SavingsAccount11(double balance)
        : base(balance)
    {
    }

    public void AddInterest()
    {
        Balance += Balance * InterestRate;
    }
}

class CreditAccount11 : BankAccount11
{
    public double CreditLimit = 10000;

    public CreditAccount11(double balance)
        : base(balance)
    {
    }

    public override void Withdraw(double amount)
    {
        if (Balance - amount >= -CreditLimit)
            Balance -= amount;
        else
            Console.WriteLine("Credit limit exceeded");
    }
}


// ==================== 12. TRANSPORT COMPANY ====================

class Transport12
{
    public virtual double CalculateCost(double distance)
    {
        return distance;
    }
}

class Car12 : Transport12
{
    public override double CalculateCost(double distance)
    {
        return distance * 10;
    }
}

class Truck12 : Transport12
{
    public override double CalculateCost(double distance)
    {
        return distance * 20;
    }
}

class Bus12 : Transport12
{
    public override double CalculateCost(double distance)
    {
        return distance * 15;
    }
}


// ==================== 13. COMPANY EMPLOYEES ====================

class Employee13
{
    public double BaseSalary;

    public Employee13(double salary)
    {
        BaseSalary = salary;
    }

    public virtual double GetSalary()
    {
        return BaseSalary;
    }
}

class Programmer13 : Employee13
{
    public int Projects;

    public Programmer13(double salary, int projects)
        : base(salary)
    {
        Projects = projects;
    }

    public override double GetSalary()
    {
        return BaseSalary + Projects * 500;
    }
}

class Designer13 : Employee13
{
    public int Designs;

    public Designer13(double salary, int designs)
        : base(salary)
    {
        Designs = designs;
    }

    public override double GetSalary()
    {
        return BaseSalary + Designs * 300;
    }
}

class Manager13 : Employee13
{
    public int Employees;

    public Manager13(double salary, int employees)
        : base(salary)
    {
        Employees = employees;
    }

    public override double GetSalary()
    {
        return BaseSalary + Employees * 400;
    }
}


// ==================== 14. EDUCATION SYSTEM ====================

class Person14
{
    public string Name;
    public int Age;

    public Person14(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Student14 : Person14
{
    public string Major;
    public int Course;

    public Student14(string name, int age, string major, int course)
        : base(name, age)
    {
        Major = major;
        Course = course;
    }
}

class GraduateStudent14 : Student14
{
    public string Thesis;

    public GraduateStudent14(
        string name,
        int age,
        string major,
        int course,
        string thesis)
        : base(name, age, major, course)
    {
        Thesis = thesis;
    }

    public void ShowInfo()
    {
        Console.WriteLine(
            $"Name: {Name}, Age: {Age}, Major: {Major}, Course: {Course}, Thesis: {Thesis}");
    }
}


// ==================== 15. MILITARY VEHICLES ====================

class MilitaryVehicle15
{
    public virtual void Attack()
    {
        Console.WriteLine("Military vehicle attacks");
    }
}

class Tank15 : MilitaryVehicle15
{
    public override void Attack()
    {
        Console.WriteLine("Tank fires its cannon");
    }
}

class Helicopter15 : MilitaryVehicle15
{
    public override void Attack()
    {
        Console.WriteLine("Helicopter launches missiles");
    }
}

class ArmoredCar15 : MilitaryVehicle15
{
    public override void Attack()
    {
        Console.WriteLine("Armored car attacks with a machine gun");
    }
}


// ==================== 16. GAME CHARACTERS ====================

class Character16
{
    public string Name;
    public int Health;
    public int Damage;

    public Character16(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{Name} attacks for {Damage} damage");
    }
}

class Warrior16 : Character16
{
    public Warrior16(string name)
        : base(name, 150, 30)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} attacks with a sword for {Damage} damage");
    }
}

class Mage16 : Character16
{
    public Mage16(string name)
        : base(name, 80, 50)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} casts a fireball for {Damage} damage");
    }
}

class Archer16 : Character16
{
    public Archer16(string name)
        : base(name, 100, 40)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} shoots an arrow for {Damage} damage");
    }
}


// ==================== 17. ELECTRONIC DEVICES ====================

class Device17
{
    public virtual void TurnOn()
    {
        Console.WriteLine("Device is turned on");
    }

    public virtual void TurnOff()
    {
        Console.WriteLine("Device is turned off");
    }
}

class Phone17 : Device17
{
    public override void TurnOn()
    {
        Console.WriteLine("Phone is turned on");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Phone is turned off");
    }
}

class Computer17 : Device17
{
    public override void TurnOn()
    {
        Console.WriteLine("Computer is turned on");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Computer is turned off");
    }
}

class Television17 : Device17
{
    public override void TurnOn()
    {
        Console.WriteLine("Television is turned on");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Television is turned off");
    }
}


// ==================== 18. PAYMENTS ====================

class Payment18
{
    public virtual void Pay(double amount)
    {
        Console.WriteLine($"Payment: {amount}");
    }
}

class CashPayment18 : Payment18
{
    public override void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using cash");
    }
}

class CardPayment18 : Payment18
{
    public override void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using card");
    }
}

class OnlinePayment18 : Payment18
{
    public override void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} online");
    }
}


// ==================== 19. EMPLOYEES WITH BONUSES ====================

class Employee19
{
    public double Salary;

    public Employee19(double salary)
    {
        Salary = salary;
    }

    public virtual double GetTotalSalary()
    {
        return Salary;
    }
}

class Manager19 : Employee19
{
    public Manager19(double salary)
        : base(salary)
    {
    }

    public override double GetTotalSalary()
    {
        return Salary + Salary * 0.20;
    }
}

class Developer19 : Employee19
{
    public Developer19(double salary)
        : base(salary)
    {
    }

    public override double GetTotalSalary()
    {
        return Salary + Salary * 0.10;
    }
}

class SalesManager19 : Employee19
{
    public SalesManager19(double salary)
        : base(salary)
    {
    }

    public override double GetTotalSalary()
    {
        return Salary + Salary * 0.30;
    }
}


// ==================== 20. ZOO ANIMALS ====================

class Animal20
{
    public virtual void Eat()
    {
        Console.WriteLine("Animal eats");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Lion20 : Animal20
{
    public override void Eat()
    {
        Console.WriteLine("Lion eats meat");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Lion: Roar!");
    }
}

class Elephant20 : Animal20
{
    public override void Eat()
    {
        Console.WriteLine("Elephant eats grass");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Elephant: Trumpet!");
    }
}

class Monkey20 : Animal20
{
    public override void Eat()
    {
        Console.WriteLine("Monkey eats fruit");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Monkey: Ooh ooh!");
    }
}

class Tiger20 : Animal20
{
    public override void Eat()
    {
        Console.WriteLine("Tiger eats meat");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Tiger: Roar!");
    }
}

class Giraffe20 : Animal20
{
    public override void Eat()
    {
        Console.WriteLine("Giraffe eats leaves");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Giraffe makes a low sound");
    }
}


// ============================================================
//                  ADVANCED LEVEL
// ============================================================


// ==================== 21. ABSTRACT SHAPES ====================

abstract class Shape21
{
    public abstract double GetArea();
}

class Circle21 : Shape21
{
    public double Radius;

    public Circle21(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle21 : Shape21
{
    public double Width;
    public double Height;

    public Rectangle21(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Triangle21 : Shape21
{
    public double Base;
    public double Height;

    public Triangle21(double b, double h)
    {
        Base = b;
        Height = h;
    }

    public override double GetArea()
    {
        return Base * Height / 2;
    }
}

class Square21 : Shape21
{
    public double Side;

    public Square21(double side)
    {
        Side = side;
    }

    public override double GetArea()
    {
        return Side * Side;
    }
}


// ==================== 22. ONLINE STORE ====================

class Product22
{
    public string Name;
    public double Price;

    public Product22(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public virtual double GetFinalPrice()
    {
        return Price;
    }
}

class Electronics22 : Product22
{
    public Electronics22(string name, double price)
        : base(name, price)
    {
    }

    public override double GetFinalPrice()
    {
        return Price * 1.10;
    }
}

class Clothing22 : Product22
{
    public Clothing22(string name, double price)
        : base(name, price)
    {
    }

    public override double GetFinalPrice()
    {
        return Price * 0.90;
    }
}

class Food22 : Product22
{
    public Food22(string name, double price)
        : base(name, price)
    {
    }

    public override double GetFinalPrice()
    {
        return Price;
    }
}


// ==================== 23. TRANSPORT SYSTEM ====================

abstract class Transport23
{
    public abstract void Move();
    public abstract double GetFuelConsumption();
}

class Car23 : Transport23
{
    public override void Move()
    {
        Console.WriteLine("Car moves on the road");
    }

    public override double GetFuelConsumption()
    {
        return 8;
    }
}

class Truck23 : Transport23
{
    public override void Move()
    {
        Console.WriteLine("Truck moves with cargo");
    }

    public override double GetFuelConsumption()
    {
        return 20;
    }
}

class Bus23 : Transport23
{
    public override void Move()
    {
        Console.WriteLine("Bus transports passengers");
    }

    public override double GetFuelConsumption()
    {
        return 15;
    }
}

class Motorcycle23 : Transport23
{
    public override void Move()
    {
        Console.WriteLine("Motorcycle moves quickly");
    }

    public override double GetFuelConsumption()
    {
        return 4;
    }
}


// ==================== 24. HOSPITAL ====================

class MedicalWorker24
{
    public string Name;

    public MedicalWorker24(string name)
    {
        Name = name;
    }

    public virtual void Work()
    {
        Console.WriteLine($"{Name} works in hospital");
    }
}

class Doctor24 : MedicalWorker24
{
    public Doctor24(string name)
        : base(name)
    {
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} diagnoses patients");
    }
}

class Nurse24 : MedicalWorker24
{
    public Nurse24(string name)
        : base(name)
    {
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} takes care of patients");
    }
}

class Surgeon24 : MedicalWorker24
{
    public Surgeon24(string name)
        : base(name)
    {
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} performs surgery");
    }
}


// ==================== 25. LEVELS OF INHERITANCE ====================

class Person25
{
    public string Name;
    public int Age;

    public Person25(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"My name is {Name}");
    }
}

class Employee25 : Person25
{
    public string Company;
    public double Salary;

    public Employee25(string name, int age, string company, double salary)
        : base(name, age)
    {
        Company = company;
        Salary = salary;
    }

    public void Work()
    {
        Console.WriteLine($"{Name} works at {Company}");
    }
}

class Manager25 : Employee25
{
    public int TeamSize;
    public string Department;

    public Manager25(
        string name,
        int age,
        string company,
        double salary,
        int teamSize,
        string department)
        : base(name, age, company, salary)
    {
        TeamSize = teamSize;
        Department = department;
    }

    public void Manage()
    {
        Console.WriteLine($"{Name} manages {TeamSize} employees");
    }
}

class Director25 : Manager25
{
    public string Office;
    public int YearsOfExperience;

    public Director25(
        string name,
        int age,
        string company,
        double salary,
        int teamSize,
        string department,
        string office,
        int yearsOfExperience)
        : base(name, age, company, salary, teamSize, department)
    {
        Office = office;
        YearsOfExperience = yearsOfExperience;
    }

    public void LeadCompany()
    {
        Console.WriteLine($"{Name} leads the company");
    }
}


// ==================== 26. GAME CHARACTERS ====================

abstract class Character26
{
    public string Name;
    public int Health;

    public Character26(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public abstract void Attack();
    public abstract void Defend();
    public abstract void SpecialAttack();
}

class Warrior26 : Character26
{
    public Warrior26(string name)
        : base(name, 150)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} attacks with a sword");
    }

    public override void Defend()
    {
        Console.WriteLine($"{Name} blocks with a shield");
    }

    public override void SpecialAttack()
    {
        Console.WriteLine($"{Name} uses powerful sword strike");
    }
}

class Mage26 : Character26
{
    public Mage26(string name)
        : base(name, 90)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} attacks with magic");
    }

    public override void Defend()
    {
        Console.WriteLine($"{Name} creates a magic shield");
    }

    public override void SpecialAttack()
    {
        Console.WriteLine($"{Name} uses a huge fireball");
    }
}

class Archer26 : Character26
{
    public Archer26(string name)
        : base(name, 110)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} shoots an arrow");
    }

    public override void Defend()
    {
        Console.WriteLine($"{Name} dodges the attack");
    }

    public override void SpecialAttack()
    {
        Console.WriteLine($"{Name} shoots three arrows");
    }
}


// ==================== 27. FILES ====================

class File27
{
    public string Name;
    public double Size;

    public File27(string name, double size)
    {
        Name = name;
        Size = size;
    }

    public virtual void Open()
    {
        Console.WriteLine($"Opening {Name}");
    }
}

class TextFile27 : File27
{
    public TextFile27(string name, double size)
        : base(name, size)
    {
    }

    public override void Open()
    {
        Console.WriteLine($"Opening text file: {Name}");
    }
}

class ImageFile27 : File27
{
    public ImageFile27(string name, double size)
        : base(name, size)
    {
    }

    public override void Open()
    {
        Console.WriteLine($"Opening image file: {Name}");
    }
}

class VideoFile27 : File27
{
    public VideoFile27(string name, double size)
        : base(name, size)
    {
    }

    public override void Open()
    {
        Console.WriteLine($"Playing video file: {Name}");
    }
}


// ==================== 28. SALARY SYSTEM ====================

abstract class Employee28
{
    public string Name;

    public Employee28(string name)
    {
        Name = name;
    }

    public abstract double CalculateSalary();
}

class HourlyEmployee28 : Employee28
{
    public double Hours;
    public double HourRate;

    public HourlyEmployee28(string name, double hours, double rate)
        : base(name)
    {
        Hours = hours;
        HourRate = rate;
    }

    public override double CalculateSalary()
    {
        return Hours * HourRate;
    }
}

class SalariedEmployee28 : Employee28
{
    public double MonthlySalary;

    public SalariedEmployee28(string name, double salary)
        : base(name)
    {
        MonthlySalary = salary;
    }

    public override double CalculateSalary()
    {
        return MonthlySalary;
    }
}

class CommissionEmployee28 : Employee28
{
    public double Sales;
    public double CommissionRate;

    public CommissionEmployee28(
        string name,
        double sales,
        double commissionRate)
        : base(name)
    {
        Sales = sales;
        CommissionRate = commissionRate;
    }

    public override double CalculateSalary()
    {
        return Sales * CommissionRate;
    }
}


// ==================== 29. POLYMORPHISM ====================

class Animal29
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog29 : Animal29
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog: Woof!");
    }
}

class Cat29 : Animal29
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat: Meow!");
    }
}

class Cow29 : Animal29
{
    public override void MakeSound()
    {
        Console.WriteLine("Cow: Moo!");
    }
}

class Horse29 : Animal29
{
    public override void MakeSound()
    {
        Console.WriteLine("Horse: Neigh!");
    }
}

class Duck29 : Animal29
{
    public override void MakeSound()
    {
        Console.WriteLine("Duck: Quack!");
    }
}


// ==================== 30. VEHICLE PARK ====================

abstract class Vehicle30
{
    public string Brand { get; set; }
    public double Speed { get; set; }
    public double Price { get; set; }

    public Vehicle30(string brand, double speed, double price)
    {
        Brand = brand;
        Speed = speed;
        Price = price;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine(
            $"Brand: {Brand}, Speed: {Speed} km/h, Price: {Price}");
    }

    public abstract double CalculateFuelConsumption();
}

class Car30 : Vehicle30
{
    public int Doors { get; set; }

    public Car30(
        string brand,
        double speed,
        double price,
        int doors)
        : base(brand, speed, price)
    {
        Doors = doors;
    }

    public override void ShowInfo()
    {
        Console.WriteLine(
            $"Car: {Brand}, Speed: {Speed}, Price: {Price}, Doors: {Doors}");
    }

    public override double CalculateFuelConsumption()
    {
        return 8;
    }
}

class Truck30 : Vehicle30
{
    public double LoadCapacity { get; set; }

    public Truck30(
        string brand,
        double speed,
        double price,
        double loadCapacity)
        : base(brand, speed, price)
    {
        LoadCapacity = loadCapacity;
    }

    public override void ShowInfo()
    {
        Console.WriteLine(
            $"Truck: {Brand}, Speed: {Speed}, Price: {Price}, Load: {LoadCapacity} tons");
    }

    public override double CalculateFuelConsumption()
    {
        return 20;
    }
}

class Bus30 : Vehicle30
{
    public int Seats { get; set; }

    public Bus30(
        string brand,
        double speed,
        double price,
        int seats)
        : base(brand, speed, price)
    {
        Seats = seats;
    }

    public override void ShowInfo()
    {
        Console.WriteLine(
            $"Bus: {Brand}, Speed: {Speed}, Price: {Price}, Seats: {Seats}");
    }

    public override double CalculateFuelConsumption()
    {
        return 15;
    }
}

class ElectricCar30 : Vehicle30
{
    public double BatteryCapacity { get; set; }

    public ElectricCar30(
        string brand,
        double speed,
        double price,
        double batteryCapacity)
        : base(brand, speed, price)
    {
        BatteryCapacity = batteryCapacity;
    }

    public override void ShowInfo()
    {
        Console.WriteLine(
            $"Electric Car: {Brand}, Speed: {Speed}, Price: {Price}, Battery: {BatteryCapacity} kWh");
    }

    public override double CalculateFuelConsumption()
    {
        return 0;
    }
}

class Motorcycle30 : Vehicle30
{
    public bool HasABS { get; set; }

    public Motorcycle30(
        string brand,
        double speed,
        double price,
        bool hasABS)
        : base(brand, speed, price)
    {
        HasABS = hasABS;
    }

    public override void ShowInfo()
    {
        Console.WriteLine(
            $"Motorcycle: {Brand}, Speed: {Speed}, Price: {Price}, ABS: {HasABS}");
    }

    public override double CalculateFuelConsumption()
    {
        return 4;
    }
}


// ============================================================
//                         MAIN
// ============================================================

class Program
{
    static void Main()
    {
        Console.WriteLine("===== 1. ANIMALS =====");
        Animal1 dog1 = new Dog1();
        Animal1 cat1 = new Cat1();
        dog1.Speak();
        cat1.Speak();


        Console.WriteLine("\n===== 2. TRANSPORT =====");
        Car2 car2 = new Car2("Toyota", 180, 4);
        Motorcycle2 motorcycle2 = new Motorcycle2("Honda", 220, false);
        Console.WriteLine($"Car: {car2.Brand}, Speed: {car2.Speed}, Doors: {car2.Doors}");
        Console.WriteLine($"Motorcycle: {motorcycle2.Brand}, Speed: {motorcycle2.Speed}, Sidecar: {motorcycle2.HasSidecar}");


        Console.WriteLine("\n===== 3. PERSON AND STUDENT =====");
        Student3 student3 = new Student3(
            "Alex",
            18,
            "Software Development",
            2);
        student3.ShowInfo();


        Console.WriteLine("\n===== 4. EMPLOYEES =====");
        Manager4 manager4 = new Manager4("John", 5000, 10);
        Developer4 developer4 = new Developer4("Mike", 4500, "C#");
        Console.WriteLine($"Manager: {manager4.Name}, Salary: {manager4.Salary}, Team: {manager4.TeamSize}");
        Console.WriteLine($"Developer: {developer4.Name}, Salary: {developer4.Salary}, Language: {developer4.ProgrammingLanguage}");


        Console.WriteLine("\n===== 5. SHAPES =====");
        Shape5 rectangle5 = new Rectangle5(10, 5);
        Shape5 circle5 = new Circle5(5);
        Console.WriteLine($"Rectangle area: {rectangle5.GetArea()}");
        Console.WriteLine($"Circle area: {circle5.GetArea():F2}");


        Console.WriteLine("\n===== 6. TRANSPORT MOVEMENT =====");
        List<Vehicle6> vehicles6 = new List<Vehicle6>
        {
            new Car6(),
            new Bus6(),
            new Train6()
        };

        foreach (Vehicle6 vehicle in vehicles6)
            vehicle.Move();


        Console.WriteLine("\n===== 7. STORE WORKERS =====");
        Cashier7 cashier7 = new Cashier7("Anna");
        Seller7 seller7 = new Seller7("Tom");
        Console.WriteLine($"{cashier7.Name} - {cashier7.Position}");
        Console.WriteLine($"{seller7.Name} - {seller7.Position}");


        Console.WriteLine("\n===== 8. COMPUTERS =====");
        Laptop8 laptop8 = new Laptop8("Intel i5", 16, 15.6);
        Desktop8 desktop8 = new Desktop8("Ryzen 7", 32, true);
        Console.WriteLine($"Laptop: {laptop8.Processor}, {laptop8.RAM} GB RAM, {laptop8.ScreenSize} inch");
        Console.WriteLine($"Desktop: {desktop8.Processor}, {desktop8.RAM} GB RAM, RGB: {desktop8.HasRGB}");


        Console.WriteLine("\n===== 9. BOOKS =====");
        PaperBook9 paperBook9 = new PaperBook9(
            "The Hobbit",
            "J.R.R. Tolkien",
            310);

        EBook9 eBook9 = new EBook9(
            "1984",
            "George Orwell",
            2.5);

        Console.WriteLine($"Paper book: {paperBook9.Title}, {paperBook9.Author}, {paperBook9.Pages} pages");
        Console.WriteLine($"E-book: {eBook9.Title}, {eBook9.Author}, {eBook9.FileSize} MB");


        Console.WriteLine("\n===== 10. PETS =====");
        List<Pet10> pets10 = new List<Pet10>
        {
            new Dog10(),
            new Cat10(),
            new Parrot10()
        };

        foreach (Pet10 pet in pets10)
            pet.Eat();


        Console.WriteLine("\n===== 11. BANK ACCOUNTS =====");
        SavingsAccount11 savings = new SavingsAccount11(10000);
        savings.Deposit(2000);
        savings.AddInterest();
        savings.ShowBalance();

        CreditAccount11 credit = new CreditAccount11(1000);
        credit.Withdraw(5000);
        credit.ShowBalance();


        Console.WriteLine("\n===== 12. TRANSPORT COMPANY =====");
        Transport12[] transports12 =
        {
            new Car12(),
            new Truck12(),
            new Bus12()
        };

        foreach (Transport12 transport in transports12)
            Console.WriteLine($"Cost for 100 km: {transport.CalculateCost(100)}");


        Console.WriteLine("\n===== 13. COMPANY EMPLOYEES =====");
        Employee13[] employees13 =
        {
            new Programmer13(5000, 3),
            new Designer13(4500, 4),
            new Manager13(6000, 5)
        };

        foreach (Employee13 employee in employees13)
            Console.WriteLine($"Salary: {employee.GetSalary()}");


        Console.WriteLine("\n===== 14. EDUCATION SYSTEM =====");
        GraduateStudent14 graduate = new GraduateStudent14(
            "David",
            23,
            "Computer Science",
            5,
            "Artificial Intelligence");

        graduate.ShowInfo();


        Console.WriteLine("\n===== 15. MILITARY VEHICLES =====");
        MilitaryVehicle15[] militaryVehicles =
        {
            new Tank15(),
            new Helicopter15(),
            new ArmoredCar15()
        };

        foreach (MilitaryVehicle15 vehicle in militaryVehicles)
            vehicle.Attack();


        Console.WriteLine("\n===== 16. GAME CHARACTERS =====");
        Character16[] characters16 =
        {
            new Warrior16("Warrior"),
            new Mage16("Mage"),
            new Archer16("Archer")
        };

        foreach (Character16 character in characters16)
            character.Attack();


        Console.WriteLine("\n===== 17. ELECTRONIC DEVICES =====");
        Device17[] devices17 =
        {
            new Phone17(),
            new Computer17(),
            new Television17()
        };

        foreach (Device17 device in devices17)
        {
            device.TurnOn();
            device.TurnOff();
        }


        Console.WriteLine("\n===== 18. PAYMENTS =====");
        Payment18[] payments18 =
        {
            new CashPayment18(),
            new CardPayment18(),
            new OnlinePayment18()
        };

        foreach (Payment18 payment in payments18)
            payment.Pay(100);


        Console.WriteLine("\n===== 19. EMPLOYEES WITH BONUSES =====");
        Employee19[] employees19 =
        {
            new Manager19(5000),
            new Developer19(5000),
            new SalesManager19(5000)
        };

        foreach (Employee19 employee in employees19)
            Console.WriteLine($"Total salary: {employee.GetTotalSalary()}");


        Console.WriteLine("\n===== 20. ZOO ANIMALS =====");
        Animal20[] zoo =
        {
            new Lion20(),
            new Elephant20(),
            new Monkey20(),
            new Tiger20(),
            new Giraffe20()
        };

        foreach (Animal20 animal in zoo)
        {
            animal.Eat();
            animal.MakeSound();
        }


        Console.WriteLine("\n===== 21. ABSTRACT SHAPES =====");
        Shape21[] shapes21 =
        {
            new Circle21(5),
            new Rectangle21(10, 4),
            new Triangle21(8, 6),
            new Square21(5)
        };

        foreach (Shape21 shape in shapes21)
            Console.WriteLine($"Area: {shape.GetArea():F2}");


        Console.WriteLine("\n===== 22. ONLINE STORE =====");
        Product22[] products22 =
        {
            new Electronics22("Laptop", 1000),
            new Clothing22("T-Shirt", 100),
            new Food22("Bread", 5)
        };

        foreach (Product22 product in products22)
            Console.WriteLine($"{product.Name}: {product.GetFinalPrice():F2}");


        Console.WriteLine("\n===== 23. TRANSPORT SYSTEM =====");
        Transport23[] transports23 =
        {
            new Car23(),
            new Truck23(),
            new Bus23(),
            new Motorcycle23()
        };

        foreach (Transport23 transport in transports23)
        {
            transport.Move();
            Console.WriteLine(
                $"Fuel consumption: {transport.GetFuelConsumption()} L/100km");
        }


        Console.WriteLine("\n===== 24. HOSPITAL =====");
        MedicalWorker24[] medicalWorkers =
        {
            new Doctor24("Dr. Smith"),
            new Nurse24("Anna"),
            new Surgeon24("Dr. Brown")
        };

        foreach (MedicalWorker24 worker in medicalWorkers)
            worker.Work();


        Console.WriteLine("\n===== 25. LEVELS OF INHERITANCE =====");
        Director25 director = new Director25(
            "Robert",
            50,
            "Tech Company",
            15000,
            20,
            "Development",
            "Office 501",
            25);

        director.Introduce();
        director.Work();
        director.Manage();
        director.LeadCompany();

        Console.WriteLine($"Age: {director.Age}");
        Console.WriteLine($"Company: {director.Company}");
        Console.WriteLine($"Salary: {director.Salary}");
        Console.WriteLine($"Team size: {director.TeamSize}");
        Console.WriteLine($"Department: {director.Department}");
        Console.WriteLine($"Office: {director.Office}");
        Console.WriteLine($"Experience: {director.YearsOfExperience} years");


        Console.WriteLine("\n===== 26. GAME CHARACTERS =====");
        Character26[] characters26 =
        {
            new Warrior26("Warrior"),
            new Mage26("Mage"),
            new Archer26("Archer")
        };

        foreach (Character26 character in characters26)
        {
            character.Attack();
            character.Defend();
            character.SpecialAttack();
        }


        Console.WriteLine("\n===== 27. FILES =====");
        File27[] files27 =
        {
            new TextFile27("document.txt", 2),
            new ImageFile27("photo.jpg", 5),
            new VideoFile27("movie.mp4", 1000)
        };

        foreach (File27 file in files27)
            file.Open();


        Console.WriteLine("\n===== 28. SALARY SYSTEM =====");
        List<Employee28> employees28 = new List<Employee28>
        {
            new HourlyEmployee28("John", 160, 20),
            new SalariedEmployee28("Mike", 4000),
            new CommissionEmployee28("Anna", 50000, 0.10)
        };

        double totalSalary = 0;

        foreach (Employee28 employee in employees28)
        {
            double salary = employee.CalculateSalary();
            Console.WriteLine($"{employee.Name}: {salary}");
            totalSalary += salary;
        }

        Console.WriteLine($"Total payroll: {totalSalary}");


        Console.WriteLine("\n===== 29. POLYMORPHISM =====");
        List<Animal29> animals29 = new List<Animal29>
        {
            new Dog29(),
            new Cat29(),
            new Cow29(),
            new Horse29(),
            new Duck29()
        };

        foreach (Animal29 animal in animals29)
            animal.MakeSound();


        Console.WriteLine("\n===== 30. VEHICLE PARK =====");

        List<Vehicle30> vehiclePark = new List<Vehicle30>
        {
            new Car30("Toyota", 200, 25000, 4),
            new Truck30("Volvo", 160, 80000, 20),
            new Bus30("Mercedes", 140, 100000, 50),
            new ElectricCar30("Tesla", 250, 70000, 100),
            new Motorcycle30("Yamaha", 280, 18000, true)
        };

        Console.WriteLine("\n--- All vehicles ---");

        foreach (Vehicle30 vehicle in vehiclePark)
        {
            vehicle.ShowInfo();
            Console.WriteLine(
                $"Fuel consumption: {vehicle.CalculateFuelConsumption()}");
        }

        // Add vehicle
        vehiclePark.Add(
            new Car30("BMW", 240, 60000, 4));

        Console.WriteLine("\n--- After adding BMW ---");

        foreach (Vehicle30 vehicle in vehiclePark)
            Console.WriteLine(vehicle.Brand);

        // Remove vehicle
        Vehicle30 vehicleToRemove = vehiclePark
            .FirstOrDefault(v => v.Brand == "BMW");

        if (vehicleToRemove != null)
            vehiclePark.Remove(vehicleToRemove);

        Console.WriteLine("\n--- After removing BMW ---");

        foreach (Vehicle30 vehicle in vehiclePark)
            Console.WriteLine(vehicle.Brand);

        // Find fastest vehicle
        Vehicle30 fastestVehicle = vehiclePark
            .OrderByDescending(v => v.Speed)
            .First();

        Console.WriteLine(
            $"\nFastest vehicle: {fastestVehicle.Brand} - {fastestVehicle.Speed} km/h");

        // Find most expensive vehicle
        Vehicle30 mostExpensive = vehiclePark
            .OrderByDescending(v => v.Price)
            .First();

        Console.WriteLine(
            $"Most expensive vehicle: {mostExpensive.Brand} - {mostExpensive.Price}");

        Console.WriteLine("\n===== ALL 30 TASKS COMPLETED =====");
    }
}