using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Abstract base class to implement the common functions of setting and getting the ID of an
    /// item to search for
    /// </summary>
    public abstract class BaseGet
    {
        protected int _id;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public BaseGet(int id)
        {
            this.ID = id;
        }

        /// <summary>
        /// Gets or sets the ID of the item to get from the hudu api.
        /// </summary>
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("ID must be greater than 0");
                }
            }
        }
    }
}