using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.HMCIS.VHC
{
    [Serializable]
    public class Complectation
    {
        private string _additionalwheel = string.Empty; public string AdditionalWheel { get { return this._additionalwheel; } set { this._additionalwheel = value; } }
        private string _standardtoolkit = string.Empty; public string StandardToolkit { get { return this._standardtoolkit; } set { this._standardtoolkit = value; } }
        private string _jack = string.Empty; public string Jack { get { return this._jack; } set { this._jack = value; } }
        private string _roadkit = string.Empty; public string Roadkit { get { return this._roadkit; } set { this._roadkit = value; } }
        private string _firstaidkit = string.Empty; public string FirstAidkit { get { return this._firstaidkit; } set { this._firstaidkit = value; } }
        private string _ashtray = string.Empty; public string Ashtray { get { return this._ashtray; } set { this._ashtray = value; } }
        private string _cigarettelighter = string.Empty; public string CigaretteLighter { get { return this._cigarettelighter; } set { this._cigarettelighter = value; } }
    }
}
