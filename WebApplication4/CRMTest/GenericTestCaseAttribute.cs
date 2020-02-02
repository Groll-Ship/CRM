
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;

namespace CRMTest
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class GenericTestCaseAttribute : TestCaseAttribute, ITestBuilder
    {
        private readonly Type _type;
        public GenericTestCaseAttribute(Type type) : 
            base()
        {
            _type = type;
        }

        IEnumerable<TestMethod> ITestBuilder.BuildFrom(IMethodInfo method, Test suite)
        {
            if (method.IsGenericMethodDefinition && _type != null)
            {
                var gm = method.MakeGenericMethod(_type);
                return BuildFrom(gm, suite);
            }
            return BuildFrom(method, suite);
        }
    }
}