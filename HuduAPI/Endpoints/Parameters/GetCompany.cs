using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Paramaters to Get a single Company from Hudu
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.IParameters" />
    public class GetCompany : BaseGet, IParameters
    {
        public GetCompany(int id) : base(id)
        {
        }
    }
}