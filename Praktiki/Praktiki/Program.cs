


using Praktiki;
using Praktiki.Controllers;
using Praktiki.Exceptions;
using Praktiki.Models;
using System.ComponentModel.DataAnnotations;
using System.Globalization;


#region HomeWork


//Generic<Person> generic = new Generic<Person>();


//generic.Add(new Person { Name = "Semed", Surname = "Huseynov", Age = 20, Id = 1 });
//generic.Add(new Person { Name = "Zaur", Surname = "Huseynov", Age = 22, Id = 2 });
//generic.Add(new Person { Name = "Samir", Surname = "Huseynov", Age = 28, Id = 3 });


////var result = generic.GetByID(1);

////Console.WriteLine(result.Name+" "+result.Surname);



////generic.DeleteById(1);

////var result = generic.ShowAll();

////foreach (var item in result)
////{
////    Console.WriteLine(item.Name+" "+item.Surname);
////}


//static void GetFactorial(int num)
//{
//	try
//	{
//		int factorial = 1; 

//		for (int i = 1; i <= num; i++)
//		{
//			factorial *= i;
//		}
//        Console.WriteLine(factorial);

//        if (num < 1)
//		{
//			throw new ZeroException();
//		} 

//	}
//	catch (Exception ex)
//	{
//        Console.WriteLine(ex.Message);
//    }
//}


//GetFactorial(3);

#endregion
#region Casting


//Animal animal = new Animal();

//Fish fish1 = new Fish();

//Bird bird = new Bird();


//Animal animal2 = fish1;

//Animal animal3 = bird;

////animal2.Sound();

//Bird bird2 =(Bird)animal;


//Animal[] datas = { animal , fish1 , bird , animal2 , animal3 , bird2 };

//foreach (var item in datas)
//{
//    item.Name = "XXXX";
//    Console.WriteLine(item.Name);
//}

#endregion
#region Boxing


//int num1 = 5;

//object obj = num1;

//int num2 =(int) obj;


//bool isMarried = false;

//object data = isMarried;

//bool test =(bool) data;


//string name = "test";

//object data2 = name;

//string name2 = data2.ToString();

#endregion
#region Implicit


//byte num1 = 12;

//int num2 = num1;

//int a1 = 1000;

//byte a2 = a1;




//Bird bird = new Bird();
//Fish fish = new Fish();
//Animal animal1 = new Bird();
//Animal animal2 = new Fish();

//object[] datas = { 1, 2, 3, bird, "Salam", fish, 100, animal2 };

//foreach(var data in datas)
//{
//    //if(data is Animal)
//    //{
//    //    ((Animal)data).Name = "XXX";
//    //    Console.WriteLine(((Animal)data).Name);

//    //}
//    //else
//    //{
//    //    Console.WriteLine($"{data}cant convert");
//    //}

//    Animal animal = data as Animal;

//    if( animal != null)
//    {
//        animal.Name = "Test";
//        Console.WriteLine(animal.Name);
//    }

//}

#endregion
#region List

//List<int> nums = new() { 1, 2, 23, 4, 5 };


//List<int> nums = new List<int>();

//List<int> nums2 = new();


//nums2.Add(100);
//nums2.Add(200);

//nums.AddRange(nums2);

//nums.Add(234);
//nums.Add(2334);
//nums.Add(2344);
//nums.Add(2346);


//Console.WriteLine();

//foreach (int i in nums)
//{
//    Console.WriteLine(i);
//}


//Console.WriteLine(nums.Count);




//List<string> str = new();

//str.Add("Tunale");
//str.Add("Arzu");
//str.Add("Semed");
//str.Add("Ilham");


//for (int i = 0; i < str.Count; i++)
//{
//    Console.WriteLine(str[i]);
//}



//List<string> email = new();
//email.Add("AA@mail.ru");
//email.Add("baA@mail.ru");
//email.Add("AAvfwe@mail.ru");
//email.Add("AaefrggwrgfA@mail.ru");

//static void CheckEmail(string email , List<string> emails)
//{
//    if (emails.Contains(email))
//    {
//        Console.WriteLine("Yes");
//    }
//    else
//    {
//        Console.WriteLine("No");
//    }
//}

//CheckEmail("ajfkaen" , email);




//List < Person > person = new();


//person.Add(new Person { Age = 12, Id = 1, Name = "Lale", Surname = "Eliyev" });
//person.Add(new Person { Age = 19, Id = 2, Name = "Eli", Surname = "Velili" });
//person.Add(new Person { Age = 32, Id = 3, Name = "Veli", Surname = "Besurli" });

//foreach (Person p in person)
//{
//    Console.WriteLine(p.Name);
//}



//static List<Person> Search(string str , List<Person>pero)
//{
//    //var datas = pero.FindAll(n => n.Name.Contains(str));

//    var datas = pero.Where(n => n.Name.Contains(str));


//}


//List<int> numbers = new List<int>();

//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.Add(4);
//numbers.Add(5);

//for (int i = 0; i < numbers.Count; i++)
//{
//    //if (i <= 4)
//    //{
//    //    Console.WriteLine(numbers[i]);
//    //}


//    //if( numbers[i] == 5)
//    //{
//    //    break;
//    //}
//    //else
//    //{
//    //    Console.WriteLine(numbers[i]);
//    //}



//    int index = numbers.IndexOf(5);

//    if(i<= index)
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}





//PersonController personController = new PersonController();

////personController.GetAll();

////personController.GetById(2);

//personController.Sorting();

#endregion



