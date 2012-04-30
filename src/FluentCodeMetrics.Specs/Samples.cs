
using System;

// ReSharper disable CheckNamespace
namespace Samples
// ReSharper restore CheckNamespace
{
    public class EmptyClass
    {
    }

    class OneArgCtor
    {
// ReSharper disable UnusedParameter.Local
        public OneArgCtor(int arg)
// ReSharper restore UnusedParameter.Local
        {}
    }

    class OneArgVoidMethod
    {
         public void Foo(int arg)
         {}
    }

    class IntMethod
    {
        public int Foo()
        {
            return 0;
        }
    }

    class StringArgIntMethod
    {
         public int Foo(string arg)
         {
             return 0;
         }
    }

    class OneProperty
    {
        public string Foo { get; set; }
    }

    class OneAttribute
    {
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local
        private string foo;
// ReSharper restore UnusedMember.Local
// ReSharper restore InconsistentNaming
    }

    class OneException
    {
         public void Foo()
         {
             throw new Exception();
         }
    }
}
