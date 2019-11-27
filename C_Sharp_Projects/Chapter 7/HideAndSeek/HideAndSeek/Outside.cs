using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

namespace HideAndSeek
{
    class Outside : Location
    {
        private bool Hot { get; }
        public Outside(string name, bool hot) : base(name)
        {
            Log.Information("Creating a new instance of Outside");
            Hot = hot;
        }

        public override string Description
        {
            get
            {
                if (Hot)
                    return base.Description + " It's very hot here.";

                else
                    return base.Description;
            }
        }


    }
}
