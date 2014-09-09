<%@ Page Title="Choose Employee" MasterPageFile="~/Site2.Master" Language="C#" AutoEventWireup="true" CodeBehind="SelectResult.aspx.cs" Inherits="WebApplication1.SelectResult" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <fieldset>
            <legend>Choose Exam</legend>
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="examIDCombo" ID="l1">Choose Exam</asp:Label>
                    <asp:DropDownList ID="examIDCombo" runat="server"></asp:DropDownList>
                </li>
            </ol>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server"  Text="Check" OnClick="check_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server" CommandName="Back" Text="Back" OnClick="back_Click" />
        </fieldset>
    </div>
</asp:Content>