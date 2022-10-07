namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// A basic Parameter for all methods that can be called with a signle id parameter
    /// </summary>
    public class ItemById : IParameters
    {
        protected int _id;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ItemById(int id)
        {
            ID = id;
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

        public string PayloadType
        {
            get
            {
                return "";
            }
        }
    }
}