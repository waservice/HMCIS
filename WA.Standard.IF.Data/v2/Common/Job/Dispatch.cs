using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.Common.Job
{
    [Serializable]
    public class Dispatch
    {
        private string _stallid = string.Empty; public string StallID { get { return this._stallid; } set { this._stallid = value; } }
        private string _stallname = string.Empty; public string StallName { get { return this._stallname; } set { this._stallname = value; } }
        private DateTime? _scheduleddatetimefromlocal; public DateTime? ScheduledDateTimeFromLocal { get { return this._scheduleddatetimefromlocal; } set { this._scheduleddatetimefromlocal = value; } }
        private DateTime? _scheduleddatetimetolocal; public DateTime? ScheduledDateTimeToLocal { get { return this._scheduleddatetimetolocal; } set { this._scheduleddatetimetolocal = value; } }
        private List<Technician> _technicians; public List<Technician> Technicians { get { return this._technicians; } set { this._technicians = value; } }
    }
}
