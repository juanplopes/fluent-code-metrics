using NUnit.Framework;
using SharpTestsEx;
using FluentCodeMetrics.Core;
using Samples;

namespace FluentCodeMetrics.Tests
{
    [TestFixture]
    // ReSharper disable InconsistentNaming
    public class CeExtensionsTests
    {
        [Test]
        public void GetReferencedTypes_EmptyClass_ReturnsObject()
        {
            typeof(EmptyClass).GetReferencedTypes()
                .Should().Have.SameSequenceAs(
                    typeof(System.Object)
                );
        }

        [Test]
        public void GetReferencedTypes_SingleField_ReturnsObjectAndString()
        {
            typeof(SingleField).GetReferencedTypes()
                .Should().Have.SameSequenceAs(
                    typeof(System.Object),  // base type
                    typeof(System.String)   // attribute type
                );
        }
    }
    // ReSharper restore InconsistentNaming
}