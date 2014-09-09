<%@ Page Title="Set Paper" MasterPageFile="~/Site2.Master" Language="C#" AutoEventWireup="true" CodeBehind="SetPaper.aspx.cs" Inherits="WebApplication1.SetPaper" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <fieldset>
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="examTypeText">Exam Type</asp:Label>
                    <asp:TextBox ID="examTypeText" ReadOnly="true" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="noOfQuestionsText">No Of Questions Added</asp:Label>
                    <asp:TextBox ID="noOfQuestionsText" ReadOnly="true" runat="server" />
                </li>
            </ol>
            <legend>Add Applicant</legend>

            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="sectionCombo" >Section</asp:Label>
                    <asp:DropDownList ID="sectionCombo" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="formatCombo">Format</asp:Label>
                    <asp:DropDownList ID="formatCombo" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="noOfQuestionsCombo">No Of Questions</asp:Label>
                    <asp:DropDownList ID="noOfQuestionsCombo" runat="server" />
                    <br />
                    <br />
                    <br />
                </li>
            </ol>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server"  Text="Add" OnClick="add_Click" ID="add"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server" CommandName="Back" Text="Back" OnClick="back_Click" />
        </fieldset>
     </div>
</asp:Content>