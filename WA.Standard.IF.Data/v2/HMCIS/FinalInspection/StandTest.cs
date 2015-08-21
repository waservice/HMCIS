using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.FinalInspection
{
    [Serializable]
    public class StandTest
    {
        private string _brakes = string.Empty; public string Brakes { get { return this._brakes; } set { this._brakes = value; } }
        private string _shocks = string.Empty; public string Shocks { get { return this._shocks; } set { this._shocks = value; } }
        private string _correctnesswayofcarmoving = string.Empty; public string CorrectnessWayOfCarMoving { get { return this._correctnesswayofcarmoving; } set { this._correctnesswayofcarmoving = value; } }
    }
}
