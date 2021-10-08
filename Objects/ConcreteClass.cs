using System;

namespace TemplateMethodPatternExample.Objects
{
    public class ConcreteClass : AbstractClass
    {
        protected override void TemplateMethodOne()
        {
            Console.WriteLine("This method is a template method executed by ConcreteClass. 1");
        }

        protected override void TemplateMethodTwo()
        {
            Console.WriteLine("This method is a template method executed by ConcreteClass. 2");
        }

        protected override void HookMethod()
        {
            Console.WriteLine("This is a hook method implemented by ConcreteClass");
        }
    }
}