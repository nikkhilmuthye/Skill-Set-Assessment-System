<%@ Page Title="Delete Question" MasterPageFile="~/Site2.Master" Language="C#" AutoEventWireup="true" CodeBehind="DeleteQuestion.aspx.cs" Inherits="WebApplication1.Delete_Question" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <fieldset>
            <legend>Delete Question</legend>
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="questionIDCombo">Question ID</asp:Label>
                    <asp:DropDownList ID="questionIDCombo" runat="server" />
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
