using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.FinalInspection
{
    [Serializable]
    public class Summary
    {
        private string _completedworkconsistentwiththestated = string.Empty; public string CompletedWorkConsistentWithTheStated { get { return this._completedworkconsistentwiththestated; } set { this._completedworkconsistentwiththestated = value; } }
        private string _replacedpartsmatcheswithworkdoneandpackedproperly = string.Empty; public string ReplacedPartsMatchesWithWorkDoneAndPackedProperly { get { return this._replacedpartsmatcheswithworkdoneandpackedproperly; } set { this._replacedpartsmatcheswithworkdoneandpackedproperly = value; } }
        private string _thevehicleissuitableforuse = string.Empty; public string TheVehicleIsSuitableForUse { get { return this._thevehicleissuitableforuse; } set { this._thevehicleissuitableforuse = value; } }
        private string _fillinfinalinspectionlistandsign = string.Empty; public string FillInFinalInspectionListAndSign { get { return this._fillinfinalinspectionlistandsign; } set { this._fillinfinalinspectionlistandsign = value; } }
        private string _cleancarinsideandout = string.Empty; public string CleanCarInsideAndOut { get { return this._cleancarinsideandout; } set { this._cleancarinsideandout = value; } }
        private string _tosignrepairorderandgiveitsa = string.Empty; public string ToSignRepairOrderAndGiveItSA { get { return this._tosignrepairorderandgiveitsa; } set { this._tosignrepairorderandgiveitsa = value; } }
    }
}
