using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.Print
{
    [Serializable]
    public class Print
    {
        private string _dmsrono = string.Empty; public string DMSRONo { get { return this._dmsrono; } set { this._dmsrono = value; } }
        private string _printtype = string.Empty; public string PrintType { get { return this._printtype; } set { this._printtype = value; } }
        private string _printaddress = string.Empty; public string PrintAddress { get { return this._printaddress; } set { this._printaddress = value; } }
        private string _copynumber = string.Empty; public string CopyNumber { get { return this._copynumber; } set { this._copynumber = value; } }
        private VHC.VHC _vhc; public VHC.VHC VHC { get { return this._vhc; } set { this._vhc = value; } }
        private FinalInspection.FinalInspection _finalinspection; public FinalInspection.FinalInspection FinalInspection { get { return this._finalinspection; } set { this._finalinspection = value; } }
    }
}
