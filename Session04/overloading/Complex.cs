namespace Session04.overloading
{
    //2 + 5i
    class Complex
    {
        #region Properties
        public int Real { get; set; }
        public int Img { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $" {Real} + {Img}i";
        }
        #endregion

        //public Complex(int real , int img)
        //{
        //    Real = real ;
        //    Img = img ;
        //}
        #region Operator Overloading
        //+

        public static Complex operator +(Complex left, Complex right)
        {
            //Complex Result = new Complex()
            //{
            //    Real = left.Real+right.Real,
            //    Img = left.Img+right.Img,
            //};
            //return Result ;

            return new Complex()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Img = (left?.Img ?? 0) + (right?.Img ?? 0),
            };
        }


        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Img = (left?.Img ?? 0 )- (right?.Img ?? 0),
            };
        }
       
        //++
        public static Complex operator ++(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) + 1,
                Img = (c?.Img ?? 0) 
            };
        }
        //--
        public static Complex operator --(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) - 1,
                Img = (c?.Img ?? 0)
            };
        }

        // >
        //public static bool operator > (Complex left , Complex right)
        //{
        //    if (left?.Real == right?.Real)
        //        return right?.Img > left?.Img;
        //    else
        //        return left?.Real > right?.Real;
        //}

        //public static bool operator < (Complex left , Complex right)
        //{
        //    if(left?.Real == right?.Real)
        //        return left?.Img < right?.Img;
        //    else
        //        return left?.Real < right?.Real;
        //}


        //<

        public static bool operator > (Complex left , Complex right)
        {
            
            if (left?.Real == right?.Real)
                return left?.Img > right?.Img;
            else 
                return left?.Real > right?.Real;
        }
        public static bool operator <(Complex left, Complex right)
        {

            if (left?.Real == right?.Real)
                return left?.Img < right?.Img;
            else
                return left?.Real < right?.Real;
        }



        //public static bool operator >(Complex left, Complex right)
        //{
        //    if (left?.Real == right?.Real)
        //        return left?.Img > right?.Img;
        //    else
        //        return left?.Real > right?.Real;
        //}
        //public static bool operator <(Complex left, Complex right)
        //{
        //    if (left?.Real == right?.Real)
        //        return left?.Img < right?.Img;
        //    else
        //        return left?.Real < right?.Real;
        //}





        public static explicit operator int(Complex c)
        {
            return c?.Real ?? 0;
        }



        public static implicit operator string?(Complex c)
        {
            //    if (c is not null)
            //        return $"{c.Real} + {c.Img}";
            //    else
            //        return " ";

            return c?.ToString() ?? string.Empty;
        }
        #endregion
    }
}
