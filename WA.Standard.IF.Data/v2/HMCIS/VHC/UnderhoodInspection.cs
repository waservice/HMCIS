using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.VHC
{
    [Serializable]
    public class UnderhoodInspection
    {
        private string _airfilter = string.Empty; public string AirFilter { get { return this._airfilter; } set { this._airfilter = value; } }
        private string _oillevelinengine = string.Empty; public string OilLevelInEngine { get { return this._oillevelinengine; } set { this._oillevelinengine = value; } }
        private string _drivebelts = string.Empty; public string DriveBelts { get { return this._drivebelts; } set { this._drivebelts = value; } }
        private string _pipelinesleakage = string.Empty; public string PipelinesLeakage { get { return this._pipelinesleakage; } set { this._pipelinesleakage = value; } }
        private string _battery = string.Empty; public string Battery { get { return this._battery; } set { this._battery = value; } }
    }
}
