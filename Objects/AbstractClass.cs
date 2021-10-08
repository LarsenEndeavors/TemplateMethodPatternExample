using System;

namespace TemplateMethodPatternExample.Objects
{
    public abstract class AbstractClass
    {
        public void ConcreteMethod()
        {
            Console.WriteLine("This line is concrete.");
            TemplateMethodOne();
            TemplateMethodTwo();
            HookMethod();
        }

        protected virtual void HookMethod()
        {
            //Empty hook method for overriding
        }

        protected abstract void TemplateMethodOne();
        protected abstract void TemplateMethodTwo();
    }
}