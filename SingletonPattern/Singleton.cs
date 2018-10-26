using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// SingleTon, class is marked sealed because it should not be inherited and can create new object.
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton instance;
        private int numberOfInstances = 0;

        /// <summary>
        /// The constructor is private because caller should not create the object with new operator
        /// </summary>
        private Singleton()
        {
            this.numberOfInstances++;
        }

        /// <summary>
        /// Works well with the single thread implementation, but has draw back for multi-thread implementation fails because
        /// if(instance == null), will be invoked by multiple threads, hence creating multiple objects.
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
