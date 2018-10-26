using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// Singleton class with double check locking
    /// </summary>
    public sealed class SingletonWithDoubleCheckedLocking
    {
        /// <summary>
        /// We are using volatile to ensure that assignment to the instance variable finishes before it’s access.
        /// The volatile keyword indicates that a field might be modified by multiple threads that are executing at the same time.
        /// Fields that are declared volatile are not subject to compiler optimizations that
        ///assume access by a single thread.This ensures that the most up-todate
        ///value is present in the field at all times.
        ///In simple terms, the volatile keyword can help you to provide
        ///a serialize access mechanism.In other words, all threads will
        ///observe the changes by any other thread as per their execution order.
        /// </summary>
        public static volatile SingletonWithDoubleCheckedLocking instance;

        private static object lockObject = new Object();

        private SingletonWithDoubleCheckedLocking() { }

        public static SingletonWithDoubleCheckedLocking Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if(instance == null)
                        {
                            instance = new SingletonWithDoubleCheckedLocking();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
