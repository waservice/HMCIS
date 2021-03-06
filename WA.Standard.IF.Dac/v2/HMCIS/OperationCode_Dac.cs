﻿using System.Data;
using System.Data.Common;
using WA.Standard.IF.Data.v2.HMCIS.OperationCode;

namespace WA.Standard.IF.Dac.v2.HMCIS
{
    public class OperationCode_Dac : WA.Standard.IF.Dac.v2.Base.BaseDac
    {
        public OperationCode_Dac() : base("DBCONN_DMS") { }

        //Get OperationCode
        public DataSet SelectOperationCode(string CountryID
                                        , string DistributorID
                                        , string GroupID
                                        , string DealerID
                                        , string Language
                                        , OperationCodeGet request
            )
        {
            DataSet ds = null;

            DbCommand command = _agent.GetStoredProcCommand("DMS_OperationCode_Q");

            _agent.AddInParameter(command, "@CountryID", DbType.String, CountryID);
            _agent.AddInParameter(command, "@DistributorID", DbType.String, DistributorID);
            _agent.AddInParameter(command, "@GroupID", DbType.String, GroupID);
            _agent.AddInParameter(command, "@DealerID", DbType.String, DealerID);
            _agent.AddInParameter(command, "@Code", DbType.String, request.Code);
            _agent.AddInParameter(command, "@Description", DbType.String, request.Description);
            _agent.AddInParameter(command, "@Make", DbType.String, request.Make);
            _agent.AddInParameter(command, "@Model", DbType.String, request.Model);
            _agent.AddInParameter(command, "@Year", DbType.String, request.Year);
            _agent.AddInParameter(command, "@Engine", DbType.String, request.Engine);
            _agent.AddInParameter(command, "@Mileage", DbType.String, request.Mileage);
            _agent.AddInParameter(command, "@Category", DbType.String, request.Category);
            _agent.AddInParameter(command, "@Language", DbType.String, Language);
            _agent.AddInParameter(command, "@LastModifiedDateTimeFromUTC", DbType.DateTime, request.LastModifiedDateTimeFromUTC);
            _agent.AddInParameter(command, "@LastModifiedDateTimeToUTC", DbType.DateTime, request.LastModifiedDateTimeToUTC);

            ds = _agent.ExecuteDataSet(command);

            return ds;
        }
    }
}