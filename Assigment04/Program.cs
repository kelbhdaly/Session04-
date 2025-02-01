namespace Assigment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Q1) Write a class named Calculator that contains a method named Add.Overload the Add method to:
            //    Accept two integers and return their sum.
            //    Accept three integers and return their sum.
            //    Accept two doubles and return their sum.


            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.ADD(2, 3)); 
            //Console.WriteLine(calculator.ADD(2, 3, 5));
            //Console.WriteLine(calculator.ADD(2.0, 3.5));
            #endregion

            #region Q02
            /* Create a class named Rectangle with the following constructors:
             A parameterless constructor that sets the width and height to 0.
             A constructor that accepts width and height as integers.
             A constructor that accepts a single integer and sets both width and height to that value.*/

            // parameterless
            //Rectangle Rect = new Rectangle();
            //Console.WriteLine(Rect);

            //accepts width and height
            //Rectangle R01 = new Rectangle(3,3);
            //Console.WriteLine(R01);


            //constructor that accepts a single
            //Rectangle R01 = new Rectangle(5);
            //Console.WriteLine(R01);
            #endregion

            #region Q03
            /*  Define a class Complex Number that represents a complex number with real and imaginary parts.
                * Note: Overload the +, - operator to add and subtract two complex numbers. */

            //Complex C01 = new Complex();
            //C01.Real = 5;
            //C01.Img = 3;
            //Console.WriteLine("C01 ="+C01);

            //Complex C02 = new Complex();
            //C02.Real = 7;
            //C02.Img = 4;
            //Console.WriteLine("C02 =" + C02);
            ////+
            //Complex C03;
            //C03 = C01 + C02;
            //Console.WriteLine($"C03 = {C03} ");


            ////-

            //Complex C04;
            //C04 = C02 - C01;
            //Console.WriteLine($"C04 = {C04}");
            #endregion

            #region Q04
            /*Create a base class named Employee with method That Work as it prints    "Employee is  working".
            b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
                *Ensure that the Manager class also calls the Work method of the Employee class within its  Overridden method */

            //Employee employee = new Employee();
            //employee.Work();
            //Manager manager = new Manager();
            //manager.Work();
            #endregion

            #region Q05
            /* Question 5)  
             a) Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass".
             b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.
             C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.
              Then explain the difference between using override and new (using binding behavior)*/

            BaseClass baseClass ;
            baseClass = new DerivedClass1();
            baseClass.DisplayMessage(); // Method in DerivedClass1 will BE Execute Runing Time (Dynamic polymorphism)

            baseClass = new DerivedClass2();
            baseClass.DisplayMessage(); // Method in BaseClass will BE Execute Complie Time (Static polymorphism)
           
            #endregion
        }
    }
}
