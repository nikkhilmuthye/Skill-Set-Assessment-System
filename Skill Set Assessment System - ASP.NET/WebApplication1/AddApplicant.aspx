<%@ Page Title="Add Applicant" MasterPageFile="~/Site2.Master" Language="C#" AutoEventWireup="true" CodeBehind="AddApplicant.aspx.cs" Inherits="WebApplication1.AddApplicant" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <fieldset>
            <legend>Add Applicant</legend>
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="employeeIDCombo">Employee ID</asp:Label>
                    <asp:DropDownList ID="employeeIDCombo" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="examIDCombo">Exam ID</asp:Label>
                    <asp:DropDownList ID="examIDCombo" runat="server" />
                </li>

                <asp:Button runat="server" CommandName="Submit" Text="Submit" OnClick="back_Click" />
                <asp:Button runat="server" CommandName="Back" Text="Back" OnClick="back_Click" />
             </ol>
        </fieldset>
        
    </div>
    </asp:Content>


