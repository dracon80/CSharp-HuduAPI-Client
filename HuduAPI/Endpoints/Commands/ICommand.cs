using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Commands
{
    internal interface ICommand<TResult>
    {
        public TResult Execute();
    }
}
