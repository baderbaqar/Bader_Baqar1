using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ===============================
// Exercise 17 - University Members
// ===============================

class Person
{
    public string Name;

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
    }
}

class Student : Person
{
    public int StudentId;

    public override void DisplayInfo()
    {
        Console.WriteLine("Student - Name: " + Name +
                          ", Student ID: " + StudentId);
    }
}

class Employee : Person
{
    public double Salary;

    public override void DisplayInfo()
    {
        Console.WriteLine("Employee - Name: " + Name +
                          ", Salary: " + Salary);
    }
}

class Teacher : Person
{
    public string CourseName;

    public override void DisplayInfo()
    {
        Console.WriteLine("Teacher - Name: " + Name +
                          ", Course: " + CourseName);
    }
}


// ===============================
// Exercise 18 - Shape Areas
// ===============================

class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }
}

class Circle : Shape
{
    public double Radius;

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width;
    public double Height;

    public override double CalculateArea()
    {
        return Width * Height;
    }
}


// ===============================
// Main Program
// ===============================

class Program
{
    // Method accepts Person
    static void ShowPerson(Person person)
    {
        person.DisplayInfo();
    }

    static void Main()
    {
        // ===========================
        // Exercise 17
        // ===========================

        Console.WriteLine("===== Exercise 17: University Members =====");

        List<Person> people = new List<Person>();

        Student student = new Student();
        student.Name = "Ahmed";
        student.StudentId = 101;

        Employee employee = new Employee();
        employee.Name = "Ali";
        employee.Salary = 5000;

        Teacher teacher = new Teacher();
        teacher.Name = "Sara";
        teacher.CourseName = "Programming";

        people.Add(student);
        people.Add(employee);
        people.Add(teacher);

        foreach (Person person in people)
        {
            person.DisplayInfo();

            Console.WriteLine("Runtime Type: " +
                              person.GetType().Name);

            Console.WriteLine();
        }

        Console.WriteLine("Using ShowPerson Method:");

        ShowPerson(student);
        ShowPerson(employee);
        ShowPerson(teacher);


        // ===========================
        // Exercise 18
        // ===========================

        Console.WriteLine();
        Console.WriteLine("===== Exercise 18: Shape Areas =====");

        List<Shape> shapes = new List<Shape>();

        Circle circle = new Circle();
        circle.Radius = 5;

        Rectangle rectangle = new Rectangle();
        rectangle.Width = 10;
        rectangle.Height = 4;

        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Runtime Type: " +
                              shape.GetType().Name);

            Console.WriteLine("Area: " +
                              shape.CalculateArea());

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}