<%@ Page Title="Exam" MasterPageFile="~/Site1.Master" Language="C#" AutoEventWireup="true" CodeBehind="FeedbackForm.aspx.cs" Inherits="WebApplication1.FeedbackForm" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <asp:Label runat="server" ID="employeeNameLabel" Text="Employee Name:"></asp:Label>
        <br />
        <asp:Label runat="server" ID="examIDLabel" Text="Exam ID:"></asp:Label>
        <br />
        <br />
        <div>
            <asp:Label ID="noteLabel" runat="server" Text="We would like you to kindly devote a few minutes to give us your valuable feedback about our system."></asp:Label>

            <label style="font-size:large; font-style:inherit; font-weight:700">
            <br />
            Note:</label>
            <p>0: Poor, 1: Bad, 2: Average, 3: Good, 4: Very good, 5: Excellent."</p>
            <p>&nbsp;1.Rate the user interface.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:DropDownList ID="comboBox1" runat="server">
                </asp:DropDownList>
            </p>
            <p>&nbsp;2.Rate the quailty of questions.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="comboBox2" runat="server">
                </asp:DropDownList>
            </p>
            <p>&nbsp;3.Rate the tutorial&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:DropDownList ID="comboBox3" runat="server">
                </asp:DropDownList>
            </p>
            <p>&nbsp;4.Rate the response time.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="comboBox4" runat="server">
                </asp:DropDownList>
            </p>
            <p>&nbsp;5.Over all rating.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:DropDownList ID="comboBox5" runat="server">
                </asp:DropDownList>
            </p>
            <br />
            <br />
        </div>

        <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
    </div>

</asp:Content>
