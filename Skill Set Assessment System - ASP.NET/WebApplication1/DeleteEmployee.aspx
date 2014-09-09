<%@ Page Title="Delete Employee" MasterPageFile="~/Site2.Master" Language="C#" AutoEventWireup="true" CodeBehind="DeleteEmployee.aspx.cs" Inherits="WebApplication1.Delete_Employee" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <fieldset>
            <legend>Delete Employee</legend>
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="employeeIDCombo">Employee ID</asp:Label>
                    <asp:DropDownList ID="employeeIDCombo" runat="server" />
                </li>
                <li>
                    <br />
                    <br />
                    <br />
                    <asp:Button runat="server"  Text="Submit" OnClick="delete_Click" onclientclick="return confirm('Are you sure you want delete ' + empIDexamIDcombo.SelectedItem.ToString() + '?');" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button runat="server" CommandName="Back" Text="Back" OnClick="back_Click" />
                </li>
            </ol>
        </fieldset>
    </div>
</asp:Content>
