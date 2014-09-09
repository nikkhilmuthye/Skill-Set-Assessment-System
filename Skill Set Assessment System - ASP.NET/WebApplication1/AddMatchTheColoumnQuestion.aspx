<%@ Page Title="Add Match The Column Question" MasterPageFile="~/Site2.Master" Language="C#" AutoEventWireup="true" CodeBehind="AddMatchTheColoumnQuestion.aspx.cs" Inherits="WebApplication1.AddMatchTheColoumnQuestion" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <fieldset>
            <legend>Add Match The Column Question</legend>
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="examTypeCombo">Exam Type</asp:Label>
                    <asp:DropDownList ID="examTypeCombo" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="formatText">Format</asp:Label>
                    <asp:Textbox ID="formatText" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="solutionText">Solution</asp:Label>
                    <asp:Textbox ID="solutionText" runat="server" />
                    
                </li>
                <li>
                    <asp:Label ID="Label1" runat="server" Text="Column A"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Column B"></asp:Label>
                </li>
                <li>
                    <asp:Label ID="Label3" runat="server" Text="A."></asp:Label>
                    <asp:TextBox ID="aText" runat="server" Height="16px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" Text="1."></asp:Label>
                    <asp:TextBox ID="oneText" runat="server"></asp:TextBox>
                </li>
                <li>
                    <asp:Label ID="Label5" runat="server" Text="B."></asp:Label>
                    <asp:TextBox ID="bText" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label6" runat="server" Text="2."></asp:Label>
                    <asp:TextBox ID="twoText" runat="server"></asp:TextBox>
                </li>
                <li>
                    <asp:Label ID="Label9" runat="server" Text="C."></asp:Label>
                    <asp:TextBox ID="cText" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label10" runat="server" Text="3."></asp:Label>
                    <asp:TextBox ID="threeText" runat="server"></asp:TextBox>
                </li>
                <li>
                    <asp:Label ID="Label7" runat="server" Text="D."></asp:Label>
                    <asp:TextBox ID="dText" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label8" runat="server" Text="4."></asp:Label>
                    <asp:TextBox ID="fourText" runat="server"></asp:TextBox>
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="marksCombo">Marks</asp:Label>
                    <asp:DropDownList ID="marksCombo" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="sectioncomboBox">Section</asp:Label>
                    <asp:DropDownList ID="sectioncomboBox" runat="server" />
                </li>

                    <asp:Button runat="server"  Text="Submit" OnClick="add_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button runat="server" CommandName="Back" Text="Back" OnClick="back_Click" />
             </ol>
        </fieldset>
        
    </div>
    </asp:Content>


