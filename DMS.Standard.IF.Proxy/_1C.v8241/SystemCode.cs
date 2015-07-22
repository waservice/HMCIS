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
            public const string Cash = "01";
            public const string Cashless = "02";
            public const string Credit = "03";
        }
        public static class DMSROStatus
        {
            public const string Request = "1";
            public const string Progressing = "2";
            public const string Agreement = "3";
            public const string ExpectationParts = "4";
            public const string Parking = "5";
            public const string Done = "6";
            public const string Closed = "7";
            public const string InReserve = "8";
            public const string Cancelled = "9";
        }
        public static class ROChannel
        {
            public const string DMS = "1";
            public const string WA = "2";
            public const string Bluelink = "3";
            public const string _3rd = "4";
        }
        public static class DMSAppointmentStatus
        {
            public const string Appointment = "1";
        }
        public static class AppointmentChannel
        {
            public const string DMS = "1";
            public const string WA = "2";
            public const string Bluelink = "3";
            public const string _3rd = "4";
        }
        public static class DMSJobStatus
        {
            public const string NotStart = "1";
            public const string Progressing = "2";
            public const string Pause = "3";
            public const string Done = "4";
        }
        public static class LogType
        {
            public const string Planned = "P";
            public const string Estimated = "E";
            public const string Actual = "A";
        }
        public static class LogStatus
        {
            public const string Start = "J01";
            public const string Finish = "J04";
            public const string Pause = "J02";
        }
        public static class PauseReasonCode
        {
            public const string TechnicalTimeout = "1";
            public const string GettingParts = "2";
            public const string Dinner = "3";
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
            public const string Default = "1";
            public const string SUV = "2";
            public const string Commercial = "3";
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
    }
}
