using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WA.v2
{
    #region Definition
    /*
        WorkType	
            1	Mechanical Repair
            2	Body Repair
		
        ServiceType	
            1	Promotion Repair 
            2	Warranty Repair
            3	Optional Equipment
            4	Completion Of Car
            5	Body Repair
            6	Washing
            7	General Repair
            8	Donative Repair
            9	Complaint Repair
            10	Maintenance
            11	Tire Repair
		
        PaymentMethod	
            1	Cash
            2	Cashless
            3	Credit
		
        DMSROStatus	
            1	Request
            2	Progressing
            3	Agreement
            4	Expectation parts
            5	Parking
            6	Done (All job done)
            7	Closed (RO closed)
            8	In reserve
            9	Cancelled
		
        ROChannel	
            1	DMS
            2	WA
            3	Bluelink
            4	3rd.
		
        DMSAppointmentStatus	
            1	Appointment
		
        AppointmentChannel	
            1	DMS
            2	WA
            3	Bluelink
            4	3rd.
		
        ServiceLineStatus	Empty	
		
        JobTypeCode	Empty	
		
        DMSJobStatus	
            1	Not Start
            2	Progressing
            3	Pause
            4	Done
		
        Status	
            1	Start
            2	Finish
            3	Pause (Pending/Hold)
		
        PauseReasonCode	
            1	Technical Timeout
            2	Getting Parts
            3	Dinner
		
        SubStatus	Empty	
		
        CustomerInfoType	
            1	Owner
            2	Customer
            3	ContactPerson
		
        Gender	
            1	Male
            2	Female
		
        AddressType	
            1	Legal (Passport address)
            2	Actual (Current address)
            3	Post (Address for post)
		
        ContactType	
            1	Home Phone
            2	Contact/Mobile Phone
            3	Business/Office Phone
		
        VehicleType	
            1	Default
            2	SUV
            3	Commercial
		
        PackageType	
            1	Hyundai PackageCode
            2	Dealer own PackageCode
		
        OPType	
            1	Hyundai OPCode
            2	Dealer own OPCode
		
        PartType	
            1	Hyundai Part
            2	Dealer own Part
		
        PartStatus	
            1	Active
            2	Non-stocked
		
        EmployeeStatus	
            1	Work
            2	Leave(Vacation)
            3	Retirement
		
        RoleName	
            1	Service Advisor
            2	Service Manager
            3	Workshop Manager
            4	Technician
            5	Final Inspector
            6	Parts Master
     */
    internal enum CodeType
    {
        Gender,
        EmployeeStatus,
        RoleName,
        CustomerInfoType,
        ContactType,
        AddressType,
        VehicleType,
        DMSAppointmentStatus,
        PaymentMethod,
        WorkType,
        DMSJobStatus,
        DMSROStatus,
        ServiceLineStatus,
        ServiceType,
        PackageCodeType,
        OPCodeType,
        PartType,
        AppointmentChannel,
        ROChannel,
        RODocumentStatus,
        PauseReasonCode,
        ActualJobStatus,
        JobSubStatus,
        TransactionType,
        RequestType,
        PartStatus,
        ActionType,
        MessageType,
        PrintType
    }
    #endregion

    public class Map
    {
        public Dictionary<string, Dictionary<string, string>> BaseDic = new Dictionary<string, Dictionary<string, string>>();

        public Map()
        {
            //Dictionary<string, string> GenderDic = new Dictionary<string, string>();
            //GenderDic.Add("1", SystemCode.Gender.Male);
            //GenderDic.Add("2", SystemCode.Gender.Female);
            //BaseDic.Add("Gender", GenderDic);

            //Dictionary<string, string> EmployeeStatusDic = new Dictionary<string, string>();
            //BaseDic.Add("EmployeeStatus", EmployeeStatusDic);
            //Dictionary<string, string> RoleNameDic = new Dictionary<string, string>();
            //BaseDic.Add("RoleName", RoleNameDic);
            //Dictionary<string, string> CustomerInfoTypeDic = new Dictionary<string, string>();
            //BaseDic.Add("CustomerInfoType", CustomerInfoTypeDic);
            //Dictionary<string, string> ContactTypeDic = new Dictionary<string, string>();
            //BaseDic.Add("ContactType", ContactTypeDic);
            //Dictionary<string, string> AddressTypeDic = new Dictionary<string, string>();
            //BaseDic.Add("AddressType", AddressTypeDic);
            //Dictionary<string, string> VehicleTypeDic = new Dictionary<string, string>();
            //BaseDic.Add("VehicleType", VehicleTypeDic);
            //Dictionary<string, string> AppointmentStatusDic = new Dictionary<string, string>();
            //BaseDic.Add("AppointmentStatus", AppointmentStatusDic);
            //Dictionary<string, string> PaymentMethodDic = new Dictionary<string, string>();
            //BaseDic.Add("PaymentMethod", PaymentMethodDic);
            //Dictionary<string, string> WorkTypeDic = new Dictionary<string, string>();
            //BaseDic.Add("WorkType", WorkTypeDic);
            //Dictionary<string, string> JobStatusDic = new Dictionary<string, string>();
            //BaseDic.Add("JobStatus", JobStatusDic);
            //Dictionary<string, string> ROStatusDic = new Dictionary<string, string>();
            //BaseDic.Add("ROStatus", ROStatusDic);
            //Dictionary<string, string> ServiceLineStatusDic = new Dictionary<string, string>();
            //BaseDic.Add("ServiceLineStatus", ServiceLineStatusDic);
            //Dictionary<string, string> ServiceTypeDic = new Dictionary<string, string>();
            //BaseDic.Add("ServiceType", ServiceTypeDic);
            //Dictionary<string, string> PackageCodeTypeDic = new Dictionary<string, string>();
            //BaseDic.Add("PackageCodeType", PackageCodeTypeDic);
            //Dictionary<string, string> OPCodeTypeDic = new Dictionary<string, string>();
            //BaseDic.Add("OPCodeType", OPCodeTypeDic);
            //Dictionary<string, string> PartTypeDic = new Dictionary<string, string>();
            //BaseDic.Add("PartType", PartTypeDic);
            //Dictionary<string, string> AppointmentChannelDic = new Dictionary<string, string>();
            //BaseDic.Add("AppointmentChannel", AppointmentChannelDic);
            //Dictionary<string, string> ROChannelDic = new Dictionary<string, string>();
            //BaseDic.Add("ROChannel", ROChannelDic);
            //Dictionary<string, string> RODocumentStatusDic = new Dictionary<string, string>();
            //BaseDic.Add("RODocumentStatus", RODocumentStatusDic);
            //Dictionary<string, string> LogTypeDic = new Dictionary<string, string>();
            //BaseDic.Add("LogType", LogTypeDic);
            //Dictionary<string, string> PauseReasonCodeDic = new Dictionary<string, string>();
            //BaseDic.Add("PauseReasonCode", PauseReasonCodeDic);
            //Dictionary<string, string> ActualLogStatusDic = new Dictionary<string, string>();
            //BaseDic.Add("ActualLogStatus", ActualLogStatusDic);
            //Dictionary<string, string> ActualLogSubStatusDic = new Dictionary<string, string>();
            //BaseDic.Add("ActualLogSubStatus", ActualLogSubStatusDic);
            //Dictionary<string, string> TransactionTypeDic = new Dictionary<string, string>();
            //BaseDic.Add("TransactionType", TransactionTypeDic);
            //Dictionary<string, string> RequestTypeDic = new Dictionary<string, string>();
            //BaseDic.Add("RequestType", RequestTypeDic);
        }

        internal static string GetWACodeFromDMSCode(CodeType dmsCodeType, string dmsCodeValue)
        {
            string rtnValue = string.Empty;

            switch (dmsCodeType)
            {
                case CodeType.Gender:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.Gender.Male; break;
                        case "2": rtnValue = SystemCode.Gender.Female; break;
                    }
                    break;
                case CodeType.EmployeeStatus:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.EmployeeStatus.Work; break;
                        case "2": rtnValue = SystemCode.EmployeeStatus.Leave; break;
                        case "3": rtnValue = SystemCode.EmployeeStatus.Retirement; break;
                    }
                    break;
                case CodeType.RoleName:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.RoleName.ServiceAdvisor; break;
                        case "2": rtnValue = SystemCode.RoleName.ServiceManager; break;
                        case "3": rtnValue = SystemCode.RoleName.WorkshopManager; break;
                        case "4": rtnValue = SystemCode.RoleName.Technician; break;
                        case "5": rtnValue = SystemCode.RoleName.FinalInspector; break;
                        case "6": rtnValue = SystemCode.RoleName.PartsMaster; break;
                    }
                    break;
                case CodeType.CustomerInfoType:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.CustomerInfoType.Owner; break;
                        case "2": rtnValue = SystemCode.CustomerInfoType.Customer; break;
                        case "3": rtnValue = SystemCode.CustomerInfoType.ContactPerson; break;
                    }
                    break;
                case CodeType.ContactType:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.ContactType.HomePhone; break;
                        case "2": rtnValue = SystemCode.ContactType.CellPhone; break;
                        case "3": rtnValue = SystemCode.ContactType.BusinessPhone; break;
                    }
                    break;
                case CodeType.AddressType:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.AddressType.Legal; break;
                        case "2": rtnValue = SystemCode.AddressType.Actual; break;
                        case "3": rtnValue = SystemCode.AddressType.Post; break;
                    }
                    break;
                case CodeType.VehicleType:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.VehicleType.Default; break;
                        case "2": rtnValue = SystemCode.VehicleType.SUV; break;
                        case "3": rtnValue = SystemCode.VehicleType.Commercial; break;
                    }
                    break;
                case CodeType.DMSAppointmentStatus:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.DMSAppointmentStatus.Appointment; break;
                    }
                    break;
                case CodeType.PaymentMethod:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.PaymentMethod.Cash; break;
                        case "2": rtnValue = SystemCode.PaymentMethod.Cashless; break;
                        case "3": rtnValue = SystemCode.PaymentMethod.Credit; break;
                    }
                    break;
                case CodeType.WorkType:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.WorkType.MechanicalRepair; break;
                        case "2": rtnValue = SystemCode.WorkType.BodyRepair; break;
                    }
                    break;
                case CodeType.DMSJobStatus:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.DMSJobStatus.NotStart; break;
                        case "2": rtnValue = SystemCode.DMSJobStatus.Progressing; break;
                        case "3": rtnValue = SystemCode.DMSJobStatus.Pause; break;
                        case "4": rtnValue = SystemCode.DMSJobStatus.Done; break;
                    }
                    break;
                case CodeType.DMSROStatus:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.DMSROStatus.Request; break;
                        case "2": rtnValue = SystemCode.DMSROStatus.Progressing; break;
                        case "3": rtnValue = SystemCode.DMSROStatus.Agreement; break;
                        case "4": rtnValue = SystemCode.DMSROStatus.ExpectationParts; break;
                        case "5": rtnValue = SystemCode.DMSROStatus.Parking; break;
                        case "6": rtnValue = SystemCode.DMSROStatus.Done; break;
                        case "7": rtnValue = SystemCode.DMSROStatus.Closed; break;
                        case "8": rtnValue = SystemCode.DMSROStatus.InReserve; break;
                        case "9": rtnValue = SystemCode.DMSROStatus.Cancelled; break;
                    }
                    break;
                case CodeType.ServiceLineStatus:
                    break;
                case CodeType.ServiceType:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.ServiceType.PromotionRepair; break;
                        case "2": rtnValue = SystemCode.ServiceType.WarrantyRepair; break;
                        case "3": rtnValue = SystemCode.ServiceType.OptionalEquipment; break;
                        case "4": rtnValue = SystemCode.ServiceType.CompletionOfCar; break;
                        case "5": rtnValue = SystemCode.ServiceType.BodyRepair; break;
                        case "6": rtnValue = SystemCode.ServiceType.Washing; break;
                        case "7": rtnValue = SystemCode.ServiceType.GeneralRepair; break;
                        case "8": rtnValue = SystemCode.ServiceType.DonativeRepair; break;
                        case "9": rtnValue = SystemCode.ServiceType.ComplaintRepair; break;
                        case "10": rtnValue = SystemCode.ServiceType.Maintenance; break;
                        case "11": rtnValue = SystemCode.ServiceType.TireRepair; break;
                    }
                    break;
                case CodeType.PackageCodeType:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.PackageCodeType.HyundaiPackageCode; break;
                        case "2": rtnValue = SystemCode.PackageCodeType.DealerownPackageCode; break;
                    }
                    break;
                case CodeType.OPCodeType:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.OPCodeType.HyundaiOPCode; break;
                        case "2": rtnValue = SystemCode.OPCodeType.DealerownOPCode; break;
                    }
                    break;
                case CodeType.PartType:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.PartType.HyundaiPart; break;
                        case "2": rtnValue = SystemCode.PartType.DealerownPart; break;
                    }
                    break;
                case CodeType.AppointmentChannel:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.AppointmentChannel.DMS; break;
                        case "2": rtnValue = SystemCode.AppointmentChannel.WA; break;
                        case "3": rtnValue = SystemCode.AppointmentChannel.Bluelink; break;
                        case "4": rtnValue = SystemCode.AppointmentChannel._3rd; break;
                    }
                    break;
                case CodeType.ROChannel:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.ROChannel.DMS; break;
                        case "2": rtnValue = SystemCode.ROChannel.WA; break;
                        case "3": rtnValue = SystemCode.ROChannel.Bluelink; break;
                        case "4": rtnValue = SystemCode.ROChannel._3rd; break;
                    }
                    break;
                //case CodeType.RODocumentStatus:
                //    switch (dmsCodeValue)
                //    {
                //    }
                //    break;
                case CodeType.PauseReasonCode:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.PauseReasonCode.TechnicalTimeout; break;
                        case "2": rtnValue = SystemCode.PauseReasonCode.GettingParts; break;
                        case "3": rtnValue = SystemCode.PauseReasonCode.Dinner; break;
                    }
                    break;
                case CodeType.ActualJobStatus:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.LogStatus.Start; break;
                        case "2": rtnValue = SystemCode.LogStatus.Finish; break;
                        case "3": rtnValue = SystemCode.LogStatus.Pause; break;
                    }
                    break;
                //case CodeType.ActualLogSubStatus:
                //    switch (dmsCodeValue)
                //    {
                //    }
                //    break;
                case CodeType.TransactionType:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.TransactionType.Sync; break;
                        case "2": rtnValue = SystemCode.TransactionType.Async; break;
                    }
                    break;
                case CodeType.RequestType:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.RequestType.Request; break;
                        case "2": rtnValue = SystemCode.RequestType.Polling; break;
                    }
                    break;
                case CodeType.PartStatus:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.PartStatus.Active; break;
                        case "2": rtnValue = SystemCode.PartStatus.NonStocked; break;
                    }
                    break;
                case CodeType.ActionType:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.ActionType.Create; break;
                        case "2": rtnValue = SystemCode.ActionType.Update; break;
                        case "3": rtnValue = SystemCode.ActionType.Delete; break;
                    }
                    break;
                case CodeType.MessageType:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.MessageType.Appointment; break;
                        case "2": rtnValue = SystemCode.MessageType.Employee; break;
                        case "3": rtnValue = SystemCode.MessageType.Job; break;
                        case "4": rtnValue = SystemCode.MessageType.PackageCode; break;
                        case "5": rtnValue = SystemCode.MessageType.RepairOrder; break;
                    }
                    break;
                case CodeType.PrintType:
                    switch (dmsCodeValue)
                    {
                        case "1": rtnValue = SystemCode.PrintType.PreRO; break;
                        case "2": rtnValue = SystemCode.PrintType.WorkingRO; break;
                        case "3": rtnValue = SystemCode.PrintType.FinalRO; break;
                        case "4": rtnValue = SystemCode.PrintType.FinalInspection; break;
                        case "5": rtnValue = SystemCode.PrintType.VHC; break;
                        case "6": rtnValue = SystemCode.PrintType.PartsRequest; break;
                    }
                    break;
            }

            return string.IsNullOrEmpty(rtnValue) ? dmsCodeValue : rtnValue;
        }

        internal static string SetDMSCodeFromWACode(CodeType waCodeType, string waCodeValue)
        {
            string rtnValue = string.Empty;

            switch (waCodeType)
            {
                case CodeType.Gender:
                    switch (waCodeValue)
                    {
                        case SystemCode.Gender.Male: rtnValue = "1"; break;
                        case SystemCode.Gender.Female: rtnValue = "2"; break;
                    }
                    break;
                case CodeType.EmployeeStatus:
                    switch (waCodeValue)
                    {
                        case SystemCode.EmployeeStatus.Work: rtnValue = "1"; break;
                        case SystemCode.EmployeeStatus.Leave: rtnValue = "2"; break;
                        case SystemCode.EmployeeStatus.Retirement: rtnValue = "3"; break;
                    }
                    break;
                case CodeType.RoleName:
                    switch (waCodeValue)
                    {
                        case SystemCode.RoleName.ServiceAdvisor: rtnValue = "1"; break;
                        case SystemCode.RoleName.ServiceManager: rtnValue = "2"; break;
                        case SystemCode.RoleName.WorkshopManager: rtnValue = "3"; break;
                        case SystemCode.RoleName.Technician: rtnValue = "4"; break;
                        case SystemCode.RoleName.FinalInspector: rtnValue = "5"; break;
                        case SystemCode.RoleName.PartsMaster: rtnValue = "6"; break;
                    }
                    break;
                case CodeType.CustomerInfoType:
                    switch (waCodeValue)
                    {
                        case SystemCode.CustomerInfoType.Owner: rtnValue = "1"; break;
                        case SystemCode.CustomerInfoType.Customer: rtnValue = "2"; break;
                        case SystemCode.CustomerInfoType.ContactPerson: rtnValue = "3"; break;
                    }
                    break;
                case CodeType.ContactType:
                    switch (waCodeValue)
                    {
                        case SystemCode.ContactType.HomePhone: rtnValue = "1"; break;
                        case SystemCode.ContactType.CellPhone: rtnValue = "2"; break;
                        case SystemCode.ContactType.BusinessPhone: rtnValue = "3"; break;
                    }
                    break;
                case CodeType.AddressType:
                    switch (waCodeValue)
                    {
                        case SystemCode.AddressType.Legal: rtnValue = "1"; break;
                        case SystemCode.AddressType.Actual: rtnValue = "2"; break;
                        case SystemCode.AddressType.Post: rtnValue = "3"; break;
                    }
                    break;
                case CodeType.VehicleType:
                    switch (waCodeValue)
                    {
                        case SystemCode.VehicleType.Default: rtnValue = "1"; break;
                        case SystemCode.VehicleType.SUV: rtnValue = "2"; break;
                        case SystemCode.VehicleType.Commercial: rtnValue = "3"; break;
                    }
                    break;
                case CodeType.DMSAppointmentStatus:
                    switch (waCodeValue)
                    {
                        case SystemCode.DMSAppointmentStatus.Appointment: rtnValue = "1"; break;
                    }
                    break;
                case CodeType.PaymentMethod:
                    switch (waCodeValue)
                    {
                        case SystemCode.PaymentMethod.Cash: rtnValue = "1"; break;
                        case SystemCode.PaymentMethod.Cashless: rtnValue = "2"; break;
                        case SystemCode.PaymentMethod.Credit: rtnValue = "3"; break;
                    }
                    break;
                case CodeType.WorkType:
                    switch (waCodeValue)
                    {
                        case SystemCode.WorkType.MechanicalRepair: rtnValue = "1"; break;
                        case SystemCode.WorkType.BodyRepair: rtnValue = "2"; break;
                    }
                    break;
                case CodeType.DMSJobStatus:
                    switch (waCodeValue)
                    {
                        case SystemCode.DMSJobStatus.NotStart: rtnValue = "1"; break;
                        case SystemCode.DMSJobStatus.Progressing: rtnValue = "2"; break;
                        case SystemCode.DMSJobStatus.Pause: rtnValue = "3"; break;
                        case SystemCode.DMSJobStatus.Done: rtnValue = "4"; break;
                    }
                    break;
                case CodeType.DMSROStatus:
                    switch (waCodeValue)
                    {
                        case SystemCode.DMSROStatus.Request: rtnValue = "1"; break;
                        case SystemCode.DMSROStatus.Progressing: rtnValue = "2"; break;
                        //case SystemCode.DMSROStatus.Agreement: rtnValue = "3"; break;
                        //case SystemCode.DMSROStatus.ExpectationParts: rtnValue = "4"; break;
                        //case SystemCode.DMSROStatus.Parking: rtnValue = "5"; break;
                        //case SystemCode.DMSROStatus.Done: rtnValue = "6"; break;
                        case SystemCode.DMSROStatus.Closed: rtnValue = "7"; break;
                        //case SystemCode.DMSROStatus.InReserve: rtnValue = "8"; break;
                        //case SystemCode.DMSROStatus.Cancelled: rtnValue = "9"; break;
                    }
                    break;
                case CodeType.ServiceLineStatus:
                    break;
                case CodeType.ServiceType:
                    switch (waCodeValue)
                    {
                        case SystemCode.ServiceType.PromotionRepair: rtnValue = "1"; break;
                        case SystemCode.ServiceType.WarrantyRepair: rtnValue = "2"; break;
                        case SystemCode.ServiceType.OptionalEquipment: rtnValue = "3"; break;
                        case SystemCode.ServiceType.CompletionOfCar: rtnValue = "4"; break;
                        case SystemCode.ServiceType.BodyRepair: rtnValue = "5"; break;
                        case SystemCode.ServiceType.Washing: rtnValue = "6"; break;
                        case SystemCode.ServiceType.GeneralRepair: rtnValue = "7"; break;
                        case SystemCode.ServiceType.DonativeRepair: rtnValue = "8"; break;
                        case SystemCode.ServiceType.ComplaintRepair: rtnValue = "9"; break;
                        case SystemCode.ServiceType.Maintenance: rtnValue = "10"; break;
                        case SystemCode.ServiceType.TireRepair: rtnValue = "11"; break;
                    }
                    break;
                case CodeType.PackageCodeType:
                    switch (waCodeValue)
                    {
                        case SystemCode.PackageCodeType.HyundaiPackageCode: rtnValue = "1"; break;
                        case SystemCode.PackageCodeType.DealerownPackageCode: rtnValue = "2"; break;
                    }
                    break;
                case CodeType.OPCodeType:
                    switch (waCodeValue)
                    {
                        case SystemCode.OPCodeType.HyundaiOPCode: rtnValue = "1"; break;
                        case SystemCode.OPCodeType.DealerownOPCode: rtnValue = "2"; break;
                    }
                    break;
                case CodeType.PartType:
                    switch (waCodeValue)
                    {
                        case SystemCode.PartType.HyundaiPart: rtnValue = "1"; break;
                        case SystemCode.PartType.DealerownPart: rtnValue = "2"; break;
                    }
                    break;
                case CodeType.AppointmentChannel:
                    switch (waCodeValue)
                    {
                        case SystemCode.AppointmentChannel.DMS: rtnValue = "1"; break;
                        case SystemCode.AppointmentChannel.WA: rtnValue = "2"; break;
                        case SystemCode.AppointmentChannel.Bluelink: rtnValue = "3"; break;
                        case SystemCode.AppointmentChannel._3rd: rtnValue = "4"; break;
                    }
                    break;
                case CodeType.ROChannel:
                    switch (waCodeValue)
                    {
                        case SystemCode.ROChannel.DMS: rtnValue = "1"; break;
                        case SystemCode.ROChannel.WA: rtnValue = "2"; break;
                        case SystemCode.ROChannel.Bluelink: rtnValue = "3"; break;
                        case SystemCode.ROChannel._3rd: rtnValue = "4"; break;
                    }
                    break;
                //case CodeType.RODocumentStatus:
                //    switch (dmsCodeValue)
                //    {
                //    }
                //    break;
                case CodeType.PauseReasonCode:
                    switch (waCodeValue)
                    {
                        case SystemCode.PauseReasonCode.TechnicalTimeout: rtnValue = "1"; break;
                        case SystemCode.PauseReasonCode.GettingParts: rtnValue = "2"; break;
                        case SystemCode.PauseReasonCode.Dinner: rtnValue = "3"; break;
                    }
                    break;
                case CodeType.ActualJobStatus:
                    switch (waCodeValue)
                    {
                        case SystemCode.LogStatus.Start: rtnValue = "1"; break;
                        case SystemCode.LogStatus.Finish: rtnValue = "2"; break;
                        case SystemCode.LogStatus.Pause: rtnValue = "3"; break;
                        case SystemCode.LogStatus.Resume: rtnValue = "1"; break;
                        case SystemCode.LogStatus.ReStart: rtnValue = "1"; break;
                    }
                    break;
                //case CodeType.ActualLogSubStatus:
                //    switch (dmsCodeValue)
                //    {
                //    }
                //    break;
                case CodeType.TransactionType:
                    switch (waCodeValue)
                    {
                        case SystemCode.TransactionType.Sync: rtnValue = "1"; break;
                        case SystemCode.TransactionType.Async: rtnValue = "2"; break;
                    }
                    break;
                case CodeType.RequestType:
                    switch (waCodeValue)
                    {
                        case SystemCode.RequestType.Request: rtnValue = "1"; break;
                        case SystemCode.RequestType.Polling: rtnValue = "2"; break;
                    }
                    break;
                case CodeType.PartStatus:
                    switch (waCodeValue)
                    {
                        case SystemCode.PartStatus.Active: rtnValue = "1"; break;
                        case SystemCode.PartStatus.NonStocked: rtnValue = "2"; break;
                    }
                    break;
                case CodeType.ActionType:
                    switch (waCodeValue)
                    {
                        case SystemCode.ActionType.Create: rtnValue = "1"; break;
                        case SystemCode.ActionType.Update: rtnValue = "2"; break;
                        case SystemCode.ActionType.Delete: rtnValue = "3"; break;
                    }
                    break;
                case CodeType.MessageType:
                    switch (waCodeValue)
                    {
                        case SystemCode.MessageType.Appointment: rtnValue = "1"; break;
                        case SystemCode.MessageType.Employee: rtnValue = "2"; break;
                        case SystemCode.MessageType.Job: rtnValue = "3"; break;
                        case SystemCode.MessageType.PackageCode: rtnValue = "4"; break;
                        case SystemCode.MessageType.RepairOrder: rtnValue = "5"; break;
                    }
                    break;
                case CodeType.PrintType:
                    switch (waCodeValue)
                    {
                        case SystemCode.PrintType.PreRO: rtnValue = "1"; break;
                        case SystemCode.PrintType.WorkingRO: rtnValue = "2"; break;
                        case SystemCode.PrintType.FinalRO: rtnValue = "3"; break;
                        case SystemCode.PrintType.FinalInspection: rtnValue = "4"; break;
                        case SystemCode.PrintType.VHC: rtnValue = "5"; break;
                        case SystemCode.PrintType.PartsRequest: rtnValue = "6"; break;
                    }
                    break;
            }

            return string.IsNullOrEmpty(rtnValue) ? waCodeValue : rtnValue;
        }
    }
}
