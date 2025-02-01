using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04.Binding
{
    internal class Employee
    {
        #region Properties

        public int Id { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        #endregion


        #region Methods
        public void GetEmployeeType()
        {
            Console.WriteLine("I am Employee");
        }

        virtual public void  GetEmployeeData()
        {
            Console.Write($"Data : Id = {Id} , Name = {Name} , Age = {Age}");
        }
        #endregion
    }
}
