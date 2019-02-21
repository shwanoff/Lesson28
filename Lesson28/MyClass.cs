using System;

namespace Lesson28
{
    class MyClass : IDisposable
    {
        public MyClass() { }

        ~MyClass() { }

        public void Dispose()
        {
            GC.Collect();
        }


    }
}
