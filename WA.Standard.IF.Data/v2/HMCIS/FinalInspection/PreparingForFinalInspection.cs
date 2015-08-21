using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.FinalInspection
{
    [Serializable]
    public class PreparingForFinalInspection
    {
        private string _lookthrowtheworkingdocumentation = string.Empty; public string LookThrowTheWorkingDocumentation { get { return this._lookthrowtheworkingdocumentation; } set { this._lookthrowtheworkingdocumentation = value; } }
        private string _lookthrowthehistoryofservice = string.Empty; public string LookThrowTheHistoryOfService { get { return this._lookthrowthehistoryofservice; } set { this._lookthrowthehistoryofservice = value; } }
    }
}
