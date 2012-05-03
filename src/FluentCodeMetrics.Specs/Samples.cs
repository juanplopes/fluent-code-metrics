
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

    public class SingleArgCtor
    {
// ReSharper disable UnusedParameter.Local
        public SingleArgCtor(Fee arg)
// ReSharper restore UnusedParameter.Local
        {}
    }

    public class SingleArgVoidMethod
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

    public class SingleProperty
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

    public class OneException
    {
         public void Foo()
         {
             throw new Exception();
         }
    }
}
