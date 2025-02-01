using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04
{
    internal class Rectangle
    {
       
        #region Properties
        public int Width { get; set; }
        public int Height { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Width = {Width} , height = {Height}";
        }
        #endregion

        #region Constructors
        //public Rectangle(int width, int height) // A constructor that accepts width and height as integers
        //{
        //    Width = width;
        //    Height = height;
        //}

        //public Rectangle(int size)
        //{
        //    Width = size;
        //    Height = size;
            
        //}
        #endregion
    }
}
