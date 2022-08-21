using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Exceptions
{
    /// <summary>
    /// Represents an expection that will be raised when a call to the HuduAPI results in no record
    /// being found
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class RecordNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordNotFoundException" /> class.
        /// </summary>
        public RecordNotFoundException()
            : base("The requested record was not found")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordNotFoundException" /> class.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        public RecordNotFoundException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordNotFoundException" /> class.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        /// <param name="inner">
        /// The inner exception.
        /// </param>
        public RecordNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}