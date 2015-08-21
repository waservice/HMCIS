using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.VHC
{
    [Serializable]
    public class ExternalInspection
    {
        private string _externallights = string.Empty; public string ExternalLights { get { return this._externallights; } set { this._externallights = value; } }
    }
}
