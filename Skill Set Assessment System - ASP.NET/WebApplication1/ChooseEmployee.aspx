<%@ Page Title="Choose Employee" MasterPageFile="~/Site2.Master" Language="C#" AutoEventWireup="true" CodeBehind="ChooseEmployee.aspx.cs" Inherits="WebApplication1.ChooseEmployee" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <fieldset>
            <legend>Choose Employee</legend>
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="employeeIDCombo" ID="l1">Choose Employee</asp:Label>
                    <asp:DropDownList ID="employeeIDCombo" runat="server"></asp:DropDownList>
                </li>
            </ol>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server"  Text="Set" OnClick="check_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server" CommandName="Back" Text="Back" OnClick="back_Click" />
        </fieldset>
    </div>
</asp:Content>