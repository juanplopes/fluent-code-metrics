
using System;

// ReSharper disable CheckNamespace
namespace Samples
// ReSharper restore CheckNamespace
{
    public class Fee
    {
    }

    public class EmptyClass
    {
    }

    class OneArgCtor
    {
// ReSharper disable UnusedParameter.Local
        public OneArgCtor(Fee arg)
// ReSharper restore UnusedParameter.Local
        {}
    }

    class SingleArgVoidMethod
    {
         public void Foo(Fee arg)
         {}
    }

    public class FeeMethod
    {
        public Fee Foo()
        {
            return new Fee();
        }
    }

    public class DateTimeArgDateTimeMethod
    {
         public DateTime Foo(DateTime arg)
         {
             return DateTime.Now;
         }
    }

    class SingleProperty
    {
        public DateTime Foo { get; set; }
    }

    public class SingleNonAutoProperty
    {
        public DateTime DummyProperty
        {
            get { return DateTime.Now; }
        }
    }

    public class SingleField
    {
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local
        private DateTime foo;
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
