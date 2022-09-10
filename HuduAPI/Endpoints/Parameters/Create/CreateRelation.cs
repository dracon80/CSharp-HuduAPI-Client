using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties required to create a new relationship using the endpoint api/v1/relations
    /// </summary>
    public class CreateRelation : IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRelation" /> class with all required
        /// properties supplied. The remaining properties are optional.
        /// </summary>
        /// <param name="toableType">
        /// The type of the TO relation.
        /// </param>
        /// <param name="toableId">
        /// The ID of the TO relation.
        /// </param>
        /// <param name="fromableType">
        /// The type of the FROM relation.
        /// </param>
        /// <param name="fromableId">
        /// The ID of the FROM relation.
        /// </param>
        public CreateRelation(string toableType, int toableId, string fromableType, int fromableId)
        {
            ToableType = toableType;
            ToableId = toableId;
            FromableType = fromableType;
            FromableId = fromableId;
            this.IsInverse = false;
        }

        /// <summary>
        /// Give a description to the relation so you know why two things are related
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The ID of the FROM relation
        /// </summary>
        [JsonProperty("fromable_id")]
        public int FromableId { get; }

        /// <summary>
        /// The type of the FROM relation (Asset, Website, Procedure, AssetPassword, Company, Article)
        /// </summary>
        [JsonProperty("fromable_type")]
        public string FromableType { get; }

        /// <summary>
        /// When a relation is created, it will also create another relation that is the inverse.
        /// When this is true, this relation is the inverse.
        /// </summary>
        [JsonProperty("is_inverse")]
        public bool IsInverse { get; set; }

        /// <summary>
        /// The ID of the TO relation
        /// </summary>
        [JsonProperty("toable_id")]
        public int ToableId { get; }

        /// <summary>
        /// The type of the TO relation (Asset, Website, Procedure, AssetPassword, Company, Article)
        /// </summary>
        [JsonProperty("toable_type")]
        public string ToableType { get; }
    }
}