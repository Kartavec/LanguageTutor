using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    class AppException : Exception
    {
        public String MethodName { get; set; }
    }
}
