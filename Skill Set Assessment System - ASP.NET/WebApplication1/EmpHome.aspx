<%@ Page Title="Employee Home" MasterPageFile="~/Site1.Master" Language="C#" AutoEventWireup="true" CodeBehind="EmpHome.aspx.cs" Inherits="WebApplication1.EmpHome" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title" style="background-color:lemonchiffon">
        <h1 id="welcomeLabel" runat="server">Welcome!</h1>
        </hgroup>
    <div style="background-color:lemonchiffon" class="float-rightx" >
        <ul id="menu" >
            <li><a runat="server" href="~/">Change Password</a></li>
            <li><a runat="server" href="~/Login.aspx">Logout</a></li>
        </ul>
    </div>
    <article>
        <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Tutorial</h2>

        <label>Thie tutorial helps you get familarized 
                with the user interface of the test. 
        <br />
        It
                explains in brief how to answer questions
                of different formats. 
        <br />
        A few snapshots, 
                help understanding the same in a better
                way.</label>

        <br />
        <br />
        <br />

        <asp:Button ID="takeTutorial" runat="server" OnClick="takeTutorial_Click" Text="Take Tutorial" Height="55px" Width="196px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="skipTutorial" runat="server" OnClick="skipTutorial_Click" Text="Skip Tutorial" Height="55px" Width="196px" />
    </article>

    <aside>
        <h3>Today's Exam Schedule</h3>

        <div>
            <asp:Label runat="server" ID="examIDLabel" Text="Exam ID:"></asp:Label>
            <br />
            <asp:Label runat="server" ID="examTypeLabel" Text="Exam Type:"></asp:Label>
            <br />
            <asp:Label runat="server" ID="dateLabel" Text="Date:"></asp:Label>
            <br />
            <asp:Label runat="server" ID="durationLabel" Text="Duration:"></asp:Label>
            <br />
            <br />
            <br />
        </div>

        <asp:label runat="server" ID="noteLabel" Text="Note:" />
    </aside>
</asp:Content>