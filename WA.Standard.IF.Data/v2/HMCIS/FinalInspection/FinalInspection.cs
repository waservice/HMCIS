using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.FinalInspection
{
    [Serializable]
    public class FinalInspection
    {
        private PreparingForFinalInspection _preparingforfinalinspection; public PreparingForFinalInspection PreparingForFinalInspection { get { return this._preparingforfinalinspection; } set { this._preparingforfinalinspection = value; } }
        private InspectionUnderTheVehicle _inspectionunderthevehicle; public InspectionUnderTheVehicle InspectionUnderTheVehicle { get { return this._inspectionunderthevehicle; } set { this._inspectionunderthevehicle = value; } }
        private CheckInsideOutside _checkinsideoutside; public CheckInsideOutside CheckInsideOutside { get { return this._checkinsideoutside; } set { this._checkinsideoutside = value; } }
        private UnderHoodInspection _underhoodinspection; public UnderHoodInspection UnderHoodInspection { get { return this._underhoodinspection; } set { this._underhoodinspection = value; } }
        private RoadTest _roadtest; public RoadTest RoadTest { get { return this._roadtest; } set { this._roadtest = value; } }
        private StandTest _standtest; public StandTest StandTest { get { return this._standtest; } set { this._standtest = value; } }
        private Summary _summary; public Summary Summary { get { return this._summary; } set { this._summary = value; } }
    }
}
