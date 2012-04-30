using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace FluentCodeMetrics.Core
{
    public static class CeExtensions
    {
        public static int ComputeCe(this Type that)
        {
            return that
                .GetReferencedTypes()
                .Count();
        }

        public static IEnumerable<Type>
            GetReferencedTypes(this Type that)
        {
            var fieldTypes = from field in that.GetFields(BindingFlags.Instance |
                                        BindingFlags.NonPublic |
                                        BindingFlags.Public
                                        )
                             select field.FieldType;

            return new[] { that.BaseType }
                .Union(fieldTypes)
                .Distinct();
        }
    }
}
