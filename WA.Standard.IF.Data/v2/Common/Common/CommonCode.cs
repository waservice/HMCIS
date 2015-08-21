using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.Common.Common
{
    public class RunningMode 
    {
        public const string XMLDMS = "XMLDMS";
        public const string DBDMS = "DBDMS";
        public const string Mapper = "Mapper";
    }

    public class LoggingMode
    {
        public const string File = "File";
        public const string DB = "DB";
        public const string None = "None";
        public const string Both = "Both";
    }
}
