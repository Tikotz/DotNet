using System;
using System.Runtime.Serialization;

namespace Try_And_Catch
{
    [Serializable]
    internal class DishNotValidExeption : Exception
    {
        public DishNotValidExeption()
        {
        }

        public DishNotValidExeption(string message) : base(message)
        {
        }

        public DishNotValidExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DishNotValidExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}