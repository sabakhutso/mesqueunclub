#region Homework 4
//      homework 4
//Console.BackgroundColor = ConsoleColor.DarkBlue;
//Console.WriteLine("Saba Khutsidze");

//Console.Write("Please Enter The Club You Support:");
//string Clubinput = Console.ReadLine();
//Console.WriteLine("Your Club Is " + Clubinput);

//Console.WriteLine("Please Enter The Position:");
//string Positioninput = Console.ReadLine();
//Console.WriteLine("Your Position Is " + Positioninput);

#endregion

#region Homework 5
//              homework 5
//                Task 1
//Console.WriteLine("vnaxot  iyofa tuara ricxvi 5 ze");
//Console.Write("sheiyvanet ricxvi: ");
//string ricxviinput = Console.ReadLine();
//int ricxvi = int.Parse(ricxviinput);
//if (ricxvi % 5 == 0) 
//    {
//    Console.WriteLine("ricxvi iyofa 5 ze");
//}
//else
//{
//    Console.WriteLine("ricxvi ar iyofa xutze");
//}


//              Task 2  
//Console.WriteLine("Insert X");
//string xinput = Console.ReadLine();

//Console.WriteLine("Insert Y ");
//string yinput = Console.ReadLine();

//var x = int.Parse(xinput);
//var y = int.Parse(yinput);

//Console.WriteLine(x + y);

//if (x > y) 
//{
//    Console.WriteLine(x - y);

//}
//else
//{
//    Console.WriteLine(y - x);
//}

//Console.WriteLine(x * y);

//if (x == 0)
//{
//    Console.WriteLine("Not Allowed To Divide By Zero");
//}
//else
//{
//    Console.WriteLine(x/y);
//}

//if (y == 0)
//{
//    Console.WriteLine("Not Allowed To Divide By Zero");
//}
//else
//{
//    Console.WriteLine(x / y);
//}

//                              Task 3

//Console.WriteLine("Insert x Number");
//string xnumberinput = Console.ReadLine();
//int firstnumber = int.Parse(xnumberinput);

//Console.WriteLine("Insert y Number");
//string ynumberinput = Console.ReadLine();
//int secondnumber = int.Parse(ynumberinput);

//int temp = firstnumber;   ტემპ დავგუგლე სხვა გზით ვერ ვაკეთებდი
//firstnumber = secondnumber;
//secondnumber = temp;

//Console.WriteLine($"x = {firstnumber}, y = {secondnumber}"); 

//                          Task 4

//Console.WriteLine("Insert Number ");
//string numberinput = Console.ReadLine();
//int number = int.Parse(numberinput);

//for (int i = 1; i <=9 ; i++)
//{
//    int result = number * i;
//    Console.WriteLine($"{number} * {i} = {result}");
//}

//                          Task 5
//Console.WriteLine("Insert Number");
//string numberinput = Console.ReadLine();
//int number = int.Parse(numberinput);

//for (int i=1; i < number; i++ )
//{
//    if ( i % 2 == 0 )
//    {
//        int kvadrati = i * i;
//        Console.WriteLine(kvadrati);
//    }
//}
#endregion

#region Homework 6
//        Task 1    
//Console.Write("sheiyvanet masivis sigrdze :");
//int n = int.Parse(Console.ReadLine()!);

//int[] numbers = new int[n];

//Console.WriteLine($"sheiyvanet {n} elementi :");
//string input = Console.ReadLine()!;
//string[] inputNumbers = input.Split(' ');

//for (int i = 0; i < n; i++)
//{
//    numbers[i] = int.Parse(inputNumbers[i]);
//}

//List<int> luwi = new List<int>();
//List<int> kenti = new List<int>();

//foreach (int number in numbers)
//{
//    if (number % 2 == 0)
//    {
//        luwi.Add(number); 
//    }
//    else
//    {
//        kenti.Add(number); 
//    }
//}

//Console.WriteLine();
//Console.Write("masivi 1: ");
//for (int i = 0; i < luwi.Count; i++)
//{
//    Console.Write(luwi[i]);
//    if (i < luwi.Count - 1)
//    {
//        Console.Write(" ");
//    }
//}
//Console.WriteLine();

//Console.Write("masivi 2: ");
//for (int i = 0; i < kenti.Count; i++)
//{
//    Console.Write(kenti[i]);
//    if (i < kenti.Count - 1)
//    {
//        Console.Write(" ");
//    }
//}
//Console.WriteLine();


//        Task 2  
//Dictionary<string, string> contacts = new Dictionary<string, string>();
//bool running = true;

