using System.Diagnostics;
using Session04.Binding;
using Session04.overloading;
using Session04.overriding;

namespace Session04
{
    internal class Program
    {
        #region Overloading
        //static int SumNumbers(int a , int b)
        //{
        //    return a + b;
        //}
        //static double SumNumbers(double a, double b)
        //{
        //    return a + b;
        //}
        //static int SumNumbers(int a, int b ,int c)
        //{
        //    return a + b + c;
        //} 
        #endregion


        public static void Process(Employee employee)
        {
            if (employee is not null)
            {
                employee.GetEmployeeData();
                employee.GetEmployeeType();
            }

        }
        static void Main(string[] args)
        {
            #region overloading

            #region Method Overloading
            //int x = 5, y = 10;

            // Console.WriteLine(SumTwoNumbers(x, y));

            #endregion

            #region OPerators OverLoading

            #region Binary Operator
            //Complex c1 = new Complex();
            //c1.Real = 5;
            //c1.Img = 10;
            ////Console.WriteLine("C1 ={0} ", c1);

            //Complex c2 = new Complex();
            //c2.Real = 7;
            //c2.Img = 20;
            //Console.WriteLine($"C2 = {c2}");
            //Complex c3;
            //c3 = c1 + c2;
            //Console.WriteLine($"C3 = {c3}");


            //Complex c3;
            //c3 = c1 - c2;
            //Console.WriteLine(c3);
            //Console.WriteLine($" C3 - C1 = {c3} - {c1} = {c3 - c1} "); 
            #endregion

            #region Unary Operators
            Complex c1 = new Complex();
            c1.Real = 5;
            c1.Img = 10;

            Complex c2 = new Complex();
            c2.Real = 7;
            c2.Img = 20;
            Console.WriteLine("C1 ={0} ", c1);

            Complex c3;
            c3 = ++c1;
            Console.WriteLine("C1 ={0} ", c1);
            Console.WriteLine($"C3 = {c3}");



            Complex C3;
            C3 = c1++;
            Console.WriteLine("C1 ={0} ", c1);
            Console.WriteLine($"C3 = {C3}");
            #endregion


            #region Relational Operators
            //Complex c1 = new Complex();
            //c1.Real = 5;
            //c1.Img = 10;

            //Complex c2 = new Complex();
            //c2.Real = 7;
            //c2.Img = 20;

            //if (c1 > c2)
            //    Console.WriteLine("C1 > C2");
            //else Console.WriteLine("C2>C1");
            #endregion


            #region Casting operator

            //Complex c1 = new Complex();
            //c1.Real = 5;
            //c1.Img = 10;
            //int X =(int) c1;


            //Console.WriteLine(X);


            //string? Message = c1;

            //Console.WriteLine(Message);
            #endregion

            #region UserDefined Casting Operators

            //User user = new User()
            //{
            //    Id = 10,
            //    FullName = "Khaled Mohamed",
            //    Email = "khaledmohamed@gmail.com",
            //    Password = "127252",
            //    SecurityStamp = Guid.NewGuid(),

            //};

            //UserViewModel userViewModel =(UserViewModel) user;
            //Console.WriteLine(userViewModel); 
            #endregion


            #endregion

            #endregion


            #region Overriding
            //TypeA typeAObj = new TypeA(5);
            //typeAObj.A = 30;
            //typeAObj.Func01();
            //typeAObj.Func02();

            #endregion


            #region Exampl02
            //TypeA refBase = new TypeB(1,3); //Binding : Reference From Base To Refere To Any Object From Child 
            //// refBase.B = 5; // Invalid
            //refBase.A = 7;
            //refBase.Func01(); // This My Func01 From Base And I Am Base
            //refBase.Func02(); // This My Func02 From Base And TypeB : A = {A} , B = {B}
            #endregion



            #region Binding

            //FullTimeEmployee employee = new FullTimeEmployee(1,"Ali" , 20 , 200000);
            //Process(employee);
            //PartTimeEmployee employeePart = new PartTimeEmployee(1,"Ali" , 20 , 200000,500);
            //Process(employeePart);
            #endregion
        }
    }
}
