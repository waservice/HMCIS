using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.Standard.IF.Data.v2.Common.Job
{
    [Serializable]
    public class Actual
    {
        private string _stallid = string.Empty; public string StallID { get { return this._stallid; } set { this._stallid = value; } }
        private string _stallname = string.Empty; public string StallName { get { return this._stallname; } set { this._stallname = value; } }
        private List<ActualTimeLog> _actualtimelogs; public List<ActualTimeLog> ActualTimeLogs { get { return this._actualtimelogs; } set { this._actualtimelogs = value; } }
        private List<JobComment> _jobcomments; public List<JobComment> JobComments { get { return this._jobcomments; } set { this._jobcomments = value; } }
    }
}
