using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateCode
{
    public abstract class AbstractBaseClass
    {
        public void TemplateMethod()
        {
            MethodName();
            MethodPicture();
            MethodDone();
        }

        protected abstract void MethodName();
        protected abstract void MethodPicture();

        private void MethodDone()
        {
            Console.WriteLine("Finished creating picture\n");

        }
    }
}
