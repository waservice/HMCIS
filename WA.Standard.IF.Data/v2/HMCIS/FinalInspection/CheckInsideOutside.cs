using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.FinalInspection
{
    [Serializable]
    public class CheckInsideOutside
    {
        private string _damagesonbodyandpaint = string.Empty; public string DamagesOnBodyAndPaint { get { return this._damagesonbodyandpaint; } set { this._damagesonbodyandpaint = value; } }
        private string _exteriorlighting = string.Empty; public string ExteriorLighting { get { return this._exteriorlighting; } set { this._exteriorlighting = value; } }
        private string _wiperandwashernozzles = string.Empty; public string WiperAndWasherNozzles { get { return this._wiperandwashernozzles; } set { this._wiperandwashernozzles = value; } }
        private string _hornhandbrakeandseatbelts = string.Empty; public string HornHandbrakeAndSeatBelts { get { return this._hornhandbrakeandseatbelts; } set { this._hornhandbrakeandseatbelts = value; } }
        private string _settingsofclockandmediasystem = string.Empty; public string SettingsOfClockAndMediaSystem { get { return this._settingsofclockandmediasystem; } set { this._settingsofclockandmediasystem = value; } }
        private string _absenceofcautionindicatorsonthedashboard = string.Empty; public string AbsenceOfCautionIndicatorsOnTheDashboard { get { return this._absenceofcautionindicatorsonthedashboard; } set { this._absenceofcautionindicatorsonthedashboard = value; } }
        private string _doorslocksandwindowlifts = string.Empty; public string DoorsLocksAndWindowLifts { get { return this._doorslocksandwindowlifts; } set { this._doorslocksandwindowlifts = value; } }
        private string _tighteningtorqueofwheelnuts = string.Empty; public string TighteningTorqueOfWheelNuts { get { return this._tighteningtorqueofwheelnuts; } set { this._tighteningtorqueofwheelnuts = value; } }
        private string _airpressureinthetiresandsparewheel = string.Empty; public string AirPressureInTheTiresAndSpareWheel { get { return this._airpressureinthetiresandsparewheel; } set { this._airpressureinthetiresandsparewheel = value; } }
    }
}
