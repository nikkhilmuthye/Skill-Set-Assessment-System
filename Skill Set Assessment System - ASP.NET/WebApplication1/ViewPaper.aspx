<%@ Page Title="Choose Paper" MasterPageFile="~/Site2.Master" Language="C#" AutoEventWireup="true" CodeBehind="ViewPaper.aspx.cs" Inherits="WebApplication1.ViewPaper" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <fieldset>
            <legend>Choose Paper</legend>
            <ol>
                <li>
                    <label>Select Exam ID to view paper details</label>
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="examIDCombo" ID="l1">Choose Exam</asp:Label>
                    <asp:DropDownList ID="examIDCombo" runat="server"></asp:DropDownList>
                </li>
            </ol>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server"  Text="View" OnClick="view_Click" ID="view" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server" CommandName="Back" Text="Back" OnClick="back_Click" />
        </fieldset>
    </div>
</asp:Content>