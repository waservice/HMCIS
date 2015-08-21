using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1C.v8241
{
    public class SystemCode
    {
        public static class TransactionType
        {
            public const string Sync = "1";
            public const string Async = "2";
        }
        public static class RequestType
        {
            public const string Request = "1";
            public const string Polling = "2";
        }
        public static class Code
        {
            public const string Success = "1";
            public const string NoData = "0";
            public const string Fail = "-1";
        }
        public static class WorkType
        {
            public const string MechanicalRepair = "01";
            public const string BodyRepair = "02";
        }
        public static class ServiceType
        {
            public const string PromotionRepair = "1";
            public const string WarrantyRepair = "2";
            public const string OptionalEquipment = "3";
            public const string CompletionOfCar = "4";
            public const string BodyRepair = "5";
            public const string Washing = "6";
            public const string GeneralRepair = "7";
            public const string DonativeRepair = "8";
            public const string ComplaintRepair = "9";
            public const string Maintenance = "10";
            public const string TireRepair = "11";
        }
        public static class PaymentMethod
        {
            //Credit	01
            //Cash	02
            //Cashless	03
            public const string Cash = "02";
            public const string Cashless = "03";
            public const string Credit = "01";
        }
        public static class DMSROStatus
        {
            //R01	Not Started
            //R02	Progressing
            //R03	Delay
            //R04	Pause
            //R05	Done
            public const string Request = "R01";
            public const string Progressing = "R02";
            public const string Agreement = "R04";
            public const string ExpectationParts = "R04";
            public const string Parking = "R04";
            public const string Done = "R02";
            public const string Closed = "R05";
            public const string InReserve = "R04";
            public const string Cancelled = "R04";
        }
        public static class ROChannel
        {
            //DMS1	01
            //DMS2	02
            //SSM	03
            //WA1	04
            //WA2	05
            public const string DMS = "01";
            public const string WA = "04";
            public const string Bluelink = "3";
            public const string _3rd = "4";
        }
        public static class DMSAppointmentStatus
        {
            public const string Appointment = "A01";
        }
        public static class AppointmentChannel
        {
            //DMS1	01
            //DMS2	02
            //SSM	03
            //WA1	04
            //WA2	05
            public const string DMS = "01";
            public const string WA = "04";
            public const string Bluelink = "3";
            public const string _3rd = "4";
        }
        public static class DMSJobStatus
        {
            public const string NotStart = "J00";
            public const string Progressing = "J01";
            public const string Pause = "J02";
            public const string Done = "J04";
        }
        public static class LogStatus
        {
            public const string Start = "J01";
            public const string Finish = "J04";
            public const string Pause = "J02";
            public const string Resume = "J03";
            public const string ReStart = "J05";
        }
        public static class PauseReasonCode
        {
            public const string TechnicalTimeout = "P04";
            public const string GettingParts = "P01";
            public const string Dinner = "P02";
        }
        public static class CustomerInfoType
        {
            public const string Owner = "1";
            public const string Customer = "2";
            public const string ContactPerson = "3";
        }
        public static class Gender
        {
            public const string Male = "M";
            public const string Female = "F";
        }
        public static class AddressType
        {
            public const string Legal = "1";
            public const string Actual = "2";
            public const string Post = "3";
        }
        public static class ContactType
        {
            public const string HomePhone = "1";
            public const string CellPhone = "2";
            public const string BusinessPhone = "3";
        }
        public static class VehicleType
        {
            public const string Default = "01";
            public const string SUV = "02";
            public const string Commercial = "03";
        }
        public static class PackageCodeType
        {
            public const string HyundaiPackageCode = "01";
            public const string DealerownPackageCode = "02";
        }
        public static class OPCodeType
        {
            public const string HyundaiOPCode = "01";
            public const string DealerownOPCode = "02";
        }
        public static class PartType
        {
            public const string HyundaiPart = "01";
            public const string DealerownPart = "02";
        }
        public static class PartStatus
        {
            public const string Active = "1";
            public const string NonStocked = "2";
        }
        public static class EmployeeStatus
        {
            public const string Work = "01";
            public const string Leave = "02";
            public const string Retirement = "03";
        }
        public static class RoleName
        {
            public const string ServiceAdvisor = "SA";
            public const string ServiceManager = "SM";
            public const string WorkshopManager = "WM";
            public const string Technician = "TC";
            public const string FinalInspector = "FI";
            public const string PartsMaster = "PM";
        }

        public static class ActionType
        {
            public const string Create = "C";
            public const string Update = "U";
            public const string Delete = "D";
        }

        public static class MessageType
        {
            public const string Appointment = "1";
            public const string Employee = "2";
            public const string Job = "3";
            public const string PackageCode = "4";
            public const string RepairOrder = "5";
        }

        public static class PrintType
        {
            public const string PreRO = "01";
            public const string WorkingRO = "02";
            public const string FinalRO = "03";
            public const string FinalInspection = "04";
            public const string VHC = "05";
            public const string PartsRequest = "06";
        }
    }
}
