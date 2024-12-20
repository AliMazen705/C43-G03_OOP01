namespace Ass01OOP
{
    #region 1- Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum
    //enum WeekDays
    //{
    //    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    //}
    #endregion
    #region 2- Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
    //struct Person
    //{
    //    public string Name;
    //    public int Age;
    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}
    #endregion
    #region 3- Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
    //enum Season
    //{
    //    Spring,Summer,Autumn,Winter
    //}
    #endregion
    #region 4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum
    [Flags]
    enum Permissions
    {
        Read, Write, Delete, Execute
    }

    #endregion
    #region 5-  Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
    enum Colors
    {
        Red, Green, Blue
    }
    #endregion
    #region 6- Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
    //struct Point
    //{
    //    public double X { get; set; }
    //    public double Y { get; set; }

    //    public Point(double x, double y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public double Distance(Point p)
    //    {
    //        double dx = p.X - X;
    //        double dy = p.Y - Y;
    //        return  Math.Sqrt( dx * dx + dy * dy);
    //    }
    //}
    #endregion
    #region 7- Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person
    //struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Person(string name, int age)
    //    {
    //       Name = name;
    //        Age = age;
    //    }
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //foreach(WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region q2
            //Person[] people = new Person[3];
            //people[0] = new Person("Ali", 20);
            //people[1] = new Person("Nada", 20);
            //people[2] = new Person("Anas", 15);
            //foreach (var Person in people)
            //{
            //    Console.WriteLine($"Name:{Person.Name},Age{Person.Age}");
            //}
            #endregion
            #region q3
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();


            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}

            #endregion
            #region q4

            //Permissions userPermissions = Permissions.Read | Permissions.Write;
            //Console.WriteLine($"Current Permissions: {userPermissions}");


            //userPermissions |= Permissions.Delete;
            //Console.WriteLine($"Added Delete: {userPermissions}");


            //userPermissions &= ~Permissions.Write;
            //Console.WriteLine($"Removed Write: {userPermissions}");


            //if ((userPermissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("User has Read permission.");
            //}
            //else
            //{
            //    Console.WriteLine("User does not have Read permission.");
            //}


            #endregion
            #region q5
            //Console.Write("Enter A Coolor Name: ");
            //string str = Console.ReadLine();
            //if (Enum.TryParse(str, true, out Colors color))
            //    Console.WriteLine($"{color} Is A Primary Color.");

            //else
            //    Console.WriteLine($"{str} Is Not A Primary Color");

            #endregion
            #region q6
            //Console.WriteLine("Enter The Coordinates Of The First Point (X Y):");
            //string[] point1Input = Console.ReadLine().Split(' ');
            //double d01 = double.Parse(point1Input[0]);
            //double d02 = double.Parse(point1Input[1]);
            //Point point1 = new Point(d01, d02);
            //Console.WriteLine("Enter The Coordinates Of The Second Point (X Y):");
            //string[] point2Input = Console.ReadLine().Split(' ');
            //double d11 = double.Parse(point2Input[0]);
            //double d12 = double.Parse(point2Input[1]);
            //Point point2 = new Point(d11, d12);

            //double distance = point1.Distance(point2);

            //Console.WriteLine($"The Distance Between The Two Points Is: {distance:F2}");
            #endregion
            #region q7
            //Person[] person = new Person[3];

            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine($"Enter Details For Person: {i + 1}");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int age = int.Parse(Console.ReadLine());
            //    person[i] = new Person(name, age);
            //}
            //Person oldPerson = person[0];
            //foreach (Person p in person)
            //{
            //    if(p.Age > oldPerson.Age )
            //      oldPerson = p;
            //}
            //Console.WriteLine($"The Oldest Person Is {oldPerson.Name} with {oldPerson.Age} years.");
            #endregion
        }
    }
}
