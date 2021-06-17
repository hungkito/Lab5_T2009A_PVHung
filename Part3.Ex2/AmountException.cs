using System;
using System.Runtime.Serialization;

namespace Part3.Ex2
{
    public class AmountException: Exception
    {
        private string _personName;
        private string _message;

        public AmountException()
        {
        }

        public AmountException(string message, string personName) : base(message)
        {
            this._personName = personName;
            this._message = message;
            PrintError();
        }

        private void PrintError()
        {
            Console.Error.WriteLine($"Error: {_message}, Name {_personName}");
        }
    }
}