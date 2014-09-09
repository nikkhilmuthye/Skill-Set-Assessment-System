<%@ Page Title="Paper Details" MasterPageFile="~/Site2.Master" Language="C#" AutoEventWireup="true" CodeBehind="DetailedReport.aspx.cs" Inherits="WebApplication1.DetailedReport" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <fieldset>
            <legend>Detailed Result</legend>
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="examIDText" ID="l1">Exam ID</asp:Label>
                    <asp:TextBox ID="examIDTextBox" runat="server" ReadOnly="true"></asp:TextBox>
                </li>
                <li>
                    <asp:GridView runat="server" ID="GridView1" AutoGenerateColumns="False" AlternatingItemStyle-BorderColor="#990000">
                        <Columns>
                            <asp:BoundField DataField="Employee_ID" HeaderText="Employee_ID" />
                            <asp:BoundField DataField="Exam_ID" HeaderText="Exam_ID" />
                            <asp:BoundField DataField="Section" HeaderText="Section" />
                            <asp:BoundField DataField="Percentage" HeaderText="Percentage" />
                        </Columns>
                    </asp:GridView>
                </li>
            </ol>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server"  Text="View" OnClick="view_Click" ID="view" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server" CommandName="Back" Text="Back" OnClick="back_Click" />
        </fieldset>
    </div>
</asp:Content>