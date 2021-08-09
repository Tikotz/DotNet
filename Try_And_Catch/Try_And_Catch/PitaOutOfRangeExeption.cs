using System;
using System.Runtime.Serialization;

namespace Try_And_Catch
{
    [Serializable]
    internal class PitaOutOfRangeExeption : Exception
    {
        public PitaOutOfRangeExeption()
        {
        }

        public PitaOutOfRangeExeption(string message) : base(message)
        {
        }

        public PitaOutOfRangeExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PitaOutOfRangeExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}