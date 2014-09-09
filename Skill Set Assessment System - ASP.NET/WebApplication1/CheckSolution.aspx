<%@ Page Title="Exam" MasterPageFile="~/Site1.Master" Language="C#" AutoEventWireup="true" CodeBehind="CheckSolution.aspx.cs" Inherits="WebApplication1.CheckSolution" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
     <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <br />
     <br />
        <asp:Button ID="proceed" runat="server" Text="Proceed" OnClick="Proceed_Click" />

</asp:Content>
