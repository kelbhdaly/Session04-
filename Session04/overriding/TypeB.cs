namespace Session04.overriding
{
    internal class TypeB : TypeA
    {
        #region Properties

        public int B { get; set; }
        #endregion

        public TypeB(int a , int b) : base(a)
        { 
            B = b;
        }
        public new void Func01() // call => based on References Type // Sataic Polymorphism [New Version - Masking]
        {
            Console.WriteLine();
        }
        public override void Func02() // Call => Based On Object // Dynamic Ploymorphism
        {
            Console.WriteLine("This My Func02 From Base And TypeB : A = {A} , B = {B} ");
        }
    }
}
