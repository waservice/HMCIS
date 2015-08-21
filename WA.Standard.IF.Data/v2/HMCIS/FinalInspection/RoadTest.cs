using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.FinalInspection
{
    [Serializable]
    public class RoadTest
    {
        private string _correctnessofengineworks = string.Empty; public string CorrectnessOfEngineWorks { get { return this._correctnessofengineworks; } set { this._correctnessofengineworks = value; } }
        private string _correctnessworkingofclutchandtransmission = string.Empty; public string CorrectnessWorkingOfClutchAndTransmission { get { return this._correctnessworkingofclutchandtransmission; } set { this._correctnessworkingofclutchandtransmission = value; } }
        private string _thecorrectpositionofthesteeringwheel = string.Empty; public string TheCorrectPositionOfTheSteeringWheel { get { return this._thecorrectpositionofthesteeringwheel; } set { this._thecorrectpositionofthesteeringwheel = value; } }
        private string _lackofnoisevibrationanddynamicimpact = string.Empty; public string LackOfNoiseVibrationAndDynamicImpact { get { return this._lackofnoisevibrationanddynamicimpact; } set { this._lackofnoisevibrationanddynamicimpact = value; } }
    }
}
