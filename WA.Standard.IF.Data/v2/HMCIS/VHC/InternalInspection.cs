using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.VHC
{
    [Serializable]
    public class InternalInspection
    {
        private string _parkingbrake = string.Empty; public string ParkingBrake { get { return this._parkingbrake; } set { this._parkingbrake = value; } }
        private string _safetybelts = string.Empty; public string SafetyBelts { get { return this._safetybelts; } set { this._safetybelts = value; } }
        private string _horn = string.Empty; public string Horn { get { return this._horn; } set { this._horn = value; } }
        private string _conditionsystem = string.Empty; public string ConditionSystem { get { return this._conditionsystem; } set { this._conditionsystem = value; } }
        private string _wiperswashers = string.Empty; public string WipersWashers { get { return this._wiperswashers; } set { this._wiperswashers = value; } }
    }
}
