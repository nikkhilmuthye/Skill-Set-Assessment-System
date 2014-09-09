<%@ Page  Title="Add Exam Details" MasterPageFile="~/Site2.Master" Language="C#" AutoEventWireup="true" CodeBehind="AddExamDetails.aspx.cs" Inherits="WebApplication1.AddExamDetails" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery.dynDateTime.min.js" type="text/javascript"></script>
    <script src="Scripts/calendar-en.min.js" type="text/javascript"></script>
    <link href="Styles/calendar-blue.css" rel="stylesheet" type="text/css" />
 
    <div>
        <fieldset>
            <legend>Add Exam Details</legend>
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="examTypeCombo" Width="120px">Exam Type ID</asp:Label>
                    <asp:DropDownList ID="examTypeCombo" runat="server" OnSelectedIndexChanged="examTypeCombo_SelectedIndexChanged" Width="67px" />
                    <br />
                    <br />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="TextBox1" Width="73px">Date</asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <img src="Images/calender.png" style="width: 24px; margin-top: 0px" />
                </li>
            </ol>
        </fieldset>
    </div>
</asp:Content>