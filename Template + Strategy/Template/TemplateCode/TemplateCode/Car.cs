using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateCode
{
    class Car : AbstractBaseClass
    {
        protected override void MethodName()
        {
            Console.WriteLine("Just a cool car");
            Console.WriteLine("(*_*)");
            Console.WriteLine("( *_*)>⌐■-■");
            Console.WriteLine("(⌐■_■)");
        }

        protected override void MethodPicture()
        {
            Console.WriteLine("                   .---;-,");
            Console.WriteLine("                __/_,{)|__;._                 ");
            Console.WriteLine("             .` _: _  `.  .:::;.    .::'");
            Console.WriteLine("             '--(_)------(_)--' `      '::'\n");
        }
    }
}
