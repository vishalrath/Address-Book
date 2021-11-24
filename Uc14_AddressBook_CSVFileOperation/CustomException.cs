using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc14_AddressBook_CSVFileOperation
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
