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

        //- 
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Img = (left?.Img ?? 0) - (right?.Img ?? 0)
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
        public static Complex operator --(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) - 1,
                Img = (c?.Img ?? 0)
            };
        }
        #endregion
    }
}
