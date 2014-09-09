<%@ Page Title="Exam" MasterPageFile="~/Site1.Master" Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="WebApplication1.Result" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <asp:Label runat="server" ID="employeeNameLabel" Text="Employee Name:"></asp:Label>
        <br />
        <asp:Label runat="server" ID="examLabel" Text="Exam ID:"></asp:Label>
        <br />
        <br />
        <div>
            <asp:Label ID="congratulationsLabel" runat="server" Text="Congratulations ! You have secured ------- marks in *Exam ID*."
                 Font-Bold="true" Font-Size="Large"></asp:Label>
        </div>

        <asp:Button ID="proceed" runat="server" Text="Proceed" OnClick="proceed_Click" />
    </div>

</asp:Content>
