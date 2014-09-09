<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Account.Login" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
    </hgroup>
    <section id="loginForm">
        <h2>Use a local account to log in.</h2>
                <fieldset>
                    <legend>Log in Form</legend>
                    <ol>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="UserName">User name</asp:Label>
                            <asp:TextBox ID="UserName" runat="server" />
                        </li>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="Password">Password</asp:Label>
                            <asp:TextBox ID="Password" runat="server" TextMode="Password" />
                        </li>
                        
                        <li>
                            <asp:RadioButton runat="server" ID="adminRadioButton" GroupName ="group1" TextAlign="Left"/>
                            <asp:Label runat="server" AssociatedControlID="adminRadioButton" CssClass="radio" >Admin</asp:Label>
                            <asp:RadioButton runat="server" ID="employeeRadioButton" GroupName ="group1" TextAlign="Left" />
                            <asp:Label runat="server" AssociatedControlID="employeeRadioButton" CssClass="radio">Employee</asp:Label>
                        </li>

                        <li>
                            <asp:CheckBox runat="server" ID="RememberMe" />
                            <asp:Label runat="server" AssociatedControlID="RememberMe" CssClass="checkbox">Remember me?</asp:Label>
                        </li>

                    </ol>
                    <p>
                        <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled" ForeColor="Blue" NavigateUrl="~/AddApplicant.aspx">Register</asp:HyperLink>
                                if you don't have an account.
                    </p>
                    <asp:Button runat="server" CommandName="Login" Text="Log in" OnClick="login_Click" />
                </fieldset>
    </section>
</asp:Content>
