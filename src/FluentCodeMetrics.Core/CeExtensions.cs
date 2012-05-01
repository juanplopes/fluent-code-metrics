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
    var flags = BindingFlags.Instance |
                BindingFlags.NonPublic |
                BindingFlags.Public
        ;

    var fieldTypes = from field in that.GetFields(flags)
                        select field.FieldType;

    var propertyTypes = from property in that.GetProperties(flags)
                        select property.PropertyType;

    var methodReturnTypes = from method in that.GetMethods(flags)
                            where method.ReturnType != typeof(void)
                            select method.ReturnType;

    var methodParameterTypes = from method in that.GetMethods(flags)
                               from parameter in method.GetParameters()
                               select parameter.ParameterType;

    var ctorParameterTypes = from ctor in that.GetConstructors(flags)
                             from parameter in ctor.GetParameters()
                             select parameter.ParameterType;
    
    return new[] { that.BaseType }
        .Union(ctorParameterTypes)
        .Union(methodParameterTypes)
        .Union(fieldTypes)
        .Union(propertyTypes)
        .Union(methodReturnTypes)
        .Distinct();
}
    }
}
