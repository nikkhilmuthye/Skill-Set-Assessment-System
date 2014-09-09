<%@ Page Title="Add Exam Type" MasterPageFile="~/Site2.Master" Language="C#" AutoEventWireup="true" CodeBehind="AddExamType.aspx.cs" Inherits="WebApplication1.AddExamType" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
    <fieldset>
            <legend>Add Applicant</legend>
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="subjectText">Subject</asp:Label>
                    <asp:Textbox ID="subjectText" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="levelCombo">Level</asp:Label>
                    <asp:DropDownList ID="levelCombo" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="noOfAttemptsCombo">Number of Attempts</asp:Label>
                    <asp:DropDownList ID="noOfAttemptsCombo" runat="server" />
                </li>

                <asp:Button runat="server" CommandName="Submit" Text="Add" OnClick="add_Click" />
                <asp:Button runat="server" CommandName="Back" Text="Back" OnClick="back_Click" />
             </ol>
        </fieldset>
        
    </div>
</asp:Content>
