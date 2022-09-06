namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Paramaters to Get a single Article from Hudu
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.IParameters" />
    public class GetArticle : IParameters
    {
        private int _id;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetArticle" /> class.
        /// </summary>
        /// <param name="id">
        /// The Article ID.
        /// </param>
        public GetArticle(int id)
        {
            this.ID = id;
        }

        /// <summary>
        /// Gets or sets the ID of the article to get.
        /// </summary>
        /// <value>
        /// The Article ID.
        /// </value>
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
                    throw new ArgumentOutOfRangeException("ArticleID must be greater than 0");
                }
            }
        }
    }
}