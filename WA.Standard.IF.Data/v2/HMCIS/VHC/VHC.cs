using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.VHC
{
    [Serializable]
    public class VHC
    {
        //private PurposeOfVisit _purposeofvisit; public PurposeOfVisit PurposeOfVisit { get { return this._purposeofvisit; } set { this._purposeofvisit = value; } }
        private InternalInspection _internalinspection; public InternalInspection InternalInspection { get { return this._internalinspection; } set { this._internalinspection = value; } }
        private LevelOfFuelInTank _leveloffuelintank; public LevelOfFuelInTank LevelOfFuelInTank { get { return this._leveloffuelintank; } set { this._leveloffuelintank = value; } }
        private ExternalInspection _externalinspection; public ExternalInspection ExternalInspection { get { return this._externalinspection; } set { this._externalinspection = value; } }
        private UnderhoodInspection _underhoodinspection; public UnderhoodInspection UnderhoodInspection { get { return this._underhoodinspection; } set { this._underhoodinspection = value; } }
        private VehicleIsPartlyLifted _vehicleispartlylifted; public VehicleIsPartlyLifted VehicleIsPartlyLifted { get { return this._vehicleispartlylifted; } set { this._vehicleispartlylifted = value; } }
        private VehicleIsFullyLifted _vehicleisfullylifted; public VehicleIsFullyLifted VehicleIsFullyLifted { get { return this._vehicleisfullylifted; } set { this._vehicleisfullylifted = value; } }
        private InspectionOfBodyAndWindows _inspectionofbodyandwindows; public InspectionOfBodyAndWindows InspectionOfBodyAndWindows { get { return this._inspectionofbodyandwindows; } set { this._inspectionofbodyandwindows = value; } }
        private Complectation _complectation; public Complectation Complectation { get { return this._complectation; } set { this._complectation = value; } }
        private AdditionalEquipment _additionalequipment; public AdditionalEquipment AdditionalEquipment { get { return this._additionalequipment; } set { this._additionalequipment = value; } }
    }
}
