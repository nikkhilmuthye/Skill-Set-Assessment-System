<%@ Page Title="Check Employee Result" MasterPageFile="~/Site2.Master" Language="C#" AutoEventWireup="true" CodeBehind="CheckEmployeeResult.aspx.cs" Inherits="WebApplication1.CheckEmployeeResult" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <fieldset>
            <legend>Check Employee Result</legend>
            <ol>
                <li>
                    <asp:Label runat="server" Enabled="true" AssociatedControlID="employeeIDText">Employee ID</asp:Label>
                    <asp:TextBox ID="employeeIDText" runat="server"  ReadOnly="true"/>
                </li>
                <li>
                    <asp:GridView ID="GridView1" runat="server" 
                        CellPadding="4" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="Employee_ID" HeaderText="Employee_ID" />
                            <asp:BoundField DataField="Exam_ID" HeaderText="Exam_ID" />
                            <asp:BoundField DataField="Score" HeaderText="Score" />
                            <asp:BoundField DataField="Percentage" HeaderText="Percentage" />
                        </Columns>
                    </asp:GridView>
                </li>
            </ol>
        </fieldset>
    </div>
</asp:Content>