<%@ Page Title="Exam" MasterPageFile="~/Site1.Master" Language="C#" EnableViewState="true" AutoEventWireup="true" CodeBehind="MatchTheColumnTest.aspx.cs" Inherits="WebApplication1.MatchTheColumnTest" %>

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
    </div>
    <div>
        <asp:ScriptManager ID= "SM1" runat="server"></asp:ScriptManager>
        <asp:Timer ID="timer1" runat="server"
            Interval="1000" OnTick="timer1_tick"></asp:Timer>
   </div>
 
    <div>
        <asp:UpdatePanel id="updPnl" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label ID="timerLabel" runat="server" Font-Bold="True" Font-Names="Arial"
                      Font-Size="Medium" ForeColor="#6600CC"></asp:Label>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="timer1" EventName ="tick" />
            </Triggers>
        </asp:UpdatePanel>
    </div>
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label runat="server" ID="questionNoLabel" Text="Q"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    
     <asp:Table runat="server" CellPadding="5" GridLines="vertical" HorizontalAlign="Center" Height="212px" Width="416px">
        <asp:TableRow runat="server">
            <asp:TableCell><asp:Label runat="server" ID="Label1" Text="Coloumn A"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:Label runat="server" ID="Label3" Text="Coloumn B"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell><asp:Label runat="server" ID="Label2" Text="A."></asp:Label>&nbsp; <asp:Label runat="server" ID="aOption1Label" Text="Option1"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:Label runat="server" ID="Label5" Text="1."></asp:Label>&nbsp; <asp:Label runat="server" ID="bOption1Label" Text="Option1"></asp:Label></asp:TableCell>
        </asp:TableRow>
         <asp:TableRow>
            <asp:TableCell><asp:Label runat="server" ID="Label7" Text="B."></asp:Label>&nbsp; <asp:Label runat="server" ID="aOption2Label" Text="Option2"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:Label runat="server" ID="Label9" Text="2."></asp:Label>&nbsp; <asp:Label runat="server" ID="bOption2Label" Text="Option2"></asp:Label></asp:TableCell>
        </asp:TableRow>
         <asp:TableRow>
            <asp:TableCell><asp:Label runat="server" ID="Label11" Text="C."></asp:Label>&nbsp; <asp:Label runat="server" ID="aOption3Label" Text="Option3"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:Label runat="server" ID="Label13" Text="3."></asp:Label>&nbsp; <asp:Label runat="server" ID="bOption3Label" Text="Option3"></asp:Label></asp:TableCell>
        </asp:TableRow>
         <asp:TableRow>
            <asp:TableCell><asp:Label runat="server" ID="Label15" Text="D."></asp:Label>&nbsp; <asp:Label runat="server" ID="aOption4Label" Text="Option4"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:Label runat="server" ID="Label17" Text="4."></asp:Label>&nbsp; <asp:Label runat="server" ID="bOption4Label" Text="Option4"></asp:Label></asp:TableCell>
        </asp:TableRow>

    </asp:Table>
    
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="orderLabel" runat="server" Text="Order:"></asp:Label>&nbsp;&nbsp; <asp:TextBox runat="server" ID="orderTextBox" Height="16px" Width="142px" ></asp:TextBox><br />
        <br />

    <asp:Button ID="previous" runat="server" Text="Previous" Height="33px" Width="113px" OnClick="previous_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 

    <asp:Button ID="next" runat="server" Text="Next" Height="33px" Width="113px" OnClick="next_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 

    <asp:Button ID="submit" runat="server" Text="Submit" Height="33px" Width="113px" OnClick="submit_Click" OnClientClick="Confirm()" />

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
        <asp:Button runat="server" ID="bookmark" Text="Bookmark" OnClick="bookmark_Click" Height="38px" Width="137px" />
        <asp:Button runat="server" ID="removeBookmark" Text=" Remove" OnClick="removeBookmark_Click" />
    </aside>

</asp:Content>