<%@ Page Title="Paper Details" MasterPageFile="~/Site2.Master" Language="C#" AutoEventWireup="true" CodeBehind="ViewPaperDetails.aspx.cs" Inherits="WebApplication1.ViewPaperDetails" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <fieldset>
            <legend>Paper Details</legend>
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="examIDText" ID="l1">Exam ID</asp:Label>
                    <asp:TextBox ID="examIDText" runat="server" ReadOnly="true"></asp:TextBox>
                </li>
                <li>
                    <asp:DataGrid runat="server" ID="paperDataGrid" AutoGenerateColumns="true" AlternatingItemStyle-BorderColor="#990000"></asp:DataGrid>
                </li>
            </ol>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server"  Text="View" OnClick="view_Click" ID="view" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server" CommandName="Back" Text="Back" OnClick="back_Click" />
        </fieldset>
    </div>
</asp:Content>