using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.FinalInspection
{
    [Serializable]
    public class InspectionUnderTheVehicle
    {
        private string _absenseofleakage = string.Empty; public string AbsenseOfLeakage { get { return this._absenseofleakage; } set { this._absenseofleakage = value; } }
        private string _brakeandfuelpipesandhoses = string.Empty; public string BrakeAndFuelPipesAndHoses { get { return this._brakeandfuelpipesandhoses; } set { this._brakeandfuelpipesandhoses = value; } }
        private string _crankcaseprotection = string.Empty; public string CrankcaseProtection { get { return this._crankcaseprotection; } set { this._crankcaseprotection = value; } }
        private string _tighteningtorqueofdrainplugsandbrakecalipers = string.Empty; public string TighteningTorqueOfDrainPlugsAndBrakeCalipers { get { return this._tighteningtorqueofdrainplugsandbrakecalipers; } set { this._tighteningtorqueofdrainplugsandbrakecalipers = value; } }
    }
}
