using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.FinalInspection
{
    [Serializable]
    public class UnderHoodInspection
    {
        private string _cleanlinessofengine = string.Empty; public string CleanlinessOfEngine { get { return this._cleanlinessofengine; } set { this._cleanlinessofengine = value; } }
        private string _absenceofleakage = string.Empty; public string AbsenceOfLeakage { get { return this._absenceofleakage; } set { this._absenceofleakage = value; } }
        private string _tighteningtorqueofoilfillercapsandradiator = string.Empty; public string TighteningTorqueOfOilFillerCapsAndRadiator { get { return this._tighteningtorqueofoilfillercapsandradiator; } set { this._tighteningtorqueofoilfillercapsandradiator = value; } }
        private string _cleanlinessandtighteningofbatteryterminals = string.Empty; public string CleanlinessAndTighteningOfBatteryTerminals { get { return this._cleanlinessandtighteningofbatteryterminals; } set { this._cleanlinessandtighteningofbatteryterminals = value; } }
        private string _levelsoftechnicalliquids = string.Empty; public string LevelsOfTechnicalLiquids { get { return this._levelsoftechnicalliquids; } set { this._levelsoftechnicalliquids = value; } }
        private string _existenceofspecialtag = string.Empty; public string ExistenceOfSpecialTag { get { return this._existenceofspecialtag; } set { this._existenceofspecialtag = value; } }
        private string _checkingofcorrectnessofheadlights = string.Empty; public string CheckingOfCorrectnessOfHeadlights { get { return this._checkingofcorrectnessofheadlights; } set { this._checkingofcorrectnessofheadlights = value; } }
    }
}
