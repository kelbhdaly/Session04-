using Session04.overloading;

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


            //Console.WriteLine($" C3 - C1 = {c3} - {c1} = {c3 - c1} "); 
            #endregion

            #region Unary Operators
            //Complex c1 = new Complex();
            //c1.Real = 5;
            //c1.Img = 10;

            //Complex c2 = new Complex();
            //c2.Real = 7;
            //c2.Img = 20;
            //Console.WriteLine("C1 ={0} ", c1);

            //Complex c3 ;   
            //c3 = ++c1;
            //Console.WriteLine("C1 ={0} ", c1);
            //Console.WriteLine($"C3 = {c3}");



            //Complex c3;
            //c3 = c1++;
            //Console.WriteLine("C1 ={0} ", c1);
            //Console.WriteLine($"C3 = {c3}");
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
        }
    }
}
