<%@ Page Title="Register" MasterPageFile="~/Site1.Master" Language="C#" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="WebApplication1.AddEmployee" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
<script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
<script src="Scripts/jquery.dynDateTime.min.js" type="text/javascript"></script>
<script src="Scripts/calendar-en.min.js" type="text/javascript"></script>
<link href="Styles/calendar-blue.css" rel="stylesheet" type="text/css" />
<script type="text/javascript">
    $(document).ready(function () {
        $("#<%=birthdatePicker.ClientID %>").dynDateTime({
            showsTime: true,
            ifFormat: "%Y/%m/%d %H:%M",
            daFormat: "%l;%M %p, %e %m, %Y",
            align: "BR",
            electric: false,
            singleClick: false,
            displayArea: ".siblings('.dtcDisplayArea')",
            button: ".next()"
        });
    });
</script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#<%=hireDatePicker.ClientID %>").dynDateTime({
            showsTime: true,
            ifFormat: "%Y/%m/%d %H:%M",
            daFormat: "%l;%M %p, %e %m, %Y",
            align: "BR",
            electric: false,
            singleClick: false,
            displayArea: ".siblings('.dtcDisplayArea')",
            button: ".next()"
        });
    });
</script>
    <script type="text/javascript">
        var myMessage = "<%=myMessageFromCodeBehind %>";  
        alert(myMessage)
</script> 
    <div>
        <fieldset>
            <legend>Add Applicant</legend>
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="lastNameText">Last Name</asp:Label>
                    <asp:Textbox ID="lastNameText" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="firstNameText">First Name</asp:Label>
                    <asp:Textbox ID="firstNameText" runat="server" />
                </li><li>
                    <asp:Label runat="server" AssociatedControlID="birthdatePicker">Birthdate</asp:Label>
                    <asp:Textbox ID="birthdatePicker" runat="server" TextMode="Date" />
                    <asp:Image ID="calender" ImageUrl="~/Images/1406906284_Calendar_24x24.png" runat="server" />
                </li><li>
                    <asp:Label runat="server" AssociatedControlID="hireDatePicker">Hire Date</asp:Label>
                    <asp:Textbox ID="hireDatePicker" runat="server" TextMode="Date" />
                    <asp:Image ID="Image1" ImageUrl="~/Images/1406906284_Calendar_24x24.png" runat="server" />

                </li><li>
                    <asp:Label runat="server" AssociatedControlID="addressText">Address</asp:Label>
                    <asp:Textbox ID="addressText" runat="server" />
                </li><li>
                    <asp:Label runat="server" AssociatedControlID="cityText">City</asp:Label>
                    <asp:Textbox ID="cityText" runat="server" />
                </li><li>
                    <asp:Label runat="server" AssociatedControlID="regionText">Region</asp:Label>
                    <asp:Textbox ID="regionText" runat="server" />
                </li><li>
                    <asp:Label runat="server" AssociatedControlID="countryText">Country</asp:Label>
                    <asp:Textbox ID="countryText" runat="server" />
                </li><li>
                    <asp:Label runat="server" AssociatedControlID="postalCodeText">Postal Code</asp:Label>
                    <asp:Textbox ID="postalCodeText" runat="server" />
                </li><li>
                    <asp:Label runat="server" AssociatedControlID="mobileText">Mobile Number</asp:Label>
                    <asp:Textbox ID="mobileText" runat="server" />
                </li><li>
                    <asp:Label runat="server" AssociatedControlID="passwordText">Passowrd</asp:Label>
                    <asp:Textbox ID="passwordText" runat="server" TextMode="Password" />
                </li><li>
                    <asp:Label runat="server" AssociatedControlID="confirmPasswordText">Confirm Password</asp:Label>
                    <asp:Textbox ID="confirmPasswordText" runat="server" TextMode="Password" />
                </li>

                <asp:Button runat="server" CommandName="Submit" Text="Register" OnClick="register_Click" />
                <asp:Button runat="server" CommandName="Back" Text="Back" OnClick="back_Click" />
             </ol>
        </fieldset>
        
    </div>
    </asp:Content>