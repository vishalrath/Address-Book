using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc9_AbilityToVeiw_PersonTocityAndState
{
    class CustomExcepetion:Exception
    {
        private readonly ExceptionType type;
        public enum ExceptionType
        {
            WrongCityName,
            WrongStateName
        }

        public CustomExcepetion(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
