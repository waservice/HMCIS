using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.VHC
{
    [Serializable]
    public class VehicleIsFullyLifted
    {
        private string _driveshafts = string.Empty; public string DriveShafts { get { return this._driveshafts; } set { this._driveshafts = value; } }
        private string _frontsuspension = string.Empty; public string FrontSuspension { get { return this._frontsuspension; } set { this._frontsuspension = value; } }
        private string _rearsuspension = string.Empty; public string RearSuspension { get { return this._rearsuspension; } set { this._rearsuspension = value; } }
        private string _exhaustsystem = string.Empty; public string ExhaustSystem { get { return this._exhaustsystem; } set { this._exhaustsystem = value; } }
        private string _leakageoftechnicalliquids = string.Empty; public string LeakageOfTechnicalLiquids { get { return this._leakageoftechnicalliquids; } set { this._leakageoftechnicalliquids = value; } }
    }
}
