using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateCode
{
    class WeirdSquare : AbstractBaseClass
    {
        protected override void MethodName()
        {
            Console.WriteLine("Just a Weird Square");
        }

        protected override void MethodPicture()
        {
            Console.WriteLine("╔═╗");
            Console.WriteLine("╚═╝\n");
        }
    }
}
