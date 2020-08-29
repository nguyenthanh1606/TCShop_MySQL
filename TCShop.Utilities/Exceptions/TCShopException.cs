using System;
using System.Collections.Generic;
using System.Text;

namespace TCShop.Utilities.Exceptions
{
    public class TCShopException:Exception
    {
        public TCShopException()
        {

        }
        public TCShopException(string message)
            :base(message)
        {

        }
        public TCShopException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
