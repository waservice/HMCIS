using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using log4net.Config;
using System.Configuration;
using System.Xml.Serialization;
using System.IO;

namespace WA.Standard.IF.Logger.Log
{
    public class Log
    {
        //Application Running Type : DMS, Mapper
        public static string RunningMode { get { return System.Configuration.ConfigurationManager.AppSettings["RunningMode"] != null ? System.Configuration.ConfigurationManager.AppSettings["RunningMode"] : string.Empty; } }

        //Loggin Type : File, DB, None
        public static string LoggingMode { get { return System.Configuration.ConfigurationManager.AppSettings["LoggingMode"] != null ? System.Configuration.ConfigurationManager.AppSettings["LoggingMode"] : string.Empty; } }

        static Log()
        {
            XmlConfigurator.Configure();
            ErrorLogger = LogManager.GetLogger("ErrorLogger");
            AppointmentLogger = LogManager.GetLogger("AppointmentLogger");
            CustomerVehicleLogger = LogManager.GetLogger("CustomerVehicleLogger");
            EmployeeLogger = LogManager.GetLogger("EmployeeLogger");
            JobLogger = LogManager.GetLogger("JobLogger");
            MessageLogger = LogManager.GetLogger("MessageLogger");
            PackageCodeLogger = LogManager.GetLogger("PackageCodeLogger");
            OPCodeLogger = LogManager.GetLogger("OPCodeLogger"); 
            PartsLogger = LogManager.GetLogger("PartsLogger");
            RepairOrderLogger = LogManager.GetLogger("RepairOrderLogger");
            PriceLogger = LogManager.GetLogger("PriceLogger");
            PrintLogger = LogManager.GetLogger("PrintLogger");
        }

        public static ILog ErrorLogger
        {
            get;
            private set;
        }

        public static ILog AppointmentLogger
        {
            get;
            private set;
        }

        public static ILog CustomerVehicleLogger
        {
            get;
            private set;
        }

        public static ILog EmployeeLogger
        {
            get;
            private set;
        }

        public static ILog JobLogger
        {
            get;
            private set;
        }

        public static ILog MessageLogger
        {
            get;
            private set;
        }

        public static ILog PackageCodeLogger
        {
            get;
            private set;
        }

        public static ILog OPCodeLogger
        {
            get;
            private set;
        }

        public static ILog PartsLogger
        {
            get;
            private set;
        }

        public static ILog RepairOrderLogger
        {
            get;
            private set;
        }

        public static ILog PriceLogger
        {
            get;
            private set;
        }

        public static ILog PrintLogger
        {
            get;
            private set;
        }

        public static ILog GetLogger(string name)
        {
            return LogManager.GetLogger(name);
        }

        public static ILog GetLogger(Type type)
        {
            return LogManager.GetLogger(type);
        }

        private static string ObjectToXml(object obj)
        {
            if (obj != null)
            {
                string xmlString = null;
                XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    xmlSerializer.Serialize(memoryStream, obj);
                    memoryStream.Position = 0;
                    xmlString = new StreamReader(memoryStream).ReadToEnd();
                }

                //return Sort(xmlString).ToString();
                return xmlString;
            }
            else
            {
                return null;
            }
        }

        private static string ReadStackTrace(System.Exception e)
        {
            if (e == null) return String.Empty;

            var stackTrace = e.StackTrace.ToString() + "\r\n";
            stackTrace += ReadStackTrace(e.InnerException);
            return stackTrace;
        }

        public static void SaveErrorLog(string dealerid, string objectname, object request, string errormessage, Exception e)
        {
            ErrorLogger.ErrorFormat("DealerID[{0}] ObjectName[{1}] ErrorMessage[{2}] Request[{3}] Error:\r\n{3}", dealerid, objectname, ObjectToXml(request), errormessage, e);

            //string sErrorTrace = string.Empty;
            //string sErrorDetail = string.Empty;

            //if (e != null)
            //{
            //    if (ReadStackTrace(e).Length > 4000)
            //    {
            //        sErrorTrace = ReadStackTrace(e).Substring(0, 4000);
            //    }
            //    else
            //    {
            //        sErrorTrace = ReadStackTrace(e);
            //    }

            //    if (e.InnerException != null)
            //    {
            //        if (e.InnerException.ToString().Length > 4000)
            //        {
            //            sErrorDetail = e.InnerException.ToString().Substring(0, 4000);
            //        }
            //        else
            //        {
            //            sErrorDetail = e.InnerException.ToString();
            //        }
            //    }
            //}

            //using (Log_Tx log_Tx = new Log_Tx())
            //{
            //    log_Tx.AddErrorLog(dealerid, objectname, ObjectToXml(request), errormessage, sErrorTrace, sErrorDetail);
            //}
        }

