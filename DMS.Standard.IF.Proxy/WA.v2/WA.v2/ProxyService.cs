using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace WA.v2
{
    public class ProxyService : Base.BaseProxy
    {
        public WA.Standard.IF.Data.v2.Common.Employee.EmployeeGetResponse EmployeeGet(WA.Standard.IF.Data.v2.Common.Employee.EmployeeGetRequest request)
        {
            WA.Standard.IF.Data.v2.Common.Employee.EmployeeGetResponse response = new WA.Standard.IF.Data.v2.Common.Employee.EmployeeGetResponse();

            #region v2.WA.v2 - WA.Standard.IF.WebService
         
            #region EmployeeGet Request Set

            //Create proxy credential
            NetworkCredential proxycredential = new NetworkCredential(request.TransactionHeader.Username, request.TransactionHeader.Password);

            //Create proxy web service from dms web service with credential
            WA.v2.WS_Employee.Employee proxyws = new WA.v2.WS_Employee.Employee();
            proxyws.Credentials = proxycredential;

            //Create proxy request with employeeget and transaction
            WA.v2.WS_Employee.EmployeeGetRequest proxyrequest = new WA.v2.WS_Employee.EmployeeGetRequest();

            //Create proxy transaction
            WA.v2.WS_Employee.TransactionHeader proxytransactionheader = new WA.v2.WS_Employee.TransactionHeader();
            if (request.TransactionHeader != null)
            {
                #region//TransactionHeader Set
                proxytransactionheader.CountryID = request.TransactionHeader.CountryID;
                proxytransactionheader.DealerID = request.TransactionHeader.DealerID;
                proxytransactionheader.DistributorID = request.TransactionHeader.DistributorID;
                proxytransactionheader.DMSCode = request.TransactionHeader.DMSCode;
                proxytransactionheader.DMSServerUrl = request.TransactionHeader.DMSServerUrl;
                proxytransactionheader.DMSVersion = request.TransactionHeader.DMSVersion;
                proxytransactionheader.DocumentVersion = request.TransactionHeader.DocumentVersion;
                proxytransactionheader.GroupID = request.TransactionHeader.GroupID;
                proxytransactionheader.IneterfaceID = request.TransactionHeader.IneterfaceID;
                proxytransactionheader.Password = request.TransactionHeader.Password;
                proxytransactionheader.PollingToken = request.TransactionHeader.PollingToken;
                proxytransactionheader.RequestPollingToken = request.TransactionHeader.RequestPollingToken;
                proxytransactionheader.RequestType = request.TransactionHeader.RequestType;
                proxytransactionheader.TransactionId = request.TransactionHeader.TransactionId;
                proxytransactionheader.TransactionDateTimeLocal = request.TransactionHeader.TransactionDateTimeLocal;
                proxytransactionheader.TransactionDateTimeUTC = request.TransactionHeader.TransactionDateTimeUTC;
                proxytransactionheader.TransactionType = request.TransactionHeader.TransactionType;
                proxytransactionheader.Username = request.TransactionHeader.Username;
                proxytransactionheader.VenderTrackingCode = request.TransactionHeader.VenderTrackingCode;
                proxyrequest.TransactionHeader = proxytransactionheader;
                proxyws.Url = string.Format("{0}/rtr-atest/ws/Employee.1cws", proxytransactionheader.DMSServerUrl);
                #endregion
            }

            //Create proxy employeeget
            WA.v2.WS_Employee.EmployeeGet proxyemployeeget = new WA.v2.WS_Employee.EmployeeGet();
            if (request.EmployeeGet != null)
            {
                #region//EmployeeGet Set
                proxyemployeeget.DMSEmployeeNo = request.EmployeeGet.DMSEmployeeNo;
                proxyemployeeget.LastModifiedDateTimeFromUTC = request.EmployeeGet.LastModifiedDateTimeFromUTC;
                proxyemployeeget.LastModifiedDateTimeToUTC = request.EmployeeGet.LastModifiedDateTimeToUTC;
                proxyemployeeget.LoginID = request.EmployeeGet.LoginID;
                proxyrequest.EmployeeGet = proxyemployeeget;
                #endregion
            }
            #endregion

            //Run proxy web method with proxy request
            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS EmployeeGetRequest XML", proxyrequest);

            WA.v2.WS_Employee.EmployeeGetResponse proxyresponse = proxyws.EmployeeGet(proxyrequest);

            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS EmployeeGetResponse XML", proxyresponse);

            //Mapping with Standard Interface Specification Object
            if (proxyresponse != null)
            {
                if (proxyresponse.TransactionHeader != null)
                {
                    #region//TransactionHeader Set
                    WA.Standard.IF.Data.v2.Common.Common.TransactionHeader transactionheader = new WA.Standard.IF.Data.v2.Common.Common.TransactionHeader();
                    transactionheader.CountryID = proxyresponse.TransactionHeader.CountryID;
                    transactionheader.DealerID = proxyresponse.TransactionHeader.DealerID;
                    transactionheader.DistributorID = proxyresponse.TransactionHeader.DistributorID;
                    transactionheader.DMSCode = proxyresponse.TransactionHeader.DMSCode;
                    transactionheader.DMSServerUrl = proxyresponse.TransactionHeader.DMSServerUrl;
                    transactionheader.DMSVersion = proxyresponse.TransactionHeader.DMSVersion;
                    transactionheader.DocumentVersion = proxyresponse.TransactionHeader.DocumentVersion;
                    transactionheader.GroupID = proxyresponse.TransactionHeader.GroupID;
                    transactionheader.IneterfaceID = proxyresponse.TransactionHeader.IneterfaceID;
                    transactionheader.Password = proxyresponse.TransactionHeader.Password;
                    transactionheader.PollingToken = proxyresponse.TransactionHeader.PollingToken;
                    transactionheader.RequestPollingToken = proxyresponse.TransactionHeader.RequestPollingToken;
                    transactionheader.RequestType = proxyresponse.TransactionHeader.RequestType;
                    transactionheader.TransactionId = proxyresponse.TransactionHeader.TransactionId;
                    transactionheader.TransactionDateTimeLocal = proxyresponse.TransactionHeader.TransactionDateTimeLocal;
                    transactionheader.TransactionDateTimeUTC = proxyresponse.TransactionHeader.TransactionDateTimeUTC;
                    transactionheader.TransactionType = proxyresponse.TransactionHeader.TransactionType;
                    transactionheader.Username = proxyresponse.TransactionHeader.Username;
                    transactionheader.VenderTrackingCode = proxyresponse.TransactionHeader.VenderTrackingCode;
                    response.TransactionHeader = transactionheader;
                    #endregion
                }

                //ResultMessage Set
                if (proxyresponse.ResultMessage != null)
                {
                    response.ResultMessage = GetResultMessageData(proxyresponse.ResultMessage.Code, proxyresponse.ResultMessage.Message);
                }

                if (proxyresponse.Errors != null)
                {
                    //Error List Set
                    foreach (WA.v2.WS_Employee.Error proxyerror in proxyresponse.Errors)
                    {
                        if (response.Errors != null)
                            response.Errors.Add(GetErrorData(proxyerror.Code, proxyerror.Message));
                        else
                            response.Errors = GetErrorDataList(proxyerror.Code, proxyerror.Message);
                    }
                }
                else
                {
                    #region //EmployeeGetResponse Set

                    if (proxyresponse.Employees != null && proxyresponse.Employees.Length > 0)
                    {
                        response.Employees = new List<WA.Standard.IF.Data.v2.Common.Employee.Employee>();
                        foreach (WA.v2.WS_Employee.Employee1 proxyemployee in proxyresponse.Employees)
                        {
                            #region //Employee Header
                            WA.Standard.IF.Data.v2.Common.Employee.Employee employee = new WA.Standard.IF.Data.v2.Common.Employee.Employee();
                            employee.DMSEmployeeNo = proxyemployee.DMSEmployeeNo;
                            employee.Email = proxyemployee.Email;
                            employee.EmployeeStatus = Map.GetWACodeFromDMSCode(CodeType.EmployeeStatus, proxyemployee.EmployeeStatus);
                            employee.FirstName = proxyemployee.FirstName;
                            employee.FullName = proxyemployee.FullName;
                            employee.Gender = Map.GetWACodeFromDMSCode(CodeType.Gender, proxyemployee.Gender);
                            employee.Group = proxyemployee.Group;
                            employee.Language = proxyemployee.Language;
                            employee.LastName = proxyemployee.LastName;
                            employee.LoginID = proxyemployee.LoginID;
                            employee.LoginPassword = proxyemployee.LoginPassword;
                            employee.MiddleName = proxyemployee.MiddleName;
                            employee.MobileNumber = proxyemployee.MobileNumber;
                            employee.PhoneNumber = proxyemployee.PhoneNumber;
                            employee.Salution = proxyemployee.Salution;
                            employee.SkillsetString = proxyemployee.SkillsetString;
                            employee.Title = proxyemployee.Title;
                            #endregion

                            #region //Employee Roles
                            if (proxyemployee.Roles != null && proxyemployee.Roles.Length > 0)
                            {
                                employee.Roles = new List<WA.Standard.IF.Data.v2.Common.Employee.Role>();
                                foreach (WA.v2.WS_Employee.Role proxyrole in proxyemployee.Roles)
                                {
                                    WA.Standard.IF.Data.v2.Common.Employee.Role role = new WA.Standard.IF.Data.v2.Common.Employee.Role();
                                    role.RoleName = Map.GetWACodeFromDMSCode(CodeType.RoleName, proxyrole.RoleName);
                                    role.RoleUserID = proxyrole.RoleUserID;
                                    employee.Roles.Add(role);
                                }
                            }
                            #endregion

                            #region //Employee ManagementFields
                            if (proxyemployee.ManagementFields != null)
                            {
                                WA.Standard.IF.Data.v2.Common.Common.ManagementFields managementfields = new WA.Standard.IF.Data.v2.Common.Common.ManagementFields();
                                managementfields.LastModifiedDateTimeUTC = proxyemployee.ManagementFields.CreateDateTimeUTC;
                                managementfields.LastModifiedDateTimeUTC = proxyemployee.ManagementFields.LastModifiedDateTimeUTC;
                                employee.ManagementFields = managementfields;
                            }

                            response.Employees.Add(employee);
                            #endregion
                        }
                    }
                    else
                    {
                        response.ResultMessage = GetResultMessageData(WA.Standard.IF.Data.v2.Common.Common.ResponseCode.NoResult, WA.Standard.IF.Data.v2.Common.Common.ResponseMessage.NoResult);
                    }
                    #endregion
                }
            }
            #endregion

            return response;
        }

        public WA.Standard.IF.Data.v2.Common.CustomerVehicle.CustomerVehicleGetResponse CustomerVehicleGet(WA.Standard.IF.Data.v2.Common.CustomerVehicle.CustomerVehicleGetRequest request)
        {
            WA.Standard.IF.Data.v2.Common.CustomerVehicle.CustomerVehicleGetResponse response = new WA.Standard.IF.Data.v2.Common.CustomerVehicle.CustomerVehicleGetResponse();

            #region v2.WA.v2 - WA.Standard.IF.WebService
          
            #region CustomerVehicleGet Request Set

            //Create proxy credential
            NetworkCredential proxycredential = new NetworkCredential(request.TransactionHeader.Username, request.TransactionHeader.Password);

            //Create proxy web service from dms web service with credential
            WA.v2.WS_CustomerVehicle.CustomerVehicle proxyws = new WA.v2.WS_CustomerVehicle.CustomerVehicle();
            proxyws.Credentials = proxycredential;

            //Create proxy request with customervehicleget and transaction
            WA.v2.WS_CustomerVehicle.CustomerVehicleGetRequest proxyrequest = new WA.v2.WS_CustomerVehicle.CustomerVehicleGetRequest();

            //Create proxy transaction
            WA.v2.WS_CustomerVehicle.TransactionHeader proxytransactionheader = new WA.v2.WS_CustomerVehicle.TransactionHeader();
            if (request.TransactionHeader != null)
            {
                #region//TransactionHeader Set
                proxytransactionheader.CountryID = request.TransactionHeader.CountryID;
                proxytransactionheader.DealerID = request.TransactionHeader.DealerID;
                proxytransactionheader.DistributorID = request.TransactionHeader.DistributorID;
                proxytransactionheader.DMSCode = request.TransactionHeader.DMSCode;
                proxytransactionheader.DMSServerUrl = request.TransactionHeader.DMSServerUrl;
                proxytransactionheader.DMSVersion = request.TransactionHeader.DMSVersion;
                proxytransactionheader.DocumentVersion = request.TransactionHeader.DocumentVersion;
                proxytransactionheader.GroupID = request.TransactionHeader.GroupID;
                proxytransactionheader.IneterfaceID = request.TransactionHeader.IneterfaceID;
                proxytransactionheader.Password = request.TransactionHeader.Password;
                proxytransactionheader.PollingToken = request.TransactionHeader.PollingToken;
                proxytransactionheader.RequestPollingToken = request.TransactionHeader.RequestPollingToken;
                proxytransactionheader.RequestType = request.TransactionHeader.RequestType;
                proxytransactionheader.TransactionId = request.TransactionHeader.TransactionId;
                proxytransactionheader.TransactionDateTimeLocal = request.TransactionHeader.TransactionDateTimeLocal;
                proxytransactionheader.TransactionDateTimeUTC = request.TransactionHeader.TransactionDateTimeUTC;
                proxytransactionheader.TransactionType = request.TransactionHeader.TransactionType;
                proxytransactionheader.Username = request.TransactionHeader.Username;
                proxytransactionheader.VenderTrackingCode = request.TransactionHeader.VenderTrackingCode;
                proxyrequest.TransactionHeader = proxytransactionheader;
                proxyws.Url = string.Format("{0}/rtr-atest/ws/CustomerVehicle.1cws", proxytransactionheader.DMSServerUrl);
                #endregion
            }

            //Create proxy customervehicleget
            WA.v2.WS_CustomerVehicle.CustomerVehicleGet proxycustomervehicleget = new WA.v2.WS_CustomerVehicle.CustomerVehicleGet();
            if (request.CustomerVehicleGet != null)
            {
                #region//CustomerVehicleGet Customer
                if (request.CustomerVehicleGet.Customer != null)
                {
                    WA.v2.WS_CustomerVehicle.Customer customerget = new WA.v2.WS_CustomerVehicle.Customer();
                    customerget.CardNo = request.CustomerVehicleGet.Customer.CardNo;
                    customerget.DMSCustomerNo = request.CustomerVehicleGet.Customer.DMSCustomerNo;
                    customerget.Email = request.CustomerVehicleGet.Customer.Email;
                    customerget.LastName = request.CustomerVehicleGet.Customer.LastName;

                    if (request.CustomerVehicleGet.Customer.Contacts != null && request.CustomerVehicleGet.Customer.Contacts.Count > 0)
                    {
                        int contactcnt = 0;
                        WA.v2.WS_CustomerVehicle.Contact[] proxycontacts = new WA.v2.WS_CustomerVehicle.Contact[request.CustomerVehicleGet.Customer.Contacts.Count];
                        foreach (WA.Standard.IF.Data.v2.Common.CustomerVehicle.Contact contact in request.CustomerVehicleGet.Customer.Contacts)
                        {
                            WA.v2.WS_CustomerVehicle.Contact proxycontact = new WA.v2.WS_CustomerVehicle.Contact();
                            proxycontact.ContactType = Map.SetDMSCodeFromWACode(CodeType.ContactType, contact.ContactType);
                            proxycontact.ContactValue = contact.ContactValue;
                            proxycontacts[contactcnt] = proxycontact;
                            contactcnt++;
                        }
                        customerget.Contacts = proxycontacts;
                    }

                    proxycustomervehicleget.Customer = customerget;
                }
                #endregion

                #region//CustomerVehicleGet Vehicle
                if (request.CustomerVehicleGet.Vehicle != null)
                {
                    WA.v2.WS_CustomerVehicle.Vehicle proxyvehicle = new WA.v2.WS_CustomerVehicle.Vehicle();
                    proxyvehicle.DMSVehicleNo = request.CustomerVehicleGet.Vehicle.DMSVehicleNo;
                    proxyvehicle.LastSixVIN = request.CustomerVehicleGet.Vehicle.LastSixVIN;
                    proxyvehicle.LicensePlateNo = request.CustomerVehicleGet.Vehicle.LicensePlateNo;
                    proxyvehicle.VIN = request.CustomerVehicleGet.Vehicle.VIN.Length == 17 ? request.CustomerVehicleGet.Vehicle.VIN : "";
                    proxycustomervehicleget.Vehicle = proxyvehicle;
                }
                #endregion

                proxyrequest.CustomerVehicleGet = proxycustomervehicleget;
            }
            #endregion

            //Run proxy web method with proxy request
            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS CustomerVehicleGetRequest XML", proxyrequest);

            WA.v2.WS_CustomerVehicle.CustomerVehicleGetResponse proxyresponse = proxyws.CustomerVehicleGet(proxyrequest);

            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS CustomerVehicleGetResponse XML", proxyresponse);

            //Mapping with Standard Interface Specification Object
            if (proxyresponse != null)
            {
                if (proxyresponse.TransactionHeader != null)
                {
                    #region//TransactionHeader Set
                    WA.Standard.IF.Data.v2.Common.Common.TransactionHeader transactionheader = new WA.Standard.IF.Data.v2.Common.Common.TransactionHeader();
                    transactionheader.CountryID = proxyresponse.TransactionHeader.CountryID;
                    transactionheader.DealerID = proxyresponse.TransactionHeader.DealerID;
                    transactionheader.DistributorID = proxyresponse.TransactionHeader.DistributorID;
                    transactionheader.DMSCode = proxyresponse.TransactionHeader.DMSCode;
                    transactionheader.DMSServerUrl = proxyresponse.TransactionHeader.DMSServerUrl;
                    transactionheader.DMSVersion = proxyresponse.TransactionHeader.DMSVersion;
                    transactionheader.DocumentVersion = proxyresponse.TransactionHeader.DocumentVersion;
                    transactionheader.GroupID = proxyresponse.TransactionHeader.GroupID;
                    transactionheader.IneterfaceID = proxyresponse.TransactionHeader.IneterfaceID;
                    transactionheader.Password = proxyresponse.TransactionHeader.Password;
                    transactionheader.PollingToken = proxyresponse.TransactionHeader.PollingToken;
                    transactionheader.RequestPollingToken = proxyresponse.TransactionHeader.RequestPollingToken;
                    transactionheader.RequestType = proxyresponse.TransactionHeader.RequestType;
                    transactionheader.TransactionId = proxyresponse.TransactionHeader.TransactionId;
                    transactionheader.TransactionDateTimeLocal = proxyresponse.TransactionHeader.TransactionDateTimeLocal;
                    transactionheader.TransactionDateTimeUTC = proxyresponse.TransactionHeader.TransactionDateTimeUTC;
                    transactionheader.TransactionType = proxyresponse.TransactionHeader.TransactionType;
                    transactionheader.Username = proxyresponse.TransactionHeader.Username;
                    transactionheader.VenderTrackingCode = proxyresponse.TransactionHeader.VenderTrackingCode;
                    response.TransactionHeader = transactionheader;
                    #endregion
                }

                //ResultMessage Set
                if (proxyresponse.ResultMessage != null)
                {
                    response.ResultMessage = GetResultMessageData(proxyresponse.ResultMessage.Code, proxyresponse.ResultMessage.Message);
                }

                if (proxyresponse.Errors != null)
                {
                    //Error List Set
                    foreach (WA.v2.WS_CustomerVehicle.Error proxyerror in proxyresponse.Errors)
                    {
                        if (response.Errors != null)
                            response.Errors.Add(GetErrorData(proxyerror.Code, proxyerror.Message));
                        else
                            response.Errors = GetErrorDataList(proxyerror.Code, proxyerror.Message);
                    }
                }
                else
                {
                    #region //CustomerVehicleGetResponse Set

                    if (proxyresponse.CustomerVehicles != null && proxyresponse.CustomerVehicles.Length > 0)
                    {
                        response.CustomerVehicles = new List<WA.Standard.IF.Data.v2.Common.CustomerVehicle.CustomerVehicle>();
                        foreach (WA.v2.WS_CustomerVehicle.CustomerVehicle1 proxycustomervehicle in proxyresponse.CustomerVehicles)
                        {
                            #region //CustomerVehicle Header
                            WA.Standard.IF.Data.v2.Common.CustomerVehicle.CustomerVehicle customervehicle = new WA.Standard.IF.Data.v2.Common.CustomerVehicle.CustomerVehicle();
                            #endregion

                            #region //CustomerVehicle Customer & Vehicle
                            if (proxycustomervehicle.Customer != null && proxycustomervehicle.Vehicle != null)
                            {
                                #region //CustomerVehicle Customer Header
                                WA.Standard.IF.Data.v2.Common.Customer.Customer customer = new WA.Standard.IF.Data.v2.Common.Customer.Customer();
                                customer.CardNo = proxycustomervehicle.Customer.CardNo;
                                customer.CustomerInfoType = Map.GetWACodeFromDMSCode(CodeType.CustomerInfoType, proxycustomervehicle.Customer.CustomerInfoType);
                                customer.DMSCustomerNo = proxycustomervehicle.Customer.DMSCustomerNo;
                                customer.Email = proxycustomervehicle.Customer.Email;
                                customer.FirstName = proxycustomervehicle.Customer.FirstName;
                                customer.FullName = proxycustomervehicle.Customer.FullName;
                                customer.Gender = Map.GetWACodeFromDMSCode(CodeType.Gender, proxycustomervehicle.Customer.Gender);
                                customer.LastName = proxycustomervehicle.Customer.LastName;
                                customer.MiddleName = proxycustomervehicle.Customer.MiddleName;
                                customer.Salutation = proxycustomervehicle.Customer.Salutation;
                                #endregion

                                #region //CustomerVehicle Customer SpecialMessage
                                if (proxycustomervehicle.Customer.SpecialMessage != null)
                                {
                                    WA.Standard.IF.Data.v2.Common.Customer.SpecialMessage specialmessage = new WA.Standard.IF.Data.v2.Common.Customer.SpecialMessage();
                                    specialmessage.Message = proxycustomervehicle.Customer.SpecialMessage.Message;
                                    customer.SpecialMessage = specialmessage;
                                }
                                #endregion

                                #region //CustomerVehicle Customer Addresses
                                if (proxycustomervehicle.Customer.Addresses != null && proxycustomervehicle.Customer.Addresses.Length > 0)
                                {
                                    customer.Addresses = new List<WA.Standard.IF.Data.v2.Common.Customer.Address>();
                                    foreach (WA.v2.WS_CustomerVehicle.Address proxyaddress in proxycustomervehicle.Customer.Addresses)
                                    {
                                        WA.Standard.IF.Data.v2.Common.Customer.Address address = new WA.Standard.IF.Data.v2.Common.Customer.Address();
                                        address.AddressType = Map.GetWACodeFromDMSCode(CodeType.AddressType, proxyaddress.AddressType);
                                        address.City = proxyaddress.City;
                                        address.District = proxyaddress.District;
                                        address.Flat = proxyaddress.Flat;
                                        address.FullAddress = proxyaddress.FullAddress;
                                        address.House = proxyaddress.House;
                                        address.Housing = proxyaddress.Housing;
                                        address.Locality = proxyaddress.Locality;
                                        address.Region = proxyaddress.Region;
                                        address.Street = proxyaddress.Street;
                                        address.ZipCode = proxyaddress.ZipCode;
                                        customer.Addresses.Add(address);
                                    }
                                }
                                #endregion

                                #region //CustomerVehicle Customer Contacts
                                if (proxycustomervehicle.Customer.Contacts != null && proxycustomervehicle.Customer.Contacts.Length > 0)
                                {
                                    customer.Contacts = new List<WA.Standard.IF.Data.v2.Common.Customer.Contact>();
                                    foreach (WA.v2.WS_CustomerVehicle.Contact1 proxycontact in proxycustomervehicle.Customer.Contacts)
                                    {
                                        WA.Standard.IF.Data.v2.Common.Customer.Contact contact = new WA.Standard.IF.Data.v2.Common.Customer.Contact();
                                        contact.ContactMethodYN = proxycontact.ContactMethodYN;
                                        contact.ContactType = Map.GetWACodeFromDMSCode(CodeType.ContactType, proxycontact.ContactType);
                                        contact.ContactValue = proxycontact.ContactValue;
                                        customer.Contacts.Add(contact);
                                    }
                                }
                                #endregion

                                #region //CustomerVehicle Customer CorporateInfos
                                if (proxycustomervehicle.Customer.CorporateInfos != null && proxycustomervehicle.Customer.CorporateInfos.Length > 0)
                                {
                                    customer.CorporateInfos = new List<WA.Standard.IF.Data.v2.Common.Customer.CorporateInfo>();
                                    foreach (WA.v2.WS_CustomerVehicle.CorporateInfo proxycorporateinfo in proxycustomervehicle.Customer.CorporateInfos)
                                    {
                                        WA.Standard.IF.Data.v2.Common.Customer.CorporateInfo corporateinfo = new WA.Standard.IF.Data.v2.Common.Customer.CorporateInfo();
                                        corporateinfo.CorporateInfoName = proxycorporateinfo.CorporateInfoName;
                                        corporateinfo.CorporateInfoValue = proxycorporateinfo.CorporateInfoValue;
                                        customer.CorporateInfos.Add(corporateinfo);
                                    }
                                }
                                #endregion

                                customervehicle.Customer = customer;

                                #region//CustomerVehicle Vehicle Header
                                WA.Standard.IF.Data.v2.Common.Vehicle.Vehicle vehicle = new WA.Standard.IF.Data.v2.Common.Vehicle.Vehicle();
                                vehicle.Color = proxycustomervehicle.Vehicle.Color;
                                vehicle.Cylinders = proxycustomervehicle.Vehicle.Cylinders;
                                vehicle.DateDelivered = proxycustomervehicle.Vehicle.DateDelivered;
                                vehicle.DateInService = proxycustomervehicle.Vehicle.DateInService;
                                vehicle.DeclinedJob = proxycustomervehicle.Vehicle.DeclinedJob;
                                vehicle.DisplayDescription = proxycustomervehicle.Vehicle.DisplayDescription;
                                vehicle.DMSVehicleNo = proxycustomervehicle.Vehicle.DMSVehicleNo;
                                vehicle.EngineType = proxycustomervehicle.Vehicle.EngineType;
                                vehicle.ExtendedWarranty = proxycustomervehicle.Vehicle.ExtendedWarranty;
                                vehicle.FuelType = proxycustomervehicle.Vehicle.FuelType;
                                vehicle.FullModelName = proxycustomervehicle.Vehicle.FullModelName;
                                vehicle.InsuranceDate = proxycustomervehicle.Vehicle.InsuranceDate;
                                vehicle.LastMileage = proxycustomervehicle.Vehicle.LastMileage;
                                vehicle.LastServiceDate = proxycustomervehicle.Vehicle.LastServiceDate;
                                vehicle.LastSixVIN = proxycustomervehicle.Vehicle.VIN;
                                vehicle.LicenseNumber = proxycustomervehicle.Vehicle.LicenseNumber;
                                vehicle.LicensePlateNo = proxycustomervehicle.Vehicle.LicensePlateNo;
                                vehicle.Make = proxycustomervehicle.Vehicle.Make;
                                vehicle.ModelCode = proxycustomervehicle.Vehicle.ModelCode;
                                vehicle.ModelName = proxycustomervehicle.Vehicle.ModelName;
                                vehicle.ModelYear = proxycustomervehicle.Vehicle.ModelYear;
                                vehicle.PendingJob = proxycustomervehicle.Vehicle.PendingJob;
                                vehicle.StockNumber = proxycustomervehicle.Vehicle.StockNumber;
                                vehicle.Trim = proxycustomervehicle.Vehicle.Trim;
                                vehicle.VehicleType = Map.GetWACodeFromDMSCode(CodeType.VehicleType, proxycustomervehicle.Vehicle.VehicleType);
                                vehicle.VIN = proxycustomervehicle.Vehicle.VIN;
                                vehicle.WarrantyMiles = proxycustomervehicle.Vehicle.WarrantyMiles;
                                vehicle.WarrantyMonths = proxycustomervehicle.Vehicle.WarrantyMonths;
                                vehicle.WarrantyStartDate = proxycustomervehicle.Vehicle.WarrantyStartDate;
                                vehicle.EngineNo = proxycustomervehicle.Vehicle.EngineNo;
                                vehicle.ExtendedWarrantyExpireDate = proxycustomervehicle.Vehicle.ExtendedWarrantyExpireDate;
                                #endregion

                                #region//CustomerVehicle Vehicle Campaigns
                                if (proxycustomervehicle.Vehicle.Campaigns != null && proxycustomervehicle.Vehicle.Campaigns.Length > 0)
                                {
                                    vehicle.Campaigns = new List<WA.Standard.IF.Data.v2.Common.Vehicle.Campaign>();
                                    foreach (WA.v2.WS_CustomerVehicle.Campaign proxycampaign in proxycustomervehicle.Vehicle.Campaigns)
                                    {
                                        WA.Standard.IF.Data.v2.Common.Vehicle.Campaign campaign = new WA.Standard.IF.Data.v2.Common.Vehicle.Campaign();
                                        campaign.CampaignDescription = proxycampaign.CampaignDescription;
                                        campaign.CampaignID = proxycampaign.CampaignID;
                                        campaign.CampaignPerformed = proxycampaign.CampaignPerformed;
                                        vehicle.Campaigns.Add(campaign);
                                    }
                                }
                                #endregion

                                customervehicle.Vehicle = vehicle;

                                response.CustomerVehicles.Add(customervehicle);
                            }
                            #endregion
                        }
                    }
                    else
                    {
                        response.ResultMessage = GetResultMessageData(WA.Standard.IF.Data.v2.Common.Common.ResponseCode.NoResult, WA.Standard.IF.Data.v2.Common.Common.ResponseMessage.NoResult);
                    }
                    #endregion
                }
            }
            #endregion

            return response;
        }

        public WA.Standard.IF.Data.v2.Common.CustomerVehicle.CustomerVehicleChangeResponse CustomerVehiclChange(WA.Standard.IF.Data.v2.Common.CustomerVehicle.CustomerVehicleChangeRequest request)
        {
            WA.Standard.IF.Data.v2.Common.CustomerVehicle.CustomerVehicleChangeResponse response = new WA.Standard.IF.Data.v2.Common.CustomerVehicle.CustomerVehicleChangeResponse();

            #region v2.WA.v2 - WA.Standard.IF.WebService
   
            #region CustomerVehicleChange Request Set

            //Create proxy credential
            NetworkCredential proxycredential = new NetworkCredential(request.TransactionHeader.Username, request.TransactionHeader.Password);

            //Create proxy web service from dms web service with credential
            WA.v2.WS_CustomerVehicle.CustomerVehicle proxyws = new WA.v2.WS_CustomerVehicle.CustomerVehicle();
            proxyws.Credentials = proxycredential;

            //Create proxy request with customervehiclechange and transaction
            WA.v2.WS_CustomerVehicle.CustomerVehicleChangeRequest proxyrequest = new WA.v2.WS_CustomerVehicle.CustomerVehicleChangeRequest();

            //Create proxy transaction
            WA.v2.WS_CustomerVehicle.TransactionHeader2 proxytransactionheader = new WA.v2.WS_CustomerVehicle.TransactionHeader2();
            if (request.TransactionHeader != null)
            {
                #region//TransactionHeader Set
                proxytransactionheader.CountryID = request.TransactionHeader.CountryID;
                proxytransactionheader.DealerID = request.TransactionHeader.DealerID;
                proxytransactionheader.DistributorID = request.TransactionHeader.DistributorID;
                proxytransactionheader.DMSCode = request.TransactionHeader.DMSCode;
                proxytransactionheader.DMSServerUrl = request.TransactionHeader.DMSServerUrl;
                proxytransactionheader.DMSVersion = request.TransactionHeader.DMSVersion;
                proxytransactionheader.DocumentVersion = request.TransactionHeader.DocumentVersion;
                proxytransactionheader.GroupID = request.TransactionHeader.GroupID;
                proxytransactionheader.IneterfaceID = request.TransactionHeader.IneterfaceID;
                proxytransactionheader.Password = request.TransactionHeader.Password;
                proxytransactionheader.PollingToken = request.TransactionHeader.PollingToken;
                proxytransactionheader.RequestPollingToken = request.TransactionHeader.RequestPollingToken;
                proxytransactionheader.RequestType = request.TransactionHeader.RequestType;
                proxytransactionheader.TransactionId = request.TransactionHeader.TransactionId;
                proxytransactionheader.TransactionDateTimeLocal = request.TransactionHeader.TransactionDateTimeLocal;
                proxytransactionheader.TransactionDateTimeUTC = request.TransactionHeader.TransactionDateTimeUTC;
                proxytransactionheader.TransactionType = request.TransactionHeader.TransactionType;
                proxytransactionheader.Username = request.TransactionHeader.Username;
                proxytransactionheader.VenderTrackingCode = request.TransactionHeader.VenderTrackingCode;
                proxyrequest.TransactionHeader = proxytransactionheader;
                proxyws.Url = string.Format("{0}/rtr-atest/ws/CustomerVehicle.1cws", proxytransactionheader.DMSServerUrl);
                #endregion
            }

            //Create proxy customervehiclechange
            WA.v2.WS_CustomerVehicle.CustomerVehicleChange proxycustomervehiclechange = new WA.v2.WS_CustomerVehicle.CustomerVehicleChange();
            if (request.CustomerVehicleChange != null)
            {
                #region//CustomerVehicleChange Customer
                if (request.CustomerVehicleChange.Customer != null)
                {
                    WA.v2.WS_CustomerVehicle.Customer2 proxycustomer = new WA.v2.WS_CustomerVehicle.Customer2();

                    proxycustomervehiclechange.Customer = proxycustomer;
                }
                #endregion

                #region//CustomerVehicleChange Vehicle
                if (request.CustomerVehicleChange.Vehicle != null)
                {
                    WA.v2.WS_CustomerVehicle.Vehicle2 proxyvehicle = new WA.v2.WS_CustomerVehicle.Vehicle2();

                    proxycustomervehiclechange.Vehicle = proxyvehicle;
                }
                #endregion

                proxyrequest.CustomerVehicleChange = proxycustomervehiclechange;
            }
            #endregion

            //Run proxy web method with proxy request
            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS CustomerVehicleChangeRequest XML", proxyrequest);

            WA.v2.WS_CustomerVehicle.CustomerVehicleChangeResponse proxyresponse = proxyws.CustomerVehicleChange(proxyrequest);

            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS CustomerVehicleChangeResponse XML", proxyresponse);

            //Mapping with Standard Interface Specification Object
            if (proxyresponse != null)
            {
                if (proxyresponse.TransactionHeader != null)
                {
                    #region//TransactionHeader Set
                    WA.Standard.IF.Data.v2.Common.Common.TransactionHeader transactionheader = new WA.Standard.IF.Data.v2.Common.Common.TransactionHeader();
                    transactionheader.CountryID = proxyresponse.TransactionHeader.CountryID;
                    transactionheader.DealerID = proxyresponse.TransactionHeader.DealerID;
                    transactionheader.DistributorID = proxyresponse.TransactionHeader.DistributorID;
                    transactionheader.DMSCode = proxyresponse.TransactionHeader.DMSCode;
                    transactionheader.DMSServerUrl = proxyresponse.TransactionHeader.DMSServerUrl;
                    transactionheader.DMSVersion = proxyresponse.TransactionHeader.DMSVersion;
                    transactionheader.DocumentVersion = proxyresponse.TransactionHeader.DocumentVersion;
                    transactionheader.GroupID = proxyresponse.TransactionHeader.GroupID;
                    transactionheader.IneterfaceID = proxyresponse.TransactionHeader.IneterfaceID;
                    transactionheader.Password = proxyresponse.TransactionHeader.Password;
                    transactionheader.PollingToken = proxyresponse.TransactionHeader.PollingToken;
                    transactionheader.RequestPollingToken = proxyresponse.TransactionHeader.RequestPollingToken;
                    transactionheader.RequestType = proxyresponse.TransactionHeader.RequestType;
                    transactionheader.TransactionId = proxyresponse.TransactionHeader.TransactionId;
                    transactionheader.TransactionDateTimeLocal = proxyresponse.TransactionHeader.TransactionDateTimeLocal;
                    transactionheader.TransactionDateTimeUTC = proxyresponse.TransactionHeader.TransactionDateTimeUTC;
                    transactionheader.TransactionType = proxyresponse.TransactionHeader.TransactionType;
                    transactionheader.Username = proxyresponse.TransactionHeader.Username;
                    transactionheader.VenderTrackingCode = proxyresponse.TransactionHeader.VenderTrackingCode;
                    response.TransactionHeader = transactionheader;
                    #endregion
                }

                //ResultMessage Set
                if (proxyresponse.ResultMessage != null)
                {
                    response.ResultMessage = GetResultMessageData(proxyresponse.ResultMessage.Code, proxyresponse.ResultMessage.Message);
                }

                if (proxyresponse.Errors != null)
                {
                    //Error List Set
                    foreach (WA.v2.WS_CustomerVehicle.Error1 proxyerror in proxyresponse.Errors)
                    {
                        if (response.Errors != null)
                            response.Errors.Add(GetErrorData(proxyerror.Code, proxyerror.Message));
                        else
                            response.Errors = GetErrorDataList(proxyerror.Code, proxyerror.Message);
                    }
                }
            }
            #endregion

            return response;
        }

        public WA.Standard.IF.Data.v2.Common.Appointment.AppointmentGetResponse AppointmentGet(WA.Standard.IF.Data.v2.Common.Appointment.AppointmentGetRequest request)
        {
            WA.Standard.IF.Data.v2.Common.Appointment.AppointmentGetResponse response = new WA.Standard.IF.Data.v2.Common.Appointment.AppointmentGetResponse();

            #region v2.WA.v2 - WA.Standard.IF.WebService

            #region AppointmentGet Request Set

            //Create proxy credential
            NetworkCredential proxycredential = new NetworkCredential(request.TransactionHeader.Username, request.TransactionHeader.Password);

            //Create proxy web service from dms web service with credential
            WA.v2.WS_Appointment.Appointment proxyws = new WA.v2.WS_Appointment.Appointment();
            proxyws.Credentials = proxycredential;

            //Create proxy request with appointmentget and transaction
            WA.v2.WS_Appointment.AppointmentGetRequest proxyrequest = new WA.v2.WS_Appointment.AppointmentGetRequest();

            //Create proxy transaction
            WA.v2.WS_Appointment.TransactionHeader proxytransactionheader = new WA.v2.WS_Appointment.TransactionHeader();
            if (request.TransactionHeader != null)
            {
                #region//TransactionHeader Set
                proxytransactionheader.CountryID = request.TransactionHeader.CountryID;
                proxytransactionheader.DealerID = request.TransactionHeader.DealerID;
                proxytransactionheader.DistributorID = request.TransactionHeader.DistributorID;
                proxytransactionheader.DMSCode = request.TransactionHeader.DMSCode;
                proxytransactionheader.DMSServerUrl = request.TransactionHeader.DMSServerUrl;
                proxytransactionheader.DMSVersion = request.TransactionHeader.DMSVersion;
                proxytransactionheader.DocumentVersion = request.TransactionHeader.DocumentVersion;
                proxytransactionheader.GroupID = request.TransactionHeader.GroupID;
                proxytransactionheader.IneterfaceID = request.TransactionHeader.IneterfaceID;
                proxytransactionheader.Password = request.TransactionHeader.Password;
                proxytransactionheader.PollingToken = request.TransactionHeader.PollingToken;
                proxytransactionheader.RequestPollingToken = request.TransactionHeader.RequestPollingToken;
                proxytransactionheader.RequestType = request.TransactionHeader.RequestType;
                proxytransactionheader.TransactionId = request.TransactionHeader.TransactionId;
                proxytransactionheader.TransactionDateTimeLocal = request.TransactionHeader.TransactionDateTimeLocal;
                proxytransactionheader.TransactionDateTimeUTC = request.TransactionHeader.TransactionDateTimeUTC;
                proxytransactionheader.TransactionType = request.TransactionHeader.TransactionType;
                proxytransactionheader.Username = request.TransactionHeader.Username;
                proxytransactionheader.VenderTrackingCode = request.TransactionHeader.VenderTrackingCode;
                proxyrequest.TransactionHeader = proxytransactionheader;
                proxyws.Url = string.Format("{0}/rtr-atest/ws/Appointment.1cws", proxytransactionheader.DMSServerUrl);
                #endregion
            }

            //Create proxy appointmentget
            WA.v2.WS_Appointment.AppointmentGet proxyappointmentget = new WA.v2.WS_Appointment.AppointmentGet();
            if (request.AppointmentGet != null)
            {
                #region//AppointmentGet Set
                proxyappointmentget.AppointmentDateTimeFromLocal = request.AppointmentGet.AppointmentDateTimeFromLocal;
                proxyappointmentget.AppointmentDateTimeToLocal = request.AppointmentGet.AppointmentDateTimeFromLocal;
                proxyappointmentget.DMSAppointmentID = request.AppointmentGet.DMSAppointmentID;
                proxyappointmentget.DMSAppointmentNo = request.AppointmentGet.DMSAppointmentNo;
                proxyappointmentget.DMSAppointmentStatus = Map.SetDMSCodeFromWACode(CodeType.DMSAppointmentStatus, request.AppointmentGet.DMSAppointmentStatus);
                proxyappointmentget.LastModifiedDateTimeFromUTC = request.AppointmentGet.LastModifiedDateTimeFromUTC;
                proxyappointmentget.LastModifiedDateTimeToUTC = request.AppointmentGet.LastModifiedDateTimeToUTC;
                proxyappointmentget.SAEmployeeID = request.AppointmentGet.SAEmployeeID;
                proxyappointmentget.SAEmployeeName = request.AppointmentGet.SAEmployeeName;
                proxyappointmentget.TCEmployeeID = request.AppointmentGet.TCEmployeeID;
                proxyappointmentget.TCEmployeeName = request.AppointmentGet.TCEmployeeName;
                if (request.AppointmentGet.Customer != null)
                {
                    WA.v2.WS_Appointment.Customer proxycustomer = new WA.v2.WS_Appointment.Customer();
                    proxycustomer.DMSCustomerNo = request.AppointmentGet.Customer.DMSCustomerNo;
                    proxycustomer.LastName = request.AppointmentGet.Customer.LastName;

                    if (request.AppointmentGet.Customer.Contacts != null && request.AppointmentGet.Customer.Contacts.Count > 0)
                    {
                        int cnt = 0;
                        proxycustomer.Contacts = new WA.v2.WS_Appointment.Contact[request.AppointmentGet.Customer.Contacts.Count];
                        foreach (WA.Standard.IF.Data.v2.Common.Appointment.Contact contact in request.AppointmentGet.Customer.Contacts)
                        {
                            WA.v2.WS_Appointment.Contact proxycontact = new WA.v2.WS_Appointment.Contact();
                            proxycontact.ContactType = Map.SetDMSCodeFromWACode(CodeType.ContactType, contact.ContactType);
                            proxycontact.ContactValue = contact.ContactValue;
                            proxycustomer.Contacts[cnt] = proxycontact;
                            cnt++;
                        }
                    }
                    proxyappointmentget.Customer = proxycustomer;
                }
                proxyrequest.AppointmentGet = proxyappointmentget;
                #endregion
            }

            #endregion

            //Run proxy web method with proxy request
            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS AppointmentGetRequest XML", proxyrequest);
            
            WA.v2.WS_Appointment.AppointmentGetResponse proxyresponse = proxyws.AppointmentGet(proxyrequest);

            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS AppointmentGetResponse XML", proxyresponse);

            //Mapping with Standard Interface Specification Object
            if (proxyresponse != null)
            {
                if (proxyresponse.TransactionHeader != null)
                {
                    #region//TransactionHeader Set
                    WA.Standard.IF.Data.v2.Common.Common.TransactionHeader transactionheader = new WA.Standard.IF.Data.v2.Common.Common.TransactionHeader();
                    transactionheader.CountryID = proxyresponse.TransactionHeader.CountryID;
                    transactionheader.DealerID = proxyresponse.TransactionHeader.DealerID;
                    transactionheader.DistributorID = proxyresponse.TransactionHeader.DistributorID;
                    transactionheader.DMSCode = proxyresponse.TransactionHeader.DMSCode;
                    transactionheader.DMSServerUrl = proxyresponse.TransactionHeader.DMSServerUrl;
                    transactionheader.DMSVersion = proxyresponse.TransactionHeader.DMSVersion;
                    transactionheader.DocumentVersion = proxyresponse.TransactionHeader.DocumentVersion;
                    transactionheader.GroupID = proxyresponse.TransactionHeader.GroupID;
                    transactionheader.IneterfaceID = proxyresponse.TransactionHeader.IneterfaceID;
                    transactionheader.Password = proxyresponse.TransactionHeader.Password;
                    transactionheader.PollingToken = proxyresponse.TransactionHeader.PollingToken;
                    transactionheader.RequestPollingToken = proxyresponse.TransactionHeader.RequestPollingToken;
                    transactionheader.RequestType = proxyresponse.TransactionHeader.RequestType;
                    transactionheader.TransactionId = proxyresponse.TransactionHeader.TransactionId;
                    transactionheader.TransactionDateTimeLocal = proxyresponse.TransactionHeader.TransactionDateTimeLocal;
                    transactionheader.TransactionDateTimeUTC = proxyresponse.TransactionHeader.TransactionDateTimeUTC;
                    transactionheader.TransactionType = proxyresponse.TransactionHeader.TransactionType;
                    transactionheader.Username = proxyresponse.TransactionHeader.Username;
                    transactionheader.VenderTrackingCode = proxyresponse.TransactionHeader.VenderTrackingCode;
                    response.TransactionHeader = transactionheader;
                    #endregion
                }

                //ResultMessage Set
                if (proxyresponse.ResultMessage != null)
                {
                    response.ResultMessage = GetResultMessageData(proxyresponse.ResultMessage.Code, proxyresponse.ResultMessage.Message);
                }

                if (proxyresponse.Errors != null)
                {
                    //Error List Set
                    foreach (WA.v2.WS_Appointment.Error proxyerror in proxyresponse.Errors)
                    {
                        if (response.Errors != null)
                            response.Errors.Add(GetErrorData(proxyerror.Code, proxyerror.Message));
                        else
                            response.Errors = GetErrorDataList(proxyerror.Code, proxyerror.Message);
                    }
                }
                else
                {
                    #region//AppointmentGetResponse Set

                    if (proxyresponse.Appointments != null && proxyresponse.Appointments.Length > 0)
                    {
                        response.Appointments = new List<WA.Standard.IF.Data.v2.Common.Appointment.Appointment>();
                        foreach (WA.v2.WS_Appointment.Appointment1 proxyappointment in proxyresponse.Appointments)
                        {
                            #region //Appointment Header
                            WA.Standard.IF.Data.v2.Common.Appointment.Appointment appointment = new WA.Standard.IF.Data.v2.Common.Appointment.Appointment();
                            appointment.AppointmentDateTimeLocal = proxyappointment.AppointmentDateTimeLocal;
                            appointment.CloseDateTimeLocal = proxyappointment.CloseDateTimeLocal;
                            appointment.CustomerComment = proxyappointment.CustomerComment;
                            appointment.DeliveryDateTimeLocal = proxyappointment.DeliveryDateTimeLocal;
                            appointment.DMSAppointmentID = proxyappointment.DMSAppointmentID;
                            appointment.DMSAppointmentNo = proxyappointment.DMSAppointmentNo;
                            appointment.DMSAppointmentStatus = Map.GetWACodeFromDMSCode(CodeType.DMSAppointmentStatus, proxyappointment.DMSAppointmentStatus);
                            appointment.InMileage = proxyappointment.InMileage;
                            appointment.OpenDateTimeLocal = proxyappointment.OpenDateTimeLocal;
                            appointment.PaymentMethod = Map.GetWACodeFromDMSCode(CodeType.PaymentMethod, proxyappointment.PaymentMethod);
                            appointment.SAEmployeeID = proxyappointment.SAEmployeeID;
                            appointment.SAEmployeeName = proxyappointment.SAEmployeeName;
                            appointment.ServiceType = proxyappointment.ServiceType;
                            appointment.TCEmployeeID = proxyappointment.TCEmployeeID;
                            appointment.TCEmployeeName = proxyappointment.TCEmployeeName;
                            appointment.WorkType = Map.GetWACodeFromDMSCode(CodeType.WorkType, proxyappointment.WorkType);
                            #endregion

                            #region //Appointment AdditionalFields
                            if (proxyappointment.AdditionalFields != null && proxyappointment.AdditionalFields.Length > 0)
                            {
                                appointment.AdditionalFields = new List<WA.Standard.IF.Data.v2.Common.Common.AdditionalField>();
                                foreach (WA.v2.WS_Appointment.AdditionalField proxyadditionalfield in proxyappointment.AdditionalFields)
                                {
                                    WA.Standard.IF.Data.v2.Common.Common.AdditionalField additionalfield = new WA.Standard.IF.Data.v2.Common.Common.AdditionalField();
                                    additionalfield.AdditionalFieldName = proxyadditionalfield.AdditionalFieldName;
                                    additionalfield.AdditionalFieldValue = proxyadditionalfield.AdditionalFieldValue;
                                    appointment.AdditionalFields.Add(additionalfield);
                                }
                            }
                            #endregion

                            #region//Appointment JobRefs
                            if (proxyappointment.JobRefs != null && proxyappointment.JobRefs.Length > 0)
                            {
                                appointment.JobRefs = new List<WA.Standard.IF.Data.v2.Common.Common.JobRef>();
                                foreach (WA.v2.WS_Appointment.JobRef proxyjobref in proxyappointment.JobRefs)
                                {
                                    WA.Standard.IF.Data.v2.Common.Common.JobRef jobref = new WA.Standard.IF.Data.v2.Common.Common.JobRef();
                                    jobref.DMSJobNo = proxyjobref.DMSJobNo;
                                    jobref.DMSJobStatus = Map.GetWACodeFromDMSCode(CodeType.DMSJobStatus, proxyjobref.DMSJobStatus);
                                    appointment.JobRefs.Add(jobref);
                                }
                            }
                            #endregion

                            #region//Appointment ManagementFields
                            if (proxyappointment.ManagementFields != null)
                            {
                                WA.Standard.IF.Data.v2.Common.Common.ManagementFields managementfields = new WA.Standard.IF.Data.v2.Common.Common.ManagementFields();
                                managementfields.CreateDateTimeUTC = proxyappointment.ManagementFields.CreateDateTimeUTC;
                                managementfields.LastModifiedDateTimeUTC = proxyappointment.ManagementFields.LastModifiedDateTimeUTC;
                                appointment.ManagementFields = managementfields;
                            }
                            #endregion

                            #region//Appointment Options
                            if (proxyappointment.Options != null && proxyappointment.Options.Length > 0)
                            {
                                appointment.Options = new List<WA.Standard.IF.Data.v2.Common.Common.Option>();
                                foreach (WA.v2.WS_Appointment.Option proxyoption in proxyappointment.Options)
                                {
                                    WA.Standard.IF.Data.v2.Common.Common.Option option = new WA.Standard.IF.Data.v2.Common.Common.Option();
                                    option.OptionName = proxyoption.OptionName;
                                    option.OptionValue = proxyoption.OptionValue;
                                    appointment.Options.Add(option);
                                }
                            }
                            #endregion

                            #region//Appointment PriceType
                            if (proxyappointment.PriceType != null)
                            {
                                WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                pricetype.DiscountPrice = proxyappointment.PriceType.DiscountPrice;
                                pricetype.DiscountRate = proxyappointment.PriceType.DiscountRate;
                                pricetype.TotalPrice = proxyappointment.PriceType.TotalPrice;
                                pricetype.TotalPriceIncludeTax = proxyappointment.PriceType.TotalPriceIncludeTax;
                                pricetype.UnitPrice = proxyappointment.PriceType.UnitPrice;
                                appointment.PriceType = pricetype;
                            }
                            #endregion

                            #region//Appointment RORefs
                            if (proxyappointment.RORefs != null && proxyappointment.RORefs.Length > 0)
                            {
                                appointment.RORefs = new List<WA.Standard.IF.Data.v2.Common.Common.RORef>();
                                foreach (WA.v2.WS_Appointment.RORef proxyroref in proxyappointment.RORefs)
                                {
                                    WA.Standard.IF.Data.v2.Common.Common.RORef roref = new WA.Standard.IF.Data.v2.Common.Common.RORef();
                                    roref.DMSRONo = proxyroref.DMSRONo;
                                    roref.DMSROStatus = Map.GetWACodeFromDMSCode(CodeType.DMSROStatus, proxyroref.DMSROStatus);
                                    appointment.RORefs.Add(roref);
                                }
                            }
                            #endregion

                            #region//Appointment Customers
                            if (proxyappointment.Customers != null && proxyappointment.Customers.Length > 0)
                            {
                                appointment.Customers = new List<WA.Standard.IF.Data.v2.Common.Customer.Customer>();
                                foreach (WA.v2.WS_Appointment.Customer1 proxycustomer in proxyappointment.Customers)
                                {
                                    #region//Appointment Customer Header
                                    WA.Standard.IF.Data.v2.Common.Customer.Customer customer = new WA.Standard.IF.Data.v2.Common.Customer.Customer();
                                    customer.CardNo = proxycustomer.CardNo;
                                    customer.CorporateInfos = customer.CorporateInfos;
                                    customer.CustomerInfoType = Map.GetWACodeFromDMSCode(CodeType.CustomerInfoType, proxycustomer.CustomerInfoType);
                                    customer.DMSCustomerNo = proxycustomer.DMSCustomerNo;
                                    customer.Email = proxycustomer.Email;
                                    customer.FirstName = proxycustomer.FirstName;
                                    customer.FullName = proxycustomer.FullName;
                                    customer.Gender = Map.GetWACodeFromDMSCode(CodeType.Gender, proxycustomer.Gender);
                                    customer.LastName = proxycustomer.LastName;
                                    customer.MiddleName = proxycustomer.MiddleName;
                                    customer.Salutation = proxycustomer.Salutation;
                                    #endregion

                                    #region//Appointment Customer Addresses
                                    if (proxycustomer.Addresses != null && proxycustomer.Addresses.Length > 0)
                                    {
                                        customer.Addresses = new List<WA.Standard.IF.Data.v2.Common.Customer.Address>();
                                        foreach (WA.v2.WS_Appointment.Address proxyaddress in proxycustomer.Addresses)
                                        {
                                            WA.Standard.IF.Data.v2.Common.Customer.Address address = new WA.Standard.IF.Data.v2.Common.Customer.Address();
                                            address.AddressType = Map.GetWACodeFromDMSCode(CodeType.AddressType, proxyaddress.AddressType);
                                            address.City = proxyaddress.City;
                                            address.District = proxyaddress.District;
                                            address.Flat = proxyaddress.Flat;
                                            address.FullAddress = proxyaddress.FullAddress;
                                            address.House = proxyaddress.House;
                                            address.Housing = proxyaddress.Housing;
                                            address.Locality = proxyaddress.Locality;
                                            address.Region = proxyaddress.Region;
                                            address.Street = proxyaddress.Street;
                                            address.ZipCode = proxyaddress.ZipCode;
                                            customer.Addresses.Add(address);
                                        }
                                    }
                                    #endregion

                                    #region//Appointment Customer Contacts
                                    if (proxycustomer.Contacts != null && proxycustomer.Contacts.Length > 0)
                                    {
                                        customer.Contacts = new List<WA.Standard.IF.Data.v2.Common.Customer.Contact>();
                                        foreach (WA.v2.WS_Appointment.Contact1 proxycontact in proxycustomer.Contacts)
                                        {
                                            WA.Standard.IF.Data.v2.Common.Customer.Contact contact = new WA.Standard.IF.Data.v2.Common.Customer.Contact();
                                            contact.ContactMethodYN = proxycontact.ContactMethodYN;
                                            contact.ContactType = Map.GetWACodeFromDMSCode(CodeType.ContactType, proxycontact.ContactType);
                                            contact.ContactValue = proxycontact.ContactValue;
                                            customer.Contacts.Add(contact);
                                        }
                                    }
                                    #endregion

                                    #region//Appointment Customer SpecialMessage
                                    if (proxycustomer.SpecialMessage != null)
                                    {
                                        WA.Standard.IF.Data.v2.Common.Customer.SpecialMessage specialmessage = new WA.Standard.IF.Data.v2.Common.Customer.SpecialMessage();
                                        specialmessage.Message = proxycustomer.SpecialMessage.Message;
                                        customer.SpecialMessage = specialmessage;
                                    }
                                    #endregion

                                    #region//Appointment Customer CorporateInfos
                                    if (proxycustomer.CorporateInfos != null && proxycustomer.CorporateInfos.Length > 0)
                                    {
                                        customer.CorporateInfos = new List<WA.Standard.IF.Data.v2.Common.Customer.CorporateInfo>();
                                        foreach (WA.v2.WS_Appointment.CorporateInfo proxycorporateinfo in proxycustomer.CorporateInfos)
                                        {
                                            WA.Standard.IF.Data.v2.Common.Customer.CorporateInfo corporateinfo = new WA.Standard.IF.Data.v2.Common.Customer.CorporateInfo();
                                            corporateinfo.CorporateInfoName = proxycorporateinfo.CorporateInfoName;
                                            corporateinfo.CorporateInfoValue = proxycorporateinfo.CorporateInfoValue;
                                            customer.CorporateInfos.Add(corporateinfo);
                                        }
                                    }
                                    #endregion

                                    appointment.Customers.Add(customer);
                                }
                            }
                            #endregion

                            #region//Appointment Vehicle
                            if (proxyappointment.Vehicle != null)
                            {
                                if (proxyappointment.Vehicle != null)
                                {
                                    #region//Appointment Vehicle Header
                                    WA.Standard.IF.Data.v2.Common.Vehicle.Vehicle vehicle = new WA.Standard.IF.Data.v2.Common.Vehicle.Vehicle();
                                    vehicle.Color = proxyappointment.Vehicle.Color;
                                    vehicle.Cylinders = proxyappointment.Vehicle.Cylinders;
                                    vehicle.DateDelivered = proxyappointment.Vehicle.DateDelivered;
                                    vehicle.DateInService = proxyappointment.Vehicle.DateInService;
                                    vehicle.DeclinedJob = proxyappointment.Vehicle.DeclinedJob;
                                    vehicle.DisplayDescription = proxyappointment.Vehicle.DisplayDescription;
                                    vehicle.DMSVehicleNo = proxyappointment.Vehicle.DMSVehicleNo;
                                    vehicle.EngineType = proxyappointment.Vehicle.EngineType;
                                    vehicle.ExtendedWarranty = proxyappointment.Vehicle.ExtendedWarranty;
                                    vehicle.FuelType = proxyappointment.Vehicle.FuelType;
                                    vehicle.FullModelName = proxyappointment.Vehicle.FullModelName;
                                    vehicle.InsuranceDate = proxyappointment.Vehicle.InsuranceDate;
                                    vehicle.LastMileage = proxyappointment.Vehicle.LastMileage;
                                    vehicle.LastServiceDate = proxyappointment.Vehicle.LastServiceDate;
                                    vehicle.LastSixVIN = proxyappointment.Vehicle.LastSixVIN;
                                    vehicle.LicenseNumber = proxyappointment.Vehicle.LicenseNumber;
                                    vehicle.LicensePlateNo = proxyappointment.Vehicle.LicensePlateNo;
                                    vehicle.Make = proxyappointment.Vehicle.Make;
                                    vehicle.ModelCode = proxyappointment.Vehicle.ModelCode;
                                    vehicle.ModelName = proxyappointment.Vehicle.ModelName;
                                    vehicle.ModelYear = proxyappointment.Vehicle.ModelYear;
                                    vehicle.PendingJob = proxyappointment.Vehicle.PendingJob;
                                    vehicle.StockNumber = proxyappointment.Vehicle.StockNumber;
                                    vehicle.Trim = proxyappointment.Vehicle.Trim;
                                    vehicle.VehicleType = Map.GetWACodeFromDMSCode(CodeType.VehicleType, proxyappointment.Vehicle.VehicleType);
                                    vehicle.VIN = proxyappointment.Vehicle.VIN;
                                    vehicle.WarrantyMiles = proxyappointment.Vehicle.WarrantyMiles;
                                    vehicle.WarrantyMonths = proxyappointment.Vehicle.WarrantyMonths;
                                    vehicle.WarrantyStartDate = proxyappointment.Vehicle.WarrantyStartDate;
                                    #endregion

                                    #region//Appointment Vehicle Campaigns
                                    if (proxyappointment.Vehicle.Campaigns != null && proxyappointment.Vehicle.Campaigns.Length > 0)
                                    {
                                        vehicle.Campaigns = new List<WA.Standard.IF.Data.v2.Common.Vehicle.Campaign>();
                                        foreach (WA.v2.WS_Appointment.Campaign proxycampaign in proxyappointment.Vehicle.Campaigns)
                                        {
                                            WA.Standard.IF.Data.v2.Common.Vehicle.Campaign campaign = new WA.Standard.IF.Data.v2.Common.Vehicle.Campaign();
                                            campaign.CampaignDescription = proxycampaign.CampaignDescription;
                                            campaign.CampaignID = proxycampaign.CampaignID;
                                            campaign.CampaignPerformed = proxycampaign.CampaignPerformed;
                                            vehicle.Campaigns.Add(campaign);
                                        }
                                    }
                                    #endregion

                                    appointment.Vehicle = vehicle;
                                }
                            }
                            #endregion

                            #region//Appointment RequestItems
                            if (proxyappointment.RequestItems != null && proxyappointment.RequestItems.Length > 0)
                            {
                                appointment.RequestItems = new List<WA.Standard.IF.Data.v2.Common.Common.RequestItem>();
                                foreach (WA.v2.WS_Appointment.RequestItem proxyrequestitem in proxyappointment.RequestItems)
                                {
                                    #region//Appointment RequestItem Header
                                    WA.Standard.IF.Data.v2.Common.Common.RequestItem requestitem = new WA.Standard.IF.Data.v2.Common.Common.RequestItem();
                                    requestitem.CPSIND = proxyrequestitem.CPSIND;
                                    requestitem.RequestCode = proxyrequestitem.RequestCode;
                                    requestitem.RequestDescription = proxyrequestitem.RequestDescription;
                                    requestitem.ServiceLineNumber = proxyrequestitem.ServiceLineNumber;
                                    requestitem.ServiceLineStatus = Map.GetWACodeFromDMSCode(CodeType.ServiceLineStatus, proxyrequestitem.ServiceLineStatus);
                                    requestitem.ServiceType = Map.GetWACodeFromDMSCode(CodeType.ServiceType, proxyrequestitem.ServiceType);
                                    requestitem.TCEmployeeID = proxyrequestitem.TCEmployeeID;
                                    requestitem.TCEmployeeName = proxyrequestitem.TCEmployeeName;
                                    requestitem.WorkType = Map.GetWACodeFromDMSCode(CodeType.WorkType, proxyrequestitem.WorkType);
                                    #endregion

                                    #region//Appointment RequestItem Comments
                                    if (proxyrequestitem.Comments != null && proxyrequestitem.Comments.Length > 0)
                                    {
                                        requestitem.Comments = new List<WA.Standard.IF.Data.v2.Common.Common.Comment>();
                                        foreach (WA.v2.WS_Appointment.Comment proxycomment in proxyrequestitem.Comments)
                                        {
                                            WA.Standard.IF.Data.v2.Common.Common.Comment comment = new WA.Standard.IF.Data.v2.Common.Common.Comment();
                                            comment.DescriptionComment = proxycomment.DescriptionComment;
                                            comment.SequenceNumber = proxycomment.SequenceNumber;
                                            requestitem.Comments.Add(comment);
                                        }
                                    }
                                    #endregion

                                    #region//Appointment RequestItem Descriptions
                                    if (proxyrequestitem.Descriptions != null && proxyrequestitem.Descriptions.Length > 0)
                                    {
                                        requestitem.Descriptions = new List<WA.Standard.IF.Data.v2.Common.Common.Description>();
                                        foreach (WA.v2.WS_Appointment.Description proxydescription in proxyrequestitem.Descriptions)
                                        {
                                            WA.Standard.IF.Data.v2.Common.Common.Description description = new WA.Standard.IF.Data.v2.Common.Common.Description();
                                            description.DescriptionComment = proxydescription.DescriptionComment;
                                            description.SequenceNumber = proxydescription.SequenceNumber;
                                            requestitem.Descriptions.Add(description);
                                        }
                                    }
                                    #endregion

                                    #region//Appointment RequestItem OPCodes
                                    if (proxyrequestitem.OPCodes != null && proxyrequestitem.OPCodes.Length > 0)
                                    {
                                        requestitem.OPCodes = new List<WA.Standard.IF.Data.v2.Common.Common.OPCode>();
                                        foreach (WA.v2.WS_Appointment.OPCode proxyopcode in proxyrequestitem.OPCodes)
                                        {
                                            #region//Appointment RequestItem OPCode Header
                                            WA.Standard.IF.Data.v2.Common.Common.OPCode opcode = new WA.Standard.IF.Data.v2.Common.Common.OPCode();
                                            opcode.ActualHours = proxyopcode.ActualHours;
                                            opcode.Code = proxyopcode.Code;
                                            opcode.Description = proxyopcode.Description;
                                            opcode.EstimatedHours = proxyopcode.EstimatedHours;
                                            opcode.OPCodeType = Map.GetWACodeFromDMSCode(CodeType.OPCodeType, proxyopcode.OPCodeType);
                                            opcode.Quantity = proxyopcode.Quantity;
                                            opcode.SequenceNumber = proxyopcode.SequenceNumber;
                                            opcode.ServiceType = Map.GetWACodeFromDMSCode(CodeType.ServiceType, proxyopcode.ServiceType);
                                            opcode.SkillLevel = proxyopcode.SkillLevel;
                                            #endregion

                                            #region//Appointment RequestItem OPCode Descriptions
                                            if (proxyopcode.Descriptions != null && proxyopcode.Descriptions.Length > 0)
                                            {
                                                opcode.Descriptions = new List<WA.Standard.IF.Data.v2.Common.Common.Description>();
                                                foreach (WA.v2.WS_Appointment.Description proxydescription in proxyopcode.Descriptions)
                                                {
                                                    WA.Standard.IF.Data.v2.Common.Common.Description description = new WA.Standard.IF.Data.v2.Common.Common.Description();
                                                    description.DescriptionComment = proxydescription.DescriptionComment;
                                                    description.SequenceNumber = proxydescription.SequenceNumber;
                                                    opcode.Descriptions.Add(description);
                                                }
                                            }
                                            #endregion

                                            #region//Appointment RequestItem OPCode Causes
                                            if (proxyopcode.Causes != null && proxyopcode.Causes.Length > 0)
                                            {
                                                opcode.Causes = new List<WA.Standard.IF.Data.v2.Common.Common.Cause>();
                                                foreach (WA.v2.WS_Appointment.Cause proxycause in proxyopcode.Causes)
                                                {
                                                    WA.Standard.IF.Data.v2.Common.Common.Cause cause = new WA.Standard.IF.Data.v2.Common.Common.Cause();
                                                    cause.CauseLaborOpCode = proxycause.CauseLaborOpCode;
                                                    cause.Comment = proxycause.Comment;
                                                    cause.SequenceNumber = proxycause.SequenceNumber;
                                                    opcode.Causes.Add(cause);
                                                }
                                            }
                                            #endregion

                                            #region//Appointment RequestItem OPCode Corrections
                                            if (proxyopcode.Corrections != null && proxyopcode.Corrections.Length > 0)
                                            {
                                                opcode.Corrections = new List<WA.Standard.IF.Data.v2.Common.Common.Correction>();
                                                foreach (WA.v2.WS_Appointment.Correction proxycorrection in proxyopcode.Corrections)
                                                {
                                                    WA.Standard.IF.Data.v2.Common.Common.Correction correction = new WA.Standard.IF.Data.v2.Common.Common.Correction();
                                                    correction.CorrectionLaborOpCode = proxycorrection.CorrectionLaborOpCode;
                                                    correction.Comment = proxycorrection.Comment;
                                                    correction.SequenceNumber = proxycorrection.SequenceNumber;
                                                    opcode.Corrections.Add(correction);
                                                }
                                            }
                                            #endregion

                                            #region//Appointment RequestItem OPCode PriceType
                                            if (proxyopcode.PriceType != null)
                                            {
                                                WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                                pricetype.DiscountPrice = proxyopcode.PriceType.DiscountPrice;
                                                pricetype.DiscountRate = proxyopcode.PriceType.DiscountRate;
                                                pricetype.TotalPrice = proxyopcode.PriceType.TotalPrice;
                                                pricetype.TotalPriceIncludeTax = proxyopcode.PriceType.TotalPriceIncludeTax;
                                                pricetype.UnitPrice = proxyopcode.PriceType.UnitPrice;
                                                opcode.PriceType = pricetype;
                                            }
                                            #endregion

                                            #region//Appointment RequestItem OPCode Parts
                                            if (proxyopcode.Parts != null && proxyopcode.Parts.Length > 0)
                                            {
                                                opcode.Parts = new List<WA.Standard.IF.Data.v2.Common.Common.Part>();
                                                foreach (WA.v2.WS_Appointment.Part proxypart in proxyopcode.Parts)
                                                {
                                                    #region//Appointment RequestItem OPCode Parts Header
                                                    WA.Standard.IF.Data.v2.Common.Common.Part part = new WA.Standard.IF.Data.v2.Common.Common.Part();
                                                    part.DisplayPartNumber = proxypart.DisplayPartNumber;
                                                    part.PartDescription = proxypart.PartDescription;
                                                    part.PartNumber = proxypart.PartNumber;
                                                    part.PartType = Map.GetWACodeFromDMSCode(CodeType.PartType, proxypart.PartType);
                                                    part.Quantity = proxypart.Quantity;
                                                    part.SequenceNumber = proxypart.SequenceNumber;
                                                    part.ServiceType = Map.GetWACodeFromDMSCode(CodeType.ServiceType, proxypart.ServiceType);
                                                    part.StockQuantity = proxypart.StockQuantity;
                                                    part.StockStatus = proxypart.StockStatus;
                                                    part.UnitOfMeasure = proxypart.UnitOfMeasure;
                                                    #endregion

                                                    #region//Appointment RequestItem OPCode Parts Descriptions
                                                    if (proxypart.Descriptions != null && proxypart.Descriptions.Length > 0)
                                                    {
                                                        part.Descriptions = new List<WA.Standard.IF.Data.v2.Common.Common.Description>();
                                                        foreach (WA.v2.WS_Appointment.Description proxydescription in proxypart.Descriptions)
                                                        {
                                                            WA.Standard.IF.Data.v2.Common.Common.Description description = new WA.Standard.IF.Data.v2.Common.Common.Description();
                                                            description.DescriptionComment = proxydescription.DescriptionComment;
                                                            description.SequenceNumber = proxydescription.SequenceNumber;
                                                            part.Descriptions.Add(description);
                                                        }
                                                    }
                                                    #endregion

                                                    #region//Appointment RequestItem OPCode Parts PriceType
                                                    if (proxypart.PriceType != null)
                                                    {
                                                        WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                                        pricetype.DiscountPrice = proxypart.PriceType.DiscountPrice;
                                                        pricetype.DiscountRate = proxypart.PriceType.DiscountRate;
                                                        pricetype.TotalPrice = proxypart.PriceType.TotalPrice;
                                                        pricetype.TotalPriceIncludeTax = proxypart.PriceType.TotalPriceIncludeTax;
                                                        pricetype.UnitPrice = proxypart.PriceType.UnitPrice;
                                                        part.PriceType = pricetype;
                                                    }
                                                    #endregion

                                                    opcode.Parts.Add(part);
                                                }
                                            }
                                            #endregion

                                            #region//Appointment RequestItem OPCode Sublets
                                            if (proxyopcode.Sublets != null && proxyopcode.Sublets.Length > 0)
                                            {
                                                opcode.Sublets = new List<WA.Standard.IF.Data.v2.Common.Common.Sublet>();
                                                foreach (WA.v2.WS_Appointment.Sublet proxysublet in proxyopcode.Sublets)
                                                {
                                                    #region//Appointment RequestItem OPCode Sublet Header
                                                    WA.Standard.IF.Data.v2.Common.Common.Sublet sublet = new WA.Standard.IF.Data.v2.Common.Common.Sublet();
                                                    sublet.SequenceNumber = proxysublet.SequenceNumber;
                                                    sublet.ServiceType = Map.GetWACodeFromDMSCode(CodeType.ServiceType, proxysublet.ServiceType);
                                                    #endregion

                                                    #region//Appointment RequestItem OPCode Sublets Descriptions
                                                    if (proxysublet.Descriptions != null && proxysublet.Descriptions.Length > 0)
                                                    {
                                                        sublet.Descriptions = new List<WA.Standard.IF.Data.v2.Common.Common.Description>();
                                                        foreach (WA.v2.WS_Appointment.Description proxydescription in proxysublet.Descriptions)
                                                        {
                                                            WA.Standard.IF.Data.v2.Common.Common.Description description = new WA.Standard.IF.Data.v2.Common.Common.Description();
                                                            description.DescriptionComment = proxydescription.DescriptionComment;
                                                            description.SequenceNumber = proxydescription.SequenceNumber;
                                                            sublet.Descriptions.Add(description);
                                                        }
                                                    }
                                                    #endregion

                                                    #region//Appointment RequestItem OPCode Sublets PriceType
                                                    if (proxysublet.PriceType != null)
                                                    {
                                                        WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                                        pricetype.DiscountPrice = proxysublet.PriceType.DiscountPrice;
                                                        pricetype.DiscountRate = proxysublet.PriceType.DiscountRate;
                                                        pricetype.TotalPrice = proxysublet.PriceType.TotalPrice;
                                                        pricetype.TotalPriceIncludeTax = proxysublet.PriceType.TotalPriceIncludeTax;
                                                        pricetype.UnitPrice = proxysublet.PriceType.UnitPrice;
                                                        sublet.PriceType = pricetype;
                                                    }
                                                    #endregion

                                                    opcode.Sublets.Add(sublet);
                                                }
                                            }
                                            #endregion

                                            #region//Appointment RequestItem OPCode MISCs
                                            if (proxyopcode.MISCs != null && proxyopcode.MISCs.Length > 0)
                                            {
                                                opcode.MISCs = new List<WA.Standard.IF.Data.v2.Common.Common.MISC>();
                                                foreach (WA.v2.WS_Appointment.MISC proxymisc in proxyopcode.MISCs)
                                                {
                                                    #region//Appointment RequestItem OPCode MISC Header
                                                    WA.Standard.IF.Data.v2.Common.Common.MISC misc = new WA.Standard.IF.Data.v2.Common.Common.MISC();
                                                    misc.SequenceNumber = proxymisc.SequenceNumber;
                                                    misc.ServiceType = Map.GetWACodeFromDMSCode(CodeType.ServiceType, proxymisc.ServiceType);
                                                    #endregion

                                                    #region//Appointment RequestItem OPCode MISCs Descriptions
                                                    if (proxymisc.Descriptions != null && proxymisc.Descriptions.Length > 0)
                                                    {
                                                        misc.Descriptions = new List<WA.Standard.IF.Data.v2.Common.Common.Description>();
                                                        foreach (WA.v2.WS_Appointment.Description proxydescription in proxymisc.Descriptions)
                                                        {
                                                            WA.Standard.IF.Data.v2.Common.Common.Description description = new WA.Standard.IF.Data.v2.Common.Common.Description();
                                                            description.DescriptionComment = proxydescription.DescriptionComment;
                                                            description.SequenceNumber = proxydescription.SequenceNumber;
                                                            misc.Descriptions.Add(description);
                                                        }
                                                    }
                                                    #endregion

                                                    #region//Appointment RequestItem OPCode MISCs PriceType
                                                    if (proxymisc.PriceType != null)
                                                    {
                                                        WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                                        pricetype.DiscountPrice = proxymisc.PriceType.DiscountPrice;
                                                        pricetype.DiscountRate = proxymisc.PriceType.DiscountRate;
                                                        pricetype.TotalPrice = proxymisc.PriceType.TotalPrice;
                                                        pricetype.TotalPriceIncludeTax = proxymisc.PriceType.TotalPriceIncludeTax;
                                                        pricetype.UnitPrice = proxymisc.PriceType.UnitPrice;
                                                        misc.PriceType = pricetype;
                                                    }
                                                    #endregion

                                                    opcode.MISCs.Add(misc);
                                                }
                                            }
                                            #endregion

                                            requestitem.OPCodes.Add(opcode);
                                        }
                                    }
                                    #endregion

                                    appointment.RequestItems.Add(requestitem);
                                }
                            }
                            #endregion

                            response.Appointments.Add(appointment);
                        }
                    }
                    else
                    {
                        response.ResultMessage = GetResultMessageData(WA.Standard.IF.Data.v2.Common.Common.ResponseCode.NoResult, WA.Standard.IF.Data.v2.Common.Common.ResponseMessage.NoResult);
                    }
                    #endregion
                }
            }
            #endregion

            return response;
        }

        public WA.Standard.IF.Data.v2.Common.Appointment.AppointmentChangeResponse AppointmentChange(WA.Standard.IF.Data.v2.Common.Appointment.AppointmentChangeRequest request)
        {
            WA.Standard.IF.Data.v2.Common.Appointment.AppointmentChangeResponse response = new WA.Standard.IF.Data.v2.Common.Appointment.AppointmentChangeResponse();

            #region v2.WA.v2 - WA.Standard.IF.WebService

            #region AppointmentChange Request Set

            //Create proxy credential
            NetworkCredential proxycredential = new NetworkCredential(request.TransactionHeader.Username, request.TransactionHeader.Password);

            //Create proxy web service from dms web service with credential
            WA.v2.WS_Appointment.Appointment proxyws = new WA.v2.WS_Appointment.Appointment();
            proxyws.Credentials = proxycredential;

            //Create proxy request with appointmentchange and transaction
            WA.v2.WS_Appointment.AppointmentChangeRequest proxyrequest = new WA.v2.WS_Appointment.AppointmentChangeRequest();

            //Create proxy transaction
            WA.v2.WS_Appointment.TransactionHeader2 proxytransactionheader = new WA.v2.WS_Appointment.TransactionHeader2();
            if (request.TransactionHeader != null)
            {
                #region//TransactionHeader Set
                proxytransactionheader.CountryID = request.TransactionHeader.CountryID;
                proxytransactionheader.DealerID = request.TransactionHeader.DealerID;
                proxytransactionheader.DistributorID = request.TransactionHeader.DistributorID;
                proxytransactionheader.DMSCode = request.TransactionHeader.DMSCode;
                proxytransactionheader.DMSServerUrl = request.TransactionHeader.DMSServerUrl;
                proxytransactionheader.DMSVersion = request.TransactionHeader.DMSVersion;
                proxytransactionheader.DocumentVersion = request.TransactionHeader.DocumentVersion;
                proxytransactionheader.GroupID = request.TransactionHeader.GroupID;
                proxytransactionheader.IneterfaceID = request.TransactionHeader.IneterfaceID;
                proxytransactionheader.Password = request.TransactionHeader.Password;
                proxytransactionheader.PollingToken = request.TransactionHeader.PollingToken;
                proxytransactionheader.RequestPollingToken = request.TransactionHeader.RequestPollingToken;
                proxytransactionheader.RequestType = request.TransactionHeader.RequestType;
                proxytransactionheader.TransactionId = request.TransactionHeader.TransactionId;
                proxytransactionheader.TransactionDateTimeLocal = request.TransactionHeader.TransactionDateTimeLocal;
                proxytransactionheader.TransactionDateTimeUTC = request.TransactionHeader.TransactionDateTimeUTC;
                proxytransactionheader.TransactionType = request.TransactionHeader.TransactionType;
                proxytransactionheader.Username = request.TransactionHeader.Username;
                proxytransactionheader.VenderTrackingCode = request.TransactionHeader.VenderTrackingCode;
                proxyrequest.TransactionHeader = proxytransactionheader;
                proxyws.Url = string.Format("{0}/rtr-atest/ws/Appointment.1cws", proxytransactionheader.DMSServerUrl);
                #endregion
            }

            //Create proxy appointmentchange
            WA.v2.WS_Appointment.AppointmentChange proxyappointmentchange = new WA.v2.WS_Appointment.AppointmentChange();
            if (request.AppointmentChange != null)
            {
                #region//Appointment Header
                proxyappointmentchange.AppointmentChannel = Map.SetDMSCodeFromWACode(CodeType.AppointmentChannel, request.AppointmentChange.AppointmentChannel);
                proxyappointmentchange.AppointmentDateTimeLocal = request.AppointmentChange.AppointmentDateTimeLocal;
                proxyappointmentchange.CloseDateTimeLocal = request.AppointmentChange.CloseDateTimeLocal;
                proxyappointmentchange.CustomerComment = request.AppointmentChange.CustomerComment;
                proxyappointmentchange.DeliveryDateTimeLocal = request.AppointmentChange.DeliveryDateTimeLocal;
                proxyappointmentchange.DMSAppointmentID = request.AppointmentChange.DMSAppointmentID;
                proxyappointmentchange.DMSAppointmentNo = string.IsNullOrEmpty(request.AppointmentChange.DMSAppointmentNo) ? string.Empty : request.AppointmentChange.DMSAppointmentNo;
                proxyappointmentchange.DMSAppointmentStatus = Map.SetDMSCodeFromWACode(CodeType.DMSAppointmentStatus, request.AppointmentChange.DMSAppointmentStatus);
                proxyappointmentchange.InMileage = request.AppointmentChange.InMileage;
                proxyappointmentchange.OpenDateTimeLocal = request.AppointmentChange.OpenDateTimeLocal;
                proxyappointmentchange.PaymentMethod = Map.SetDMSCodeFromWACode(CodeType.PaymentMethod, request.AppointmentChange.PaymentMethod);
                proxyappointmentchange.SAEmployeeID = request.AppointmentChange.SAEmployeeID;
                proxyappointmentchange.SAEmployeeName = request.AppointmentChange.SAEmployeeName;
                proxyappointmentchange.ServiceType = request.AppointmentChange.ServiceType;
                proxyappointmentchange.TCEmployeeID = request.AppointmentChange.TCEmployeeID;
                proxyappointmentchange.TCEmployeeName = request.AppointmentChange.TCEmployeeName;
                proxyappointmentchange.WorkType = Map.SetDMSCodeFromWACode(CodeType.WorkType, request.AppointmentChange.WorkType);
                #endregion

                #region //Appointment AdditionalFields
                if (request.AppointmentChange.AdditionalFields != null && request.AppointmentChange.AdditionalFields.Count > 0)
                {
                    int additionalfieldscnt = 0;
                    WA.v2.WS_Appointment.AdditionalField1[] proxyadditionalfields = new WA.v2.WS_Appointment.AdditionalField1[request.AppointmentChange.AdditionalFields.Count];
                    foreach (WA.Standard.IF.Data.v2.Common.Common.AdditionalField additionalfield in request.AppointmentChange.AdditionalFields)
                    {
                        WA.v2.WS_Appointment.AdditionalField1 proxyadditionalfield = new WA.v2.WS_Appointment.AdditionalField1();
                        proxyadditionalfield.AdditionalFieldName = additionalfield.AdditionalFieldName;
                        proxyadditionalfield.AdditionalFieldValue = additionalfield.AdditionalFieldValue;
                        proxyadditionalfields[additionalfieldscnt] = proxyadditionalfield;
                        additionalfieldscnt++;
                    }
                    proxyappointmentchange.AdditionalFields = proxyadditionalfields;
                }
                #endregion

                #region//Appointment Options
                if (request.AppointmentChange.Options != null && request.AppointmentChange.Options.Count > 0)
                {
                    int optionscnt = 0;
                    WA.v2.WS_Appointment.Option1[] proxyoptions = new WA.v2.WS_Appointment.Option1[request.AppointmentChange.Options.Count];
                    foreach (WA.Standard.IF.Data.v2.Common.Common.Option option in request.AppointmentChange.Options)
                    {
                        WA.v2.WS_Appointment.Option1 proxyoption = new WA.v2.WS_Appointment.Option1();
                        proxyoption.OptionName = option.OptionName;
                        proxyoption.OptionValue = option.OptionValue;
                        proxyoptions[optionscnt] = proxyoption;
                        optionscnt++;
                    }
                    proxyappointmentchange.Options = proxyoptions;
                }
                #endregion

                #region//Appointment PriceType
                if (request.AppointmentChange.PriceType != null)
                {
                    WA.v2.WS_Appointment.PriceType1 proxypricetype = new WA.v2.WS_Appointment.PriceType1();
                    proxypricetype.DiscountPrice = request.AppointmentChange.PriceType.DiscountPrice;
                    proxypricetype.DiscountRate = request.AppointmentChange.PriceType.DiscountRate;
                    proxypricetype.TotalPrice = request.AppointmentChange.PriceType.TotalPrice;
                    proxypricetype.TotalPriceIncludeTax = request.AppointmentChange.PriceType.TotalPriceIncludeTax;
                    proxypricetype.UnitPrice = request.AppointmentChange.PriceType.UnitPrice;
                    proxyappointmentchange.PriceType = proxypricetype;
                }
                #endregion

                #region//Appointment Customers
                if (request.AppointmentChange.Customers != null && request.AppointmentChange.Customers.Count > 0)
                {
                    int customerscnt = 0;
                    WA.v2.WS_Appointment.Customer2[] proxycustomers = new WA.v2.WS_Appointment.Customer2[request.AppointmentChange.Customers.Count];
                    foreach (WA.Standard.IF.Data.v2.Common.Customer.Customer customer in request.AppointmentChange.Customers)
                    {
                        #region//Appointment Customer Header
                        WA.v2.WS_Appointment.Customer2 proxycustomer = new WA.v2.WS_Appointment.Customer2();
                        proxycustomer.CardNo = customer.CardNo;
                        proxycustomer.CustomerInfoType = Map.SetDMSCodeFromWACode(CodeType.CustomerInfoType, customer.CustomerInfoType);
                        proxycustomer.DMSCustomerNo = customer.DMSCustomerNo;
                        proxycustomer.Email = customer.Email;
                        proxycustomer.FirstName = customer.FirstName;
                        proxycustomer.FullName = customer.FullName;
                        proxycustomer.Gender = Map.SetDMSCodeFromWACode(CodeType.Gender, customer.Gender);
                        proxycustomer.LastName = customer.LastName;
                        proxycustomer.MiddleName = customer.MiddleName;
                        proxycustomer.Salutation = customer.Salutation;
                        #endregion

                        #region//Appointment Customer Addresses
                        if (customer.Addresses != null && customer.Addresses.Count > 0)
                        {
                            int addressescnt = 0;
                            WA.v2.WS_Appointment.Address1[] proxyaddresses = new WA.v2.WS_Appointment.Address1[customer.Addresses.Count];
                            foreach (WA.Standard.IF.Data.v2.Common.Customer.Address address in customer.Addresses)
                            {
                                WA.v2.WS_Appointment.Address1 proxyaddress = new WA.v2.WS_Appointment.Address1();
                                proxyaddress.AddressType = Map.SetDMSCodeFromWACode(CodeType.AddressType, address.AddressType);
                                proxyaddress.City = address.City;
                                proxyaddress.District = address.District;
                                proxyaddress.Flat = address.Flat;
                                proxyaddress.FullAddress = address.FullAddress;
                                proxyaddress.House = address.House;
                                proxyaddress.Housing = address.Housing;
                                proxyaddress.Locality = address.Locality;
                                proxyaddress.Region = address.Region;
                                proxyaddress.Street = address.Street;
                                proxyaddress.ZipCode = address.ZipCode;
                                proxyaddresses[addressescnt] = proxyaddress;
                                addressescnt++;
                            }
                            proxycustomer.Addresses = proxyaddresses;
                        }
                        #endregion

                        #region//Appointment Customer Contacts
                        if (customer.Contacts != null && customer.Contacts.Count > 0)
                        {
                            int contactscnt = 0;
                            WA.v2.WS_Appointment.Contact2[] proxycontacts = new WA.v2.WS_Appointment.Contact2[customer.Contacts.Count];
                            foreach (WA.Standard.IF.Data.v2.Common.Customer.Contact contact in customer.Contacts)
                            {
                                WA.v2.WS_Appointment.Contact2 proxycontact = new WA.v2.WS_Appointment.Contact2();
                                proxycontact.ContactMethodYN = contact.ContactMethodYN;
                                proxycontact.ContactType = Map.SetDMSCodeFromWACode(CodeType.ContactType, contact.ContactType);
                                proxycontact.ContactValue = contact.ContactValue;
                                proxycontacts[contactscnt] = proxycontact;
                                contactscnt++;
                            }
                            proxycustomer.Contacts = proxycontacts;
                        }
                        #endregion

                        #region//Appointment Customer SpecialMessage
                        if (customer.SpecialMessage != null)
                        {
                            WA.v2.WS_Appointment.SpecialMessage1 proxyspecialmessage = new WA.v2.WS_Appointment.SpecialMessage1();
                            proxyspecialmessage.Message = customer.SpecialMessage.Message;
                            proxycustomer.SpecialMessage = proxyspecialmessage;
                        }
                        #endregion

                        #region//Appointment Customer CorporateInfos
                        if (customer.CorporateInfos != null && customer.CorporateInfos.Count > 0)
                        {
                            int corporateinfoscnt = 0;
                            WA.v2.WS_Appointment.CorporateInfo1[] proxycorporateinfos = new WA.v2.WS_Appointment.CorporateInfo1[customer.CorporateInfos.Count];
                            foreach (WA.Standard.IF.Data.v2.Common.Customer.CorporateInfo corporateinfo in customer.CorporateInfos)
                            {
                                WA.v2.WS_Appointment.CorporateInfo1 proxycorporateinfo = new WA.v2.WS_Appointment.CorporateInfo1();
                                proxycorporateinfo.CorporateInfoName = corporateinfo.CorporateInfoName;
                                proxycorporateinfo.CorporateInfoValue = corporateinfo.CorporateInfoValue;
                                proxycorporateinfos[corporateinfoscnt] = proxycorporateinfo;
                                corporateinfoscnt++;
                            }
                            proxycustomer.CorporateInfos = proxycorporateinfos;
                        }
                        #endregion

                        proxycustomers[customerscnt] = proxycustomer;
                    }
                    proxyappointmentchange.Customers = proxycustomers;
                }
                #endregion

                #region//Appointment Vehicle
                if (request.AppointmentChange.Vehicle != null)
                {
                    #region//Appointment Vehicle Header
                    WA.v2.WS_Appointment.Vehicle2 proxyvehicle = new WA.v2.WS_Appointment.Vehicle2();
                    proxyvehicle.Color = request.AppointmentChange.Vehicle.Color;
                    proxyvehicle.Cylinders = request.AppointmentChange.Vehicle.Cylinders;
                    proxyvehicle.DateDelivered = request.AppointmentChange.Vehicle.DateDelivered;
                    proxyvehicle.DateInService = request.AppointmentChange.Vehicle.DateInService;
                    proxyvehicle.DeclinedJob = request.AppointmentChange.Vehicle.DeclinedJob;
                    proxyvehicle.DisplayDescription = request.AppointmentChange.Vehicle.DisplayDescription;
                    proxyvehicle.DMSVehicleNo = request.AppointmentChange.Vehicle.DMSVehicleNo;
                    proxyvehicle.EngineType = request.AppointmentChange.Vehicle.EngineType;
                    proxyvehicle.ExtendedWarranty = request.AppointmentChange.Vehicle.ExtendedWarranty;
                    proxyvehicle.FuelType = request.AppointmentChange.Vehicle.FuelType;
                    proxyvehicle.FullModelName = request.AppointmentChange.Vehicle.FullModelName;
                    proxyvehicle.InsuranceDate = request.AppointmentChange.Vehicle.InsuranceDate;
                    proxyvehicle.LastMileage = request.AppointmentChange.Vehicle.LastMileage;
                    proxyvehicle.LastServiceDate = request.AppointmentChange.Vehicle.LastServiceDate;
                    proxyvehicle.LastSixVIN = request.AppointmentChange.Vehicle.LastSixVIN;
                    proxyvehicle.LicenseNumber = request.AppointmentChange.Vehicle.LicenseNumber;
                    proxyvehicle.LicensePlateNo = request.AppointmentChange.Vehicle.LicensePlateNo;
                    proxyvehicle.Make = request.AppointmentChange.Vehicle.Make;
                    proxyvehicle.ModelCode = request.AppointmentChange.Vehicle.ModelCode;
                    proxyvehicle.ModelName = request.AppointmentChange.Vehicle.ModelName;
                    proxyvehicle.ModelYear = request.AppointmentChange.Vehicle.ModelYear;
                    proxyvehicle.PendingJob = request.AppointmentChange.Vehicle.PendingJob;
                    proxyvehicle.StockNumber = request.AppointmentChange.Vehicle.StockNumber;
                    proxyvehicle.Trim = request.AppointmentChange.Vehicle.Trim;
                    proxyvehicle.VehicleType = Map.SetDMSCodeFromWACode(CodeType.VehicleType, request.AppointmentChange.Vehicle.VehicleType);
                    proxyvehicle.VIN = request.AppointmentChange.Vehicle.VIN;
                    proxyvehicle.WarrantyMiles = request.AppointmentChange.Vehicle.WarrantyMiles;
                    proxyvehicle.WarrantyMonths = request.AppointmentChange.Vehicle.WarrantyMonths;
                    proxyvehicle.WarrantyStartDate = request.AppointmentChange.Vehicle.WarrantyStartDate;
                    #endregion

                    #region//Appointment Vehicle Campaigns
                    if (request.AppointmentChange.Vehicle.Campaigns != null && request.AppointmentChange.Vehicle.Campaigns.Count > 0)
                    {
                        int campaignscnt = 0;
                        WA.v2.WS_Appointment.Campaign1[] proxycampaigns = new WA.v2.WS_Appointment.Campaign1[request.AppointmentChange.Vehicle.Campaigns.Count];
                        foreach (WA.Standard.IF.Data.v2.Common.Vehicle.Campaign campaign in request.AppointmentChange.Vehicle.Campaigns)
                        {
                            WA.v2.WS_Appointment.Campaign1 proxycampaign = new WA.v2.WS_Appointment.Campaign1();
                            proxycampaign.CampaignDescription = campaign.CampaignDescription;
                            proxycampaign.CampaignID = campaign.CampaignID;
                            proxycampaign.CampaignPerformed = campaign.CampaignPerformed;
                            proxycampaigns[campaignscnt] = proxycampaign;
                            campaignscnt++;
                        }
                        proxyvehicle.Campaigns = proxycampaigns;
                    }
                    #endregion

                    proxyappointmentchange.Vehicle = proxyvehicle;
                }
                #endregion

                #region//Appointment RequestItems
                if (request.AppointmentChange.RequestItems != null && request.AppointmentChange.RequestItems.Count > 0)
                {
                    int requestitemscnt = 0;
                    WA.v2.WS_Appointment.RequestItem1[] proxyrequestitems = new WA.v2.WS_Appointment.RequestItem1[request.AppointmentChange.RequestItems.Count];
                    foreach (WA.Standard.IF.Data.v2.Common.Common.RequestItem requestitem in request.AppointmentChange.RequestItems)
                    {
                        #region//Appointment RequestItem Header
                        WA.v2.WS_Appointment.RequestItem1 proxyrequestitem = new WA.v2.WS_Appointment.RequestItem1();
                        proxyrequestitem.CPSIND = requestitem.CPSIND;
                        proxyrequestitem.RequestCode = requestitem.RequestCode;
                        proxyrequestitem.RequestDescription = requestitem.RequestDescription;
                        proxyrequestitem.ServiceLineNumber = requestitem.ServiceLineNumber;
                        proxyrequestitem.ServiceLineStatus = Map.SetDMSCodeFromWACode(CodeType.ServiceLineStatus, requestitem.ServiceLineStatus);
                        proxyrequestitem.ServiceType = Map.SetDMSCodeFromWACode(CodeType.ServiceType, requestitem.ServiceType);
                        proxyrequestitem.TCEmployeeID = requestitem.TCEmployeeID;
                        proxyrequestitem.TCEmployeeName = requestitem.TCEmployeeName;
                        proxyrequestitem.WorkType = Map.SetDMSCodeFromWACode(CodeType.WorkType, requestitem.WorkType);
                        #endregion

                        #region//Appointment RequestItem Comments
                        if (requestitem.Comments != null && requestitem.Comments.Count > 0)
                        {
                            int commentscnt = 0;
                            WA.v2.WS_Appointment.Comment1[] proxycomments = new WA.v2.WS_Appointment.Comment1[requestitem.Comments.Count];
                            foreach (WA.Standard.IF.Data.v2.Common.Common.Comment Comment in requestitem.Comments)
                            {
                                WA.v2.WS_Appointment.Comment1 proxycomment = new WA.v2.WS_Appointment.Comment1();
                                proxycomment.DescriptionComment = Comment.DescriptionComment;
                                proxycomment.SequenceNumber = Comment.SequenceNumber;
                                proxycomments[commentscnt] = proxycomment;
                                commentscnt++;
                            }
                            proxyrequestitem.Comments = proxycomments;
                        }
                        #endregion

                        #region//Appointment RequestItem Descriptions
                        if (requestitem.Descriptions != null && requestitem.Descriptions.Count > 0)
                        {
                            int descriptionscnt = 0;
                            WA.v2.WS_Appointment.Description1[] proxydescriptions = new WA.v2.WS_Appointment.Description1[requestitem.Descriptions.Count];
                            foreach (WA.Standard.IF.Data.v2.Common.Common.Description description in requestitem.Descriptions)
                            {
                                WA.v2.WS_Appointment.Description1 proxydescription = new WA.v2.WS_Appointment.Description1();
                                proxydescription.DescriptionComment = description.DescriptionComment;
                                proxydescription.SequenceNumber = description.SequenceNumber;
                                proxydescriptions[descriptionscnt] = proxydescription;
                                descriptionscnt++;
                            }
                            proxyrequestitem.Descriptions = proxydescriptions;
                        }
                        #endregion

                        #region//Appointment RequestItem OPCodes
                        if (requestitem.OPCodes != null && requestitem.OPCodes.Count > 0)
                        {
                            int opcodescnt = 0;
                            WA.v2.WS_Appointment.OPCode1[] proxyopcodes = new WA.v2.WS_Appointment.OPCode1[requestitem.OPCodes.Count];
                            foreach (WA.Standard.IF.Data.v2.Common.Common.OPCode opcode in requestitem.OPCodes)
                            {
                                #region//Appointment RequestItem OPCode Header
                                WA.v2.WS_Appointment.OPCode1 proxyopcode = new WA.v2.WS_Appointment.OPCode1();
                                proxyopcode.ActualHours = opcode.ActualHours;
                                proxyopcode.Code = opcode.Code;
                                proxyopcode.Description = opcode.Description;
                                proxyopcode.EstimatedHours = opcode.EstimatedHours;
                                proxyopcode.SequenceNumber = opcode.SequenceNumber;
                                proxyopcode.ServiceType = Map.SetDMSCodeFromWACode(CodeType.ServiceType, opcode.ServiceType);
                                proxyopcode.SkillLevel = opcode.SkillLevel;
                                #endregion

                                #region//Appointment RequestItem OPCode Descriptions
                                if (opcode.Descriptions != null && opcode.Descriptions.Count > 0)
                                {
                                    int descriptionscnt = 0;
                                    WA.v2.WS_Appointment.Description1[] proxydescriptions = new WA.v2.WS_Appointment.Description1[opcode.Descriptions.Count];
                                    foreach (WA.Standard.IF.Data.v2.Common.Common.Description description in opcode.Descriptions)
                                    {
                                        WA.v2.WS_Appointment.Description1 proxydescription = new WA.v2.WS_Appointment.Description1();
                                        proxydescription.DescriptionComment = description.DescriptionComment;
                                        proxydescription.SequenceNumber = description.SequenceNumber;
                                        proxydescriptions[descriptionscnt] = proxydescription;
                                        descriptionscnt++;
                                    }
                                    proxyopcode.Descriptions = proxydescriptions;
                                }
                                #endregion

                                #region//Appointment RequestItem OPCode Causes
                                if (opcode.Causes != null && opcode.Causes.Count > 0)
                                {
                                    int causescnt = 0;
                                    WA.v2.WS_Appointment.Cause1[] proxycauses = new WA.v2.WS_Appointment.Cause1[opcode.Causes.Count];
                                    foreach (WA.Standard.IF.Data.v2.Common.Common.Cause cause in opcode.Causes)
                                    {
                                        WA.v2.WS_Appointment.Cause1 proxycause = new WA.v2.WS_Appointment.Cause1();
                                        proxycause.CauseLaborOpCode = cause.CauseLaborOpCode;
                                        proxycause.Comment = cause.Comment;
                                        proxycause.SequenceNumber = cause.SequenceNumber;
                                        proxycauses[causescnt] = proxycause;
                                        causescnt++;
                                    }
                                    proxyopcode.Causes = proxycauses;
                                }
                                #endregion

                                #region//Appointment RequestItem OPCode Corrections
                                if (opcode.Corrections != null && opcode.Corrections.Count > 0)
                                {
                                    int correctionscnt = 0;
                                    WA.v2.WS_Appointment.Correction1[] proxycorrections = new WA.v2.WS_Appointment.Correction1[opcode.Corrections.Count];
                                    foreach (WA.Standard.IF.Data.v2.Common.Common.Correction Correction in opcode.Corrections)
                                    {
                                        WA.v2.WS_Appointment.Correction1 proxycorrection = new WA.v2.WS_Appointment.Correction1();
                                        proxycorrection.CorrectionLaborOpCode = Correction.CorrectionLaborOpCode;
                                        proxycorrection.Comment = Correction.Comment;
                                        proxycorrection.SequenceNumber = Correction.SequenceNumber;
                                        proxycorrections[correctionscnt] = proxycorrection;
                                        correctionscnt++;
                                    }
                                    proxyopcode.Corrections = proxycorrections;
                                }
                                #endregion

                                #region//Appointment RequestItem OPCode PriceType
                                if (opcode.PriceType != null)
                                {
                                    WA.v2.WS_Appointment.PriceType1 proxypricetype = new WA.v2.WS_Appointment.PriceType1();
                                    proxypricetype.DiscountPrice = opcode.PriceType.DiscountPrice;
                                    proxypricetype.DiscountRate = opcode.PriceType.DiscountRate;
                                    proxypricetype.TotalPrice = opcode.PriceType.TotalPrice;
                                    proxypricetype.TotalPriceIncludeTax = opcode.PriceType.TotalPriceIncludeTax;
                                    proxypricetype.UnitPrice = opcode.PriceType.UnitPrice;
                                    proxyopcode.PriceType = proxypricetype;
                                }
                                #endregion

                                #region//Appointment RequestItem OPCode Parts
                                if (opcode.Parts != null && opcode.Parts.Count > 0)
                                {
                                    int partscnt = 0;
                                    WA.v2.WS_Appointment.Part1[] proxyparts = new WA.v2.WS_Appointment.Part1[opcode.Parts.Count];
                                    foreach (WA.Standard.IF.Data.v2.Common.Common.Part part in opcode.Parts)
                                    {
                                        #region//Appointment RequestItem OPCode Parts Header
                                        WA.v2.WS_Appointment.Part1 proxypart = new WA.v2.WS_Appointment.Part1();
                                        proxypart.DisplayPartNumber = part.DisplayPartNumber;
                                        proxypart.PartDescription = part.PartDescription;
                                        proxypart.PartNumber = part.PartNumber;
                                        proxypart.PartType = Map.SetDMSCodeFromWACode(CodeType.PartType, part.PartType);
                                        proxypart.Quantity = part.Quantity;
                                        proxypart.SequenceNumber = part.SequenceNumber;
                                        proxypart.ServiceType = Map.SetDMSCodeFromWACode(CodeType.ServiceType, part.ServiceType);
                                        proxypart.StockQuantity = part.StockQuantity;
                                        proxypart.StockStatus = part.StockStatus;
                                        proxypart.UnitOfMeasure = part.UnitOfMeasure;
                                        #endregion

                                        #region//Appointment RequestItem OPCode Parts Descriptions
                                        if (part.Descriptions != null && part.Descriptions.Count > 0)
                                        {
                                            int descriptionscnt = 0;
                                            WA.v2.WS_Appointment.Description1[] proxydescriptions = new WA.v2.WS_Appointment.Description1[part.Descriptions.Count];
                                            foreach (WA.Standard.IF.Data.v2.Common.Common.Description description in part.Descriptions)
                                            {
                                                WA.v2.WS_Appointment.Description1 proxydescription = new WA.v2.WS_Appointment.Description1();
                                                proxydescription.DescriptionComment = description.DescriptionComment;
                                                proxydescription.SequenceNumber = description.SequenceNumber;
                                                proxydescriptions[descriptionscnt] = proxydescription;
                                                descriptionscnt++;
                                            }
                                            proxypart.Descriptions = proxydescriptions;
                                        }
                                        #endregion

                                        #region//Appointment RequestItem OPCode Parts PriceType
                                        if (part.PriceType != null)
                                        {
                                            WA.v2.WS_Appointment.PriceType1 proxypricetype = new WA.v2.WS_Appointment.PriceType1();
                                            proxypricetype.DiscountPrice = part.PriceType.DiscountPrice;
                                            proxypricetype.DiscountRate = part.PriceType.DiscountRate;
                                            proxypricetype.TotalPrice = part.PriceType.TotalPrice;
                                            proxypricetype.TotalPriceIncludeTax = part.PriceType.TotalPriceIncludeTax;
                                            proxypricetype.UnitPrice = part.PriceType.UnitPrice;
                                            proxypart.PriceType = proxypricetype;
                                        }
                                        #endregion

                                        proxyparts[partscnt] = proxypart;
                                        partscnt++;
                                    }
                                    proxyopcode.Parts = proxyparts;
                                }
                                #endregion

                                #region//Appointment RequestItem OPCode Sublets
                                if (opcode.Sublets != null && opcode.Sublets.Count > 0)
                                {
                                    int subletscnt = 0;
                                    WA.v2.WS_Appointment.Sublet1[] proxysublets = new WA.v2.WS_Appointment.Sublet1[opcode.Sublets.Count];
                                    foreach (WA.Standard.IF.Data.v2.Common.Common.Sublet sublet in opcode.Sublets)
                                    {
                                        #region//Appointment RequestItem OPCode Sublets Header
                                        WA.v2.WS_Appointment.Sublet1 proxysublet = new WA.v2.WS_Appointment.Sublet1();
                                        proxysublet.SequenceNumber = sublet.SequenceNumber;
                                        proxysublet.ServiceType = Map.SetDMSCodeFromWACode(CodeType.ServiceType, sublet.ServiceType);
                                        #endregion

                                        #region//Appointment RequestItem OPCode Sublets Descriptions
                                        if (sublet.Descriptions != null && sublet.Descriptions.Count > 0)
                                        {
                                            int descriptionscnt = 0;
                                            WA.v2.WS_Appointment.Description1[] proxydescriptions = new WA.v2.WS_Appointment.Description1[sublet.Descriptions.Count];
                                            foreach (WA.Standard.IF.Data.v2.Common.Common.Description description in sublet.Descriptions)
                                            {
                                                WA.v2.WS_Appointment.Description1 proxydescription = new WA.v2.WS_Appointment.Description1();
                                                proxydescription.DescriptionComment = description.DescriptionComment;
                                                proxydescription.SequenceNumber = description.SequenceNumber;
                                                proxydescriptions[descriptionscnt] = proxydescription;
                                                descriptionscnt++;
                                            }
                                            proxysublet.Descriptions = proxydescriptions;
                                        }
                                        #endregion

                                        #region//Appointment RequestItem OPCode Sublets PriceType
                                        if (sublet.PriceType != null)
                                        {
                                            WA.v2.WS_Appointment.PriceType1 proxypricetype = new WA.v2.WS_Appointment.PriceType1();
                                            proxypricetype.DiscountPrice = sublet.PriceType.DiscountPrice;
                                            proxypricetype.DiscountRate = sublet.PriceType.DiscountRate;
                                            proxypricetype.TotalPrice = sublet.PriceType.TotalPrice;
                                            proxypricetype.TotalPriceIncludeTax = sublet.PriceType.TotalPriceIncludeTax;
                                            proxypricetype.UnitPrice = sublet.PriceType.UnitPrice;
                                            proxysublet.PriceType = proxypricetype;
                                        }
                                        #endregion

                                        proxysublets[subletscnt] = proxysublet;
                                        subletscnt++;
                                    }
                                    proxyopcode.Sublets = proxysublets;
                                }
                                #endregion

                                #region//Appointment RequestItem OPCode MISCs
                                if (opcode.MISCs != null && opcode.MISCs.Count > 0)
                                {
                                    int miscscnt = 0;
                                    WA.v2.WS_Appointment.MISC1[] proxymiscs = new WA.v2.WS_Appointment.MISC1[opcode.MISCs.Count];
                                    foreach (WA.Standard.IF.Data.v2.Common.Common.MISC misc in opcode.MISCs)
                                    {
                                        #region//Appointment RequestItem OPCode MISCs Header
                                        WA.v2.WS_Appointment.MISC1 proxymisc = new WA.v2.WS_Appointment.MISC1();
                                        proxymisc.SequenceNumber = misc.SequenceNumber;
                                        proxymisc.ServiceType = Map.SetDMSCodeFromWACode(CodeType.ServiceType, misc.ServiceType);
                                        #endregion

                                        #region//Appointment RequestItem OPCode MISCs Descriptions
                                        if (misc.Descriptions != null && misc.Descriptions.Count > 0)
                                        {
                                            int descriptionscnt = 0;
                                            WA.v2.WS_Appointment.Description1[] proxydescriptions = new WA.v2.WS_Appointment.Description1[misc.Descriptions.Count];
                                            foreach (WA.Standard.IF.Data.v2.Common.Common.Description description in misc.Descriptions)
                                            {
                                                WA.v2.WS_Appointment.Description1 proxydescription = new WA.v2.WS_Appointment.Description1();
                                                proxydescription.DescriptionComment = description.DescriptionComment;
                                                proxydescription.SequenceNumber = description.SequenceNumber;
                                                proxydescriptions[descriptionscnt] = proxydescription;
                                                descriptionscnt++;
                                            }
                                            proxymisc.Descriptions = proxydescriptions;
                                        }
                                        #endregion

                                        #region//Appointment RequestItem OPCode MISCs PriceType
                                        if (misc.PriceType != null)
                                        {
                                            WA.v2.WS_Appointment.PriceType1 proxypricetype = new WA.v2.WS_Appointment.PriceType1();
                                            proxypricetype.DiscountPrice = misc.PriceType.DiscountPrice;
                                            proxypricetype.DiscountRate = misc.PriceType.DiscountRate;
                                            proxypricetype.TotalPrice = misc.PriceType.TotalPrice;
                                            proxypricetype.TotalPriceIncludeTax = misc.PriceType.TotalPriceIncludeTax;
                                            proxypricetype.UnitPrice = misc.PriceType.UnitPrice;
                                            proxymisc.PriceType = proxypricetype;
                                        }
                                        #endregion

                                        proxymiscs[miscscnt] = proxymisc;
                                        miscscnt++;
                                    }
                                    proxyopcode.MISCs = proxymiscs;
                                }
                                #endregion

                                proxyopcodes[opcodescnt] = proxyopcode;
                                opcodescnt++;
                            }
                            proxyrequestitem.OPCodes = proxyopcodes;
                        }
                        #endregion

                        proxyrequestitems[requestitemscnt] = proxyrequestitem;
                        requestitemscnt++;
                    }
                    proxyappointmentchange.RequestItems = proxyrequestitems;
                }
                #endregion

                proxyrequest.AppointmentChange = proxyappointmentchange;
            }
            #endregion

            //Run proxy web method with proxy request
            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS AppointmentChangeRequest XML", proxyrequest);

            WA.v2.WS_Appointment.AppointmentChangeResponse proxyresponse = proxyws.AppointmentChange(proxyrequest);

            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS AppointmentChangeResponse XML", proxyresponse);

            //Mapping with Standard Interface Specification Object
            if (proxyresponse != null)
            {
                if (proxyresponse.TransactionHeader != null)
                {
                    #region//TransactionHeader Set
                    WA.Standard.IF.Data.v2.Common.Common.TransactionHeader transactionheader = new WA.Standard.IF.Data.v2.Common.Common.TransactionHeader();
                    transactionheader.CountryID = proxyresponse.TransactionHeader.CountryID;
                    transactionheader.DealerID = proxyresponse.TransactionHeader.DealerID;
                    transactionheader.DistributorID = proxyresponse.TransactionHeader.DistributorID;
                    transactionheader.DMSCode = proxyresponse.TransactionHeader.DMSCode;
                    transactionheader.DMSServerUrl = proxyresponse.TransactionHeader.DMSServerUrl;
                    transactionheader.DMSVersion = proxyresponse.TransactionHeader.DMSVersion;
                    transactionheader.DocumentVersion = proxyresponse.TransactionHeader.DocumentVersion;
                    transactionheader.GroupID = proxyresponse.TransactionHeader.GroupID;
                    transactionheader.IneterfaceID = proxyresponse.TransactionHeader.IneterfaceID;
                    transactionheader.Password = proxyresponse.TransactionHeader.Password;
                    transactionheader.PollingToken = proxyresponse.TransactionHeader.PollingToken;
                    transactionheader.RequestPollingToken = proxyresponse.TransactionHeader.RequestPollingToken;
                    transactionheader.RequestType = proxyresponse.TransactionHeader.RequestType;
                    transactionheader.TransactionId = proxyresponse.TransactionHeader.TransactionId;
                    transactionheader.TransactionDateTimeLocal = proxyresponse.TransactionHeader.TransactionDateTimeLocal;
                    transactionheader.TransactionDateTimeUTC = proxyresponse.TransactionHeader.TransactionDateTimeUTC;
                    transactionheader.TransactionType = proxyresponse.TransactionHeader.TransactionType;
                    transactionheader.Username = proxyresponse.TransactionHeader.Username;
                    transactionheader.VenderTrackingCode = proxyresponse.TransactionHeader.VenderTrackingCode;
                    response.TransactionHeader = transactionheader;
                    #endregion
                }

                //ResultMessage Set
                if (proxyresponse.ResultMessage != null)
                {
                    response.ResultMessage = GetResultMessageData(proxyresponse.ResultMessage.Code, proxyresponse.ResultMessage.Message);
                }

                if (proxyresponse.Errors != null)
                {
                    //Error List Set
                    foreach (WA.v2.WS_Appointment.Error1 proxyerror in proxyresponse.Errors)
                    {
                        if (response.Errors != null)
                            response.Errors.Add(GetErrorData(proxyerror.Code, proxyerror.Message));
                        else
                            response.Errors = GetErrorDataList(proxyerror.Code, proxyerror.Message);
                    }
                }
            }
            #endregion

            return response;
        }

        public WA.Standard.IF.Data.v2.Common.RepairOrder.RepairOrderGetResponse RepairOrderGet(WA.Standard.IF.Data.v2.Common.RepairOrder.RepairOrderGetRequest request)
        {
            WA.Standard.IF.Data.v2.Common.RepairOrder.RepairOrderGetResponse response = new WA.Standard.IF.Data.v2.Common.RepairOrder.RepairOrderGetResponse();

            #region v2.WA.v2 - WA.Standard.IF.WebService

            #region RepairOrderGet Request Set

            //Create proxy credential
            NetworkCredential proxycredential = new NetworkCredential(request.TransactionHeader.Username, request.TransactionHeader.Password);

            //Create proxy web service from dms web service with credential
            WA.v2.WS_RepairOrder.RepairOrder proxyws = new WA.v2.WS_RepairOrder.RepairOrder();
            proxyws.Credentials = proxycredential;

            //Create proxy request with repairorderget and transaction
            WA.v2.WS_RepairOrder.RepairOrderGetRequest proxyrequest = new WA.v2.WS_RepairOrder.RepairOrderGetRequest();

            //Create proxy transaction
            WA.v2.WS_RepairOrder.TransactionHeader proxytransactionheader = new WA.v2.WS_RepairOrder.TransactionHeader();
            if (request.TransactionHeader != null)
            {
                #region//TransactionHeader Set
                proxytransactionheader.CountryID = request.TransactionHeader.CountryID;
                proxytransactionheader.DealerID = request.TransactionHeader.DealerID;
                proxytransactionheader.DistributorID = request.TransactionHeader.DistributorID;
                proxytransactionheader.DMSCode = request.TransactionHeader.DMSCode;
                proxytransactionheader.DMSServerUrl = request.TransactionHeader.DMSServerUrl;
                proxytransactionheader.DMSVersion = request.TransactionHeader.DMSVersion;
                proxytransactionheader.DocumentVersion = request.TransactionHeader.DocumentVersion;
                proxytransactionheader.GroupID = request.TransactionHeader.GroupID;
                proxytransactionheader.IneterfaceID = request.TransactionHeader.IneterfaceID;
                proxytransactionheader.Password = request.TransactionHeader.Password;
                proxytransactionheader.PollingToken = request.TransactionHeader.PollingToken;
                proxytransactionheader.RequestPollingToken = request.TransactionHeader.RequestPollingToken;
                proxytransactionheader.RequestType = request.TransactionHeader.RequestType;
                proxytransactionheader.TransactionId = request.TransactionHeader.TransactionId;
                proxytransactionheader.TransactionDateTimeLocal = request.TransactionHeader.TransactionDateTimeLocal;
                proxytransactionheader.TransactionDateTimeUTC = request.TransactionHeader.TransactionDateTimeUTC;
                proxytransactionheader.TransactionType = request.TransactionHeader.TransactionType;
                proxytransactionheader.Username = request.TransactionHeader.Username;
                proxytransactionheader.VenderTrackingCode = request.TransactionHeader.VenderTrackingCode;
                proxyrequest.TransactionHeader = proxytransactionheader;
                proxyws.Url = string.Format("{0}/rtr-atest/ws/RepairOrder.1cws", proxytransactionheader.DMSServerUrl);
                #endregion
            }

            //Create proxy repairorderget
            WA.v2.WS_RepairOrder.RepairOrderGet proxyrepairorderget = new WA.v2.WS_RepairOrder.RepairOrderGet();
            if (request.RepairOrderGet != null)
            {
                #region//RepairOrderGet Set
                proxyrepairorderget.OpenDateTimeFromLocal = request.RepairOrderGet.OpenDateTimeFromLocal;
                proxyrepairorderget.OpenDateTimeToLocal = request.RepairOrderGet.OpenDateTimeToLocal;
                proxyrepairorderget.DMSROID = request.RepairOrderGet.DMSROID;
                proxyrepairorderget.DMSRONo = request.RepairOrderGet.DMSRONo;
                proxyrepairorderget.DMSAppointmentID = request.RepairOrderGet.DMSAppointmentID;
                proxyrepairorderget.DMSAppointmentNo = request.RepairOrderGet.DMSAppointmentNo;
                proxyrepairorderget.DMSROStatus = Map.SetDMSCodeFromWACode(CodeType.DMSROStatus, request.RepairOrderGet.DMSROStatus);
                proxyrepairorderget.LastModifiedDateTimeFromUTC = request.RepairOrderGet.LastModifiedDateTimeFromUTC;
                proxyrepairorderget.LastModifiedDateTimeToUTC = request.RepairOrderGet.LastModifiedDateTimeToUTC;
                proxyrepairorderget.SAEmployeeID = request.RepairOrderGet.SAEmployeeID;
                proxyrepairorderget.SAEmployeeName = request.RepairOrderGet.SAEmployeeName;
                proxyrepairorderget.TCEmployeeID = request.RepairOrderGet.TCEmployeeID;
                proxyrepairorderget.TCEmployeeName = request.RepairOrderGet.TCEmployeeName;
                if (request.RepairOrderGet.Customer != null)
                {
                    WA.v2.WS_RepairOrder.Customer proxycustomer = new WA.v2.WS_RepairOrder.Customer();
                    proxycustomer.DMSCustomerNo = request.RepairOrderGet.Customer.DMSCustomerNo;
                    proxycustomer.LastName = request.RepairOrderGet.Customer.LastName;

                    if (request.RepairOrderGet.Customer.Contacts != null && request.RepairOrderGet.Customer.Contacts.Count > 0)
                    {
                        int cnt = 0;
                        proxycustomer.Contacts = new WA.v2.WS_RepairOrder.Contact[request.RepairOrderGet.Customer.Contacts.Count];
                        foreach (WA.Standard.IF.Data.v2.Common.RepairOrder.Contact contact in request.RepairOrderGet.Customer.Contacts)
                        {
                            WA.v2.WS_RepairOrder.Contact proxycontact = new WA.v2.WS_RepairOrder.Contact();
                            proxycontact.ContactType = Map.SetDMSCodeFromWACode(CodeType.ContactType, contact.ContactType);
                            proxycontact.ContactValue = contact.ContactValue;
                            proxycustomer.Contacts[cnt] = proxycontact;
                            cnt++;
                        }
                    }
                    proxyrepairorderget.Customer = proxycustomer;
                }
                proxyrequest.RepairOrderGet = proxyrepairorderget;
                #endregion
            }

            #endregion

            //Run proxy web method with proxy request
            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS RepairOrderGetRequest XML", proxyrequest);

            WA.v2.WS_RepairOrder.RepairOrderGetResponse proxyresponse = proxyws.RepairOrderGet(proxyrequest);

            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS RepairOrderGetResponse XML", proxyresponse);

            //Mapping with Standard Interface Specification Object
            if (proxyresponse != null)
            {
                if (proxyresponse.TransactionHeader != null)
                {
                    #region//TransactionHeader Set
                    WA.Standard.IF.Data.v2.Common.Common.TransactionHeader transactionheader = new WA.Standard.IF.Data.v2.Common.Common.TransactionHeader();
                    transactionheader.CountryID = proxyresponse.TransactionHeader.CountryID;
                    transactionheader.DealerID = proxyresponse.TransactionHeader.DealerID;
                    transactionheader.DistributorID = proxyresponse.TransactionHeader.DistributorID;
                    transactionheader.DMSCode = proxyresponse.TransactionHeader.DMSCode;
                    transactionheader.DMSServerUrl = proxyresponse.TransactionHeader.DMSServerUrl;
                    transactionheader.DMSVersion = proxyresponse.TransactionHeader.DMSVersion;
                    transactionheader.DocumentVersion = proxyresponse.TransactionHeader.DocumentVersion;
                    transactionheader.GroupID = proxyresponse.TransactionHeader.GroupID;
                    transactionheader.IneterfaceID = proxyresponse.TransactionHeader.IneterfaceID;
                    transactionheader.Password = proxyresponse.TransactionHeader.Password;
                    transactionheader.PollingToken = proxyresponse.TransactionHeader.PollingToken;
                    transactionheader.RequestPollingToken = proxyresponse.TransactionHeader.RequestPollingToken;
                    transactionheader.RequestType = proxyresponse.TransactionHeader.RequestType;
                    transactionheader.TransactionId = proxyresponse.TransactionHeader.TransactionId;
                    transactionheader.TransactionDateTimeLocal = proxyresponse.TransactionHeader.TransactionDateTimeLocal;
                    transactionheader.TransactionDateTimeUTC = proxyresponse.TransactionHeader.TransactionDateTimeUTC;
                    transactionheader.TransactionType = proxyresponse.TransactionHeader.TransactionType;
                    transactionheader.Username = proxyresponse.TransactionHeader.Username;
                    transactionheader.VenderTrackingCode = proxyresponse.TransactionHeader.VenderTrackingCode;
                    response.TransactionHeader = transactionheader;
                    #endregion
                }

                //ResultMessage Set
                if (proxyresponse.ResultMessage != null)
                {
                    response.ResultMessage = GetResultMessageData(proxyresponse.ResultMessage.Code, proxyresponse.ResultMessage.Message);
                }

                if (proxyresponse.Errors != null)
                {
                    //Error List Set
                    foreach (WA.v2.WS_RepairOrder.Error proxyerror in proxyresponse.Errors)
                    {
                        if (response.Errors != null)
                            response.Errors.Add(GetErrorData(proxyerror.Code, proxyerror.Message));
                        else
                            response.Errors = GetErrorDataList(proxyerror.Code, proxyerror.Message);
                    }
                }
                else
                {
                    #region//RepairOrderGetResponse Set

                    if (proxyresponse.RepairOrderDocuments != null && proxyresponse.RepairOrderDocuments.Length > 0)
                    {
                        response.RepairOrderDocuments = new List<WA.Standard.IF.Data.v2.Common.RepairOrder.RepairOrderDocument>();
                        foreach (WA.v2.WS_RepairOrder.RepairOrderDocument proxyrepairorderdocument in proxyresponse.RepairOrderDocuments)
                        {
                            #region //RepairOrderDocuments Header
                            WA.Standard.IF.Data.v2.Common.RepairOrder.RepairOrderDocument repairorderdocument = new WA.Standard.IF.Data.v2.Common.RepairOrder.RepairOrderDocument();
                            repairorderdocument.DMSRODocumentNo = proxyrepairorderdocument.DMSRODocumentNo;
                            repairorderdocument.DMSRODocumentStatus = Map.GetWACodeFromDMSCode(CodeType.RODocumentStatus, proxyrepairorderdocument.DMSRODocumentStatus);
                            #endregion

                            if (proxyrepairorderdocument.RepairOrders != null && proxyrepairorderdocument.RepairOrders.Length > 0)
                            {
                                repairorderdocument.RepairOrders = new List<WA.Standard.IF.Data.v2.Common.RepairOrder.RepairOrder>();
                                foreach (WA.v2.WS_RepairOrder.RepairOrder1 proxyrepairorder in proxyrepairorderdocument.RepairOrders)
                                {
                                    #region //RepairOrder Header
                                    WA.Standard.IF.Data.v2.Common.RepairOrder.RepairOrder repairorder = new WA.Standard.IF.Data.v2.Common.RepairOrder.RepairOrder();
                                    repairorder.CloseDateTimeLocal = proxyrepairorder.CloseDateTimeLocal;
                                    repairorder.DeliveryDateTimeLocal = proxyrepairorder.DeliveryDateTimeLocal;
                                    repairorder.Description = proxyrepairorder.Description;
                                    repairorder.DMSROID = proxyrepairorder.DMSROID;
                                    repairorder.DMSRONo = proxyrepairorder.DMSRONo;
                                    repairorder.DMSROStatus = Map.GetWACodeFromDMSCode(CodeType.DMSROStatus, proxyrepairorder.DMSROStatus);
                                    repairorder.HangTagColor = proxyrepairorder.HangTagColor;
                                    repairorder.HangTagNo = proxyrepairorder.HangTagNo;
                                    repairorder.InMileage = proxyrepairorder.InMileage;
                                    repairorder.OpenDateTimeLocal = proxyrepairorder.OpenDateTimeLocal;
                                    repairorder.OutMileage = proxyrepairorder.OutMileage;
                                    repairorder.PaymentMethod = Map.GetWACodeFromDMSCode(CodeType.PaymentMethod, proxyrepairorder.PaymentMethod);
                                    repairorder.ROChannel = Map.GetWACodeFromDMSCode(CodeType.ROChannel, proxyrepairorder.ROChannel);
                                    repairorder.SAEmployeeID = proxyrepairorder.SAEmployeeID;
                                    repairorder.SAEmployeeName = proxyrepairorder.SAEmployeeName;
                                    repairorder.ServiceType = Map.GetWACodeFromDMSCode(CodeType.ServiceType, proxyrepairorder.ServiceType);
                                    repairorder.TCEmployeeID = proxyrepairorder.TCEmployeeID;
                                    repairorder.TCEmployeeName = proxyrepairorder.TCEmployeeName;
                                    repairorder.WorkType = Map.GetWACodeFromDMSCode(CodeType.WorkType, proxyrepairorder.WorkType);
                                    #endregion

                                    #region//RepairOrder CustomerParts
                                    if (proxyrepairorder.CustomerParts != null && proxyrepairorder.CustomerParts.Length > 0)
                                    {
                                        repairorder.CustomerParts = new List<WA.Standard.IF.Data.v2.Common.RepairOrder.CustomerPart>();
                                        foreach (WA.v2.WS_RepairOrder.CustomerPart proxycustomerpart in proxyrepairorder.CustomerParts)
                                        {
                                            WA.Standard.IF.Data.v2.Common.RepairOrder.CustomerPart customerpart = new WA.Standard.IF.Data.v2.Common.RepairOrder.CustomerPart();
                                            customerpart.Comment = proxycustomerpart.Comment;
                                            customerpart.PartDescription = proxycustomerpart.PartDescription;
                                            customerpart.PartNumber = proxycustomerpart.PartNumber;
                                            customerpart.Quantity = proxycustomerpart.Quantity;
                                            customerpart.UnitOfMeasure = proxycustomerpart.UnitOfMeasure;
                                            repairorder.CustomerParts.Add(customerpart);
                                        }
                                    }
                                    #endregion

                                    #region //RepairOrder AdditionalFields
                                    if (proxyrepairorder.AdditionalFields != null && proxyrepairorder.AdditionalFields.Length > 0)
                                    {
                                        repairorder.AdditionalFields = new List<WA.Standard.IF.Data.v2.Common.Common.AdditionalField>();
                                        foreach (WA.v2.WS_RepairOrder.AdditionalField proxyadditionalfield in proxyrepairorder.AdditionalFields)
                                        {
                                            WA.Standard.IF.Data.v2.Common.Common.AdditionalField additionalfield = new WA.Standard.IF.Data.v2.Common.Common.AdditionalField();
                                            additionalfield.AdditionalFieldName = proxyadditionalfield.AdditionalFieldName;
                                            additionalfield.AdditionalFieldValue = proxyadditionalfield.AdditionalFieldValue;
                                            repairorder.AdditionalFields.Add(additionalfield);
                                        }
                                    }
                                    #endregion

                                    #region//RepairOrder JobRefs
                                    if (proxyrepairorder.JobRefs != null && proxyrepairorder.JobRefs.Length > 0)
                                    {
                                        repairorder.JobRefs = new List<WA.Standard.IF.Data.v2.Common.Common.JobRef>();
                                        foreach (WA.v2.WS_RepairOrder.JobRef proxyjobref in proxyrepairorder.JobRefs)
                                        {
                                            WA.Standard.IF.Data.v2.Common.Common.JobRef jobref = new WA.Standard.IF.Data.v2.Common.Common.JobRef();
                                            jobref.DMSJobNo = proxyjobref.DMSJobNo;
                                            jobref.DMSJobStatus = Map.GetWACodeFromDMSCode(CodeType.DMSJobStatus, proxyjobref.DMSJobStatus);
                                            repairorder.JobRefs.Add(jobref);
                                        }
                                    }
                                    #endregion

                                    #region//RepairOrder ManagementFields
                                    if (proxyrepairorder.ManagementFields != null)
                                    {
                                        WA.Standard.IF.Data.v2.Common.Common.ManagementFields managementfields = new WA.Standard.IF.Data.v2.Common.Common.ManagementFields();
                                        managementfields.CreateDateTimeUTC = proxyrepairorder.ManagementFields.CreateDateTimeUTC;
                                        managementfields.LastModifiedDateTimeUTC = proxyrepairorder.ManagementFields.LastModifiedDateTimeUTC;
                                        repairorder.ManagementFields = managementfields;
                                    }
                                    #endregion

                                    #region//RepairOrder Options
                                    if (proxyrepairorder.Options != null && proxyrepairorder.Options.Length > 0)
                                    {
                                        repairorder.Options = new List<WA.Standard.IF.Data.v2.Common.Common.Option>();
                                        foreach (WA.v2.WS_RepairOrder.Option proxyoption in proxyrepairorder.Options)
                                        {
                                            WA.Standard.IF.Data.v2.Common.Common.Option option = new WA.Standard.IF.Data.v2.Common.Common.Option();
                                            option.OptionName = proxyoption.OptionName;
                                            option.OptionValue = proxyoption.OptionValue;
                                            repairorder.Options.Add(option);
                                        }
                                    }
                                    #endregion

                                    #region//RepairOrder PriceType
                                    if (proxyrepairorder.PriceType != null)
                                    {
                                        WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                        pricetype.DiscountPrice = proxyrepairorder.PriceType.DiscountPrice;
                                        pricetype.DiscountRate = proxyrepairorder.PriceType.DiscountRate;
                                        pricetype.TotalPrice = proxyrepairorder.PriceType.TotalPrice;
                                        pricetype.TotalPriceIncludeTax = proxyrepairorder.PriceType.TotalPriceIncludeTax;
                                        pricetype.UnitPrice = proxyrepairorder.PriceType.UnitPrice;
                                    }
                                    #endregion

                                    #region//RepairOrder AppointmentRef
                                    if (proxyrepairorder.AppointmentRef != null)
                                    {
                                        WA.Standard.IF.Data.v2.Common.Common.AppointmentRef appointmentref = new WA.Standard.IF.Data.v2.Common.Common.AppointmentRef();
                                        appointmentref.DMSAppointmentID = proxyrepairorder.AppointmentRef.DMSAppointmentID;
                                        appointmentref.DMSAppointmentNo = proxyrepairorder.AppointmentRef.DMSAppointmentNo;
                                        appointmentref.DMSAppointmentStatus = Map.GetWACodeFromDMSCode(CodeType.DMSAppointmentStatus, proxyrepairorder.AppointmentRef.DMSAppointmentStatus);
                                        repairorder.AppointmentRef = appointmentref;
                                    }
                                    #endregion

                                    #region//RepairOrder Customers
                                    if (proxyrepairorder.Customers != null && proxyrepairorder.Customers.Length > 0)
                                    {
                                        repairorder.Customers = new List<WA.Standard.IF.Data.v2.Common.Customer.Customer>();
                                        foreach (WA.v2.WS_RepairOrder.Customer1 proxycustomer in proxyrepairorder.Customers)
                                        {
                                            #region//RepairOrder Customer Header
                                            WA.Standard.IF.Data.v2.Common.Customer.Customer customer = new WA.Standard.IF.Data.v2.Common.Customer.Customer();
                                            customer.CardNo = proxycustomer.CardNo;
                                            customer.CorporateInfos = customer.CorporateInfos;
                                            customer.CustomerInfoType = Map.GetWACodeFromDMSCode(CodeType.CustomerInfoType, proxycustomer.CustomerInfoType);
                                            customer.DMSCustomerNo = proxycustomer.DMSCustomerNo;
                                            customer.Email = proxycustomer.Email;
                                            customer.FirstName = proxycustomer.FirstName;
                                            customer.FullName = proxycustomer.FullName;
                                            customer.Gender = Map.GetWACodeFromDMSCode(CodeType.Gender, proxycustomer.Gender);
                                            customer.LastName = proxycustomer.LastName;
                                            customer.MiddleName = proxycustomer.MiddleName;
                                            customer.Salutation = proxycustomer.Salutation;
                                            #endregion

                                            #region//RepairOrder Customer Addresses
                                            if (proxycustomer.Addresses != null && proxycustomer.Addresses.Length > 0)
                                            {
                                                customer.Addresses = new List<WA.Standard.IF.Data.v2.Common.Customer.Address>();
                                                foreach (WA.v2.WS_RepairOrder.Address proxyaddress in proxycustomer.Addresses)
                                                {
                                                    WA.Standard.IF.Data.v2.Common.Customer.Address address = new WA.Standard.IF.Data.v2.Common.Customer.Address();
                                                    address.AddressType = Map.GetWACodeFromDMSCode(CodeType.AddressType, proxyaddress.AddressType);
                                                    address.City = proxyaddress.City;
                                                    address.District = proxyaddress.District;
                                                    address.Flat = proxyaddress.Flat;
                                                    address.FullAddress = proxyaddress.FullAddress;
                                                    address.House = proxyaddress.House;
                                                    address.Housing = proxyaddress.Housing;
                                                    address.Locality = proxyaddress.Locality;
                                                    address.Region = proxyaddress.Region;
                                                    address.Street = proxyaddress.Street;
                                                    address.ZipCode = proxyaddress.ZipCode;
                                                    customer.Addresses.Add(address);
                                                }
                                            }
                                            #endregion

                                            #region//RepairOrder Customer Contacts
                                            if (proxycustomer.Contacts != null && proxycustomer.Contacts.Length > 0)
                                            {
                                                customer.Contacts = new List<WA.Standard.IF.Data.v2.Common.Customer.Contact>();
                                                foreach (WA.v2.WS_RepairOrder.Contact1 proxycontact in proxycustomer.Contacts)
                                                {
                                                    WA.Standard.IF.Data.v2.Common.Customer.Contact contact = new WA.Standard.IF.Data.v2.Common.Customer.Contact();
                                                    contact.ContactMethodYN = proxycontact.ContactMethodYN;
                                                    contact.ContactType = Map.GetWACodeFromDMSCode(CodeType.ContactType, proxycontact.ContactType);
                                                    contact.ContactValue = proxycontact.ContactValue;
                                                    customer.Contacts.Add(contact);
                                                }
                                            }
                                            #endregion

                                            #region//RepairOrder Customer SpecialMessage
                                            if (proxycustomer.SpecialMessage != null)
                                            {
                                                WA.Standard.IF.Data.v2.Common.Customer.SpecialMessage specialmessage = new WA.Standard.IF.Data.v2.Common.Customer.SpecialMessage();
                                                specialmessage.Message = proxycustomer.SpecialMessage.Message;
                                                customer.SpecialMessage = specialmessage;
                                            }
                                            #endregion

                                            #region//RepairOrder Customer CorporateInfos
                                            if (proxycustomer.CorporateInfos != null && proxycustomer.CorporateInfos.Length > 0)
                                            {
                                                customer.CorporateInfos = new List<WA.Standard.IF.Data.v2.Common.Customer.CorporateInfo>();
                                                foreach (WA.v2.WS_RepairOrder.CorporateInfo proxycorporateinfo in proxycustomer.CorporateInfos)
                                                {
                                                    WA.Standard.IF.Data.v2.Common.Customer.CorporateInfo corporateinfo = new WA.Standard.IF.Data.v2.Common.Customer.CorporateInfo();
                                                    corporateinfo.CorporateInfoName = proxycorporateinfo.CorporateInfoName;
                                                    corporateinfo.CorporateInfoValue = proxycorporateinfo.CorporateInfoValue;
                                                    customer.CorporateInfos.Add(corporateinfo);
                                                }
                                            }
                                            #endregion

                                            repairorder.Customers.Add(customer);
                                        }
                                    }
                                    #endregion

                                    #region//RepairOrder Vehicle
                                    if (proxyrepairorder.Vehicle != null)
                                    {
                                        if (proxyrepairorder.Vehicle != null)
                                        {
                                            #region//RepairOrder Vehicle Header
                                            WA.Standard.IF.Data.v2.Common.Vehicle.Vehicle vehicle = new WA.Standard.IF.Data.v2.Common.Vehicle.Vehicle();
                                            vehicle.Color = proxyrepairorder.Vehicle.Color;
                                            vehicle.Cylinders = proxyrepairorder.Vehicle.Cylinders;
                                            vehicle.DateDelivered = proxyrepairorder.Vehicle.DateDelivered;
                                            vehicle.DateInService = proxyrepairorder.Vehicle.DateInService;
                                            vehicle.DeclinedJob = proxyrepairorder.Vehicle.DeclinedJob;
                                            vehicle.DisplayDescription = proxyrepairorder.Vehicle.DisplayDescription;
                                            vehicle.DMSVehicleNo = proxyrepairorder.Vehicle.DMSVehicleNo;
                                            vehicle.EngineNo = proxyrepairorder.Vehicle.EngineNo;
                                            vehicle.EngineType = proxyrepairorder.Vehicle.EngineType;
                                            vehicle.ExtendedWarranty = proxyrepairorder.Vehicle.ExtendedWarranty;
                                            vehicle.ExtendedWarrantyExpireDate = proxyrepairorder.Vehicle.ExtendedWarrantyExpireDate;
                                            vehicle.FuelType = proxyrepairorder.Vehicle.FuelType;
                                            vehicle.FullModelName = proxyrepairorder.Vehicle.FullModelName;
                                            vehicle.InsuranceDate = proxyrepairorder.Vehicle.InsuranceDate;
                                            vehicle.LastMileage = proxyrepairorder.Vehicle.LastMileage;
                                            vehicle.LastServiceDate = proxyrepairorder.Vehicle.LastServiceDate;
                                            vehicle.LastSixVIN = proxyrepairorder.Vehicle.LastSixVIN;
                                            vehicle.LicenseNumber = proxyrepairorder.Vehicle.LicenseNumber;
                                            vehicle.LicensePlateNo = proxyrepairorder.Vehicle.LicensePlateNo;
                                            vehicle.Make = proxyrepairorder.Vehicle.Make;
                                            vehicle.ModelCode = proxyrepairorder.Vehicle.ModelCode;
                                            vehicle.ModelName = proxyrepairorder.Vehicle.ModelName;
                                            vehicle.ModelYear = proxyrepairorder.Vehicle.ModelYear;
                                            vehicle.PendingJob = proxyrepairorder.Vehicle.PendingJob;
                                            vehicle.StockNumber = proxyrepairorder.Vehicle.StockNumber;
                                            vehicle.Trim = proxyrepairorder.Vehicle.Trim;
                                            vehicle.VehicleType = Map.GetWACodeFromDMSCode(CodeType.VehicleType, proxyrepairorder.Vehicle.VehicleType);
                                            vehicle.VIN = proxyrepairorder.Vehicle.VIN;
                                            vehicle.WarrantyMiles = proxyrepairorder.Vehicle.WarrantyMiles;
                                            vehicle.WarrantyMonths = proxyrepairorder.Vehicle.WarrantyMonths;
                                            vehicle.WarrantyStartDate = proxyrepairorder.Vehicle.WarrantyStartDate;
                                            #endregion

                                            #region//RepairOrder Vehicle Campaigns
                                            if (proxyrepairorder.Vehicle.Campaigns != null && proxyrepairorder.Vehicle.Campaigns.Length > 0)
                                            {
                                                vehicle.Campaigns = new List<WA.Standard.IF.Data.v2.Common.Vehicle.Campaign>();
                                                foreach (WA.v2.WS_RepairOrder.Campaign proxycampaign in proxyrepairorder.Vehicle.Campaigns)
                                                {
                                                    WA.Standard.IF.Data.v2.Common.Vehicle.Campaign campaign = new WA.Standard.IF.Data.v2.Common.Vehicle.Campaign();
                                                    campaign.CampaignDescription = proxycampaign.CampaignDescription;
                                                    campaign.CampaignID = proxycampaign.CampaignID;
                                                    campaign.CampaignPerformed = proxycampaign.CampaignPerformed;
                                                    vehicle.Campaigns.Add(campaign);
                                                }
                                            }
                                            #endregion

                                            repairorder.Vehicle = vehicle;
                                        }
                                    }
                                    #endregion

                                    #region//RepairOrder RequestItems
                                    if (proxyrepairorder.RequestItems != null && proxyrepairorder.RequestItems.Length > 0)
                                    {
                                        repairorder.RequestItems = new List<WA.Standard.IF.Data.v2.Common.Common.RequestItem>();
                                        foreach (WA.v2.WS_RepairOrder.RequestItem proxyrequestitem in proxyrepairorder.RequestItems)
                                        {
                                            #region//RepairOrder RequestItem Header
                                            WA.Standard.IF.Data.v2.Common.Common.RequestItem requestitem = new WA.Standard.IF.Data.v2.Common.Common.RequestItem();
                                            requestitem.CPSIND = proxyrequestitem.CPSIND;
                                            requestitem.RequestCode = proxyrequestitem.RequestCode;
                                            requestitem.RequestDescription = proxyrequestitem.RequestDescription;
                                            requestitem.ServiceLineNumber = proxyrequestitem.ServiceLineNumber;
                                            requestitem.ServiceLineStatus = Map.GetWACodeFromDMSCode(CodeType.ServiceLineStatus, proxyrequestitem.ServiceLineStatus);
                                            requestitem.ServiceType = Map.GetWACodeFromDMSCode(CodeType.ServiceType, proxyrequestitem.ServiceType);
                                            requestitem.TCEmployeeID = proxyrequestitem.TCEmployeeID;
                                            requestitem.TCEmployeeName = proxyrequestitem.TCEmployeeName;
                                            requestitem.WorkType = Map.GetWACodeFromDMSCode(CodeType.WorkType, proxyrequestitem.WorkType);
                                            #endregion

                                            #region//RepairOrder RequestItem Comments
                                            if (proxyrequestitem.Comments != null && proxyrequestitem.Comments.Length > 0)
                                            {
                                                requestitem.Comments = new List<WA.Standard.IF.Data.v2.Common.Common.Comment>();
                                                foreach (WA.v2.WS_RepairOrder.Comment proxycomment in proxyrequestitem.Comments)
                                                {
                                                    WA.Standard.IF.Data.v2.Common.Common.Comment comment = new WA.Standard.IF.Data.v2.Common.Common.Comment();
                                                    comment.DescriptionComment = proxycomment.DescriptionComment;
                                                    comment.SequenceNumber = proxycomment.SequenceNumber;
                                                    requestitem.Comments.Add(comment);
                                                }
                                            }
                                            #endregion

                                            #region//RepairOrder RequestItem Descriptions
                                            if (proxyrequestitem.Descriptions != null && proxyrequestitem.Descriptions.Length > 0)
                                            {
                                                requestitem.Descriptions = new List<WA.Standard.IF.Data.v2.Common.Common.Description>();
                                                foreach (WA.v2.WS_RepairOrder.Description proxydescription in proxyrequestitem.Descriptions)
                                                {
                                                    WA.Standard.IF.Data.v2.Common.Common.Description description = new WA.Standard.IF.Data.v2.Common.Common.Description();
                                                    description.DescriptionComment = proxydescription.DescriptionComment;
                                                    description.SequenceNumber = proxydescription.SequenceNumber;
                                                    requestitem.Descriptions.Add(description);
                                                }
                                            }
                                            #endregion

                                            #region//RepairOrder RequestItem OPCodes
                                            if (proxyrequestitem.OPCodes != null && proxyrequestitem.OPCodes.Length > 0)
                                            {
                                                requestitem.OPCodes = new List<WA.Standard.IF.Data.v2.Common.Common.OPCode>();
                                                foreach (WA.v2.WS_RepairOrder.OPCode proxyopcode in proxyrequestitem.OPCodes)
                                                {
                                                    #region//RepairOrder RequestItem OPCode Header
                                                    WA.Standard.IF.Data.v2.Common.Common.OPCode opcode = new WA.Standard.IF.Data.v2.Common.Common.OPCode();
                                                    opcode.ActualHours = proxyopcode.ActualHours;
                                                    opcode.Code = proxyopcode.Code;
                                                    opcode.Description = proxyopcode.Description;
                                                    opcode.EstimatedHours = proxyopcode.EstimatedHours;
                                                    opcode.OPCodeType = Map.GetWACodeFromDMSCode(CodeType.OPCodeType, proxyopcode.OPCodeType);
                                                    opcode.Quantity = proxyopcode.Quantity;
                                                    opcode.SequenceNumber = proxyopcode.SequenceNumber;
                                                    opcode.ServiceType = Map.GetWACodeFromDMSCode(CodeType.ServiceType, proxyopcode.ServiceType);
                                                    opcode.SkillLevel = proxyopcode.SkillLevel;
                                                    #endregion

                                                    #region//RepairOrder RequestItem OPCode Descriptions
                                                    if (proxyopcode.Descriptions != null && proxyopcode.Descriptions.Length > 0)
                                                    {
                                                        opcode.Descriptions = new List<WA.Standard.IF.Data.v2.Common.Common.Description>();
                                                        foreach (WA.v2.WS_RepairOrder.Description proxydescription in proxyopcode.Descriptions)
                                                        {
                                                            WA.Standard.IF.Data.v2.Common.Common.Description description = new WA.Standard.IF.Data.v2.Common.Common.Description();
                                                            description.DescriptionComment = proxydescription.DescriptionComment;
                                                            description.SequenceNumber = proxydescription.SequenceNumber;
                                                            opcode.Descriptions.Add(description);
                                                        }
                                                    }
                                                    #endregion

                                                    #region//RepairOrder RequestItem OPCode Causes
                                                    if (proxyopcode.Causes != null && proxyopcode.Causes.Length > 0)
                                                    {
                                                        opcode.Causes = new List<WA.Standard.IF.Data.v2.Common.Common.Cause>();
                                                        foreach (WA.v2.WS_RepairOrder.Cause proxycause in proxyopcode.Causes)
                                                        {
                                                            WA.Standard.IF.Data.v2.Common.Common.Cause cause = new WA.Standard.IF.Data.v2.Common.Common.Cause();
                                                            cause.CauseLaborOpCode = proxycause.CauseLaborOpCode;
                                                            cause.Comment = proxycause.Comment;
                                                            cause.SequenceNumber = proxycause.SequenceNumber;
                                                            opcode.Causes.Add(cause);
                                                        }
                                                    }
                                                    #endregion

                                                    #region//RepairOrder RequestItem OPCode Corrections
                                                    if (proxyopcode.Corrections != null && proxyopcode.Corrections.Length > 0)
                                                    {
                                                        opcode.Corrections = new List<WA.Standard.IF.Data.v2.Common.Common.Correction>();
                                                        foreach (WA.v2.WS_RepairOrder.Correction proxycorrection in proxyopcode.Corrections)
                                                        {
                                                            WA.Standard.IF.Data.v2.Common.Common.Correction correction = new WA.Standard.IF.Data.v2.Common.Common.Correction();
                                                            correction.CorrectionLaborOpCode = proxycorrection.CorrectionLaborOpCode;
                                                            correction.Comment = proxycorrection.Comment;
                                                            correction.SequenceNumber = proxycorrection.SequenceNumber;
                                                            opcode.Corrections.Add(correction);
                                                        }
                                                    }
                                                    #endregion

                                                    #region//RepairOrder RequestItem OPCode PriceType
                                                    if (proxyopcode.PriceType != null)
                                                    {
                                                        WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                                        pricetype.DiscountPrice = proxyopcode.PriceType.DiscountPrice;
                                                        pricetype.DiscountRate = proxyopcode.PriceType.DiscountRate;
                                                        pricetype.TotalPrice = proxyopcode.PriceType.TotalPrice;
                                                        pricetype.TotalPriceIncludeTax = proxyopcode.PriceType.TotalPriceIncludeTax;
                                                        pricetype.UnitPrice = proxyopcode.PriceType.UnitPrice;
                                                        opcode.PriceType = pricetype;
                                                    }
                                                    #endregion

                                                    #region//RepairOrder RequestItem OPCode Parts
                                                    if (proxyopcode.Parts != null && proxyopcode.Parts.Length > 0)
                                                    {
                                                        opcode.Parts = new List<WA.Standard.IF.Data.v2.Common.Common.Part>();
                                                        foreach (WA.v2.WS_RepairOrder.Part proxypart in proxyopcode.Parts)
                                                        {
                                                            #region//RepairOrder RequestItem OPCode Parts Header
                                                            WA.Standard.IF.Data.v2.Common.Common.Part part = new WA.Standard.IF.Data.v2.Common.Common.Part();
                                                            part.DisplayPartNumber = proxypart.DisplayPartNumber;
                                                            part.PartDescription = proxypart.PartDescription;
                                                            part.PartNumber = proxypart.PartNumber;
                                                            part.PartType = Map.GetWACodeFromDMSCode(CodeType.PartType, proxypart.PartType);
                                                            part.Quantity = proxypart.Quantity;
                                                            part.SequenceNumber = proxypart.SequenceNumber;
                                                            part.ServiceType = Map.GetWACodeFromDMSCode(CodeType.ServiceType, proxypart.ServiceType);
                                                            part.StockQuantity = proxypart.StockQuantity;
                                                            part.StockStatus = proxypart.StockStatus;
                                                            part.UnitOfMeasure = proxypart.UnitOfMeasure;
                                                            #endregion

                                                            #region//RepairOrder RequestItem OPCode Parts Descriptions
                                                            if (proxypart.Descriptions != null && proxypart.Descriptions.Length > 0)
                                                            {
                                                                part.Descriptions = new List<WA.Standard.IF.Data.v2.Common.Common.Description>();
                                                                foreach (WA.v2.WS_RepairOrder.Description proxydescription in proxypart.Descriptions)
                                                                {
                                                                    WA.Standard.IF.Data.v2.Common.Common.Description description = new WA.Standard.IF.Data.v2.Common.Common.Description();
                                                                    description.DescriptionComment = proxydescription.DescriptionComment;
                                                                    description.SequenceNumber = proxydescription.SequenceNumber;
                                                                    part.Descriptions.Add(description);
                                                                }
                                                            }
                                                            #endregion

                                                            #region//RepairOrder RequestItem OPCode Parts PriceType
                                                            if (proxypart.PriceType != null)
                                                            {
                                                                WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                                                pricetype.DiscountPrice = proxypart.PriceType.DiscountPrice;
                                                                pricetype.DiscountRate = proxypart.PriceType.DiscountRate;
                                                                pricetype.TotalPrice = proxypart.PriceType.TotalPrice;
                                                                pricetype.TotalPriceIncludeTax = proxypart.PriceType.TotalPriceIncludeTax;
                                                                pricetype.UnitPrice = proxypart.PriceType.UnitPrice;
                                                                part.PriceType = pricetype;
                                                            }
                                                            #endregion

                                                            opcode.Parts.Add(part);
                                                        }
                                                    }
                                                    #endregion

                                                    #region//RepairOrder RequestItem OPCode Sublets
                                                    if (proxyopcode.Sublets != null && proxyopcode.Sublets.Length > 0)
                                                    {
                                                        opcode.Sublets = new List<WA.Standard.IF.Data.v2.Common.Common.Sublet>();
                                                        foreach (WA.v2.WS_RepairOrder.Sublet proxysublet in proxyopcode.Sublets)
                                                        {
                                                            #region//RepairOrder RequestItem OPCode Sublet Header
                                                            WA.Standard.IF.Data.v2.Common.Common.Sublet sublet = new WA.Standard.IF.Data.v2.Common.Common.Sublet();
                                                            sublet.SequenceNumber = proxysublet.SequenceNumber;
                                                            sublet.ServiceType = Map.GetWACodeFromDMSCode(CodeType.ServiceType, proxysublet.ServiceType);
                                                            #endregion

                                                            #region//RepairOrder RequestItem OPCode Sublets Descriptions
                                                            if (proxysublet.Descriptions != null && proxysublet.Descriptions.Length > 0)
                                                            {
                                                                sublet.Descriptions = new List<WA.Standard.IF.Data.v2.Common.Common.Description>();
                                                                foreach (WA.v2.WS_RepairOrder.Description proxydescription in proxysublet.Descriptions)
                                                                {
                                                                    WA.Standard.IF.Data.v2.Common.Common.Description description = new WA.Standard.IF.Data.v2.Common.Common.Description();
                                                                    description.DescriptionComment = proxydescription.DescriptionComment;
                                                                    description.SequenceNumber = proxydescription.SequenceNumber;
                                                                    sublet.Descriptions.Add(description);
                                                                }
                                                            }
                                                            #endregion

                                                            #region//RepairOrder RequestItem OPCode Sublets PriceType
                                                            if (proxysublet.PriceType != null)
                                                            {
                                                                WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                                                pricetype.DiscountPrice = proxysublet.PriceType.DiscountPrice;
                                                                pricetype.DiscountRate = proxysublet.PriceType.DiscountRate;
                                                                pricetype.TotalPrice = proxysublet.PriceType.TotalPrice;
                                                                pricetype.TotalPriceIncludeTax = proxysublet.PriceType.TotalPriceIncludeTax;
                                                                pricetype.UnitPrice = proxysublet.PriceType.UnitPrice;
                                                                sublet.PriceType = pricetype;
                                                            }
                                                            #endregion

                                                            opcode.Sublets.Add(sublet);
                                                        }
                                                    }
                                                    #endregion

                                                    #region//RepairOrder RequestItem OPCode MISCs
                                                    if (proxyopcode.MISCs != null && proxyopcode.MISCs.Length > 0)
                                                    {
                                                        opcode.MISCs = new List<WA.Standard.IF.Data.v2.Common.Common.MISC>();
                                                        foreach (WA.v2.WS_RepairOrder.MISC proxymisc in proxyopcode.MISCs)
                                                        {
                                                            #region//RepairOrder RequestItem OPCode MISC Header
                                                            WA.Standard.IF.Data.v2.Common.Common.MISC misc = new WA.Standard.IF.Data.v2.Common.Common.MISC();
                                                            misc.SequenceNumber = proxymisc.SequenceNumber;
                                                            misc.ServiceType = Map.GetWACodeFromDMSCode(CodeType.ServiceType, proxymisc.ServiceType);
                                                            #endregion

                                                            #region//RepairOrder RequestItem OPCode MISCs Descriptions
                                                            if (proxymisc.Descriptions != null && proxymisc.Descriptions.Length > 0)
                                                            {
                                                                misc.Descriptions = new List<WA.Standard.IF.Data.v2.Common.Common.Description>();
                                                                foreach (WA.v2.WS_RepairOrder.Description proxydescription in proxymisc.Descriptions)
                                                                {
                                                                    WA.Standard.IF.Data.v2.Common.Common.Description description = new WA.Standard.IF.Data.v2.Common.Common.Description();
                                                                    description.DescriptionComment = proxydescription.DescriptionComment;
                                                                    description.SequenceNumber = proxydescription.SequenceNumber;
                                                                    misc.Descriptions.Add(description);
                                                                }
                                                            }
                                                            #endregion

                                                            #region//RepairOrder RequestItem OPCode MISCs PriceType
                                                            if (proxymisc.PriceType != null)
                                                            {
                                                                WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                                                pricetype.DiscountPrice = proxymisc.PriceType.DiscountPrice;
                                                                pricetype.DiscountRate = proxymisc.PriceType.DiscountRate;
                                                                pricetype.TotalPrice = proxymisc.PriceType.TotalPrice;
                                                                pricetype.TotalPriceIncludeTax = proxymisc.PriceType.TotalPriceIncludeTax;
                                                                pricetype.UnitPrice = proxymisc.PriceType.UnitPrice;
                                                                misc.PriceType = pricetype;
                                                            }
                                                            #endregion

                                                            opcode.MISCs.Add(misc);
                                                        }
                                                    }
                                                    #endregion

                                                    requestitem.OPCodes.Add(opcode);
                                                }
                                            }
                                            #endregion

                                            repairorder.RequestItems.Add(requestitem);
                                        }
                                    }
                                    #endregion

                                    repairorderdocument.RepairOrders.Add(repairorder);
                                }
                            }
                            response.RepairOrderDocuments.Add(repairorderdocument);
                        }
                    }
                    else
                    {
                        response.ResultMessage = GetResultMessageData(WA.Standard.IF.Data.v2.Common.Common.ResponseCode.NoResult, WA.Standard.IF.Data.v2.Common.Common.ResponseMessage.NoResult);
                    }
                    #endregion
                }
            }
            #endregion

            return response;
        }

        public WA.Standard.IF.Data.v2.Common.RepairOrder.RepairOrderChangeResponse RepairOrderChange(WA.Standard.IF.Data.v2.Common.RepairOrder.RepairOrderChangeRequest request)
        {
            WA.Standard.IF.Data.v2.Common.RepairOrder.RepairOrderChangeResponse response = new WA.Standard.IF.Data.v2.Common.RepairOrder.RepairOrderChangeResponse();
            
            #region v2.WA.v2 - WA.Standard.IF.WebService

            #region RepairOrderChange Request Set

            //Create proxy credential
            NetworkCredential proxycredential = new NetworkCredential(request.TransactionHeader.Username, request.TransactionHeader.Password);

            //Create proxy web service from dms web service with credential
            WA.v2.WS_RepairOrder.RepairOrder proxyws = new WA.v2.WS_RepairOrder.RepairOrder();
            proxyws.Credentials = proxycredential;

            //Create proxy request with repairorderchange and transaction
            WA.v2.WS_RepairOrder.RepairOrderChangeRequest proxyrequest = new WA.v2.WS_RepairOrder.RepairOrderChangeRequest();

            //Create proxy transaction
            WA.v2.WS_RepairOrder.TransactionHeader2 proxytransactionheader = new WA.v2.WS_RepairOrder.TransactionHeader2();
            if (request.TransactionHeader != null)
            {
                #region//TransactionHeader Set
                proxytransactionheader.CountryID = request.TransactionHeader.CountryID;
                proxytransactionheader.DealerID = request.TransactionHeader.DealerID;
                proxytransactionheader.DistributorID = request.TransactionHeader.DistributorID;
                proxytransactionheader.DMSCode = request.TransactionHeader.DMSCode;
                proxytransactionheader.DMSServerUrl = request.TransactionHeader.DMSServerUrl;
                proxytransactionheader.DMSVersion = request.TransactionHeader.DMSVersion;
                proxytransactionheader.DocumentVersion = request.TransactionHeader.DocumentVersion;
                proxytransactionheader.GroupID = request.TransactionHeader.GroupID;
                proxytransactionheader.IneterfaceID = request.TransactionHeader.IneterfaceID;
                proxytransactionheader.Password = request.TransactionHeader.Password;
                proxytransactionheader.PollingToken = request.TransactionHeader.PollingToken;
                proxytransactionheader.RequestPollingToken = request.TransactionHeader.RequestPollingToken;
                proxytransactionheader.RequestType = request.TransactionHeader.RequestType;
                proxytransactionheader.TransactionId = request.TransactionHeader.TransactionId;
                proxytransactionheader.TransactionDateTimeLocal = request.TransactionHeader.TransactionDateTimeLocal;
                proxytransactionheader.TransactionDateTimeUTC = request.TransactionHeader.TransactionDateTimeUTC;
                proxytransactionheader.TransactionType = request.TransactionHeader.TransactionType;
                proxytransactionheader.Username = request.TransactionHeader.Username;
                proxytransactionheader.VenderTrackingCode = request.TransactionHeader.VenderTrackingCode;
                proxyrequest.TransactionHeader = proxytransactionheader;
                proxyws.Url = string.Format("{0}/rtr-atest/ws/RepairOrder.1cws", proxytransactionheader.DMSServerUrl);
                #endregion
            }

            //Create proxy repairorderchange
            WA.v2.WS_RepairOrder.RepairOrderChange proxyrepairorderchange = new WA.v2.WS_RepairOrder.RepairOrderChange();
            if (request.RepairOrderChange != null)
            {
                #region//RepairOrder Header
                proxyrepairorderchange.CloseDateTimeLocal = request.RepairOrderChange.CloseDateTimeLocal;
                proxyrepairorderchange.DeliveryDateTimeLocal = request.RepairOrderChange.DeliveryDateTimeLocal;
                proxyrepairorderchange.DMSROID = request.RepairOrderChange.DMSROID;
                proxyrepairorderchange.DMSRONo = string.IsNullOrEmpty(request.RepairOrderChange.DMSRONo) ? string.Empty : request.RepairOrderChange.DMSRONo;
                proxyrepairorderchange.DMSROStatus = Map.SetDMSCodeFromWACode(CodeType.DMSROStatus, request.RepairOrderChange.DMSROStatus);
                proxyrepairorderchange.HangTagColor = request.RepairOrderChange.HangTagColor;
                proxyrepairorderchange.HangTagNo = request.RepairOrderChange.HangTagNo;
                proxyrepairorderchange.HangTagNo = request.RepairOrderChange.HangTagNo;
                proxyrepairorderchange.OpenDateTimeLocal = request.RepairOrderChange.OpenDateTimeLocal;
                proxyrepairorderchange.InMileage = request.RepairOrderChange.InMileage;
                proxyrepairorderchange.OutMileage = request.RepairOrderChange.OutMileage;
                proxyrepairorderchange.PaymentMethod = Map.SetDMSCodeFromWACode(CodeType.PaymentMethod, request.RepairOrderChange.PaymentMethod);
                proxyrepairorderchange.ROChannel = Map.SetDMSCodeFromWACode(CodeType.ROChannel, request.RepairOrderChange.ROChannel);
                proxyrepairorderchange.SAEmployeeID = request.RepairOrderChange.SAEmployeeID;
                proxyrepairorderchange.SAEmployeeName = request.RepairOrderChange.SAEmployeeName;
                proxyrepairorderchange.ServiceType = Map.SetDMSCodeFromWACode(CodeType.ServiceType, request.RepairOrderChange.ServiceType);
                proxyrepairorderchange.TCEmployeeID = request.RepairOrderChange.TCEmployeeID;
                proxyrepairorderchange.TCEmployeeName = request.RepairOrderChange.TCEmployeeName;
                proxyrepairorderchange.WorkType = Map.SetDMSCodeFromWACode(CodeType.WorkType, request.RepairOrderChange.WorkType);
                proxyrepairorderchange.Description = request.RepairOrderChange.Description;
                #endregion

                #region//RepairOrder AppointmentRef
                if (request.RepairOrderChange.AppointmentRef != null)
                {
                    WA.v2.WS_RepairOrder.AppointmentRef1 proxyappointmentref = new WA.v2.WS_RepairOrder.AppointmentRef1();
                    proxyappointmentref.DMSAppointmentNo = request.RepairOrderChange.AppointmentRef.DMSAppointmentNo;
                    proxyappointmentref.DMSAppointmentStatus = Map.SetDMSCodeFromWACode(CodeType.DMSAppointmentStatus, request.RepairOrderChange.AppointmentRef.DMSAppointmentStatus);
                    proxyrepairorderchange.AppointmentRef = proxyappointmentref;
                }
                #endregion

                #region//RepairOrder CustomerParts
                if (request.RepairOrderChange.CustomerParts != null && request.RepairOrderChange.CustomerParts.Count > 0)
                {
                    int customerpartscnt = 0;
                    WA.v2.WS_RepairOrder.CustomerPart1[] proxycustomerparts = new WA.v2.WS_RepairOrder.CustomerPart1[request.RepairOrderChange.CustomerParts.Count];
                    foreach (WA.Standard.IF.Data.v2.Common.RepairOrder.CustomerPart customerpart in request.RepairOrderChange.CustomerParts)
                    {
                        WA.v2.WS_RepairOrder.CustomerPart1 proxycustomerpart = new WA.v2.WS_RepairOrder.CustomerPart1();
                        proxycustomerpart.Comment = customerpart.Comment;
                        proxycustomerpart.PartDescription = customerpart.PartDescription;
                        proxycustomerpart.PartNumber = customerpart.PartNumber;
                        proxycustomerpart.Quantity = customerpart.Quantity;
                        proxycustomerpart.UnitOfMeasure = customerpart.UnitOfMeasure;
                        proxycustomerparts[customerpartscnt] = proxycustomerpart;
                        customerpartscnt++;
                    }
                }
                #endregion

                #region //RepairOrder AdditionalFields
                if (request.RepairOrderChange.AdditionalFields != null && request.RepairOrderChange.AdditionalFields.Count > 0)
                {
                    int additionalfieldscnt = 0;
                    WA.v2.WS_RepairOrder.AdditionalField1[] proxyadditionalfields = new WA.v2.WS_RepairOrder.AdditionalField1[request.RepairOrderChange.AdditionalFields.Count];
                    foreach (WA.Standard.IF.Data.v2.Common.Common.AdditionalField additionalfield in request.RepairOrderChange.AdditionalFields)
                    {
                        WA.v2.WS_RepairOrder.AdditionalField1 proxyadditionalfield = new WA.v2.WS_RepairOrder.AdditionalField1();
                        proxyadditionalfield.AdditionalFieldName = additionalfield.AdditionalFieldName;
                        proxyadditionalfield.AdditionalFieldValue = additionalfield.AdditionalFieldValue;
                        proxyadditionalfields[additionalfieldscnt] = proxyadditionalfield;
                        additionalfieldscnt++;
                    }
                    proxyrepairorderchange.AdditionalFields = proxyadditionalfields;
                }
                #endregion

                #region//RepairOrder Options
                if (request.RepairOrderChange.Options != null && request.RepairOrderChange.Options.Count > 0)
                {
                    int optionscnt = 0;
                    WA.v2.WS_RepairOrder.Option1[] proxyoptions = new WA.v2.WS_RepairOrder.Option1[request.RepairOrderChange.Options.Count];
                    foreach (WA.Standard.IF.Data.v2.Common.Common.Option option in request.RepairOrderChange.Options)
                    {
                        WA.v2.WS_RepairOrder.Option1 proxyoption = new WA.v2.WS_RepairOrder.Option1();
                        proxyoption.OptionName = option.OptionName;
                        proxyoption.OptionValue = option.OptionValue;
                        proxyoptions[optionscnt] = proxyoption;
                        optionscnt++;
                    }
                    proxyrepairorderchange.Options = proxyoptions;
                }
                #endregion

                #region//RepairOrder PriceType
                if (request.RepairOrderChange.PriceType != null)
                {
                    WA.v2.WS_RepairOrder.PriceType1 proxypricetype = new WA.v2.WS_RepairOrder.PriceType1();
                    proxypricetype.DiscountPrice = request.RepairOrderChange.PriceType.DiscountPrice;
                    proxypricetype.DiscountRate = request.RepairOrderChange.PriceType.DiscountRate;
                    proxypricetype.TotalPrice = request.RepairOrderChange.PriceType.TotalPrice;
                    proxypricetype.TotalPriceIncludeTax = request.RepairOrderChange.PriceType.TotalPriceIncludeTax;
                    proxypricetype.UnitPrice = request.RepairOrderChange.PriceType.UnitPrice;
                    proxyrepairorderchange.PriceType = proxypricetype;
                }
                #endregion

                #region//RepairOrder Customers
                if (request.RepairOrderChange.Customers != null && request.RepairOrderChange.Customers.Count > 0)
                {
                    int customerscnt = 0;
                    WA.v2.WS_RepairOrder.Customer2[] proxycustomers = new WA.v2.WS_RepairOrder.Customer2[request.RepairOrderChange.Customers.Count];
                    foreach (WA.Standard.IF.Data.v2.Common.Customer.Customer customer in request.RepairOrderChange.Customers)
                    {
                        #region//RepairOrder Customer Header
                        WA.v2.WS_RepairOrder.Customer2 proxycustomer = new WA.v2.WS_RepairOrder.Customer2();
                        proxycustomer.CardNo = customer.CardNo;
                        proxycustomer.CustomerInfoType = Map.SetDMSCodeFromWACode(CodeType.CustomerInfoType, customer.CustomerInfoType);
                        proxycustomer.DMSCustomerNo = customer.DMSCustomerNo;
                        proxycustomer.Email = customer.Email;
                        proxycustomer.FirstName = customer.FirstName;
                        proxycustomer.FullName = customer.FullName;
                        proxycustomer.Gender = Map.SetDMSCodeFromWACode(CodeType.Gender, customer.Gender);
                        proxycustomer.LastName = customer.LastName;
                        proxycustomer.MiddleName = customer.MiddleName;
                        proxycustomer.Salutation = customer.Salutation;
                        #endregion

                        #region//RepairOrder Customer Addresses
                        if (customer.Addresses != null && customer.Addresses.Count > 0)
                        {
                            int addressescnt = 0;
                            WA.v2.WS_RepairOrder.Address1[] proxyaddresses = new WA.v2.WS_RepairOrder.Address1[customer.Addresses.Count];
                            foreach (WA.Standard.IF.Data.v2.Common.Customer.Address address in customer.Addresses)
                            {
                                WA.v2.WS_RepairOrder.Address1 proxyaddress = new WA.v2.WS_RepairOrder.Address1();
                                address.AddressType = Map.SetDMSCodeFromWACode(CodeType.AddressType, proxyaddress.AddressType);
                                address.City = proxyaddress.City;
                                address.District = proxyaddress.District;
                                address.Flat = proxyaddress.Flat;
                                address.FullAddress = proxyaddress.FullAddress;
                                address.House = proxyaddress.House;
                                address.Housing = proxyaddress.Housing;
                                address.Locality = proxyaddress.Locality;
                                address.Region = proxyaddress.Region;
                                address.Street = proxyaddress.Street;
                                address.ZipCode = proxyaddress.ZipCode;
                                proxyaddresses[addressescnt] = proxyaddress;
                                addressescnt++;
                            }
                            proxycustomer.Addresses = proxyaddresses;
                        }
                        #endregion

                        #region//RepairOrder Customer Contacts
                        if (customer.Contacts != null && customer.Contacts.Count > 0)
                        {
                            int contactscnt = 0;
                            WA.v2.WS_RepairOrder.Contact2[] proxycontacts = new WA.v2.WS_RepairOrder.Contact2[customer.Contacts.Count];
                            foreach (WA.Standard.IF.Data.v2.Common.Customer.Contact contact in customer.Contacts)
                            {
                                WA.v2.WS_RepairOrder.Contact2 proxycontact = new WA.v2.WS_RepairOrder.Contact2();
                                proxycontact.ContactMethodYN = contact.ContactMethodYN;
                                proxycontact.ContactType = Map.SetDMSCodeFromWACode(CodeType.ContactType, contact.ContactType);
                                proxycontact.ContactValue = contact.ContactValue;
                                proxycontacts[contactscnt] = proxycontact;
                                contactscnt++;
                            }
                            proxycustomer.Contacts = proxycontacts;
                        }
                        #endregion

                        #region//RepairOrder Customer SpecialMessage
                        if (customer.SpecialMessage != null)
                        {
                            WA.v2.WS_RepairOrder.SpecialMessage1 proxyspecialmessage = new WA.v2.WS_RepairOrder.SpecialMessage1();
                            proxyspecialmessage.Message = customer.SpecialMessage.Message;
                            proxycustomer.SpecialMessage = proxyspecialmessage;
                        }
                        #endregion

                        #region//RepairOrder Customer CorporateInfos
                        if (customer.CorporateInfos != null && customer.CorporateInfos.Count > 0)
                        {
                            int corporateinfoscnt = 0;
                            WA.v2.WS_RepairOrder.CorporateInfo1[] proxycorporateinfos = new WA.v2.WS_RepairOrder.CorporateInfo1[customer.CorporateInfos.Count];
                            foreach (WA.Standard.IF.Data.v2.Common.Customer.CorporateInfo corporateinfo in customer.CorporateInfos)
                            {
                                WA.v2.WS_RepairOrder.CorporateInfo1 proxycorporateinfo = new WA.v2.WS_RepairOrder.CorporateInfo1();
                                proxycorporateinfo.CorporateInfoName = corporateinfo.CorporateInfoName;
                                proxycorporateinfo.CorporateInfoValue = corporateinfo.CorporateInfoValue;
                                proxycorporateinfos[corporateinfoscnt] = proxycorporateinfo;
                                corporateinfoscnt++;
                            }
                            proxycustomer.CorporateInfos = proxycorporateinfos;
                        }
                        #endregion

                        proxycustomers[customerscnt] = proxycustomer;
                    }
                    proxyrepairorderchange.Customers = proxycustomers;
                }
                #endregion

                #region//RepairOrder Vehicle
                if (request.RepairOrderChange.Vehicle != null)
                {
                    #region//RepairOrder Vehicle Header
                    WA.v2.WS_RepairOrder.Vehicle2 proxyvehicle = new WA.v2.WS_RepairOrder.Vehicle2();
                    proxyvehicle.Color = request.RepairOrderChange.Vehicle.Color;
                    proxyvehicle.Cylinders = request.RepairOrderChange.Vehicle.Cylinders;
                    proxyvehicle.DateDelivered = request.RepairOrderChange.Vehicle.DateDelivered;
                    proxyvehicle.DateInService = request.RepairOrderChange.Vehicle.DateInService;
                    proxyvehicle.DeclinedJob = request.RepairOrderChange.Vehicle.DeclinedJob;
                    proxyvehicle.DisplayDescription = request.RepairOrderChange.Vehicle.DisplayDescription;
                    proxyvehicle.DMSVehicleNo = request.RepairOrderChange.Vehicle.DMSVehicleNo;
                    proxyvehicle.EngineType = request.RepairOrderChange.Vehicle.EngineType;
                    proxyvehicle.ExtendedWarranty = request.RepairOrderChange.Vehicle.ExtendedWarranty;
                    proxyvehicle.FuelType = request.RepairOrderChange.Vehicle.FuelType;
                    proxyvehicle.FullModelName = request.RepairOrderChange.Vehicle.FullModelName;
                    proxyvehicle.InsuranceDate = request.RepairOrderChange.Vehicle.InsuranceDate;
                    proxyvehicle.LastMileage = request.RepairOrderChange.Vehicle.LastMileage;
                    proxyvehicle.LastServiceDate = request.RepairOrderChange.Vehicle.LastServiceDate;
                    proxyvehicle.LastSixVIN = request.RepairOrderChange.Vehicle.LastSixVIN;
                    proxyvehicle.LicenseNumber = request.RepairOrderChange.Vehicle.LicenseNumber;
                    proxyvehicle.LicensePlateNo = request.RepairOrderChange.Vehicle.LicensePlateNo;
                    proxyvehicle.Make = request.RepairOrderChange.Vehicle.Make;
                    proxyvehicle.ModelCode = request.RepairOrderChange.Vehicle.ModelCode;
                    proxyvehicle.ModelName = request.RepairOrderChange.Vehicle.ModelName;
                    proxyvehicle.ModelYear = request.RepairOrderChange.Vehicle.ModelYear;
                    proxyvehicle.PendingJob = request.RepairOrderChange.Vehicle.PendingJob;
                    proxyvehicle.StockNumber = request.RepairOrderChange.Vehicle.StockNumber;
                    proxyvehicle.Trim = request.RepairOrderChange.Vehicle.Trim;
                    proxyvehicle.VehicleType = Map.SetDMSCodeFromWACode(CodeType.VehicleType, request.RepairOrderChange.Vehicle.VehicleType);
                    proxyvehicle.VIN = request.RepairOrderChange.Vehicle.VIN;
                    proxyvehicle.WarrantyMiles = request.RepairOrderChange.Vehicle.WarrantyMiles;
                    proxyvehicle.WarrantyMonths = request.RepairOrderChange.Vehicle.WarrantyMonths;
                    proxyvehicle.WarrantyStartDate = request.RepairOrderChange.Vehicle.WarrantyStartDate;
                    #endregion

                    #region//RepairOrder Vehicle Campaigns
                    if (request.RepairOrderChange.Vehicle.Campaigns != null && request.RepairOrderChange.Vehicle.Campaigns.Count > 0)
                    {
                        int campaignscnt = 0;
                        WA.v2.WS_RepairOrder.Campaign1[] proxycampaigns = new WA.v2.WS_RepairOrder.Campaign1[request.RepairOrderChange.Vehicle.Campaigns.Count];
                        foreach (WA.Standard.IF.Data.v2.Common.Vehicle.Campaign campaign in request.RepairOrderChange.Vehicle.Campaigns)
                        {
                            WA.v2.WS_RepairOrder.Campaign1 proxycampaign = new WA.v2.WS_RepairOrder.Campaign1();
                            proxycampaign.CampaignDescription = campaign.CampaignDescription;
                            proxycampaign.CampaignID = campaign.CampaignID;
                            proxycampaign.CampaignPerformed = campaign.CampaignPerformed;
                            proxycampaigns[campaignscnt] = proxycampaign;
                            campaignscnt++;
                        }
                        proxyvehicle.Campaigns = proxycampaigns;
                    }
                    #endregion

                    proxyrepairorderchange.Vehicle = proxyvehicle;
                }
                #endregion

                #region//RepairOrder RequestItems
                if (request.RepairOrderChange.RequestItems != null && request.RepairOrderChange.RequestItems.Count > 0)
                {
                    int requestitemscnt = 0;
                    WA.v2.WS_RepairOrder.RequestItem1[] proxyrequestitems = new WA.v2.WS_RepairOrder.RequestItem1[request.RepairOrderChange.RequestItems.Count];
                    foreach (WA.Standard.IF.Data.v2.Common.Common.RequestItem requestitem in request.RepairOrderChange.RequestItems)
                    {
                        #region//RepairOrder RequestItem Header
                        WA.v2.WS_RepairOrder.RequestItem1 proxyrequestitem = new WA.v2.WS_RepairOrder.RequestItem1();
                        proxyrequestitem.CPSIND = requestitem.CPSIND;
                        proxyrequestitem.RequestCode = requestitem.RequestCode;
                        proxyrequestitem.RequestDescription = requestitem.RequestDescription;
                        proxyrequestitem.ServiceLineNumber = requestitem.ServiceLineNumber;
                        proxyrequestitem.ServiceLineStatus = Map.SetDMSCodeFromWACode(CodeType.ServiceLineStatus, requestitem.ServiceLineStatus);
                        proxyrequestitem.ServiceType = Map.SetDMSCodeFromWACode(CodeType.ServiceType, requestitem.ServiceType);
                        proxyrequestitem.TCEmployeeID = requestitem.TCEmployeeID;
                        proxyrequestitem.TCEmployeeName = requestitem.TCEmployeeName;
                        proxyrequestitem.WorkType = Map.SetDMSCodeFromWACode(CodeType.WorkType, requestitem.WorkType);
                        #endregion

                        #region//RepairOrder RequestItem Comments
                        if (requestitem.Comments != null && requestitem.Comments.Count > 0)
                        {
                            int commentscnt = 0;
                            WA.v2.WS_RepairOrder.Comment1[] proxycomments = new WA.v2.WS_RepairOrder.Comment1[requestitem.Comments.Count];
                            foreach (WA.Standard.IF.Data.v2.Common.Common.Comment Comment in requestitem.Comments)
                            {
                                WA.v2.WS_RepairOrder.Comment1 proxycomment = new WA.v2.WS_RepairOrder.Comment1();
                                proxycomment.DescriptionComment = Comment.DescriptionComment;
                                proxycomment.SequenceNumber = Comment.SequenceNumber;
                                proxycomments[commentscnt] = proxycomment;
                                commentscnt++;
                            }
                            proxyrequestitem.Comments = proxycomments;
                        }
                        #endregion

                        #region//RepairOrder RequestItem Descriptions
                        if (requestitem.Descriptions != null && requestitem.Descriptions.Count > 0)
                        {
                            int descriptionscnt = 0;
                            WA.v2.WS_RepairOrder.Description1[] proxydescriptions = new WA.v2.WS_RepairOrder.Description1[requestitem.Descriptions.Count];
                            foreach (WA.Standard.IF.Data.v2.Common.Common.Description description in requestitem.Descriptions)
                            {
                                WA.v2.WS_RepairOrder.Description1 proxydescription = new WA.v2.WS_RepairOrder.Description1();
                                proxydescription.DescriptionComment = description.DescriptionComment;
                                proxydescription.SequenceNumber = description.SequenceNumber;
                                proxydescriptions[descriptionscnt] = proxydescription;
                                descriptionscnt++;
                            }
                            proxyrequestitem.Descriptions = proxydescriptions;
                        }
                        #endregion

                        #region//RepairOrder RequestItem OPCodes
                        if (requestitem.OPCodes != null && requestitem.OPCodes.Count > 0)
                        {
                            int opcodescnt = 0;
                            WA.v2.WS_RepairOrder.OPCode1[] proxyopcodes = new WA.v2.WS_RepairOrder.OPCode1[requestitem.OPCodes.Count];
                            foreach (WA.Standard.IF.Data.v2.Common.Common.OPCode opcode in requestitem.OPCodes)
                            {
                                #region//RepairOrder RequestItem OPCode Header
                                WA.v2.WS_RepairOrder.OPCode1 proxyopcode = new WA.v2.WS_RepairOrder.OPCode1();
                                proxyopcode.ActualHours = opcode.ActualHours;
                                proxyopcode.Code = opcode.Code;
                                proxyopcode.Description = opcode.Description;
                                proxyopcode.EstimatedHours = opcode.EstimatedHours;
                                proxyopcode.SequenceNumber = opcode.SequenceNumber;
                                proxyopcode.ServiceType = Map.SetDMSCodeFromWACode(CodeType.ServiceType, opcode.ServiceType);
                                proxyopcode.SkillLevel = opcode.SkillLevel;
                                #endregion

                                #region//RepairOrder RequestItem OPCode Descriptions
                                if (opcode.Descriptions != null && opcode.Descriptions.Count > 0)
                                {
                                    int descriptionscnt = 0;
                                    WA.v2.WS_RepairOrder.Description1[] proxydescriptions = new WA.v2.WS_RepairOrder.Description1[opcode.Descriptions.Count];
                                    foreach (WA.Standard.IF.Data.v2.Common.Common.Description description in opcode.Descriptions)
                                    {
                                        WA.v2.WS_RepairOrder.Description1 proxydescription = new WA.v2.WS_RepairOrder.Description1();
                                        proxydescription.DescriptionComment = description.DescriptionComment;
                                        proxydescription.SequenceNumber = description.SequenceNumber;
                                        proxydescriptions[descriptionscnt] = proxydescription;
                                        descriptionscnt++;
                                    }
                                    proxyopcode.Descriptions = proxydescriptions;
                                }
                                #endregion

                                #region//RepairOrder RequestItem OPCode Causes
                                if (opcode.Causes != null && opcode.Causes.Count > 0)
                                {
                                    int causescnt = 0;
                                    WA.v2.WS_RepairOrder.Cause1[] proxycauses = new WA.v2.WS_RepairOrder.Cause1[opcode.Causes.Count];
                                    foreach (WA.Standard.IF.Data.v2.Common.Common.Cause cause in opcode.Causes)
                                    {
                                        WA.v2.WS_RepairOrder.Cause1 proxycause = new WA.v2.WS_RepairOrder.Cause1();
                                        proxycause.CauseLaborOpCode = cause.CauseLaborOpCode;
                                        proxycause.Comment = cause.Comment;
                                        proxycause.SequenceNumber = cause.SequenceNumber;
                                        proxycauses[causescnt] = proxycause;
                                        causescnt++;
                                    }
                                    proxyopcode.Causes = proxycauses;
                                }
                                #endregion

                                #region//RepairOrder RequestItem OPCode Corrections
                                if (opcode.Corrections != null && opcode.Corrections.Count > 0)
                                {
                                    int correctionscnt = 0;
                                    WA.v2.WS_RepairOrder.Correction1[] proxycorrections = new WA.v2.WS_RepairOrder.Correction1[opcode.Corrections.Count];
                                    foreach (WA.Standard.IF.Data.v2.Common.Common.Correction Correction in opcode.Corrections)
                                    {
                                        WA.v2.WS_RepairOrder.Correction1 proxycorrection = new WA.v2.WS_RepairOrder.Correction1();
                                        proxycorrection.CorrectionLaborOpCode = Correction.CorrectionLaborOpCode;
                                        proxycorrection.Comment = Correction.Comment;
                                        proxycorrection.SequenceNumber = Correction.SequenceNumber;
                                        proxycorrections[correctionscnt] = proxycorrection;
                                        correctionscnt++;
                                    }
                                    proxyopcode.Corrections = proxycorrections;
                                }
                                #endregion

                                #region//RepairOrder RequestItem OPCode PriceType
                                if (opcode.PriceType != null)
                                {
                                    WA.v2.WS_RepairOrder.PriceType1 proxypricetype = new WA.v2.WS_RepairOrder.PriceType1();
                                    proxypricetype.DiscountPrice = opcode.PriceType.DiscountPrice;
                                    proxypricetype.DiscountRate = opcode.PriceType.DiscountRate;
                                    proxypricetype.TotalPrice = opcode.PriceType.TotalPrice;
                                    proxypricetype.TotalPriceIncludeTax = opcode.PriceType.TotalPriceIncludeTax;
                                    proxypricetype.UnitPrice = opcode.PriceType.UnitPrice;
                                    proxyopcode.PriceType = proxypricetype;
                                }
                                #endregion

                                #region//RepairOrder RequestItem OPCode Parts
                                if (opcode.Parts != null && opcode.Parts.Count > 0)
                                {
                                    int partscnt = 0;
                                    WA.v2.WS_RepairOrder.Part1[] proxyparts = new WA.v2.WS_RepairOrder.Part1[opcode.Parts.Count];
                                    foreach (WA.Standard.IF.Data.v2.Common.Common.Part part in opcode.Parts)
                                    {
                                        #region//RepairOrder RequestItem OPCode Parts Header
                                        WA.v2.WS_RepairOrder.Part1 proxypart = new WA.v2.WS_RepairOrder.Part1();
                                        proxypart.DisplayPartNumber = part.DisplayPartNumber;
                                        proxypart.PartDescription = part.PartDescription;
                                        proxypart.PartNumber = part.PartNumber;
                                        proxypart.PartType = Map.SetDMSCodeFromWACode(CodeType.PartType, part.PartType);
                                        proxypart.Quantity = part.Quantity;
                                        proxypart.SequenceNumber = part.SequenceNumber;
                                        proxypart.ServiceType = Map.SetDMSCodeFromWACode(CodeType.ServiceType, part.ServiceType);
                                        proxypart.StockQuantity = part.StockQuantity;
                                        proxypart.StockStatus = part.StockStatus;
                                        proxypart.UnitOfMeasure = part.UnitOfMeasure;
                                        #endregion

                                        #region//RepairOrder RequestItem OPCode Parts Descriptions
                                        if (part.Descriptions != null && part.Descriptions.Count > 0)
                                        {
                                            int descriptionscnt = 0;
                                            WA.v2.WS_RepairOrder.Description1[] proxydescriptions = new WA.v2.WS_RepairOrder.Description1[part.Descriptions.Count];
                                            foreach (WA.Standard.IF.Data.v2.Common.Common.Description description in part.Descriptions)
                                            {
                                                WA.v2.WS_RepairOrder.Description1 proxydescription = new WA.v2.WS_RepairOrder.Description1();
                                                proxydescription.DescriptionComment = description.DescriptionComment;
                                                proxydescription.SequenceNumber = description.SequenceNumber;
                                                proxydescriptions[descriptionscnt] = proxydescription;
                                                descriptionscnt++;
                                            }
                                            proxypart.Descriptions = proxydescriptions;
                                        }
                                        #endregion

                                        #region//RepairOrder RequestItem OPCode Parts PriceType
                                        if (part.PriceType != null)
                                        {
                                            WA.v2.WS_RepairOrder.PriceType1 proxypricetype = new WA.v2.WS_RepairOrder.PriceType1();
                                            proxypricetype.DiscountPrice = part.PriceType.DiscountPrice;
                                            proxypricetype.DiscountRate = part.PriceType.DiscountRate;
                                            proxypricetype.TotalPrice = part.PriceType.TotalPrice;
                                            proxypricetype.TotalPriceIncludeTax = part.PriceType.TotalPriceIncludeTax;
                                            proxypricetype.UnitPrice = part.PriceType.UnitPrice;
                                            proxypart.PriceType = proxypricetype;
                                        }
                                        #endregion

                                        proxyparts[partscnt] = proxypart;
                                        partscnt++;
                                    }
                                    proxyopcode.Parts = proxyparts;
                                }
                                #endregion

                                #region//RepairOrder RequestItem OPCode Sublets
                                if (opcode.Sublets != null && opcode.Sublets.Count > 0)
                                {
                                    int subletscnt = 0;
                                    WA.v2.WS_RepairOrder.Sublet1[] proxysublets = new WA.v2.WS_RepairOrder.Sublet1[opcode.Sublets.Count];
                                    foreach (WA.Standard.IF.Data.v2.Common.Common.Sublet sublet in opcode.Sublets)
                                    {
                                        #region//RepairOrder RequestItem OPCode Sublets Header
                                        WA.v2.WS_RepairOrder.Sublet1 proxysublet = new WA.v2.WS_RepairOrder.Sublet1();
                                        proxysublet.SequenceNumber = sublet.SequenceNumber;
                                        proxysublet.ServiceType = Map.SetDMSCodeFromWACode(CodeType.ServiceType, sublet.ServiceType);
                                        #endregion

                                        #region//RepairOrder RequestItem OPCode Sublets Descriptions
                                        if (sublet.Descriptions != null && sublet.Descriptions.Count > 0)
                                        {
                                            int descriptionscnt = 0;
                                            WA.v2.WS_RepairOrder.Description1[] proxydescriptions = new WA.v2.WS_RepairOrder.Description1[sublet.Descriptions.Count];
                                            foreach (WA.Standard.IF.Data.v2.Common.Common.Description description in sublet.Descriptions)
                                            {
                                                WA.v2.WS_RepairOrder.Description1 proxydescription = new WA.v2.WS_RepairOrder.Description1();
                                                proxydescription.DescriptionComment = description.DescriptionComment;
                                                proxydescription.SequenceNumber = description.SequenceNumber;
                                                proxydescriptions[descriptionscnt] = proxydescription;
                                                descriptionscnt++;
                                            }
                                            proxysublet.Descriptions = proxydescriptions;
                                        }
                                        #endregion

                                        #region//RepairOrder RequestItem OPCode Sublets PriceType
                                        if (sublet.PriceType != null)
                                        {
                                            WA.v2.WS_RepairOrder.PriceType1 proxypricetype = new WA.v2.WS_RepairOrder.PriceType1();
                                            proxypricetype.DiscountPrice = sublet.PriceType.DiscountPrice;
                                            proxypricetype.DiscountRate = sublet.PriceType.DiscountRate;
                                            proxypricetype.TotalPrice = sublet.PriceType.TotalPrice;
                                            proxypricetype.TotalPriceIncludeTax = sublet.PriceType.TotalPriceIncludeTax;
                                            proxypricetype.UnitPrice = sublet.PriceType.UnitPrice;
                                            proxysublet.PriceType = proxypricetype;
                                        }
                                        #endregion

                                        proxysublets[subletscnt] = proxysublet;
                                        subletscnt++;
                                    }
                                    proxyopcode.Sublets = proxysublets;
                                }
                                #endregion

                                #region//RepairOrder RequestItem OPCode MISCs
                                if (opcode.MISCs != null && opcode.MISCs.Count > 0)
                                {
                                    int miscscnt = 0;
                                    WA.v2.WS_RepairOrder.MISC1[] proxymiscs = new WA.v2.WS_RepairOrder.MISC1[opcode.MISCs.Count];
                                    foreach (WA.Standard.IF.Data.v2.Common.Common.MISC misc in opcode.MISCs)
                                    {
                                        #region//RepairOrder RequestItem OPCode MISCs Header
                                        WA.v2.WS_RepairOrder.MISC1 proxymisc = new WA.v2.WS_RepairOrder.MISC1();
                                        proxymisc.SequenceNumber = misc.SequenceNumber;
                                        proxymisc.ServiceType = Map.SetDMSCodeFromWACode(CodeType.ServiceType, misc.ServiceType);
                                        #endregion

                                        #region//RepairOrder RequestItem OPCode MISCs Descriptions
                                        if (misc.Descriptions != null && misc.Descriptions.Count > 0)
                                        {
                                            int descriptionscnt = 0;
                                            WA.v2.WS_RepairOrder.Description1[] proxydescriptions = new WA.v2.WS_RepairOrder.Description1[misc.Descriptions.Count];
                                            foreach (WA.Standard.IF.Data.v2.Common.Common.Description description in misc.Descriptions)
                                            {
                                                WA.v2.WS_RepairOrder.Description1 proxydescription = new WA.v2.WS_RepairOrder.Description1();
                                                proxydescription.DescriptionComment = description.DescriptionComment;
                                                proxydescription.SequenceNumber = description.SequenceNumber;
                                                proxydescriptions[descriptionscnt] = proxydescription;
                                                descriptionscnt++;
                                            }
                                            proxymisc.Descriptions = proxydescriptions;
                                        }
                                        #endregion

                                        #region//RepairOrder RequestItem OPCode MISCs PriceType
                                        if (misc.PriceType != null)
                                        {
                                            WA.v2.WS_RepairOrder.PriceType1 proxypricetype = new WA.v2.WS_RepairOrder.PriceType1();
                                            proxypricetype.DiscountPrice = misc.PriceType.DiscountPrice;
                                            proxypricetype.DiscountRate = misc.PriceType.DiscountRate;
                                            proxypricetype.TotalPrice = misc.PriceType.TotalPrice;
                                            proxypricetype.TotalPriceIncludeTax = misc.PriceType.TotalPriceIncludeTax;
                                            proxypricetype.UnitPrice = misc.PriceType.UnitPrice;
                                            proxymisc.PriceType = proxypricetype;
                                        }
                                        #endregion

                                        proxymiscs[miscscnt] = proxymisc;
                                        miscscnt++;
                                    }
                                    proxyopcode.MISCs = proxymiscs;
                                }
                                #endregion

                                proxyopcodes[opcodescnt] = proxyopcode;
                                opcodescnt++;
                            }
                            proxyrequestitem.OPCodes = proxyopcodes;
                        }
                        #endregion

                        proxyrequestitems[requestitemscnt] = proxyrequestitem;
                        requestitemscnt++;
                    }
                    proxyrepairorderchange.RequestItems = proxyrequestitems;
                }
                #endregion

                proxyrequest.RepairOrderChange = proxyrepairorderchange;
            }
            #endregion

            //Run proxy web method with proxy request
            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS RepairOrderChangeRequest XML", proxyrequest);

            WA.v2.WS_RepairOrder.RepairOrderChangeResponse proxyresponse = proxyws.RepairOrderChange(proxyrequest);

            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS RepairOrderChangeResponse XML", proxyresponse);

            //Mapping with Standard Interface Specification Object
            if (proxyresponse != null)
            {
                if (proxyresponse.TransactionHeader != null)
                {
                    #region//TransactionHeader Set
                    WA.Standard.IF.Data.v2.Common.Common.TransactionHeader transactionheader = new WA.Standard.IF.Data.v2.Common.Common.TransactionHeader();
                    transactionheader.CountryID = proxyresponse.TransactionHeader.CountryID;
                    transactionheader.DealerID = proxyresponse.TransactionHeader.DealerID;
                    transactionheader.DistributorID = proxyresponse.TransactionHeader.DistributorID;
                    transactionheader.DMSCode = proxyresponse.TransactionHeader.DMSCode;
                    transactionheader.DMSServerUrl = proxyresponse.TransactionHeader.DMSServerUrl;
                    transactionheader.DMSVersion = proxyresponse.TransactionHeader.DMSVersion;
                    transactionheader.DocumentVersion = proxyresponse.TransactionHeader.DocumentVersion;
                    transactionheader.GroupID = proxyresponse.TransactionHeader.GroupID;
                    transactionheader.IneterfaceID = proxyresponse.TransactionHeader.IneterfaceID;
                    transactionheader.Password = proxyresponse.TransactionHeader.Password;
                    transactionheader.PollingToken = proxyresponse.TransactionHeader.PollingToken;
                    transactionheader.RequestPollingToken = proxyresponse.TransactionHeader.RequestPollingToken;
                    transactionheader.RequestType = proxyresponse.TransactionHeader.RequestType;
                    transactionheader.TransactionId = proxyresponse.TransactionHeader.TransactionId;
                    transactionheader.TransactionDateTimeLocal = proxyresponse.TransactionHeader.TransactionDateTimeLocal;
                    transactionheader.TransactionDateTimeUTC = proxyresponse.TransactionHeader.TransactionDateTimeUTC;
                    transactionheader.TransactionType = proxyresponse.TransactionHeader.TransactionType;
                    transactionheader.Username = proxyresponse.TransactionHeader.Username;
                    transactionheader.VenderTrackingCode = proxyresponse.TransactionHeader.VenderTrackingCode;
                    response.TransactionHeader = transactionheader;
                    #endregion
                }

                //ResultMessage Set
                if (proxyresponse.ResultMessage != null)
                {
                    response.ResultMessage = GetResultMessageData(proxyresponse.ResultMessage.Code, proxyresponse.ResultMessage.Message);
                }

                if (proxyresponse.Errors != null)
                {
                    //Error List Set
                    foreach (WA.v2.WS_RepairOrder.Error1 proxyerror in proxyresponse.Errors)
                    {
                        if (response.Errors != null)
                            response.Errors.Add(GetErrorData(proxyerror.Code, proxyerror.Message));
                        else
                            response.Errors = GetErrorDataList(proxyerror.Code, proxyerror.Message);
                    }
                }
            }
            #endregion

            return response;
        }

        public WA.Standard.IF.Data.v2.Common.Job.JobGetResponse JobGet(WA.Standard.IF.Data.v2.Common.Job.JobGetRequest request)
        {
            WA.Standard.IF.Data.v2.Common.Job.JobGetResponse response = new WA.Standard.IF.Data.v2.Common.Job.JobGetResponse();

            #region v2.WA.v2 - WA.Standard.IF.WebService

            #region JobGet Request Set

            //Create proxy credential
            NetworkCredential proxycredential = new NetworkCredential(request.TransactionHeader.Username, request.TransactionHeader.Password);

            //Create proxy web service from dms web service with credential
            WA.v2.WS_Job.Job proxyws = new WA.v2.WS_Job.Job();
            proxyws.Credentials = proxycredential;

            //Create proxy request with jobget and transaction
            WA.v2.WS_Job.JobGetRequest proxyrequest = new WA.v2.WS_Job.JobGetRequest();

            //Create proxy transaction
            WA.v2.WS_Job.TransactionHeader proxytransactionheader = new WA.v2.WS_Job.TransactionHeader();
            if (request.TransactionHeader != null)
            {
                #region//TransactionHeader Set
                proxytransactionheader.CountryID = request.TransactionHeader.CountryID;
                proxytransactionheader.DealerID = request.TransactionHeader.DealerID;
                proxytransactionheader.DistributorID = request.TransactionHeader.DistributorID;
                proxytransactionheader.DMSCode = request.TransactionHeader.DMSCode;
                proxytransactionheader.DMSServerUrl = request.TransactionHeader.DMSServerUrl;
                proxytransactionheader.DMSVersion = request.TransactionHeader.DMSVersion;
                proxytransactionheader.DocumentVersion = request.TransactionHeader.DocumentVersion;
                proxytransactionheader.GroupID = request.TransactionHeader.GroupID;
                proxytransactionheader.IneterfaceID = request.TransactionHeader.IneterfaceID;
                proxytransactionheader.Password = request.TransactionHeader.Password;
                proxytransactionheader.PollingToken = request.TransactionHeader.PollingToken;
                proxytransactionheader.RequestPollingToken = request.TransactionHeader.RequestPollingToken;
                proxytransactionheader.RequestType = request.TransactionHeader.RequestType;
                proxytransactionheader.TransactionId = request.TransactionHeader.TransactionId;
                proxytransactionheader.TransactionDateTimeLocal = request.TransactionHeader.TransactionDateTimeLocal;
                proxytransactionheader.TransactionDateTimeUTC = request.TransactionHeader.TransactionDateTimeUTC;
                proxytransactionheader.TransactionType = request.TransactionHeader.TransactionType;
                proxytransactionheader.Username = request.TransactionHeader.Username;
                proxytransactionheader.VenderTrackingCode = request.TransactionHeader.VenderTrackingCode;
                proxyrequest.TransactionHeader = proxytransactionheader;
                proxyws.Url = string.Format("{0}/rtr-atest/ws/Job.1cws", proxytransactionheader.DMSServerUrl);
                #endregion
            }

            //Create proxy jobget
            WA.v2.WS_Job.JobGet proxyjobget = new WA.v2.WS_Job.JobGet();
            if (request.JobGet != null)
            {
                #region//JobGet Set
                proxyjobget.DMSAppointmentNo = request.JobGet.DMSAppointmentNo;
                proxyjobget.DMSJobNo = request.JobGet.DMSJobNo;
                proxyjobget.DMSJobStatus = Map.SetDMSCodeFromWACode(CodeType.DMSJobStatus, request.JobGet.DMSJobStatus);
                proxyjobget.DMSRONo = request.JobGet.DMSRONo;
                proxyjobget.LastModifiedDateTimeFromUTC = request.JobGet.LastModifiedDateTimeFromUTC;
                proxyjobget.LastModifiedDateTimeToUTC = request.JobGet.LastModifiedDateTimeToUTC;
                proxyjobget.ScheduledDateTimeFromLocal = request.JobGet.ScheduledDateTimeFromLocal;
                proxyjobget.ScheduledDateTimeToLocal = request.JobGet.ScheduledDateTimeToLocal;
                proxyrequest.JobGet = proxyjobget;
                #endregion
            }

            #endregion

            //Run proxy web method with proxy request
            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS JobGetRequest XML", proxyrequest);

            WA.v2.WS_Job.JobGetResponse proxyresponse = proxyws.JobGet(proxyrequest);

            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS JobGetResponse XML", proxyresponse);

            //Mapping with Standard Interface Specification Object
            if (proxyresponse != null)
            {
                if (proxyresponse.TransactionHeader != null)
                {
                    #region//TransactionHeader Set
                    WA.Standard.IF.Data.v2.Common.Common.TransactionHeader transactionheader = new WA.Standard.IF.Data.v2.Common.Common.TransactionHeader();
                    transactionheader.CountryID = proxyresponse.TransactionHeader.CountryID;
                    transactionheader.DealerID = proxyresponse.TransactionHeader.DealerID;
                    transactionheader.DistributorID = proxyresponse.TransactionHeader.DistributorID;
                    transactionheader.DMSCode = proxyresponse.TransactionHeader.DMSCode;
                    transactionheader.DMSServerUrl = proxyresponse.TransactionHeader.DMSServerUrl;
                    transactionheader.DMSVersion = proxyresponse.TransactionHeader.DMSVersion;
                    transactionheader.DocumentVersion = proxyresponse.TransactionHeader.DocumentVersion;
                    transactionheader.GroupID = proxyresponse.TransactionHeader.GroupID;
                    transactionheader.IneterfaceID = proxyresponse.TransactionHeader.IneterfaceID;
                    transactionheader.Password = proxyresponse.TransactionHeader.Password;
                    transactionheader.PollingToken = proxyresponse.TransactionHeader.PollingToken;
                    transactionheader.RequestPollingToken = proxyresponse.TransactionHeader.RequestPollingToken;
                    transactionheader.RequestType = proxyresponse.TransactionHeader.RequestType;
                    transactionheader.TransactionId = proxyresponse.TransactionHeader.TransactionId;
                    transactionheader.TransactionDateTimeLocal = proxyresponse.TransactionHeader.TransactionDateTimeLocal;
                    transactionheader.TransactionDateTimeUTC = proxyresponse.TransactionHeader.TransactionDateTimeUTC;
                    transactionheader.TransactionType = proxyresponse.TransactionHeader.TransactionType;
                    transactionheader.Username = proxyresponse.TransactionHeader.Username;
                    transactionheader.VenderTrackingCode = proxyresponse.TransactionHeader.VenderTrackingCode;
                    response.TransactionHeader = transactionheader;
                    #endregion
                }

                //ResultMessage Set
                if (proxyresponse.ResultMessage != null)
                {
                    response.ResultMessage = GetResultMessageData(proxyresponse.ResultMessage.Code, proxyresponse.ResultMessage.Message);
                }

                if (proxyresponse.Errors != null)
                {
                    //Error List Set
                    foreach (WA.v2.WS_Job.Error proxyerror in proxyresponse.Errors)
                    {
                        if (response.Errors != null)
                            response.Errors.Add(GetErrorData(proxyerror.Code, proxyerror.Message));
                        else
                            response.Errors = GetErrorDataList(proxyerror.Code, proxyerror.Message);
                    }
                }
                else
                {
                    #region//JobGetResponse Set

                    if (proxyresponse.Jobs != null && proxyresponse.Jobs.Length > 0)
                    {
                        response.Jobs = new List<WA.Standard.IF.Data.v2.Common.Job.Job>();
                        foreach (WA.v2.WS_Job.Job1 proxyjob in proxyresponse.Jobs)
                        {
                            #region//Job Header
                            WA.Standard.IF.Data.v2.Common.Job.Job job = new WA.Standard.IF.Data.v2.Common.Job.Job();
                            job.ActualHours = proxyjob.ActualHours;
                            job.DMSJobNo = proxyjob.DMSJobNo;
                            job.DMSRONo = proxyjob.DMSRONo;
                            job.DMSAppointmentNo = proxyjob.DMSAppointmentNo;
                            job.ServiceLineNumber = proxyjob.ServiceLineNumber;
                            job.SkillLevel = proxyjob.SkillLevel;
                            job.DMSJobStatus = proxyjob.DMSJobStatus;
                            #endregion

                            #region //Job ManagementFields
                            if (proxyjob.ManagementFields != null)
                            {
                                WA.Standard.IF.Data.v2.Common.Common.ManagementFields managementfields = new WA.Standard.IF.Data.v2.Common.Common.ManagementFields();
                                managementfields.CreateDateTimeUTC = proxyjob.ManagementFields.CreateDateTimeUTC;
                                managementfields.LastModifiedDateTimeUTC = proxyjob.ManagementFields.LastModifiedDateTimeUTC;
                                job.ManagementFields = managementfields;
                            }
                            #endregion

                            #region//Job Comments - Not Used
                            if (proxyjob.Comments != null && proxyjob.Comments.Length > 0)
                            {
                                job.Comments = new List<WA.Standard.IF.Data.v2.Common.Common.Comment>();
                                foreach (WA.v2.WS_Job.Comment proxycomment in proxyjob.Comments)
                                {
                                    WA.Standard.IF.Data.v2.Common.Common.Comment comment = new WA.Standard.IF.Data.v2.Common.Common.Comment();
                                    comment.DescriptionComment = proxycomment.DescriptionComment;
                                    comment.SequenceNumber = proxycomment.SequenceNumber;
                                    job.Comments.Add(comment);
                                }
                            }
                            #endregion

                            #region//Job Descriptions - Not Used
                            if (proxyjob.Descriptions != null && proxyjob.Descriptions.Length > 0)
                            {
                                job.Descriptions = new List<WA.Standard.IF.Data.v2.Common.Common.Description>();
                                foreach (WA.v2.WS_Job.Description proxydescription in proxyjob.Descriptions)
                                {
                                    WA.Standard.IF.Data.v2.Common.Common.Description description = new WA.Standard.IF.Data.v2.Common.Common.Description();
                                    description.DescriptionComment = proxydescription.DescriptionComment;
                                    description.SequenceNumber = proxydescription.SequenceNumber;
                                    job.Descriptions.Add(description);
                                }
                            }
                            #endregion

                            #region//Job Causes - Not Used
                            if (proxyjob.Causes != null && proxyjob.Causes.Length > 0)
                            {
                                job.Causes = new List<WA.Standard.IF.Data.v2.Common.Common.Cause>();
                                foreach (WA.v2.WS_Job.Cause proxycause in proxyjob.Causes)
                                {
                                    WA.Standard.IF.Data.v2.Common.Common.Cause cause = new WA.Standard.IF.Data.v2.Common.Common.Cause();
                                    cause.CauseLaborOpCode = proxycause.CauseLaborOpCode;
                                    cause.Comment = proxycause.Comment;
                                    cause.SequenceNumber = proxycause.SequenceNumber;
                                    job.Causes.Add(cause);
                                }
                            }
                            #endregion

                            #region//Job Corrections - Not Used
                            if (proxyjob.Corrections != null && proxyjob.Corrections.Length > 0)
                            {
                                job.Corrections = new List<WA.Standard.IF.Data.v2.Common.Common.Correction>();
                                foreach (WA.v2.WS_Job.Correction proxycorrection in proxyjob.Corrections)
                                {
                                    WA.Standard.IF.Data.v2.Common.Common.Correction cause = new WA.Standard.IF.Data.v2.Common.Common.Correction();
                                    cause.CorrectionLaborOpCode = proxycorrection.CorrectionLaborOpCode;
                                    cause.Comment = proxycorrection.Comment;
                                    cause.SequenceNumber = proxycorrection.SequenceNumber;
                                    job.Corrections.Add(cause);
                                }
                            }
                            #endregion

                            #region//Job OPCodes
                            if (proxyjob.OPCodes != null && proxyjob.OPCodes.Length > 0)
                            {
                                job.OPCodes = new List<WA.Standard.IF.Data.v2.Common.Job.OPCode>();
                                foreach (WA.v2.WS_Job.OPCode proxyopcode in proxyjob.OPCodes)
                                {
                                    #region//Job OPCode Header
                                    WA.Standard.IF.Data.v2.Common.Job.OPCode opcode = new WA.Standard.IF.Data.v2.Common.Job.OPCode();
                                    opcode.ActualHours = proxyopcode.ActualHours;
                                    opcode.Code = proxyopcode.Code;
                                    opcode.Description = proxyopcode.Description;
                                    opcode.EstimatedHours = proxyopcode.EstimatedHours;
                                    opcode.SkillLevel = proxyopcode.SkillLevel;
                                    #endregion

                                    #region//Job OPCode Comments - Not Used
                                    //if (proxyopcode.Comments != null && proxyopcode.Comments.Length > 0)
                                    //{
                                    //    opcode.Comments = new List<WA.Standard.IF.Data.v2.Common.Common.Comment>();
                                    //    foreach (WA.v2.WS_Job.Comment proxycomment in proxyopcode.Comments)
                                    //    {
                                    //        WA.Standard.IF.Data.v2.Common.Common.Comment comment = new WA.Standard.IF.Data.v2.Common.Common.Comment();
                                    //        comment.DescriptionComment = proxycomment.DescriptionComment;
                                    //        comment.SequenceNumber = proxycomment.SequenceNumber;
                                    //        opcode.Comments.Add(comment);
                                    //    }
                                    //}
                                    #endregion

                                    #region//Job OPCode Descriptions - Not Used
                                    //if (proxyopcode.Descriptions != null && proxyopcode.Descriptions.Length > 0)
                                    //{
                                    //    opcode.Descriptions = new List<WA.Standard.IF.Data.v2.Common.Common.Description>();
                                    //    foreach (WA.v2.WS_Job.Description proxydescription in proxyopcode.Descriptions)
                                    //    {
                                    //        WA.Standard.IF.Data.v2.Common.Common.Description description = new WA.Standard.IF.Data.v2.Common.Common.Description();
                                    //        description.DescriptionComment = proxydescription.DescriptionComment;
                                    //        description.SequenceNumber = proxydescription.SequenceNumber;
                                    //        opcode.Descriptions.Add(description);
                                    //    }
                                    //}
                                    #endregion

                                    #region//Job OPCode Causes - Not Used
                                    //if (proxyopcode.Causes != null && proxyopcode.Causes.Length > 0)
                                    //{
                                    //    opcode.Causes = new List<WA.Standard.IF.Data.v2.Common.Common.Cause>();
                                    //    foreach (WA.v2.WS_Job.Cause proxycause in proxyopcode.Causes)
                                    //    {
                                    //        WA.Standard.IF.Data.v2.Common.Common.Cause cause = new WA.Standard.IF.Data.v2.Common.Common.Cause();
                                    //        cause.CauseLaborOpCode = proxycause.CauseLaborOpCode;
                                    //        cause.Comment = proxycause.Comment;
                                    //        cause.SequenceNumber = proxycause.SequenceNumber;
                                    //        opcode.Causes.Add(cause);
                                    //    }
                                    //}
                                    #endregion

                                    #region//Job OPCode Corrections - Not Used
                                    //if (proxyopcode.Corrections != null && proxyopcode.Corrections.Length > 0)
                                    //{
                                    //    opcode.Corrections = new List<WA.Standard.IF.Data.v2.Common.Common.Correction>();
                                    //    foreach (WA.v2.WS_Job.Correction proxycorrection in proxyopcode.Corrections)
                                    //    {
                                    //        WA.Standard.IF.Data.v2.Common.Common.Correction correction = new WA.Standard.IF.Data.v2.Common.Common.Correction();
                                    //        correction.CorrectionLaborOpCode = proxycorrection.CorrectionLaborOpCode;
                                    //        correction.Comment = proxycorrection.Comment;
                                    //        correction.SequenceNumber = proxycorrection.SequenceNumber;
                                    //        opcode.Corrections.Add(correction);
                                    //    }
                                    //}
                                    #endregion

                                    job.OPCodes.Add(opcode);
                                }
                            }
                            #endregion

                            #region//Job Plan
                            if (proxyjob.Plan != null)
                            {
                                #region//Job Plan Header
                                WA.Standard.IF.Data.v2.Common.Job.Plan plan = new WA.Standard.IF.Data.v2.Common.Job.Plan();
                                plan.ScheduledDateTimeFromLocal = proxyjob.Plan.ScheduledDateTimeFromLocal;
                                plan.ScheduledDateTimeToLocal = proxyjob.Plan.ScheduledDateTimeToLocal;
                                plan.StallID = proxyjob.Plan.StallID;
                                plan.StallName = proxyjob.Plan.StallName;
                                #endregion

                                #region//Job Technicians
                                if (proxyjob.Plan.Technicians != null && proxyjob.Plan.Technicians.Length > 0)
                                {
                                    plan.Technicians = new List<WA.Standard.IF.Data.v2.Common.Job.Technician>();
                                    foreach (WA.v2.WS_Job.Technician proxytechnician in proxyjob.Plan.Technicians)
                                    {
                                        WA.Standard.IF.Data.v2.Common.Job.Technician technician = new WA.Standard.IF.Data.v2.Common.Job.Technician();
                                        technician.TCEmployeeID = proxytechnician.TCEmployeeID;
                                        technician.TCEmployeeName = proxytechnician.TCEmployeeName;
                                        plan.Technicians.Add(technician);
                                    }
                                }
                                #endregion

                                job.Plan = plan;
                            }
                            #endregion

                            #region//Job Dispatch
                            if (proxyjob.Dispatch != null)
                            {
                                #region//Job Dispatch Header
                                WA.Standard.IF.Data.v2.Common.Job.Dispatch dispatch = new WA.Standard.IF.Data.v2.Common.Job.Dispatch();
                                dispatch.ScheduledDateTimeFromLocal = proxyjob.Dispatch.ScheduledDateTimeFromLocal;
                                dispatch.ScheduledDateTimeToLocal = proxyjob.Dispatch.ScheduledDateTimeToLocal;
                                dispatch.StallID = proxyjob.Dispatch.StallID;
                                dispatch.StallName = proxyjob.Dispatch.StallName;
                                #endregion

                                #region//Job Technicians
                                if (proxyjob.Dispatch.Technicians != null && proxyjob.Dispatch.Technicians.Length > 0)
                                {
                                    dispatch.Technicians = new List<WA.Standard.IF.Data.v2.Common.Job.Technician>();
                                    foreach (WA.v2.WS_Job.Technician proxytechnician in proxyjob.Dispatch.Technicians)
                                    {
                                        WA.Standard.IF.Data.v2.Common.Job.Technician technician = new WA.Standard.IF.Data.v2.Common.Job.Technician();
                                        technician.TCEmployeeID = proxytechnician.TCEmployeeID;
                                        technician.TCEmployeeName = proxytechnician.TCEmployeeName;
                                        dispatch.Technicians.Add(technician);
                                    }
                                }
                                #endregion

                                job.Dispatch = dispatch;
                            }
                            #endregion

                            #region//Job Actual
                            if (proxyjob.Actual != null)
                            {
                                #region//Job Actual Header
                                WA.Standard.IF.Data.v2.Common.Job.Actual actual = new WA.Standard.IF.Data.v2.Common.Job.Actual();
                                actual.StallID = proxyjob.Actual.StallID;
                                actual.StallName = proxyjob.Actual.StallName;
                                #endregion

                                #region//Job ActualTimeLogs
                                if (proxyjob.Actual.ActualTimeLogs != null && proxyjob.Actual.ActualTimeLogs.Length > 0)
                                {
                                    actual.ActualTimeLogs = new List<WA.Standard.IF.Data.v2.Common.Job.ActualTimeLog>();
                                    foreach (WA.v2.WS_Job.ActualTimeLog proxyactualtimelog in proxyjob.Actual.ActualTimeLogs)
                                    {
                                        WA.Standard.IF.Data.v2.Common.Job.ActualTimeLog actualtimelog = new WA.Standard.IF.Data.v2.Common.Job.ActualTimeLog();
                                        actualtimelog.EndDateTimeLocal = proxyactualtimelog.EndDateTimeLocal;
                                        actualtimelog.PauseReasonCode = Map.GetWACodeFromDMSCode(CodeType.PauseReasonCode, proxyactualtimelog.PauseReasonCode);
                                        actualtimelog.PauseReasonComment = proxyactualtimelog.PauseReasonComment;
                                        actualtimelog.StartDateTimeLocal = proxyactualtimelog.StartDateTimeLocal;
                                        actualtimelog.Status = Map.GetWACodeFromDMSCode(CodeType.ActualJobStatus, proxyactualtimelog.Status);
                                        actualtimelog.TCEmployeeID = proxyactualtimelog.TCEmployeeID;
                                        actualtimelog.TCEmployeeName = proxyactualtimelog.TCEmployeeName;
                                        actual.ActualTimeLogs.Add(actualtimelog);
                                    }
                                }
                                #endregion

                                #region//Job JobComments
                                if (proxyjob.Actual.JobComments != null && proxyjob.Actual.JobComments.Length > 0)
                                {
                                    actual.JobComments = new List<WA.Standard.IF.Data.v2.Common.Job.JobComment>();
                                    foreach (WA.v2.WS_Job.JobComment proxyjobcomment in proxyjob.Actual.JobComments)
                                    {
                                        WA.Standard.IF.Data.v2.Common.Job.JobComment jobcomment = new WA.Standard.IF.Data.v2.Common.Job.JobComment();
                                        jobcomment.ActualWorkHour = proxyjobcomment.ActualWorkHour;
                                        jobcomment.SubStatus = Map.GetWACodeFromDMSCode(CodeType.JobSubStatus, proxyjobcomment.SubStatus);
                                        actual.JobComments.Add(jobcomment);
                                    }
                                }
                                #endregion

                                job.Actual = actual;
                            }
                            #endregion

                            response.Jobs.Add(job);
                        }
                    }
                    else
                    {
                        response.ResultMessage = GetResultMessageData(WA.Standard.IF.Data.v2.Common.Common.ResponseCode.NoResult, WA.Standard.IF.Data.v2.Common.Common.ResponseMessage.NoResult);
                    }
                    #endregion
                }
            }
            #endregion

            return response;
        }

        public WA.Standard.IF.Data.v2.Common.Job.JobChangeResponse JobChange(WA.Standard.IF.Data.v2.Common.Job.JobChangeRequest request)
        {
            WA.Standard.IF.Data.v2.Common.Job.JobChangeResponse response = new WA.Standard.IF.Data.v2.Common.Job.JobChangeResponse();

            #region v2.WA.v2 - WA.Standard.IF.WebService

            #region JobChange Request Set

            //Create proxy credential
            NetworkCredential proxycredential = new NetworkCredential(request.TransactionHeader.Username, request.TransactionHeader.Password);

            //Create proxy web service from dms web service with credential
            WA.v2.WS_Job.Job proxyws = new WA.v2.WS_Job.Job();
            proxyws.Credentials = proxycredential;

            //Create proxy request with jobchange and transaction
            WA.v2.WS_Job.JobChangeRequest proxyrequest = new WA.v2.WS_Job.JobChangeRequest();

            //Create proxy transaction
            WA.v2.WS_Job.TransactionHeader2 proxytransactionheader = new WA.v2.WS_Job.TransactionHeader2();
            if (request.TransactionHeader != null)
            {
                #region//TransactionHeader Set
                proxytransactionheader.CountryID = request.TransactionHeader.CountryID;
                proxytransactionheader.DealerID = request.TransactionHeader.DealerID;
                proxytransactionheader.DistributorID = request.TransactionHeader.DistributorID;
                proxytransactionheader.DMSCode = request.TransactionHeader.DMSCode;
                proxytransactionheader.DMSServerUrl = request.TransactionHeader.DMSServerUrl;
                proxytransactionheader.DMSVersion = request.TransactionHeader.DMSVersion;
                proxytransactionheader.DocumentVersion = request.TransactionHeader.DocumentVersion;
                proxytransactionheader.GroupID = request.TransactionHeader.GroupID;
                proxytransactionheader.IneterfaceID = request.TransactionHeader.IneterfaceID;
                proxytransactionheader.Password = request.TransactionHeader.Password;
                proxytransactionheader.PollingToken = request.TransactionHeader.PollingToken;
                proxytransactionheader.RequestPollingToken = request.TransactionHeader.RequestPollingToken;
                proxytransactionheader.RequestType = request.TransactionHeader.RequestType;
                proxytransactionheader.TransactionId = request.TransactionHeader.TransactionId;
                proxytransactionheader.TransactionDateTimeLocal = request.TransactionHeader.TransactionDateTimeLocal;
                proxytransactionheader.TransactionDateTimeUTC = request.TransactionHeader.TransactionDateTimeUTC;
                proxytransactionheader.TransactionType = request.TransactionHeader.TransactionType;
                proxytransactionheader.Username = request.TransactionHeader.Username;
                proxytransactionheader.VenderTrackingCode = request.TransactionHeader.VenderTrackingCode;
                proxyrequest.TransactionHeader = proxytransactionheader;
                proxyws.Url = string.Format("{0}/rtr-atest/ws/Job.1cws", proxytransactionheader.DMSServerUrl);
                #endregion
            }

            //Create proxy jobchange
            WA.v2.WS_Job.JobChange proxyjobchange = new WA.v2.WS_Job.JobChange();
            if (request.JobChange != null)
            {
                #region//JobChange Header
                proxyjobchange.ActualHours = request.JobChange.ActualHours;
                proxyjobchange.DMSJobNo = request.JobChange.DMSJobNo;
                proxyjobchange.DMSRONo = request.JobChange.DMSRONo;
                proxyjobchange.DMSAppointmentNo = request.JobChange.DMSAppointmentNo;
                proxyjobchange.EstimatedHours = request.JobChange.EstimatedHours;
                proxyjobchange.ServiceLineNumber = request.JobChange.ServiceLineNumber;
                proxyjobchange.SkillLevel = request.JobChange.SkillLevel;
                #endregion

                #region//JobChange Comments
                if (request.JobChange.Comments != null && request.JobChange.Comments.Count > 0)
                {
                    int commentscnt = 0;
                    WA.v2.WS_Job.Comment1[] proxycomments = new WA.v2.WS_Job.Comment1[request.JobChange.Comments.Count];
                    foreach (WA.Standard.IF.Data.v2.Common.Common.Comment Comment in request.JobChange.Comments)
                    {
                        WA.v2.WS_Job.Comment1 proxycomment = new WA.v2.WS_Job.Comment1();
                        proxycomment.DescriptionComment = Comment.DescriptionComment;
                        proxycomment.SequenceNumber = Comment.SequenceNumber;
                        proxycomments[commentscnt] = proxycomment;
                        commentscnt++;
                    }
                    proxyjobchange.Comments = proxycomments;
                }
                #endregion

                #region//JobChange Descriptions
                if (request.JobChange.Descriptions != null && request.JobChange.Descriptions.Count > 0)
                {
                    int descriptionscnt = 0;
                    WA.v2.WS_Job.Description1[] proxydescriptions = new WA.v2.WS_Job.Description1[request.JobChange.Descriptions.Count];
                    foreach (WA.Standard.IF.Data.v2.Common.Common.Description description in request.JobChange.Descriptions)
                    {
                        WA.v2.WS_Job.Description1 proxydescription = new WA.v2.WS_Job.Description1();
                        proxydescription.DescriptionComment = description.DescriptionComment;
                        proxydescription.SequenceNumber = description.SequenceNumber;
                        proxydescriptions[descriptionscnt] = proxydescription;
                        descriptionscnt++;
                    }
                    proxyjobchange.Descriptions = proxydescriptions;
                }
                #endregion

                #region//JobChange Causes
                if (request.JobChange.Causes != null && request.JobChange.Causes.Count > 0)
                {
                    int causescnt = 0;
                    WA.v2.WS_Job.Cause1[] proxycauses = new WA.v2.WS_Job.Cause1[request.JobChange.Causes.Count];
                    foreach (WA.Standard.IF.Data.v2.Common.Common.Cause cause in request.JobChange.Causes)
                    {
                        WA.v2.WS_Job.Cause1 proxycause = new WA.v2.WS_Job.Cause1();
                        proxycause.CauseLaborOpCode = cause.CauseLaborOpCode;
                        proxycause.Comment = cause.Comment;
                        proxycause.SequenceNumber = cause.SequenceNumber;
                        proxycauses[causescnt] = proxycause;
                        causescnt++;
                    }
                    proxyjobchange.Causes = proxycauses;
                }
                #endregion

                #region//JobChange Corrections
                if (request.JobChange.Corrections != null && request.JobChange.Corrections.Count > 0)
                {
                    int correctionscnt = 0;
                    WA.v2.WS_Job.Correction1[] proxycorrections = new WA.v2.WS_Job.Correction1[request.JobChange.Corrections.Count];
                    foreach (WA.Standard.IF.Data.v2.Common.Common.Correction correction in request.JobChange.Corrections)
                    {
                        WA.v2.WS_Job.Correction1 proxycorrection = new WA.v2.WS_Job.Correction1();
                        proxycorrection.CorrectionLaborOpCode = correction.CorrectionLaborOpCode;
                        proxycorrection.Comment = correction.Comment;
                        proxycorrection.SequenceNumber = correction.SequenceNumber;
                        proxycorrections[correctionscnt] = proxycorrection;
                        correctionscnt++;
                    }
                    proxyjobchange.Corrections = proxycorrections;
                }
                #endregion

                #region//JobChange OPCodes
                if (request.JobChange.OPCodes != null && request.JobChange.OPCodes.Count > 0)
                {
                    int opcodescnt = 0;
                    WA.v2.WS_Job.OPCode1[] proxyopcodes = new WA.v2.WS_Job.OPCode1[request.JobChange.OPCodes.Count];
                    foreach (WA.Standard.IF.Data.v2.Common.Job.OPCode opcode in request.JobChange.OPCodes)
                    {
                        #region//JobChange OPCode Header
                        WA.v2.WS_Job.OPCode1 proxyopcode = new WA.v2.WS_Job.OPCode1();
                        proxyopcode.ActualHours = opcode.ActualHours;
                        proxyopcode.Code = opcode.Code;
                        proxyopcode.Description = opcode.Description;
                        proxyopcode.EstimatedHours = opcode.EstimatedHours;
                        proxyopcode.SkillLevel = opcode.SkillLevel;
                        #endregion

                        #region//JobChange OPCode Comments
                        //if (opcode.Comments != null && opcode.Comments.Count > 0)
                        //{
                        //    int commentscnt = 0;
                        //    WA.v2.WS_Job.Comment1[] proxycomments = new WA.v2.WS_Job.Comment1[opcode.Comments.Count];
                        //    foreach (WA.Standard.IF.Data.v2.Common.Common.Comment comment in opcode.Comments)
                        //    {
                        //        WA.v2.WS_Job.Comment1 proxycomment = new WA.v2.WS_Job.Comment1();
                        //        proxycomment.DescriptionComment = comment.DescriptionComment;
                        //        proxycomment.SequenceNumber = comment.SequenceNumber;
                        //        proxycomments[commentscnt] = proxycomment;
                        //        commentscnt++;
                        //    }
                        //    proxyopcode.Comments = proxycomments;
                        //}
                        #endregion

                        #region//JobChange OPCode Descriptions
                        //if (opcode.Descriptions != null && opcode.Descriptions.Count > 0)
                        //{
                        //    int descriptionscnt = 0;
                        //    WA.v2.WS_Job.Description1[] proxydescriptions = new WA.v2.WS_Job.Description1[opcode.Descriptions.Count];
                        //    foreach (WA.Standard.IF.Data.v2.Common.Common.Description description in opcode.Descriptions)
                        //    {
                        //        WA.v2.WS_Job.Description1 proxydescription = new WA.v2.WS_Job.Description1();
                        //        proxydescription.DescriptionComment = description.DescriptionComment;
                        //        proxydescription.SequenceNumber = description.SequenceNumber;
                        //        proxydescriptions[descriptionscnt] = proxydescription;
                        //        descriptionscnt++;
                        //    }
                        //    proxyopcode.Descriptions = proxydescriptions;
                        //}
                        #endregion

                        #region//JobChange OPCode Causes
                        //if (opcode.Causes != null && opcode.Causes.Count > 0)
                        //{
                        //    int causescnt = 0;
                        //    WA.v2.WS_Job.Cause1[] proxycauses = new WA.v2.WS_Job.Cause1[opcode.Causes.Count];
                        //    foreach (WA.Standard.IF.Data.v2.Common.Common.Cause cause in opcode.Causes)
                        //    {
                        //        WA.v2.WS_Job.Cause1 proxycause = new WA.v2.WS_Job.Cause1();
                        //        proxycause.CauseLaborOpCode = cause.CauseLaborOpCode;
                        //        proxycause.Comment = cause.Comment;
                        //        proxycause.SequenceNumber = cause.SequenceNumber;
                        //        proxycauses[causescnt] = proxycause;
                        //        causescnt++;
                        //    }
                        //    proxyopcode.Causes = proxycauses;
                        //}
                        #endregion

                        #region//JobChange OPCode Corrections
                        //if (opcode.Corrections != null && opcode.Corrections.Count > 0)
                        //{
                        //    int correctionscnt = 0;
                        //    WA.v2.WS_Job.Correction1[] proxycorrections = new WA.v2.WS_Job.Correction1[opcode.Corrections.Count];
                        //    foreach (WA.Standard.IF.Data.v2.Common.Common.Correction correction in opcode.Corrections)
                        //    {
                        //        WA.v2.WS_Job.Correction1 proxycorrection = new WA.v2.WS_Job.Correction1();
                        //        proxycorrection.CorrectionLaborOpCode = correction.CorrectionLaborOpCode;
                        //        proxycorrection.Comment = correction.Comment;
                        //        proxycorrection.SequenceNumber = correction.SequenceNumber;
                        //        proxycorrections[correctionscnt] = proxycorrection;
                        //        correctionscnt++;
                        //    }
                        //    proxyopcode.Corrections = proxycorrections;
                        //}
                        #endregion

                        proxyopcodes[opcodescnt] = proxyopcode;
                        opcodescnt++;
                    }
                    proxyjobchange.OPCodes = proxyopcodes;
                }
                #endregion

                #region//JobChange Plan
                if (request.JobChange.Plan != null)
                {
                    WA.v2.WS_Job.Plan1 proxyplan = new WA.v2.WS_Job.Plan1();
                    proxyplan.ScheduledDateTimeFromLocal = request.JobChange.Plan.ScheduledDateTimeFromLocal;
                    proxyplan.ScheduledDateTimeToLocal = request.JobChange.Plan.ScheduledDateTimeToLocal;
                    proxyplan.StallID = request.JobChange.Plan.StallID;
                    proxyplan.StallName = request.JobChange.Plan.StallName;

                    #region//Technicians
                    if (request.JobChange.Plan.Technicians != null && request.JobChange.Plan.Technicians.Count > 0)
                    {
                        int technicianscnt = 0;
                        WA.v2.WS_Job.Technician1[] proxytechnicians = new WA.v2.WS_Job.Technician1[request.JobChange.Plan.Technicians.Count];
                        foreach (WA.Standard.IF.Data.v2.Common.Job.Technician technician in request.JobChange.Plan.Technicians)
                        {
                            WA.v2.WS_Job.Technician1 proxytechnician = new WA.v2.WS_Job.Technician1();
                            proxytechnician.TCEmployeeID = technician.TCEmployeeID;
                            proxytechnician.TCEmployeeName = technician.TCEmployeeName;
                            proxytechnicians[technicianscnt] = proxytechnician;
                            technicianscnt++;
                        }
                        proxyplan.Technicians = proxytechnicians;
                    }
                    #endregion

                    proxyjobchange.Plan = proxyplan;
                }
                #endregion

                #region//JobChange Dispatch
                if (request.JobChange.Dispatch != null)
                {
                    WA.v2.WS_Job.Dispatch1 proxydispatch = new WA.v2.WS_Job.Dispatch1();
                    proxydispatch.ScheduledDateTimeFromLocal = request.JobChange.Dispatch.ScheduledDateTimeFromLocal;
                    proxydispatch.ScheduledDateTimeToLocal = request.JobChange.Dispatch.ScheduledDateTimeToLocal;
                    proxydispatch.StallID = request.JobChange.Dispatch.StallID;
                    proxydispatch.StallName = request.JobChange.Dispatch.StallName;

                    #region//Technicians
                    if (request.JobChange.Dispatch.Technicians != null && request.JobChange.Dispatch.Technicians.Count > 0)
                    {
                        int technicianscnt = 0;
                        WA.v2.WS_Job.Technician1[] proxytechnicians = new WA.v2.WS_Job.Technician1[request.JobChange.Dispatch.Technicians.Count];
                        foreach (WA.Standard.IF.Data.v2.Common.Job.Technician technician in request.JobChange.Dispatch.Technicians)
                        {
                            WA.v2.WS_Job.Technician1 proxytechnician = new WA.v2.WS_Job.Technician1();
                            proxytechnician.TCEmployeeID = technician.TCEmployeeID;
                            proxytechnician.TCEmployeeName = technician.TCEmployeeName;
                            proxytechnicians[technicianscnt] = proxytechnician;
                            technicianscnt++;
                        }
                        proxydispatch.Technicians = proxytechnicians;
                    }
                    #endregion

                    proxyjobchange.Dispatch = proxydispatch;
                }
                #endregion

                #region//JobChange Actual
                if (request.JobChange.Actual != null)
                {
                    WA.v2.WS_Job.Actual1 proxyactual = new WA.v2.WS_Job.Actual1();
                    proxyactual.StallID = request.JobChange.Actual.StallID;
                    proxyactual.StallName = request.JobChange.Actual.StallName;

                    #region//ActualTimeLogs
                    if (request.JobChange.Actual.ActualTimeLogs != null && request.JobChange.Actual.ActualTimeLogs.Count > 0)
                    {
                        int actualtimelogcnt = 0;
                        WA.v2.WS_Job.ActualTimeLog1[] proxytechnicians = new WA.v2.WS_Job.ActualTimeLog1[request.JobChange.Actual.ActualTimeLogs.Count];
                        foreach (WA.Standard.IF.Data.v2.Common.Job.ActualTimeLog actualtimelog in request.JobChange.Actual.ActualTimeLogs)
                        {
                            WA.v2.WS_Job.ActualTimeLog1 proxyactualtimelog = new WA.v2.WS_Job.ActualTimeLog1();
                            proxyactualtimelog.EndDateTimeLocal = actualtimelog.EndDateTimeLocal;
                            proxyactualtimelog.PauseReasonCode = Map.SetDMSCodeFromWACode(CodeType.PauseReasonCode, actualtimelog.PauseReasonCode);
                            proxyactualtimelog.PauseReasonComment = actualtimelog.PauseReasonComment;
                            proxyactualtimelog.StartDateTimeLocal = actualtimelog.StartDateTimeLocal;
                            proxyactualtimelog.Status = Map.SetDMSCodeFromWACode(CodeType.ActualJobStatus, actualtimelog.Status);
                            proxyactualtimelog.TCEmployeeID = actualtimelog.TCEmployeeID;
                            proxyactualtimelog.TCEmployeeName = actualtimelog.TCEmployeeName;
                            proxytechnicians[actualtimelogcnt] = proxyactualtimelog;
                            actualtimelogcnt++;
                        }
                        proxyactual.ActualTimeLogs = proxytechnicians;
                    }
                    #endregion

                    #region//JobChange JobLogs JobComments
                    if (request.JobChange.Actual.JobComments != null && request.JobChange.Actual.JobComments.Count > 0)
                    {
                        int jobcommentscnt = 0;
                        WA.v2.WS_Job.JobComment1[] proxyjobcomments = new WA.v2.WS_Job.JobComment1[request.JobChange.Actual.JobComments.Count];
                        foreach (WA.Standard.IF.Data.v2.Common.Job.JobComment jobcomment in request.JobChange.Actual.JobComments)
                        {
                            WA.v2.WS_Job.JobComment1 proxyjobcomment = new WA.v2.WS_Job.JobComment1();
                            proxyjobcomment.ActualWorkHour = jobcomment.ActualWorkHour;
                            proxyjobcomment.SubStatus = Map.SetDMSCodeFromWACode(CodeType.JobSubStatus, jobcomment.SubStatus);
                            proxyjobcomments[jobcommentscnt] = proxyjobcomment;
                            jobcommentscnt++;
                        }
                        proxyactual.JobComments = proxyjobcomments;
                    }
                    #endregion

                    proxyjobchange.Actual = proxyactual;
                }
                #endregion
            }
            #endregion

            //Run proxy web method with proxy request
            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS JobChangeRequest XML", proxyrequest);

            WA.v2.WS_Job.JobChangeResponse proxyresponse = proxyws.JobChange(proxyrequest);

            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS JobChangeResponse XML", proxyresponse);

            //Mapping with Standard Interface Specification Object
            if (proxyresponse != null)
            {
                if (proxyresponse.TransactionHeader != null)
                {
                    #region//TransactionHeader Set
                    WA.Standard.IF.Data.v2.Common.Common.TransactionHeader transactionheader = new WA.Standard.IF.Data.v2.Common.Common.TransactionHeader();
                    transactionheader.CountryID = proxyresponse.TransactionHeader.CountryID;
                    transactionheader.DealerID = proxyresponse.TransactionHeader.DealerID;
                    transactionheader.DistributorID = proxyresponse.TransactionHeader.DistributorID;
                    transactionheader.DMSCode = proxyresponse.TransactionHeader.DMSCode;
                    transactionheader.DMSServerUrl = proxyresponse.TransactionHeader.DMSServerUrl;
                    transactionheader.DMSVersion = proxyresponse.TransactionHeader.DMSVersion;
                    transactionheader.DocumentVersion = proxyresponse.TransactionHeader.DocumentVersion;
                    transactionheader.GroupID = proxyresponse.TransactionHeader.GroupID;
                    transactionheader.IneterfaceID = proxyresponse.TransactionHeader.IneterfaceID;
                    transactionheader.Password = proxyresponse.TransactionHeader.Password;
                    transactionheader.PollingToken = proxyresponse.TransactionHeader.PollingToken;
                    transactionheader.RequestPollingToken = proxyresponse.TransactionHeader.RequestPollingToken;
                    transactionheader.RequestType = proxyresponse.TransactionHeader.RequestType;
                    transactionheader.TransactionId = proxyresponse.TransactionHeader.TransactionId;
                    transactionheader.TransactionDateTimeLocal = proxyresponse.TransactionHeader.TransactionDateTimeLocal;
                    transactionheader.TransactionDateTimeUTC = proxyresponse.TransactionHeader.TransactionDateTimeUTC;
                    transactionheader.TransactionType = proxyresponse.TransactionHeader.TransactionType;
                    transactionheader.Username = proxyresponse.TransactionHeader.Username;
                    transactionheader.VenderTrackingCode = proxyresponse.TransactionHeader.VenderTrackingCode;
                    response.TransactionHeader = transactionheader;
                    #endregion
                }

                //ResultMessage Set
                if (proxyresponse.ResultMessage != null)
                {
                    response.ResultMessage = GetResultMessageData(proxyresponse.ResultMessage.Code, proxyresponse.ResultMessage.Message);
                }

                if (proxyresponse.Errors != null)
                {
                    //Error List Set
                    foreach (WA.v2.WS_Job.Error1 proxyerror in proxyresponse.Errors)
                    {
                        if (response.Errors != null)
                            response.Errors.Add(GetErrorData(proxyerror.Code, proxyerror.Message));
                        else
                            response.Errors = GetErrorDataList(proxyerror.Code, proxyerror.Message);
                    }
                }
            }
            #endregion

            return response;
        }

        public WA.Standard.IF.Data.v2.Common.OPCode.OPCodeGetResponse OPCodeGet(WA.Standard.IF.Data.v2.Common.OPCode.OPCodeGetRequest request)
        {
            WA.Standard.IF.Data.v2.Common.OPCode.OPCodeGetResponse response = new WA.Standard.IF.Data.v2.Common.OPCode.OPCodeGetResponse();

            #region v2.WA.v2 - WA.Standard.IF.WebService

            #region OPCodeGet Request Set

            //Create proxy credential
            NetworkCredential proxycredential = new NetworkCredential(request.TransactionHeader.Username, request.TransactionHeader.Password);

            //Create proxy web service from dms web service with credential
            WA.v2.WS_OPCode.OPCode proxyws = new WA.v2.WS_OPCode.OPCode();
            proxyws.Credentials = proxycredential;

            //Create proxy request with opcodeget and transaction
            WA.v2.WS_OPCode.OPCodeGetRequest proxyrequest = new WA.v2.WS_OPCode.OPCodeGetRequest();

            //Create proxy transaction
            WA.v2.WS_OPCode.TransactionHeader proxytransactionheader = new WA.v2.WS_OPCode.TransactionHeader();
            if (request.TransactionHeader != null)
            {
                #region//TransactionHeader Set
                proxytransactionheader.CountryID = request.TransactionHeader.CountryID;
                proxytransactionheader.DealerID = request.TransactionHeader.DealerID;
                proxytransactionheader.DistributorID = request.TransactionHeader.DistributorID;
                proxytransactionheader.DMSCode = request.TransactionHeader.DMSCode;
                proxytransactionheader.DMSServerUrl = request.TransactionHeader.DMSServerUrl;
                proxytransactionheader.DMSVersion = request.TransactionHeader.DMSVersion;
                proxytransactionheader.DocumentVersion = request.TransactionHeader.DocumentVersion;
                proxytransactionheader.GroupID = request.TransactionHeader.GroupID;
                proxytransactionheader.IneterfaceID = request.TransactionHeader.IneterfaceID;
                proxytransactionheader.Password = request.TransactionHeader.Password;
                proxytransactionheader.PollingToken = request.TransactionHeader.PollingToken;
                proxytransactionheader.RequestPollingToken = request.TransactionHeader.RequestPollingToken;
                proxytransactionheader.RequestType = request.TransactionHeader.RequestType;
                proxytransactionheader.TransactionId = request.TransactionHeader.TransactionId;
                proxytransactionheader.TransactionDateTimeLocal = request.TransactionHeader.TransactionDateTimeLocal;
                proxytransactionheader.TransactionDateTimeUTC = request.TransactionHeader.TransactionDateTimeUTC;
                proxytransactionheader.TransactionType = request.TransactionHeader.TransactionType;
                proxytransactionheader.Username = request.TransactionHeader.Username;
                proxytransactionheader.VenderTrackingCode = request.TransactionHeader.VenderTrackingCode;
                proxyrequest.TransactionHeader = proxytransactionheader;
                proxyws.Url = string.Format("{0}/rtr-atest/ws/OPCode.1cws", proxytransactionheader.DMSServerUrl);
                #endregion
            }

            //Create proxy opcodeget
            WA.v2.WS_OPCode.OPCodeGet proxyopcodeget = new WA.v2.WS_OPCode.OPCodeGet();
            if (request.OPCodeGet != null)
            {
                #region//OPCodeGet Set
                proxyopcodeget.Category = request.OPCodeGet.Category;
                proxyopcodeget.Code = request.OPCodeGet.Code;
                proxyopcodeget.Description = request.OPCodeGet.Description;
                proxyopcodeget.Engine = request.OPCodeGet.Engine;
                proxyopcodeget.Make = request.OPCodeGet.Make;
                proxyopcodeget.Mileage = request.OPCodeGet.Mileage;
                proxyopcodeget.Model = request.OPCodeGet.Model;
                proxyopcodeget.Year = request.OPCodeGet.Year;
                proxyrequest.OPCodeGet = proxyopcodeget;
                #endregion
            }
            #endregion

            //Run proxy web method with proxy request
            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS OPCodeGetRequest XML", proxyrequest);

            WA.v2.WS_OPCode.OPCodeGetResponse proxyresponse = proxyws.OPCodeGet(proxyrequest);

            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS OPCodeGetResponse XML", proxyresponse);

            //Mapping with Standard Interface Specification Object
            if (proxyresponse != null)
            {
                if (proxyresponse.TransactionHeader != null)
                {
                    #region//TransactionHeader Set
                    WA.Standard.IF.Data.v2.Common.Common.TransactionHeader transactionheader = new WA.Standard.IF.Data.v2.Common.Common.TransactionHeader();
                    transactionheader.CountryID = proxyresponse.TransactionHeader.CountryID;
                    transactionheader.DealerID = proxyresponse.TransactionHeader.DealerID;
                    transactionheader.DistributorID = proxyresponse.TransactionHeader.DistributorID;
                    transactionheader.DMSCode = proxyresponse.TransactionHeader.DMSCode;
                    transactionheader.DMSServerUrl = proxyresponse.TransactionHeader.DMSServerUrl;
                    transactionheader.DMSVersion = proxyresponse.TransactionHeader.DMSVersion;
                    transactionheader.DocumentVersion = proxyresponse.TransactionHeader.DocumentVersion;
                    transactionheader.GroupID = proxyresponse.TransactionHeader.GroupID;
                    transactionheader.IneterfaceID = proxyresponse.TransactionHeader.IneterfaceID;
                    transactionheader.Password = proxyresponse.TransactionHeader.Password;
                    transactionheader.PollingToken = proxyresponse.TransactionHeader.PollingToken;
                    transactionheader.RequestPollingToken = proxyresponse.TransactionHeader.RequestPollingToken;
                    transactionheader.RequestType = proxyresponse.TransactionHeader.RequestType;
                    transactionheader.TransactionId = proxyresponse.TransactionHeader.TransactionId;
                    transactionheader.TransactionDateTimeLocal = proxyresponse.TransactionHeader.TransactionDateTimeLocal;
                    transactionheader.TransactionDateTimeUTC = proxyresponse.TransactionHeader.TransactionDateTimeUTC;
                    transactionheader.TransactionType = proxyresponse.TransactionHeader.TransactionType;
                    transactionheader.Username = proxyresponse.TransactionHeader.Username;
                    transactionheader.VenderTrackingCode = proxyresponse.TransactionHeader.VenderTrackingCode;
                    response.TransactionHeader = transactionheader;
                    #endregion
                }

                //ResultMessage Set
                if (proxyresponse.ResultMessage != null)
                {
                    response.ResultMessage = GetResultMessageData(proxyresponse.ResultMessage.Code, proxyresponse.ResultMessage.Message);
                }

                if (proxyresponse.Errors != null)
                {
                    //Error List Set
                    foreach (WA.v2.WS_OPCode.Error proxyerror in proxyresponse.Errors)
                    {
                        if (response.Errors != null)
                            response.Errors.Add(GetErrorData(proxyerror.Code, proxyerror.Message));
                        else
                            response.Errors = GetErrorDataList(proxyerror.Code, proxyerror.Message);
                    }
                }
                else
                {
                    #region //OPCodeGetResponse Set

                    if (proxyresponse.OPCodes != null && proxyresponse.OPCodes.Length > 0)
                    {
                        response.OPCodes = new List<WA.Standard.IF.Data.v2.Common.OPCode.OPCode>();
                        foreach (WA.v2.WS_OPCode.OPCode1 proxyopcode in proxyresponse.OPCodes)
                        {
                            #region //OPCode Header
                            WA.Standard.IF.Data.v2.Common.OPCode.OPCode opcode = new WA.Standard.IF.Data.v2.Common.OPCode.OPCode();
                            opcode.Code = proxyopcode.Code;
                            opcode.CorrectionLOP = proxyopcode.CorrectionLOP;
                            opcode.CPSIND = proxyopcode.CPSIND;
                            opcode.DefLinePaymentMethod = proxyopcode.DefLinePaymentMethod;
                            opcode.Description = proxyopcode.Description;
                            opcode.DisplayOPCode = proxyopcode.DisplayOPCode;
                            opcode.DisplayOPDescription = proxyopcode.DisplayOPDescription;
                            opcode.Engine = proxyopcode.Engine;
                            opcode.EstimatedHours = proxyopcode.EstimatedHours;
                            opcode.HazardMaterialCharge = proxyopcode.HazardMaterialCharge;
                            opcode.Make = proxyopcode.Make;
                            opcode.Mileage = proxyopcode.Mileage;
                            opcode.Model = proxyopcode.Model;
                            opcode.OPCodeType = Map.GetWACodeFromDMSCode(CodeType.OPCodeType, proxyopcode.OPCodeType);
                            opcode.Period = proxyopcode.Period;
                            opcode.PredefinedCauseDescription = proxyopcode.PredefinedCauseDescription;
                            opcode.Quantity = proxyopcode.Quantity;
                            opcode.SkillLevel = proxyopcode.SkillLevel;
                            opcode.Year = proxyopcode.Year;
                            #endregion

                            #region //OPCode PriceType
                            if (proxyopcode.PriceType != null)
                            {
                                WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                pricetype.DiscountPrice = proxyopcode.PriceType.DiscountPrice;
                                pricetype.DiscountRate = proxyopcode.PriceType.DiscountRate;
                                pricetype.TotalPrice = proxyopcode.PriceType.TotalPrice;
                                pricetype.TotalPriceIncludeTax = proxyopcode.PriceType.TotalPriceIncludeTax;
                                pricetype.UnitPrice = proxyopcode.PriceType.UnitPrice;
                                opcode.PriceType = pricetype;
                            }
                            #endregion

                            #region //OPCode Parts
                            if (proxyopcode.Parts != null && proxyopcode.Parts.Length > 0)
                            {
                                opcode.Parts = new List<WA.Standard.IF.Data.v2.Common.Part.Part>();
                                foreach (WA.v2.WS_OPCode.Part proxypart in proxyopcode.Parts)
                                {
                                    #region //OPCode Part Header
                                    WA.Standard.IF.Data.v2.Common.Part.Part part = new WA.Standard.IF.Data.v2.Common.Part.Part();
                                    part.DisplayPartNumber = proxypart.DisplayPartNumber;
                                    part.PartDescription = proxypart.PartDescription;
                                    part.PartNumber = proxypart.PartNumber;
                                    part.PartType = Map.GetWACodeFromDMSCode(CodeType.PartType, proxypart.PartType);
                                    part.Quantity = proxypart.Quantity;
                                    //part.ServiceType = proxypart.ServiceType;
                                    part.StockQuantity = proxypart.StockQuantity;
                                    part.StockStatus = proxypart.StockStatus;
                                    part.UnitOfMeasure = proxypart.UnitOfMeasure;
                                    part.QuantityOnHand = proxypart.QuantityOnHand;
                                    #endregion

                                    #region //OPCode Part PriceType
                                    if (proxypart.PriceType != null)
                                    {
                                        WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                        pricetype.DiscountPrice = proxypart.PriceType.DiscountPrice;
                                        pricetype.DiscountRate = proxypart.PriceType.DiscountRate;
                                        pricetype.TotalPrice = proxypart.PriceType.TotalPrice;
                                        pricetype.TotalPriceIncludeTax = proxypart.PriceType.TotalPriceIncludeTax;
                                        pricetype.UnitPrice = proxypart.PriceType.UnitPrice;
                                        part.PriceType = pricetype;
                                    }
                                    #endregion

                                    opcode.Parts.Add(part);
                                }
                            }
                            #endregion

                            response.OPCodes.Add(opcode);
                        }
                    }
                    else
                    {
                        response.ResultMessage = GetResultMessageData(WA.Standard.IF.Data.v2.Common.Common.ResponseCode.NoResult, WA.Standard.IF.Data.v2.Common.Common.ResponseMessage.NoResult);
                    }
                    #endregion
                }
            }
            #endregion

            return response;
        }

        public WA.Standard.IF.Data.v2.Common.PackageCode.PackageCodeGetResponse PackageCodeGet(WA.Standard.IF.Data.v2.Common.PackageCode.PackageCodeGetRequest request)
        {
            WA.Standard.IF.Data.v2.Common.PackageCode.PackageCodeGetResponse response = new WA.Standard.IF.Data.v2.Common.PackageCode.PackageCodeGetResponse();

            #region v2.WA.v2 - WA.Standard.IF.WebService

            #region PackageCodeGet Request Set

            //Create proxy credential
            NetworkCredential proxycredential = new NetworkCredential(request.TransactionHeader.Username, request.TransactionHeader.Password);

            //Create proxy web service from dms web service with credential
            WA.v2.WS_PackageCode.PackageCode proxyws = new WA.v2.WS_PackageCode.PackageCode();
            proxyws.Credentials = proxycredential;

            //Create proxy request with packagecodeget and transaction
            WA.v2.WS_PackageCode.PackageCodeGetRequest proxyrequest = new WA.v2.WS_PackageCode.PackageCodeGetRequest();

            //Create proxy transaction
            WA.v2.WS_PackageCode.TransactionHeader proxytransactionheader = new WA.v2.WS_PackageCode.TransactionHeader();
            if (request.TransactionHeader != null)
            {
                #region//TransactionHeader Set
                proxytransactionheader.CountryID = request.TransactionHeader.CountryID;
                proxytransactionheader.DealerID = request.TransactionHeader.DealerID;
                proxytransactionheader.DistributorID = request.TransactionHeader.DistributorID;
                proxytransactionheader.DMSCode = request.TransactionHeader.DMSCode;
                proxytransactionheader.DMSServerUrl = request.TransactionHeader.DMSServerUrl;
                proxytransactionheader.DMSVersion = request.TransactionHeader.DMSVersion;
                proxytransactionheader.DocumentVersion = request.TransactionHeader.DocumentVersion;
                proxytransactionheader.GroupID = request.TransactionHeader.GroupID;
                proxytransactionheader.IneterfaceID = request.TransactionHeader.IneterfaceID;
                proxytransactionheader.Password = request.TransactionHeader.Password;
                proxytransactionheader.PollingToken = request.TransactionHeader.PollingToken;
                proxytransactionheader.RequestPollingToken = request.TransactionHeader.RequestPollingToken;
                proxytransactionheader.RequestType = request.TransactionHeader.RequestType;
                proxytransactionheader.TransactionId = request.TransactionHeader.TransactionId;
                proxytransactionheader.TransactionDateTimeLocal = request.TransactionHeader.TransactionDateTimeLocal;
                proxytransactionheader.TransactionDateTimeUTC = request.TransactionHeader.TransactionDateTimeUTC;
                proxytransactionheader.TransactionType = request.TransactionHeader.TransactionType;
                proxytransactionheader.Username = request.TransactionHeader.Username;
                proxytransactionheader.VenderTrackingCode = request.TransactionHeader.VenderTrackingCode;
                proxyrequest.TransactionHeader = proxytransactionheader;
                proxyws.Url = string.Format("{0}/rtr-atest/ws/PackageCode.1cws", proxytransactionheader.DMSServerUrl);
                #endregion
            }

            //Create proxy packagecodeget
            WA.v2.WS_PackageCode.PackageCodeGet proxypackagecodeget = new WA.v2.WS_PackageCode.PackageCodeGet();
            if (request.PackageCodeGet != null)
            {
                #region//PackageCodeGet Set
                proxypackagecodeget.Category = request.PackageCodeGet.Category;
                proxypackagecodeget.Code = request.PackageCodeGet.Code;
                proxypackagecodeget.Description = request.PackageCodeGet.Description;
                proxypackagecodeget.EngineCode = request.PackageCodeGet.EngineCode;
                proxypackagecodeget.Engine = request.PackageCodeGet.Engine;
                proxypackagecodeget.LastModifiedDateTimeFromUTC = request.PackageCodeGet.LastModifiedDateTimeFromUTC;
                proxypackagecodeget.LastModifiedDateTimeToUTC = request.PackageCodeGet.LastModifiedDateTimeToUTC;
                proxypackagecodeget.Make = request.PackageCodeGet.Make;
                proxypackagecodeget.Mileage = request.PackageCodeGet.Mileage;
                proxypackagecodeget.ModelCode = request.PackageCodeGet.ModelCode;
                proxypackagecodeget.Model = request.PackageCodeGet.Model;
                proxypackagecodeget.Year = request.PackageCodeGet.Year;
                proxyrequest.PackageCodeGet = proxypackagecodeget;
                #endregion
            }
            #endregion

            //Run proxy web method with proxy request
            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS PackageCodeGetRequest XML", proxyrequest);

            WA.v2.WS_PackageCode.PackageCodeGetResponse proxyresponse = proxyws.PackageCodeGet(proxyrequest);

            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS PackageCodeGetResponse XML", proxyresponse);

            //Mapping with Standard Interface Specification Object
            if (proxyresponse != null)
            {
                if (proxyresponse.TransactionHeader != null)
                {
                    #region//TransactionHeader Set
                    WA.Standard.IF.Data.v2.Common.Common.TransactionHeader transactionheader = new WA.Standard.IF.Data.v2.Common.Common.TransactionHeader();
                    transactionheader.CountryID = proxyresponse.TransactionHeader.CountryID;
                    transactionheader.DealerID = proxyresponse.TransactionHeader.DealerID;
                    transactionheader.DistributorID = proxyresponse.TransactionHeader.DistributorID;
                    transactionheader.DMSCode = proxyresponse.TransactionHeader.DMSCode;
                    transactionheader.DMSServerUrl = proxyresponse.TransactionHeader.DMSServerUrl;
                    transactionheader.DMSVersion = proxyresponse.TransactionHeader.DMSVersion;
                    transactionheader.DocumentVersion = proxyresponse.TransactionHeader.DocumentVersion;
                    transactionheader.GroupID = proxyresponse.TransactionHeader.GroupID;
                    transactionheader.IneterfaceID = proxyresponse.TransactionHeader.IneterfaceID;
                    transactionheader.Password = proxyresponse.TransactionHeader.Password;
                    transactionheader.PollingToken = proxyresponse.TransactionHeader.PollingToken;
                    transactionheader.RequestPollingToken = proxyresponse.TransactionHeader.RequestPollingToken;
                    transactionheader.RequestType = proxyresponse.TransactionHeader.RequestType;
                    transactionheader.TransactionId = proxyresponse.TransactionHeader.TransactionId;
                    transactionheader.TransactionDateTimeLocal = proxyresponse.TransactionHeader.TransactionDateTimeLocal;
                    transactionheader.TransactionDateTimeUTC = proxyresponse.TransactionHeader.TransactionDateTimeUTC;
                    transactionheader.TransactionType = proxyresponse.TransactionHeader.TransactionType;
                    transactionheader.Username = proxyresponse.TransactionHeader.Username;
                    transactionheader.VenderTrackingCode = proxyresponse.TransactionHeader.VenderTrackingCode;
                    response.TransactionHeader = transactionheader;
                    #endregion
                }

                //ResultMessage Set
                if (proxyresponse.ResultMessage != null)
                {
                    response.ResultMessage = GetResultMessageData(proxyresponse.ResultMessage.Code, proxyresponse.ResultMessage.Message);
                }

                if (proxyresponse.Errors != null)
                {
                    //Error List Set
                    foreach (WA.v2.WS_PackageCode.Error proxyerror in proxyresponse.Errors)
                    {
                        if (response.Errors != null)
                            response.Errors.Add(GetErrorData(proxyerror.Code, proxyerror.Message));
                        else
                            response.Errors = GetErrorDataList(proxyerror.Code, proxyerror.Message);
                    }
                }
                else
                {
                    #region //PackageCodeGetResponse Set

                    if (proxyresponse.PackageCodes != null && proxyresponse.PackageCodes.Length > 0)
                    {
                        #region//PackageCodesGetResponse Set
                        response.PackageCodes = new List<WA.Standard.IF.Data.v2.Common.PackageCode.PackageCode>();
                        foreach (WA.v2.WS_PackageCode.PackageCode1 proxypackagecode in proxyresponse.PackageCodes)
                        {
                            #region //PackageCodes Header
                            WA.Standard.IF.Data.v2.Common.PackageCode.PackageCode packagecode = new WA.Standard.IF.Data.v2.Common.PackageCode.PackageCode();
                            packagecode.Code = proxypackagecode.Code;
                            packagecode.DefLinePaymentMethod = proxypackagecode.DefLinePaymentMethod;
                            packagecode.Description = proxypackagecode.Description;
                            packagecode.PackageCodeType = Map.GetWACodeFromDMSCode(CodeType.PackageCodeType, proxypackagecode.PackageCodeType);
                            packagecode.DisplayPackageCode = proxypackagecode.DisplayPackageCode;
                            packagecode.DisplayPackageDescription = proxypackagecode.DisplayPackageDescription;
                            packagecode.EngineCode = proxypackagecode.EngineCode;
                            packagecode.Engine = proxypackagecode.Engine;
                            packagecode.EstimatedHours = proxypackagecode.EstimatedHours;
                            packagecode.Make = proxypackagecode.Make;
                            packagecode.Mileage = proxypackagecode.Mileage;
                            packagecode.ModelCode = proxypackagecode.ModelCode;
                            packagecode.Model = proxypackagecode.Model;
                            packagecode.Period = proxypackagecode.Period;
                            packagecode.Year = proxypackagecode.Year;
                            #endregion

                            #region //PackageCodes ManagementFields
                            if (proxypackagecode.ManagementFields != null)
                            {
                                WA.Standard.IF.Data.v2.Common.Common.ManagementFields managementfields = new WA.Standard.IF.Data.v2.Common.Common.ManagementFields();
                                managementfields.CreateDateTimeUTC = proxypackagecode.ManagementFields.CreateDateTimeUTC;
                                managementfields.LastModifiedDateTimeUTC = proxypackagecode.ManagementFields.LastModifiedDateTimeUTC;
                                packagecode.ManagementFields = managementfields;
                            }
                            #endregion

                            #region //PackageCodes PriceType
                            if (proxypackagecode.PriceType != null)
                            {
                                WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                pricetype.DiscountPrice = proxypackagecode.PriceType.DiscountPrice;
                                pricetype.DiscountRate = proxypackagecode.PriceType.DiscountRate;
                                pricetype.TotalPrice = proxypackagecode.PriceType.TotalPrice;
                                pricetype.TotalPriceIncludeTax = proxypackagecode.PriceType.TotalPriceIncludeTax;
                                pricetype.UnitPrice = proxypackagecode.PriceType.UnitPrice;
                                packagecode.PriceType = pricetype;
                            }
                            #endregion

                            if (proxypackagecode.OPCodes != null && proxypackagecode.OPCodes.Length > 0)
                            {
                                #region//PackageCodes OPCode
                                packagecode.OPCodes = new List<WA.Standard.IF.Data.v2.Common.PackageCode.OPCode>();
                                foreach (WA.v2.WS_PackageCode.OPCode proxyopcode in proxypackagecode.OPCodes)
                                {
                                    #region //PackageCodes OPCode Header
                                    WA.Standard.IF.Data.v2.Common.PackageCode.OPCode opcode = new WA.Standard.IF.Data.v2.Common.PackageCode.OPCode();
                                    opcode.Code = proxyopcode.Code;
                                    opcode.CorrectionLOP = proxyopcode.CorrectionLOP;
                                    opcode.CPSIND = proxyopcode.CPSIND;
                                    opcode.DefLinePaymentMethod = proxyopcode.DefLinePaymentMethod;
                                    opcode.Description = proxyopcode.Description;
                                    opcode.DisplayOPCode = proxyopcode.DisplayOPCode;
                                    opcode.DisplayOPDescription = proxyopcode.DisplayOPDescription;
                                    opcode.Engine = proxyopcode.Engine;
                                    opcode.EstimatedHours = proxyopcode.EstimatedHours;
                                    opcode.HazardMaterialCharge = proxyopcode.HazardMaterialCharge;
                                    opcode.MandatoryYN = proxyopcode.MandatoryYN;
                                    opcode.Make = proxyopcode.Make;
                                    opcode.Mileage = proxyopcode.Mileage;
                                    opcode.Model = proxyopcode.Model;
                                    opcode.OPCodeType = Map.GetWACodeFromDMSCode(CodeType.OPCodeType, proxyopcode.OPCodeType);
                                    opcode.Quantity = proxyopcode.Quantity;
                                    opcode.Period = proxyopcode.Period;
                                    opcode.PredefinedCauseDescription = proxyopcode.PredefinedCauseDescription;
                                    opcode.SkillLevel = proxyopcode.SkillLevel;
                                    opcode.Year = proxyopcode.Year;
                                    #endregion

                                    #region //PackageCodes OPCode PriceType
                                    if (proxyopcode.PriceType != null)
                                    {
                                        WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                        pricetype.DiscountPrice = proxyopcode.PriceType.DiscountPrice;
                                        pricetype.DiscountRate = proxyopcode.PriceType.DiscountRate;
                                        pricetype.TotalPrice = proxyopcode.PriceType.TotalPrice;
                                        pricetype.TotalPriceIncludeTax = proxyopcode.PriceType.TotalPriceIncludeTax;
                                        pricetype.UnitPrice = proxyopcode.PriceType.UnitPrice;
                                        opcode.PriceType = pricetype;
                                    }
                                    #endregion

                                    #region //PackageCodes OPCode Parts
                                    if (proxyopcode.Parts != null && proxyopcode.Parts.Length > 0)
                                    {
                                        opcode.Parts = new List<WA.Standard.IF.Data.v2.Common.PackageCode.Part>();
                                        foreach (WA.v2.WS_PackageCode.Part proxypart in proxyopcode.Parts)
                                        {
                                            #region //PackageCodes OPCode Part Header
                                            WA.Standard.IF.Data.v2.Common.PackageCode.Part part = new WA.Standard.IF.Data.v2.Common.PackageCode.Part();
                                            part.DisplayPartNumber = proxypart.DisplayPartNumber;
                                            part.MandatoryYN = proxypart.MandatoryYN;
                                            part.PartDescription = proxypart.PartDescription;
                                            part.PartNumber = proxypart.PartNumber;
                                            part.PartType = Map.GetWACodeFromDMSCode(CodeType.PartType, proxypart.PartType);
                                            part.Quantity = proxypart.Quantity;
                                            //part.ServiceType = Map.GetWACodeFromDMSCode(CodeType.ServiceType, proxypart.ServiceType);
                                            part.StockQuantity = proxypart.StockQuantity;
                                            part.StockStatus = proxypart.StockStatus;
                                            part.UnitOfMeasure = proxypart.UnitOfMeasure;
                                            part.QuantityOnHand = proxypart.QuantityOnHand;
                                            #endregion

                                            #region //PackageCodes OPCode Part PriceType
                                            if (proxypart.PriceType != null)
                                            {
                                                WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                                pricetype.DiscountPrice = proxypart.PriceType.DiscountPrice;
                                                pricetype.DiscountRate = proxypart.PriceType.DiscountRate;
                                                pricetype.TotalPrice = proxypart.PriceType.TotalPrice;
                                                pricetype.TotalPriceIncludeTax = proxypart.PriceType.TotalPriceIncludeTax;
                                                pricetype.UnitPrice = proxypart.PriceType.UnitPrice;
                                                part.PriceType = pricetype;
                                            }
                                            #endregion

                                            opcode.Parts.Add(part);
                                        }
                                    }
                                    #endregion

                                    packagecode.OPCodes.Add(opcode);
                                }
                                #endregion
                            }
                            response.PackageCodes.Add(packagecode);
                        }
                        #endregion
                    }
                    else
                    {
                        response.ResultMessage = GetResultMessageData(WA.Standard.IF.Data.v2.Common.Common.ResponseCode.NoResult, WA.Standard.IF.Data.v2.Common.Common.ResponseMessage.NoResult);
                    }
                    #endregion
                }
            }
            #endregion

            return response;
        }

        public WA.Standard.IF.Data.v2.Common.Part.PartsGetResponse PartsGet(WA.Standard.IF.Data.v2.Common.Part.PartsGetRequest request)
        {
            WA.Standard.IF.Data.v2.Common.Part.PartsGetResponse response = new WA.Standard.IF.Data.v2.Common.Part.PartsGetResponse();

            #region v2.WA.v2 - WA.Standard.IF.WebService

            #region PartGet Request Set

            //Create proxy credential
            NetworkCredential proxycredential = new NetworkCredential(request.TransactionHeader.Username, request.TransactionHeader.Password);

            //Create proxy web service from dms web service with credential
            WA.v2.WS_Parts.Parts proxyws = new WA.v2.WS_Parts.Parts();
            proxyws.Credentials = proxycredential;

            //Create proxy request with partget and transaction
            WA.v2.WS_Parts.PartsGetRequest proxyrequest = new WA.v2.WS_Parts.PartsGetRequest();

            //Create proxy transaction
            WA.v2.WS_Parts.TransactionHeader proxytransactionheader = new WA.v2.WS_Parts.TransactionHeader();
            if (request.TransactionHeader != null)
            {
                #region//TransactionHeader Set
                proxytransactionheader.CountryID = request.TransactionHeader.CountryID;
                proxytransactionheader.DealerID = request.TransactionHeader.DealerID;
                proxytransactionheader.DistributorID = request.TransactionHeader.DistributorID;
                proxytransactionheader.DMSCode = request.TransactionHeader.DMSCode;
                proxytransactionheader.DMSServerUrl = request.TransactionHeader.DMSServerUrl;
                proxytransactionheader.DMSVersion = request.TransactionHeader.DMSVersion;
                proxytransactionheader.DocumentVersion = request.TransactionHeader.DocumentVersion;
                proxytransactionheader.GroupID = request.TransactionHeader.GroupID;
                proxytransactionheader.IneterfaceID = request.TransactionHeader.IneterfaceID;
                proxytransactionheader.Password = request.TransactionHeader.Password;
                proxytransactionheader.PollingToken = request.TransactionHeader.PollingToken;
                proxytransactionheader.RequestPollingToken = request.TransactionHeader.RequestPollingToken;
                proxytransactionheader.RequestType = request.TransactionHeader.RequestType;
                proxytransactionheader.TransactionId = request.TransactionHeader.TransactionId;
                proxytransactionheader.TransactionDateTimeLocal = request.TransactionHeader.TransactionDateTimeLocal;
                proxytransactionheader.TransactionDateTimeUTC = request.TransactionHeader.TransactionDateTimeUTC;
                proxytransactionheader.TransactionType = request.TransactionHeader.TransactionType;
                proxytransactionheader.Username = request.TransactionHeader.Username;
                proxytransactionheader.VenderTrackingCode = request.TransactionHeader.VenderTrackingCode;
                proxyrequest.TransactionHeader = proxytransactionheader;
                proxyws.Url = string.Format("{0}/rtr-atest/ws/Parts.1cws", proxytransactionheader.DMSServerUrl);
                #endregion
            }

            //Create proxy partget
            WA.v2.WS_Parts.PartsGet proxypartsget = new WA.v2.WS_Parts.PartsGet();
            if (request.PartsGet != null)
            {
                #region//PartsGet Set
                proxypartsget.Category = request.PartsGet.Category;
                proxypartsget.Engine = request.PartsGet.Engine;
                proxypartsget.Make = request.PartsGet.Make;
                proxypartsget.Manufacturer = request.PartsGet.Manufacturer;
                proxypartsget.Mileage = request.PartsGet.Mileage;
                proxypartsget.Model = request.PartsGet.Model;
                proxypartsget.PartDescription = request.PartsGet.PartDescription;
                proxypartsget.PartNumber = request.PartsGet.PartNumber;
                proxypartsget.Year = request.PartsGet.Year;
                proxyrequest.PartsGet = proxypartsget;
                #endregion
            }
            #endregion

            //Run proxy web method with proxy request
            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS PartsGetRequest XML", proxyrequest);

            WA.v2.WS_Parts.PartsGetResponse proxyresponse = proxyws.PartsGet(proxyrequest);

            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS PartsGetResponse XML", proxyresponse);

            //Mapping with Standard Interface Specification Object
            if (proxyresponse != null)
            {
                if (proxyresponse.TransactionHeader != null)
                {
                    #region//TransactionHeader Set
                    WA.Standard.IF.Data.v2.Common.Common.TransactionHeader transactionheader = new WA.Standard.IF.Data.v2.Common.Common.TransactionHeader();
                    transactionheader.CountryID = proxyresponse.TransactionHeader.CountryID;
                    transactionheader.DealerID = proxyresponse.TransactionHeader.DealerID;
                    transactionheader.DistributorID = proxyresponse.TransactionHeader.DistributorID;
                    transactionheader.DMSCode = proxyresponse.TransactionHeader.DMSCode;
                    transactionheader.DMSServerUrl = proxyresponse.TransactionHeader.DMSServerUrl;
                    transactionheader.DMSVersion = proxyresponse.TransactionHeader.DMSVersion;
                    transactionheader.DocumentVersion = proxyresponse.TransactionHeader.DocumentVersion;
                    transactionheader.GroupID = proxyresponse.TransactionHeader.GroupID;
                    transactionheader.IneterfaceID = proxyresponse.TransactionHeader.IneterfaceID;
                    transactionheader.Password = proxyresponse.TransactionHeader.Password;
                    transactionheader.PollingToken = proxyresponse.TransactionHeader.PollingToken;
                    transactionheader.RequestPollingToken = proxyresponse.TransactionHeader.RequestPollingToken;
                    transactionheader.RequestType = proxyresponse.TransactionHeader.RequestType;
                    transactionheader.TransactionId = proxyresponse.TransactionHeader.TransactionId;
                    transactionheader.TransactionDateTimeLocal = proxyresponse.TransactionHeader.TransactionDateTimeLocal;
                    transactionheader.TransactionDateTimeUTC = proxyresponse.TransactionHeader.TransactionDateTimeUTC;
                    transactionheader.TransactionType = proxyresponse.TransactionHeader.TransactionType;
                    transactionheader.Username = proxyresponse.TransactionHeader.Username;
                    transactionheader.VenderTrackingCode = proxyresponse.TransactionHeader.VenderTrackingCode;
                    response.TransactionHeader = transactionheader;
                    #endregion
                }

                //ResultMessage Set
                if (proxyresponse.ResultMessage != null)
                {
                    response.ResultMessage = GetResultMessageData(proxyresponse.ResultMessage.Code, proxyresponse.ResultMessage.Message);
                }

                if (proxyresponse.Errors != null)
                {
                    //Error List Set
                    foreach (WA.v2.WS_Parts.Error proxyerror in proxyresponse.Errors)
                    {
                        if (response.Errors != null)
                            response.Errors.Add(GetErrorData(proxyerror.Code, proxyerror.Message));
                        else
                            response.Errors = GetErrorDataList(proxyerror.Code, proxyerror.Message);
                    }
                }
                else
                {
                    #region //PartsGetResponse Set

                    if (proxyresponse.Parts != null && proxyresponse.Parts.Length > 0)
                    {
                        #region //PartsGetResponse Parts
                        response.Parts = new List<WA.Standard.IF.Data.v2.Common.Part.Part>();
                        foreach (WA.v2.WS_Parts.Part proxypart in proxyresponse.Parts)
                        {
                            #region //Part Header
                            WA.Standard.IF.Data.v2.Common.Part.Part part = new WA.Standard.IF.Data.v2.Common.Part.Part();
                            part.DisplayPartNumber = proxypart.DisplayPartNumber;
                            part.PartDescription = proxypart.PartDescription;
                            part.PartNumber = proxypart.PartNumber;
                            part.PartType = proxypart.PartType;
                            part.Quantity = proxypart.Quantity;
                            //part.ServiceType = proxypart.ServiceType;
                            part.StockQuantity = proxypart.StockQuantity;
                            part.StockStatus = proxypart.StockStatus;
                            part.UnitOfMeasure = proxypart.UnitOfMeasure;
                            part.QuantityOnHand = proxypart.QuantityOnHand;
                            #endregion

                            #region //Part PriceType
                            if (proxypart.PriceType != null)
                            {
                                WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                pricetype.DiscountPrice = proxypart.PriceType.DiscountPrice;
                                pricetype.DiscountRate = proxypart.PriceType.DiscountRate;
                                pricetype.TotalPrice = proxypart.PriceType.TotalPrice;
                                pricetype.TotalPriceIncludeTax = proxypart.PriceType.TotalPriceIncludeTax;
                                pricetype.UnitPrice = proxypart.PriceType.UnitPrice;
                                part.PriceType = pricetype;
                            }
                            #endregion

                            response.Parts.Add(part);
                        }
                        #endregion
                    }
                    else
                    {
                        response.ResultMessage = GetResultMessageData(WA.Standard.IF.Data.v2.Common.Common.ResponseCode.NoResult, WA.Standard.IF.Data.v2.Common.Common.ResponseMessage.NoResult);
                    }

                    #endregion
                }
            }
            #endregion

            return response;
        }

        public WA.Standard.IF.Data.v2.HMCIS.Price.PriceCheckResponse PriceCheck(WA.Standard.IF.Data.v2.HMCIS.Price.PriceCheckRequest request)
        {
            WA.Standard.IF.Data.v2.HMCIS.Price.PriceCheckResponse response = new WA.Standard.IF.Data.v2.HMCIS.Price.PriceCheckResponse();

            #region v2.WA.v2 - WA.Standard.IF.WebService

            #region PriceCheck Request Set

            //Create proxy credential
            NetworkCredential proxycredential = new NetworkCredential(request.TransactionHeader.Username, request.TransactionHeader.Password);

            //Create proxy web service from dms web service with credential
            WA.v2.WS_Price.Price proxyws = new WA.v2.WS_Price.Price();
            proxyws.Credentials = proxycredential;

            //Create proxy request with pricecheck and transaction
            WA.v2.WS_Price.PriceCheckRequest proxyrequest = new WA.v2.WS_Price.PriceCheckRequest();

            //Create proxy transaction
            WA.v2.WS_Price.TransactionHeader proxytransactionheader = new WA.v2.WS_Price.TransactionHeader();
            if (request.TransactionHeader != null)
            {
                #region//TransactionHeader Set
                proxytransactionheader.CountryID = request.TransactionHeader.CountryID;
                proxytransactionheader.DealerID = request.TransactionHeader.DealerID;
                proxytransactionheader.DistributorID = request.TransactionHeader.DistributorID;
                proxytransactionheader.DMSCode = request.TransactionHeader.DMSCode;
                proxytransactionheader.DMSServerUrl = request.TransactionHeader.DMSServerUrl;
                proxytransactionheader.DMSVersion = request.TransactionHeader.DMSVersion;
                proxytransactionheader.DocumentVersion = request.TransactionHeader.DocumentVersion;
                proxytransactionheader.GroupID = request.TransactionHeader.GroupID;
                proxytransactionheader.IneterfaceID = request.TransactionHeader.IneterfaceID;
                proxytransactionheader.Password = request.TransactionHeader.Password;
                proxytransactionheader.PollingToken = request.TransactionHeader.PollingToken;
                proxytransactionheader.RequestPollingToken = request.TransactionHeader.RequestPollingToken;
                proxytransactionheader.RequestType = request.TransactionHeader.RequestType;
                proxytransactionheader.TransactionId = request.TransactionHeader.TransactionId;
                proxytransactionheader.TransactionDateTimeLocal = request.TransactionHeader.TransactionDateTimeLocal;
                proxytransactionheader.TransactionDateTimeUTC = request.TransactionHeader.TransactionDateTimeUTC;
                proxytransactionheader.TransactionType = request.TransactionHeader.TransactionType;
                proxytransactionheader.Username = request.TransactionHeader.Username;
                proxytransactionheader.VenderTrackingCode = request.TransactionHeader.VenderTrackingCode;
                proxyrequest.TransactionHeader = proxytransactionheader;
                proxyws.Url = string.Format("{0}/rtr-atest/ws/Price.1cws", proxytransactionheader.DMSServerUrl);
                #endregion
            }

            //Create proxy pricecheck
            WA.v2.WS_Price.PriceCheck proxypricecheck = new WA.v2.WS_Price.PriceCheck();
            if (request.PriceCheck != null)
            {
                #region//PriceCheck Header
                proxypricecheck.DMSRONo = request.PriceCheck.DMSRONo;
                #endregion

                #region//PriceCheck OPCodes
                if (request.PriceCheck.OPCodes != null && request.PriceCheck.OPCodes.Count > 0)
                {
                    int opcodescnt = 0;
                    WA.v2.WS_Price.OPCode[] proxyopcodes = new WA.v2.WS_Price.OPCode[request.PriceCheck.OPCodes.Count];
                    foreach (WA.Standard.IF.Data.v2.HMCIS.Price.OPCode opcode in request.PriceCheck.OPCodes)
                    {
                        #region//PriceCheck OPCode Header
                        WA.v2.WS_Price.OPCode proxyopcode = new WA.v2.WS_Price.OPCode();
                        proxyopcode.Code = opcode.Code;
                        proxyopcode.Engine = opcode.Engine;
                        proxyopcode.Make = opcode.Make;
                        proxyopcode.Mileage = opcode.Mileage;
                        proxyopcode.Model = opcode.Model;
                        proxyopcode.Period = opcode.Period;
                        proxyopcode.Year = opcode.Year;
                        proxyopcode.Quantity = opcode.Quantity;
                        #endregion

                        #region//PriceCheck OPCode PriceType
                        if (opcode.PriceType != null)
                        {
                            WA.v2.WS_Price.PriceType proxypricetype = new WA.v2.WS_Price.PriceType();
                            proxypricetype.DiscountPrice = opcode.PriceType.DiscountPrice;
                            proxypricetype.DiscountRate = opcode.PriceType.DiscountRate;
                            proxypricetype.TotalPrice = opcode.PriceType.TotalPrice;
                            proxypricetype.TotalPriceIncludeTax = opcode.PriceType.TotalPriceIncludeTax;
                            proxypricetype.UnitPrice = opcode.PriceType.UnitPrice;
                            proxyopcode.PriceType = proxypricetype;
                        }
                        #endregion

                        #region//PriceCheck OPCode Parts
                        if (opcode.Parts != null && opcode.Parts.Count > 0)
                        {
                            int partscnt = 0;
                            WA.v2.WS_Price.Part[] proxyparts = new WA.v2.WS_Price.Part[opcode.Parts.Count];
                            foreach (WA.Standard.IF.Data.v2.HMCIS.Price.Part part in opcode.Parts)
                            {
                                #region//PriceCheck OPCode Parts Header
                                WA.v2.WS_Price.Part proxypart = new WA.v2.WS_Price.Part();
                                proxypart.Manufacturer = part.Manufacturer;
                                proxypart.PartNumber = part.PartNumber;
                                proxypart.Quantity = part.Quantity;
                                //proxypart.ServiceType = part.ServiceType;
                                #endregion

                                #region//PriceCheck OPCode Parts PriceType
                                if (part.PriceType != null)
                                {
                                    WA.v2.WS_Price.PriceType proxypricetype = new WA.v2.WS_Price.PriceType();
                                    proxypricetype.DiscountPrice = part.PriceType.DiscountPrice;
                                    proxypricetype.DiscountRate = part.PriceType.DiscountRate;
                                    proxypricetype.TotalPrice = part.PriceType.TotalPrice;
                                    proxypricetype.TotalPriceIncludeTax = part.PriceType.TotalPriceIncludeTax;
                                    proxypricetype.UnitPrice = part.PriceType.UnitPrice;
                                    proxypart.PriceType = proxypricetype;
                                }
                                #endregion

                                proxyparts[partscnt] = proxypart;
                                partscnt++;
                            }

                            proxyopcode.Parts = proxyparts;
                        }
                        #endregion

                        proxyopcodes[opcodescnt] = proxyopcode;
                        opcodescnt++;
                    }

                    proxypricecheck.OPCodes = proxyopcodes;
                }
                #endregion

                proxyrequest.PriceCheck = proxypricecheck;
            }
            #endregion

            //Run proxy web method with proxy request
            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS PriceCheckRequest XML", proxyrequest);

            WA.v2.WS_Price.PriceCheckResponse proxyresponse = proxyws.PriceCheck(proxyrequest);

            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS PriceCheckResponse XML", proxyresponse);

            //Mapping with Standard Interface Specification Object
            if (proxyresponse != null)
            {
                if (proxyresponse.TransactionHeader != null)
                {
                    #region//TransactionHeader Set
                    WA.Standard.IF.Data.v2.Common.Common.TransactionHeader transactionheader = new WA.Standard.IF.Data.v2.Common.Common.TransactionHeader();
                    transactionheader.CountryID = proxyresponse.TransactionHeader.CountryID;
                    transactionheader.DealerID = proxyresponse.TransactionHeader.DealerID;
                    transactionheader.DistributorID = proxyresponse.TransactionHeader.DistributorID;
                    transactionheader.DMSCode = proxyresponse.TransactionHeader.DMSCode;
                    transactionheader.DMSServerUrl = proxyresponse.TransactionHeader.DMSServerUrl;
                    transactionheader.DMSVersion = proxyresponse.TransactionHeader.DMSVersion;
                    transactionheader.DocumentVersion = proxyresponse.TransactionHeader.DocumentVersion;
                    transactionheader.GroupID = proxyresponse.TransactionHeader.GroupID;
                    transactionheader.IneterfaceID = proxyresponse.TransactionHeader.IneterfaceID;
                    transactionheader.Password = proxyresponse.TransactionHeader.Password;
                    transactionheader.PollingToken = proxyresponse.TransactionHeader.PollingToken;
                    transactionheader.RequestPollingToken = proxyresponse.TransactionHeader.RequestPollingToken;
                    transactionheader.RequestType = proxyresponse.TransactionHeader.RequestType;
                    transactionheader.TransactionId = proxyresponse.TransactionHeader.TransactionId;
                    transactionheader.TransactionDateTimeLocal = proxyresponse.TransactionHeader.TransactionDateTimeLocal;
                    transactionheader.TransactionDateTimeUTC = proxyresponse.TransactionHeader.TransactionDateTimeUTC;
                    transactionheader.TransactionType = proxyresponse.TransactionHeader.TransactionType;
                    transactionheader.Username = proxyresponse.TransactionHeader.Username;
                    transactionheader.VenderTrackingCode = proxyresponse.TransactionHeader.VenderTrackingCode;
                    response.TransactionHeader = transactionheader;
                    #endregion
                }

                //ResultMessage Set
                if (proxyresponse.ResultMessage != null)
                {
                    response.ResultMessage = GetResultMessageData(proxyresponse.ResultMessage.Code, proxyresponse.ResultMessage.Message);
                }

                if (proxyresponse.Errors != null)
                {
                    //Error List Set
                    foreach (WA.v2.WS_Price.Error proxyerror in proxyresponse.Errors)
                    {
                        if (response.Errors != null)
                            response.Errors.Add(GetErrorData(proxyerror.Code, proxyerror.Message));
                        else
                            response.Errors = GetErrorDataList(proxyerror.Code, proxyerror.Message);
                    }
                }
                else
                {
                    #region //OPCodeGetResponse Set

                    if (proxyresponse.Price != null)
                    {
                        #region//PricesGetResponse Set

                        WA.v2.WS_Price.Price1 proxyprice = proxyresponse.Price;

                        #region //Prices Header
                        WA.Standard.IF.Data.v2.HMCIS.Price.Price price = new WA.Standard.IF.Data.v2.HMCIS.Price.Price();
                        price.LaborCampaignDiscountAmount = proxyprice.LaborCampaignDiscountAmount;
                        price.PartsCampaignDiscountAmount = proxyprice.PartsCampaignDiscountAmount;
                        price.TotalAmount = proxyprice.TotalAmount;
                        price.TotalCampaignDiscountAmount = proxyprice.TotalCampaignDiscountAmount;
                        price.VATAmount = proxyprice.VATAmount;
                        price.AdditionalRepairOrderSummary = proxyprice.AdditionalRepairOrderSummary;
                        #endregion

                        if (proxyprice.OPCodes != null && proxyprice.OPCodes.Length > 0)
                        {
                            #region//Prices OPCode
                            price.OPCodes = new List<Standard.IF.Data.v2.Common.OPCode.OPCode>();
                            foreach (WA.v2.WS_Price.OPCode1 proxyopcode in proxyprice.OPCodes)
                            {
                                #region //Prices OPCode Header
                                WA.Standard.IF.Data.v2.Common.OPCode.OPCode opcode = new WA.Standard.IF.Data.v2.Common.OPCode.OPCode();
                                opcode.Code = proxyopcode.Code;
                                opcode.Engine = proxyopcode.Engine;
                                opcode.Make = proxyopcode.Make;
                                opcode.Mileage = proxyopcode.Mileage;
                                opcode.Model = proxyopcode.Model;
                                opcode.Period = proxyopcode.Period;
                                opcode.Year = proxyopcode.Year;
                                opcode.Quantity = proxyopcode.Quantity;
                                #endregion

                                #region //Prices OPCode PriceType
                                if (proxyopcode.PriceType != null)
                                {
                                    WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                    pricetype.DiscountPrice = proxyopcode.PriceType.DiscountPrice;
                                    pricetype.DiscountRate = proxyopcode.PriceType.DiscountRate;
                                    pricetype.TotalPrice = proxyopcode.PriceType.TotalPrice;
                                    pricetype.TotalPriceIncludeTax = proxyopcode.PriceType.TotalPriceIncludeTax;
                                    pricetype.UnitPrice = proxyopcode.PriceType.UnitPrice;
                                    opcode.PriceType = pricetype;
                                }
                                #endregion

                                #region //Prices OPCode Parts
                                if (proxyopcode.Parts != null && proxyopcode.Parts.Length > 0)
                                {
                                    opcode.Parts = new List<Standard.IF.Data.v2.Common.Part.Part>();
                                    foreach (WA.v2.WS_Price.Part1 proxypart in proxyopcode.Parts)
                                    {
                                        #region //Prices OPCode Part Header
                                        WA.Standard.IF.Data.v2.Common.Part.Part part = new WA.Standard.IF.Data.v2.Common.Part.Part();
                                        //part.Manufacturer = proxypart.Manufacturer;
                                        part.PartNumber = proxypart.PartNumber;
                                        part.Quantity = proxypart.Quantity;
                                        //part.ServiceType = proxypart.ServiceType;
                                        #endregion

                                        #region //Prices OPCode Part PriceType
                                        if (proxypart.PriceType != null)
                                        {
                                            WA.Standard.IF.Data.v2.Common.Common.PriceType pricetype = new WA.Standard.IF.Data.v2.Common.Common.PriceType();
                                            pricetype.DiscountPrice = proxypart.PriceType.DiscountPrice;
                                            pricetype.DiscountRate = proxypart.PriceType.DiscountRate;
                                            pricetype.TotalPrice = proxypart.PriceType.TotalPrice;
                                            pricetype.TotalPriceIncludeTax = proxypart.PriceType.TotalPriceIncludeTax;
                                            pricetype.UnitPrice = proxypart.PriceType.UnitPrice;
                                            part.PriceType = pricetype;
                                        }
                                        #endregion

                                        opcode.Parts.Add(part);
                                    }
                                }
                                #endregion

                                price.OPCodes.Add(opcode);
                            }
                            #endregion
                        }

                        response.Price = price;

                        #endregion
                    }
                    else
                    {
                        response.ResultMessage = GetResultMessageData(WA.Standard.IF.Data.v2.Common.Common.ResponseCode.NoResult, WA.Standard.IF.Data.v2.Common.Common.ResponseMessage.NoResult);
                    }
                    #endregion
                }
            }
            #endregion

            return response;
        }

        public WA.Standard.IF.Data.v2.HMCIS.Print.PrintResponse PrintRequest(WA.Standard.IF.Data.v2.HMCIS.Print.PrintRequest request)
        {
            WA.Standard.IF.Data.v2.HMCIS.Print.PrintResponse response = new WA.Standard.IF.Data.v2.HMCIS.Print.PrintResponse();

            #region v2.WA.v2 - WA.Standard.IF.WebService

            #region PrintRequest Request Set

            //Create proxy credential
            NetworkCredential proxycredential = new NetworkCredential(request.TransactionHeader.Username, request.TransactionHeader.Password);

            //Create proxy web service from dms web service with credential
            WA.v2.WS_Print.Print proxyws = new WA.v2.WS_Print.Print();
            proxyws.Credentials = proxycredential;

            //Create proxy request with printrequest and transaction
            WA.v2.WS_Print.PrintRequest proxyrequest = new WA.v2.WS_Print.PrintRequest();

            //Create proxy transaction
            WA.v2.WS_Print.TransactionHeader proxytransactionheader = new WA.v2.WS_Print.TransactionHeader();
            if (request.TransactionHeader != null)
            {
                #region//TransactionHeader Set
                proxytransactionheader.CountryID = request.TransactionHeader.CountryID;
                proxytransactionheader.DealerID = request.TransactionHeader.DealerID;
                proxytransactionheader.DistributorID = request.TransactionHeader.DistributorID;
                proxytransactionheader.DMSCode = request.TransactionHeader.DMSCode;
                proxytransactionheader.DMSServerUrl = request.TransactionHeader.DMSServerUrl;
                proxytransactionheader.DMSVersion = request.TransactionHeader.DMSVersion;
                proxytransactionheader.DocumentVersion = request.TransactionHeader.DocumentVersion;
                proxytransactionheader.GroupID = request.TransactionHeader.GroupID;
                proxytransactionheader.IneterfaceID = request.TransactionHeader.IneterfaceID;
                proxytransactionheader.Password = request.TransactionHeader.Password;
                proxytransactionheader.PollingToken = request.TransactionHeader.PollingToken;
                proxytransactionheader.RequestPollingToken = request.TransactionHeader.RequestPollingToken;
                proxytransactionheader.RequestType = request.TransactionHeader.RequestType;
                proxytransactionheader.TransactionId = request.TransactionHeader.TransactionId;
                proxytransactionheader.TransactionDateTimeLocal = request.TransactionHeader.TransactionDateTimeLocal;
                proxytransactionheader.TransactionDateTimeUTC = request.TransactionHeader.TransactionDateTimeUTC;
                proxytransactionheader.TransactionType = request.TransactionHeader.TransactionType;
                proxytransactionheader.Username = request.TransactionHeader.Username;
                proxytransactionheader.VenderTrackingCode = request.TransactionHeader.VenderTrackingCode;
                proxyrequest.TransactionHeader = proxytransactionheader;
                proxyws.Url = string.Format("{0}/rtr-atest/ws/Print.1cws", proxytransactionheader.DMSServerUrl);
                #endregion
            }

            //Create proxy printrequest
            WA.v2.WS_Print.Print1 proxyprint = new WA.v2.WS_Print.Print1();
            if (request.Print != null)
            {
                #region//Print Set
                proxyprint.DMSRONo = request.Print.DMSRONo;
                proxyprint.PrintAddress = request.Print.PrintAddress;
                proxyprint.PrintType = Map.SetDMSCodeFromWACode(CodeType.PrintType, request.Print.PrintType);
                proxyprint.CopyNumber = request.Print.CopyNumber;

                if (request.Print.PrintType.Equals(SystemCode.PrintType.VHC) && request.Print.VHC != null)
                {
                    #region//VHC
                    WA.v2.WS_Print.VHC proxyvhc = new WS_Print.VHC();
                    if (request.Print.VHC.AdditionalEquipment != null)
                        proxyvhc.AdditionalEquipment = new WS_Print.AdditionalEquipment()
                        {
                            SecretNutsOnWheels = request.Print.VHC.AdditionalEquipment.SecretNutsOnWheels,
                            SecuritySystemWithEngineImmobilizer = request.Print.VHC.AdditionalEquipment.SecuritySystemWithEngineImmobilizer,
                        };
                    if (request.Print.VHC.Complectation != null)
                        proxyvhc.Complectation = new WS_Print.Complectation()
                        {
                            AdditionalWheel = request.Print.VHC.Complectation.AdditionalWheel,
                            Ashtray = request.Print.VHC.Complectation.Ashtray,
                            CigaretteLighter = request.Print.VHC.Complectation.CigaretteLighter,
                            FirstAidkit = request.Print.VHC.Complectation.FirstAidkit,
                            Jack = request.Print.VHC.Complectation.Jack,
                            Roadkit = request.Print.VHC.Complectation.Roadkit,
                            StandardToolkit = request.Print.VHC.Complectation.StandardToolkit,
                        };
                    if (request.Print.VHC.ExternalInspection != null)
                        proxyvhc.ExternalInspection = new WS_Print.ExternalInspection()
                        {
                            ExternalLights = request.Print.VHC.ExternalInspection.ExternalLights,
                        };
                    if (request.Print.VHC.InspectionOfBodyAndWindows != null)
                        proxyvhc.InspectionOfBodyAndWindows = new WS_Print.InspectionOfBodyAndWindows()
                        {
                            Value = request.Print.VHC.InspectionOfBodyAndWindows.Value,
                        };
                    if (request.Print.VHC.InternalInspection != null)
                        proxyvhc.InternalInspection = new WS_Print.InternalInspection()
                        {
                            ConditionSystem = request.Print.VHC.InternalInspection.ConditionSystem,
                            Horn = request.Print.VHC.InternalInspection.Horn,
                            ParkingBrake = request.Print.VHC.InternalInspection.ParkingBrake,
                            SafetyBelts = request.Print.VHC.InternalInspection.SafetyBelts,
                            WipersWashers = request.Print.VHC.InternalInspection.WipersWashers,
                        };
                    if (request.Print.VHC.LevelOfFuelInTank != null)
                        proxyvhc.LevelOfFuelInTank = new WS_Print.LevelOfFuelInTank()
                        {
                            Value = request.Print.VHC.LevelOfFuelInTank.Value,
                        };
                    //if (request.Print.VHC.PurposeOfVisit != null)
                    //    proxyvhc.PurposeOfVisit = new WS_Print.PurposeOfVisit()
                    //    {
                    //        Value = request.Print.VHC.PurposeOfVisit.Value,
                    //    };
                    if (request.Print.VHC.UnderhoodInspection != null)
                        proxyvhc.UnderhoodInspection = new WS_Print.UnderhoodInspection()
                        {
                            AirFilter = request.Print.VHC.UnderhoodInspection.AirFilter,
                            Battery = request.Print.VHC.UnderhoodInspection.Battery,
                            DriveBelts = request.Print.VHC.UnderhoodInspection.DriveBelts,
                            OilLevelInEngine = request.Print.VHC.UnderhoodInspection.OilLevelInEngine,
                            PipelinesLeakage = request.Print.VHC.UnderhoodInspection.PipelinesLeakage,
                        };
                    if (request.Print.VHC.VehicleIsFullyLifted != null)
                        proxyvhc.VehicleIsFullyLifted = new WS_Print.VehicleIsFullyLifted()
                        {
                            DriveShafts = request.Print.VHC.VehicleIsFullyLifted.DriveShafts,
                            ExhaustSystem = request.Print.VHC.VehicleIsFullyLifted.ExhaustSystem,
                            FrontSuspension = request.Print.VHC.VehicleIsFullyLifted.FrontSuspension,
                            LeakageOfTechnicalLiquids = request.Print.VHC.VehicleIsFullyLifted.LeakageOfTechnicalLiquids,
                            RearSuspension = request.Print.VHC.VehicleIsFullyLifted.RearSuspension,
                        };
                    if (request.Print.VHC.VehicleIsPartlyLifted != null)
                        proxyvhc.VehicleIsPartlyLifted = new WS_Print.VehicleIsPartlyLifted()
                        {
                            FrontBrakeDiscs = request.Print.VHC.VehicleIsPartlyLifted.FrontBrakeDiscs,
                            FrontBrakePads = request.Print.VHC.VehicleIsPartlyLifted.FrontBrakePads,
                            FrontWheelBearings = request.Print.VHC.VehicleIsPartlyLifted.FrontWheelBearings,
                            Radiators = request.Print.VHC.VehicleIsPartlyLifted.Radiators,
                            RearBrakeDiscs = request.Print.VHC.VehicleIsPartlyLifted.RearBrakeDiscs,
                            RearBrakePads = request.Print.VHC.VehicleIsPartlyLifted.RearBrakePads,
                            RearWheelBearings = request.Print.VHC.VehicleIsPartlyLifted.RearWheelBearings,
                            ShockAbsorbers = request.Print.VHC.VehicleIsPartlyLifted.ShockAbsorbers,
                            SteeringSystem = request.Print.VHC.VehicleIsPartlyLifted.SteeringSystem,
                            TyresWheelDiscs = request.Print.VHC.VehicleIsPartlyLifted.TyresWheelDiscs,
                        };
                    #endregion

                    proxyprint.VHC = proxyvhc;
                }
                else if (request.Print.PrintType.Equals(SystemCode.PrintType.FinalInspection) && request.Print.FinalInspection != null)
                {
                    #region//FinalInspection
                    WA.v2.WS_Print.FinalInspection proxyfinalinspection = new WS_Print.FinalInspection();
                    if (request.Print.FinalInspection.CheckInsideOutside != null)
                        proxyfinalinspection.CheckInsideOutside = new WS_Print.CheckInsideOutside()
                        {
                            AbsenceOfCautionIndicatorsOnTheDashboard = request.Print.FinalInspection.CheckInsideOutside.AbsenceOfCautionIndicatorsOnTheDashboard,
                            AirPressureInTheTiresAndSpareWheel = request.Print.FinalInspection.CheckInsideOutside.AirPressureInTheTiresAndSpareWheel,
                            DamagesOnBodyAndPaint = request.Print.FinalInspection.CheckInsideOutside.DamagesOnBodyAndPaint,
                            DoorsLocksAndWindowLifts = request.Print.FinalInspection.CheckInsideOutside.DoorsLocksAndWindowLifts,
                            ExteriorLighting = request.Print.FinalInspection.CheckInsideOutside.ExteriorLighting,
                            HornHandbrakeAndSeatBelts = request.Print.FinalInspection.CheckInsideOutside.HornHandbrakeAndSeatBelts,
                            SettingsOfClockAndMediaSystem = request.Print.FinalInspection.CheckInsideOutside.SettingsOfClockAndMediaSystem,
                            TighteningTorqueOfWheelNuts = request.Print.FinalInspection.CheckInsideOutside.TighteningTorqueOfWheelNuts,
                            WiperAndWasherNozzles = request.Print.FinalInspection.CheckInsideOutside.WiperAndWasherNozzles,
                        };
                    if (request.Print.FinalInspection.InspectionUnderTheVehicle != null)
                        proxyfinalinspection.InspectionUnderTheVehicle = new WS_Print.InspectionUnderTheVehicle()
                        {
                            AbsenseOfLeakage = request.Print.FinalInspection.InspectionUnderTheVehicle.AbsenseOfLeakage,
                            BrakeAndFuelPipesAndHoses = request.Print.FinalInspection.InspectionUnderTheVehicle.BrakeAndFuelPipesAndHoses,
                            CrankcaseProtection = request.Print.FinalInspection.InspectionUnderTheVehicle.CrankcaseProtection,
                            TighteningTorqueOfDrainPlugsAndBrakeCalipers = request.Print.FinalInspection.InspectionUnderTheVehicle.TighteningTorqueOfDrainPlugsAndBrakeCalipers,
                        };
                    if (request.Print.FinalInspection.PreparingForFinalInspection != null)
                        proxyfinalinspection.PreparingForFinalInspection = new WS_Print.PreparingForFinalInspection()
                        {
                            LookThrowTheHistoryOfService = request.Print.FinalInspection.PreparingForFinalInspection.LookThrowTheHistoryOfService,
                            LookThrowTheWorkingDocumentation = request.Print.FinalInspection.PreparingForFinalInspection.LookThrowTheWorkingDocumentation,
                        };

                    if (request.Print.FinalInspection.RoadTest != null)
                        proxyfinalinspection.RoadTest = new WS_Print.RoadTest()
                        {
                            CorrectnessOfEngineWorks = request.Print.FinalInspection.RoadTest.CorrectnessOfEngineWorks,
                            CorrectnessWorkingOfClutchAndTransmission = request.Print.FinalInspection.RoadTest.CorrectnessWorkingOfClutchAndTransmission,
                            LackOfNoiseVibrationAndDynamicImpact = request.Print.FinalInspection.RoadTest.LackOfNoiseVibrationAndDynamicImpact,
                            TheCorrectPositionOfTheSteeringWheel = request.Print.FinalInspection.RoadTest.TheCorrectPositionOfTheSteeringWheel,
                        };
                    if (request.Print.FinalInspection.StandTest != null)
                        proxyfinalinspection.StandTest = new WS_Print.StandTest()
                        {
                            Brakes = request.Print.FinalInspection.StandTest.Brakes,
                            CorrectnessWayOfCarMoving = request.Print.FinalInspection.StandTest.CorrectnessWayOfCarMoving,
                            Shocks = request.Print.FinalInspection.StandTest.Shocks,
                        };
                    if (request.Print.FinalInspection.Summary != null)
                        proxyfinalinspection.Summary = new WS_Print.Summary()
                        {
                            CleanCarInsideAndOut = request.Print.FinalInspection.Summary.CleanCarInsideAndOut,
                            CompletedWorkConsistentWithTheStated = request.Print.FinalInspection.Summary.CompletedWorkConsistentWithTheStated,
                            FillInFinalInspectionListAndSign = request.Print.FinalInspection.Summary.FillInFinalInspectionListAndSign,
                            ReplacedPartsMatchesWithWorkDoneAndPackedProperly = request.Print.FinalInspection.Summary.ReplacedPartsMatchesWithWorkDoneAndPackedProperly,
                            TheVehicleIsSuitableForUse = request.Print.FinalInspection.Summary.TheVehicleIsSuitableForUse,
                            ToSignRepairOrderAndGiveItSA = request.Print.FinalInspection.Summary.ToSignRepairOrderAndGiveItSA,
                        };
                    if (request.Print.FinalInspection.UnderHoodInspection != null)
                        proxyfinalinspection.UnderHoodInspection = new WS_Print.UnderHoodInspection()
                        {
                            AbsenceOfLeakage = request.Print.FinalInspection.UnderHoodInspection.AbsenceOfLeakage,
                            CheckingOfCorrectnessOfHeadlights = request.Print.FinalInspection.UnderHoodInspection.CheckingOfCorrectnessOfHeadlights,
                            CleanlinessAndTighteningOfBatteryTerminals = request.Print.FinalInspection.UnderHoodInspection.CleanlinessAndTighteningOfBatteryTerminals,
                            CleanlinessOfEngine = request.Print.FinalInspection.UnderHoodInspection.CleanlinessOfEngine,
                            ExistenceOfSpecialTag = request.Print.FinalInspection.UnderHoodInspection.ExistenceOfSpecialTag,
                            LevelsOfTechnicalLiquids = request.Print.FinalInspection.UnderHoodInspection.LevelsOfTechnicalLiquids,
                            TighteningTorqueOfOilFillerCapsAndRadiator = request.Print.FinalInspection.UnderHoodInspection.TighteningTorqueOfOilFillerCapsAndRadiator,
                        };
                    #endregion

                    proxyprint.FinalInspection = proxyfinalinspection;
                }
                #endregion

                proxyrequest.Print = proxyprint;
            }
            #endregion

            //Run proxy web method with proxy request
            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS PrintRequest XML", proxyrequest);

            WA.v2.WS_Print.PrintResponse proxyresponse = proxyws.PrintRequest(proxyrequest);

            WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "DMS PrintResponse XML", proxyresponse);

            //Mapping with Standard Interface Specification Object
            if (proxyresponse != null)
            {
                if (proxyresponse.TransactionHeader != null)
                {
                    #region//TransactionHeader Set
                    WA.Standard.IF.Data.v2.Common.Common.TransactionHeader transactionheader = new WA.Standard.IF.Data.v2.Common.Common.TransactionHeader();
                    transactionheader.CountryID = proxyresponse.TransactionHeader.CountryID;
                    transactionheader.DealerID = proxyresponse.TransactionHeader.DealerID;
                    transactionheader.DistributorID = proxyresponse.TransactionHeader.DistributorID;
                    transactionheader.DMSCode = proxyresponse.TransactionHeader.DMSCode;
                    transactionheader.DMSServerUrl = proxyresponse.TransactionHeader.DMSServerUrl;
                    transactionheader.DMSVersion = proxyresponse.TransactionHeader.DMSVersion;
                    transactionheader.DocumentVersion = proxyresponse.TransactionHeader.DocumentVersion;
                    transactionheader.GroupID = proxyresponse.TransactionHeader.GroupID;
                    transactionheader.IneterfaceID = proxyresponse.TransactionHeader.IneterfaceID;
                    transactionheader.Password = proxyresponse.TransactionHeader.Password;
                    transactionheader.PollingToken = proxyresponse.TransactionHeader.PollingToken;
                    transactionheader.RequestPollingToken = proxyresponse.TransactionHeader.RequestPollingToken;
                    transactionheader.RequestType = proxyresponse.TransactionHeader.RequestType;
                    transactionheader.TransactionId = proxyresponse.TransactionHeader.TransactionId;
                    transactionheader.TransactionDateTimeLocal = proxyresponse.TransactionHeader.TransactionDateTimeLocal;
                    transactionheader.TransactionDateTimeUTC = proxyresponse.TransactionHeader.TransactionDateTimeUTC;
                    transactionheader.TransactionType = proxyresponse.TransactionHeader.TransactionType;
                    transactionheader.Username = proxyresponse.TransactionHeader.Username;
                    transactionheader.VenderTrackingCode = proxyresponse.TransactionHeader.VenderTrackingCode;
                    response.TransactionHeader = transactionheader;
                    #endregion
                }

                //ResultMessage Set
                if (proxyresponse.ResultMessage != null)
                {
                    response.ResultMessage = GetResultMessageData(proxyresponse.ResultMessage.Code, proxyresponse.ResultMessage.Message);
                }

                if (proxyresponse.Errors != null)
                {
                    //Error List Set
                    foreach (WA.v2.WS_Print.Error proxyerror in proxyresponse.Errors)
                    {
                        if (response.Errors != null)
                            response.Errors.Add(GetErrorData(proxyerror.Code, proxyerror.Message));
                        else
                            response.Errors = GetErrorDataList(proxyerror.Code, proxyerror.Message);
                    }
                }
            }
            #endregion

            return response;
        }
    }
}
