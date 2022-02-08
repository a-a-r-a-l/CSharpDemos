using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo18_Generics
{
    /// <summary>
    ///     My Generic Class Demo
    /// </summary>
    /// <typeparam name="T">Type of object packaged with the generic class</typeparam>
    class MyGenericType<T>
    {
        /// <summary>
        ///     Gets or Sets the value of the object packaged within the generic type
        /// </summary>
        public T Value { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("Type: {0}", this.Value.GetType());
            Console.WriteLine(this.Value.ToString());
            Console.WriteLine();
        }

    }
}
