<%@ Page Title="Exam Result" MasterPageFile="~/Site2.Master" Language="C#" AutoEventWireup="true" CodeBehind="SeeResult.aspx.cs" Inherits="WebApplication1.SeeResult" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <fieldset>
            <legend>Exam Result</legend>
            <ol>
                <li>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="examIDlabel" runat="server" Text="Exam ID:"></asp:Label>
                    <asp:TextBox ID="examIDText" ReadOnly="true" runat="server"></asp:TextBox>
                </li>
                <li>
                    <asp:Label ID="highestlabel" runat="server" Text="Highest:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lowestlabel" runat="server" Text="Lowest:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="averagelabel" runat="server" Text="Average:"></asp:Label>
                    
   
                </li>
                <li>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
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