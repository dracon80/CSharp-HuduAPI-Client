namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides the parameters to get a signle Folder from the Hudu API endpoint api/v1/folders
    /// </summary>
    public class GetFolder : BaseGet, IParameters
    {
        public GetFolder(int id) : base(id)
        {
        }
    }
}