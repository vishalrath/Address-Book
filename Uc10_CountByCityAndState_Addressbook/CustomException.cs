using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc10_CountByCityAndState_Addressbook
{
    class CustomException:Exception
    {
        private readonly ExceptionType type;
        public enum ExceptionType
        {
            WrongCityName,
            WrongStateName
        }

        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

