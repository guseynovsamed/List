


using Domain.Models;
using HomeWorkList.Controllers;
using Service.Services;

AuthorController authorController = new AuthorController();
EmployeeController employeeController = new EmployeeController();
AccountController accountController = new AccountController();
ProductController productController = new ProductController();
//authorController.GetAuthor();
employeeController.GetEmployeeBySalary();





//if (accountController.Login())
//{
//    Console.WriteLine("1-Print all \n2-Print by search");
//    int num = Convert.ToInt32(Console.ReadLine());

//    switch (num)
//    {
//        case 1:
//            productController.PrintAll();
//            break;
//        case 2:
//            productController.PrintBySearch();
//            break;
//    }
//}


