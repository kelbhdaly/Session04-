using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04.overriding
{
    internal class TypeA
    {
        #region Properties
        public int A { get; set; }

        #endregion

        #region Methods
        public void Func01()
        {
            Console.WriteLine("This My Func01 From Base And I Am Base");
        }

        public virtual void Func02()
        {
            Console.WriteLine($"This My Func02 From Base And TypeA : A = {A} ");
        }
        #endregion


        #region Constructors
        public TypeA(int a)
        {
            A = a;
        }
        #endregion
    }
}
