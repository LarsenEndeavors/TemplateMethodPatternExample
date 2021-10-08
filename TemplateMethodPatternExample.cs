using System;
using TemplateMethodPatternExample.Objects;

namespace TemplateMethodPatternExample
{
    internal static class TemplateMethodPatternExample
    {
        private static void Main()
        {
            AbstractClass template = new ConcreteClass();
            template.ConcreteMethod();
        }
    }
}
