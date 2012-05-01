using NUnit.Framework;
using SharpTestsEx;
using FluentCodeMetrics.Core;
using Samples;
using System;

namespace FluentCodeMetrics.Tests
{
    [TestFixture]
    // ReSharper disable InconsistentNaming
    public class CeExtensionsTests
    {
        [Test]
        public void GetReferencedTypes_EmptyClass()
        {
            typeof(EmptyClass).GetReferencedTypes()
                .Should().Have.SameSequenceAs(
                    typeof(object),
                    typeof(string),
                    typeof(bool),
                    typeof(int),
                    typeof(Type)
                );
        }

        [Test]
        public void GetReferencedTypes_SingleField()
        {
            typeof(SingleField).GetReferencedTypes()
                .Should().Have.SameSequenceAs(
                    typeof(object),
                    typeof(DateTime), // field type
                    typeof(string),
                    typeof(bool),
                    typeof(int),
                    typeof(Type)
                );
        }

        [Test]
        public void GetReferencedTypes_SingleNonAutoProperty()
        {
            typeof(SingleNonAutoProperty).GetReferencedTypes()
                .Should().Have.SameSequenceAs(
                    typeof(object),
                    typeof(DateTime), // property type
                    typeof(string),
                    typeof(bool),
                    typeof(int),
                    typeof(Type)
                );
        }

        [Test]
        public void GetReferencedTypes_FeeMethod()
        {
            typeof(FeeMethod).GetReferencedTypes()
                .Should().Have.SameSequenceAs(
                    typeof(object),
                    typeof(Fee), // returning type
                    typeof(string),
                    typeof(bool),
                    typeof(int),
                    typeof(Type)
                );
        }

        [Test]
        public void GetReferencedTypes_SingleArgVoidMethod()
        {
            typeof(SingleArgVoidMethod).GetReferencedTypes()
                .Should().Have.SameSequenceAs(
                    typeof(object),
                    typeof(Fee), // argument type
                    typeof(string),
                    typeof(bool),
                    typeof(int),
                    typeof(Type)
                );
        }

        [Test]
        public void GetReferencedTypes_SingleArgCtor()
        {
            typeof(SingleArgCtor).GetReferencedTypes()
                .Should().Have.SameSequenceAs(
                    typeof(object),
                    typeof(Fee), // argument type
                    typeof(string),
                    typeof(bool),
                    typeof(int),
                    typeof(Type)
                );
        }
    }
    // ReSharper restore InconsistentNaming
}