//while (running)
//{
//    Console.WriteLine("\n--- Contact App ---");
//    Console.WriteLine("1. Add Contact");
//    Console.WriteLine("2. Delete Contact");
//    Console.WriteLine("3. Update Contact");
//    Console.WriteLine("4. Show Contacts");
//    Console.WriteLine("5. Exit");
//    Console.Write("Choose option: ");
//    string choice = Console.ReadLine();

//    switch (choice)
//    {
//        case "1": // Add Contact
//            Console.Write("Enter name: ");
//            string name = Console.ReadLine();
//            if (contacts.ContainsKey(name))
//                Console.WriteLine("Contact already exists!");
//            else
//            {
//                Console.Write("Enter phone: ");
//                string phone = Console.ReadLine();
//                contacts[name] = phone;
//                Console.WriteLine("Contact added!");
//            }
//            break;

//        case "2": // Delete Contact
//            Console.Write("Enter name to delete: ");
//            string delName = Console.ReadLine();
//            if (contacts.Remove(delName))
//                Console.WriteLine("Contact deleted!");
//            else
//                Console.WriteLine("Contact not found!");
//            break;

//        case "3": // Update Contact
//            Console.Write("Enter name to update: ");
//            string updName = Console.ReadLine();
//            if (contacts.ContainsKey(updName))
//            {
//                Console.Write("Enter new phone: ");
//                contacts[updName] = Console.ReadLine();
//                Console.WriteLine("Contact updated!");
//            }
//            else
//                Console.WriteLine("Contact not found!");
//            break;

//        case "4": // Show Contacts
//            if (contacts.Count == 0)
//                Console.WriteLine("No contacts yet!");
//            else
//            {
//                Console.WriteLine("\n--- Contacts ---");
//                foreach (var c in contacts)
//                    Console.WriteLine($"{c.Key}: {c.Value}");
//            }
//            break;

//        case "5": // Exit
//            running = false;
//            Console.WriteLine("Exiting...");
//            break;

//        default:
//            Console.WriteLine("Invalid option! Try again.");
//            break;
//    }
//}




//        Task 3
//Console.WriteLine("Enter lenght of elements:");
//int n = int.Parse(Console.ReadLine());

//Console.WriteLine($"Enter {n} elements separated by space:");
//int[] arr = Console.ReadLine()
//                   .Split(' ')
//                   .Select(int.Parse)
//                   .ToArray();


//var groups = arr.GroupBy(x => x)
//                .Select(ricxvebi => new
//                {
//                    Number = ricxvebi.Key,
//                    Count = ricxvebi.Count(),
//                    Sum = ricxvebi.Key * ricxvebi.Count()
//                });

//foreach (var ricxvebi in groups)
//{
//    Console.WriteLine($"{ricxvebi.Number} appears {ricxvebi.Count} times sum {ricxvebi.Sum}");
//}




//        Task 4

//Console.WriteLine("Enter how many top elements you want:");
//int raodenoba = int.Parse(Console.ReadLine()!);

//int[] ricxvebi = { 1, 81, 24, 9, 124 };

//var udidesi = ricxvebi.OrderByDescending(x => x)
//              .Take(raodenoba)
//              .OrderBy(x => x);

//Console.WriteLine(string.Join(" ", udidesi));

#endregion

#region Homework 7
//          Task 1

#endregion

#region Homework 9
//          Task 1



//          Task 2
//using mesqueunclub;
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {

//        Student Saba = new Student
//        {
//            Name = "saba",
//            Age = 20,
//            Date = 2023
//        };

//        Teacher teacher = new Teacher
//        {
//            Name = "nana maswavlebeli",
//            Certified = true
//        };

//        Console.WriteLine($"Student: {Saba.Name}, Age: {Saba.Age}");
//        Console.WriteLine($"Years left to graduate: {Saba.graduationyear()}");

//        string subject = Saba.randomsubjects();
//        Console.WriteLine($"\nStudent chose subject: {subject}");


//        teacher.CheckSubject(subject);
//    }
//}


//             Task 3
//using mesqueunclub;
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        bejiti student1 = new bejiti { Name = "Pedri" };
//        zarmaci student2 = new zarmaci { Name = "Gavi" };
//        bejiti student3 = new bejiti { Name = "Lamine" };
//        zarmaci student4 = new zarmaci { Name = "Ronald" };

       
//        ClassRoom classRoom = new ClassRoom(student1, student2, student3, student4);

     
//        classRoom.yvelastudenti();
//    }
//}

#endregion