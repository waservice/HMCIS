using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.VHC
{
    [Serializable]
    public class AdditionalEquipment
    {
        private string _securitysystemwithengineimmobilizer = string.Empty; public string SecuritySystemWithEngineImmobilizer { get { return this._securitysystemwithengineimmobilizer; } set { this._securitysystemwithengineimmobilizer = value; } }
        private string _secretnutsonwheels = string.Empty; public string SecretNutsOnWheels { get { return this._secretnutsonwheels; } set { this._secretnutsonwheels = value; } }
    }
}
