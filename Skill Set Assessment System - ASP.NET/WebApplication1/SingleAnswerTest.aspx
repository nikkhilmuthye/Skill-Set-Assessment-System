﻿<%@ Page Title="Exam" MasterPageFile="~/Site1.Master" Language="C#" AutoEventWireup="true" CodeBehind="SingleAnswerTest.aspx.cs" Inherits="WebApplication1.SingleAnswerTest" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <script type = "text/javascript">
        function Confirm() {
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";
            if (confirm("Do you want to submit?")) {
                confirm_value.value = "Yes";
            } else {
                confirm_value.value = "No";
            }
            document.forms[0].appendChild(confirm_value);
        }
    </script>

    <article style="background-color:lemonchiffon; height: 388px;">
    <div>
        <asp:Label runat="server" ID="employeeNameLabel" Text="Employee Name:"></asp:Label>
        <br />
        <asp:Label runat="server" ID="examIDLabel" Text="Exam ID:"></asp:Label>
        <br />
        <br />
        <asp:ScriptManager ID= "SM1" runat="server"></asp:ScriptManager>
        <asp:Timer ID="timer1" runat="server"
            Interval="1000" OnTick="timer1_tick"></asp:Timer>
    </div>
 
    <div>
        <asp:UpdatePanel id="updPnl" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
            <asp:Label ID="timerLabel" runat="server" Font-Size="Medium" ForeColor="#6600CC"></asp:Label>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="timer1" EventName ="tick" />
            </Triggers>
        </asp:UpdatePanel>
    </div><br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Label runat="server" ID="questionNoLabel" Text="Q"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Label runat="server" ID="questionLabel" Text="Question"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:RadioButton ID="DemoRB1" runat="server" CssClass="radio" Text="Hello" /><br />
        <asp:RadioButton runat="server"  ID="option1RadioButton" GroupName="answers" CssClass="radio" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <%--<asp:Label runat="server" ID="option1Label" Text="Option 1" ></asp:Label>--%><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RadioButton runat="server"  GroupName="answers" ID="option2RadioButton" CssClass="radio" /><%--&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label runat="server" ID="option2Label" Text="Option 2" ></asp:Label>--%> <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RadioButton runat="server"  GroupName="answers" ID="option3RadioButton" CssClass="radio" /><%--&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label runat="server" ID="option3Label" Text="Option 3" ></asp:Label>--%> <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RadioButton runat="server"  GroupName="answers" ID="option4RadioButon" CssClass="radio" /><%--&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label runat="server" ID="option4Label" Text="Option 4" ></asp:Label>--%> <br />

        <br />

    <asp:Button ID="previous" runat="server" Text="Previous" Height="33px" Width="113px" OnClick="previous_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 

    <asp:Button ID="next" runat="server" Text="Next" Height="33px" Width="113px" OnClick="next_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 

    <asp:Button ID="submit" runat="server" Text="Submit" Height="33px" Width="113px" OnClick="submit_Click" OnClientClick="Confirm()" /></div>
            <asp:Label Font-Size="Larger" runat="server" ID="answ" Text="Check Again"></asp:Label>

    </article>


    <aside style="background-color:lemonchiffon">
        <asp:GridView ID="bookmarkGridView" runat="server" AutoGenerateColumns="False" >
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Question Number" DataField="Question" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:Button runat="server" ID="bookmark" Text="Bookmark" OnClick="bookmark_Click" />
        <asp:Button runat="server" ID="removeBookmark" Text=" Remove" OnClick="removeBookmark_Click" />
    </aside>
    
    </asp:Content>