        public static void SaveXMLLog(int logseq, string dealerid, string objectname, object obj)
        {
            if (LoggingMode.Equals("DB"))
            {
                //using (Log_Tx log_Tx = new Log_Tx())
                //{
                //    log_Tx.AddXMLLog(logseq, dealerid, objectname, ObjectToXml(obj), null);
                //}
            }
            else if (LoggingMode.Equals("File"))
            {
                if (objectname.ToLower().Contains("appointment"))
                    AppointmentLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("customervehicle"))
                    CustomerVehicleLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("employee"))
                    EmployeeLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("job"))
                    JobLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("message"))
                    MessageLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("packagecode"))
                    PackageCodeLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("opcode"))
                    OPCodeLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("part"))
                    PartsLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("repairorder"))
                    RepairOrderLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("price"))
                    PriceLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("print"))
                    PrintLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else
                    ErrorLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
            }
            else if (LoggingMode.Equals("Both"))
            {
                if (objectname.ToLower().Contains("appointment"))
                    AppointmentLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("customervehicle"))
                    CustomerVehicleLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("employee"))
                    EmployeeLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("job"))
                    JobLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("message"))
                    MessageLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("packagecode"))
                    PackageCodeLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("opcode"))
                    OPCodeLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("part"))
                    PartsLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("repairorder"))
                    RepairOrderLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("price"))
                    PriceLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else if (objectname.ToLower().Contains("print"))
                    PrintLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));
                else
                    ErrorLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n{2}", dealerid, objectname, ObjectToXml(obj));

                //using (Log_Tx log_Tx = new Log_Tx())
                //{
                //    log_Tx.AddXMLLog(logseq, dealerid, objectname, ObjectToXml(obj), null);
                //}
            }
        }

        public static void SaveXMLLog(int logseq, string dealerid, string objectname, object request, object response)
        {
            if (LoggingMode.Equals("DB"))
            {
                //using (Log_Tx log_Tx = new Log_Tx())
                //{
                //    log_Tx.AddXMLLog(logseq, dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                //}
            }
            else if (LoggingMode.Equals("File"))
            {
                if (objectname.ToLower().Contains("appointment"))
                    AppointmentLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("customervehicle"))
                    CustomerVehicleLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("employee"))
                    EmployeeLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("Job"))
                    JobLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("message"))
                    MessageLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("packagecode"))
                    PackageCodeLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("opcode"))
                    OPCodeLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("part"))
                    PartsLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("repairorder"))
                    RepairOrderLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("price"))
                    PriceLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("print"))
                    PrintLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else
                    ErrorLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));

            }
            else if (LoggingMode.Equals("Both"))
            {
                if (objectname.ToLower().Contains("appointment"))
                    AppointmentLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("customervehicle"))
                    CustomerVehicleLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("employee"))
                    EmployeeLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("job"))
                    JobLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("message"))
                    MessageLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("packagecode"))
                    PackageCodeLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("opcode"))
                    OPCodeLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("part"))
                    PartsLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("repairorder"))
                    RepairOrderLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("price"))
                    PriceLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else if (objectname.ToLower().Contains("print"))
                    PrintLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                else
                    ErrorLogger.InfoFormat("DealerID[{0}] ObjectName[{1}]\r\n[RequestXML]\r\n{2}\r\n[ResponseXML]\r\n{3}\r\n", dealerid, objectname, ObjectToXml(request), ObjectToXml(response));


                //using (Log_Tx log_Tx = new Log_Tx())
                //{
                //    log_Tx.AddXMLLog(logseq, dealerid, objectname, ObjectToXml(request), ObjectToXml(response));
                //}
            }
        }
    }
}