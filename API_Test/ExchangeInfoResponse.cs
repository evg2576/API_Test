using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Test
{
    internal class ExchangeInfoResponse
    {
        public string TimeZone { get; set; }
        public long ServerTime { get; set; }
        public Symbols[] symbols = new Symbols[] { };
    }
}
