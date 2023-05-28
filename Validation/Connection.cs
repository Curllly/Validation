using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    using Models;
    using Validation.Database;

    public static class Connection
    {
        public static ValidationUserContext Database { get; set; }
    }
}
