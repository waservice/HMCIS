using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.VHC
{
    [Serializable]
    public class VehicleIsPartlyLifted
    {
        private string _steeringsystem = string.Empty; public string SteeringSystem { get { return this._steeringsystem; } set { this._steeringsystem = value; } }
        private string _frontwheelbearings = string.Empty; public string FrontWheelBearings { get { return this._frontwheelbearings; } set { this._frontwheelbearings = value; } }
        private string _rearwheelbearings = string.Empty; public string RearWheelBearings { get { return this._rearwheelbearings; } set { this._rearwheelbearings = value; } }
        private string _shockabsorbers = string.Empty; public string ShockAbsorbers { get { return this._shockabsorbers; } set { this._shockabsorbers = value; } }
        private string _frontbrakediscs = string.Empty; public string FrontBrakeDiscs { get { return this._frontbrakediscs; } set { this._frontbrakediscs = value; } }
        private string _rearbrakediscs = string.Empty; public string RearBrakeDiscs { get { return this._rearbrakediscs; } set { this._rearbrakediscs = value; } }
        private string _frontbrakepads = string.Empty; public string FrontBrakePads { get { return this._frontbrakepads; } set { this._frontbrakepads = value; } }
        private string _rearbrakepads = string.Empty; public string RearBrakePads { get { return this._rearbrakepads; } set { this._rearbrakepads = value; } }
        private string _tyreswheeldiscs = string.Empty; public string TyresWheelDiscs { get { return this._tyreswheeldiscs; } set { this._tyreswheeldiscs = value; } }
        private string _radiators = string.Empty; public string Radiators { get { return this._radiators; } set { this._radiators = value; } }
    }
}
