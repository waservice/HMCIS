﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WA.Standard.IF.WebService.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<title>Workshop Automation Standard API</title>
<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Workshop Automation Standard API</h1>
        <p>
            Workshop Automation Standard API is the public API for DMS to interact with the
            WA.
        </p>
        <br />
        <ul>
            <li>
                <h3>
                    Appointment</h3>
                <a href="/v2/Common/Appointment.asmx?WSDL">WSDL</a> <a href="/v2/Common/Appointment.asmx?op=AppointmentGet">
                    GET</a> <a href="/v2/Common/Appointment.asmx?op=AppointmentChange">CHANGE</a>
            </li>
            <li>
                <h3>
                    CustomerVehicle</h3>
                <a href="/v2/Common/CustomerVehicle.asmx?WSDL">WSDL</a> <a href="/v2/Common/CustomerVehicle.asmx?op=CustomerVehicleGet">
                    GET</a> <a href="/v2/Common/CustomerVehicle.asmx?op=CustomerVehicleChange">CHANGE</a>
            </li>
            <li>
                <h3>
                    Employee</h3>
                <a href="/v2/Common/Employee.asmx?WSDL">WSDL</a> <a href="/v2/Common/Employee.asmx?op=EmployeeGet">
                    GET</a>
            </li>
            <li>
                <h3>
                    Job</h3>
                <a href="/v2/Common/Job.asmx?WSDL">WSDL</a> <a href="/v2/Common/Job.asmx?op=JobGet">
                    GET</a> <a href="/v2/Common/Job.asmx?op=JobChange">CHANGE</a>
            </li>
            <li>
                <h3>
                    PackageCode</h3>
                <a href="/v2/Common/PackageCode.asmx?WSDL">WSDL</a> <a href="/v2/Common/PackageCode.asmx?op=PackageCodeGet">
                    GET</a>
            </li>
            <li>
                <h3>
                    OPCode</h3>
                <a href="/v2/Common/OPCode.asmx?WSDL">WSDL</a> <a href="/v2/Common/OPCode.asmx?op=OPCodeGet">
                    GET</a>
            </li>
            <li>
                <h3>
                    Parts</h3>
                <a href="/v2/Common/Parts.asmx?WSDL">WSDL</a> <a href="/v2/Common/Parts.asmx?op=PartsGet">
                    GET</a>
            </li>
            <li>
                <h3>
                    RepairOrder</h3>
                <a href="/v2/Common/RepairOrder.asmx?WSDL">WSDL</a> <a href="/v2/Common/RepairOrder.asmx?op=RepairOrderGet">
                    GET</a> <a href="/v2/Common/RepairOrder.asmx?op=RepairOrderChange">CHANGE</a>
            </li>
            <li>
                <h3>
                    Message</h3>
                <a href="/v2/Common/Message.asmx?WSDL">WSDL</a> <a href="/v2/Common/Message.asmx?op=MessageReceive">
                    RECEIVE</a> <a href="/v2/Common/Message.asmx?op=MessageSend">SEND</a>
            </li>
            <br />
            <h3>
                HMCIS</h3>
           <%-- <li>
                <h3>
                    OperationCode</h3>
                <a href="/v2/HMCIS/OperationCode.asmx?WSDL">WSDL</a> <a href="/v2/HMCIS/OperationCode.asmx?op=OperationCodeGet">
                    GET</a>
            </li>--%>
            <li>
                <h3>
                    Price</h3>
                <a href="/v2/HMCIS/Price.asmx?WSDL">WSDL</a> <a href="/v2/HMCIS/Price.asmx?op=PriceCheck">
                    CHECK</a>
            </li>
            <li>
                <h3>
                    Print</h3>
                <a href="/v2/HMCIS/Print.asmx?WSDL">WSDL</a> <a href="/v2/HMCIS/Print.asmx?op=PrintRequest">
                    REQUEST</a>
            </li>
        </ul>
    </div>
    </form>
</body>
</html>
