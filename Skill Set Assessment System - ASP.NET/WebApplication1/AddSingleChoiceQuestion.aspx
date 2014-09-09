<%@ Page Title="Add Single Choice Question" MasterPageFile="~/Site2.Master"  Language="C#" AutoEventWireup="true" CodeBehind="AddSingleChoiceQuestion.aspx.cs" Inherits="WebApplication1.AddSingleChoiceQuestion" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <fieldset>
            <legend>Add Single Choice Question</legend>
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="examTypeCombo">Exam Type</asp:Label>
                    <asp:DropDownList ID="examTypeCombo" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="questionText">Question</asp:Label>
                    <asp:Textbox ID="questionText" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="formatText">Format</asp:Label>
                    <asp:Textbox ID="formatText" ReadOnly="true" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="option1Text">Option 1</asp:Label>
                    <asp:Textbox ID="option1Text" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="option2Text">Option 2</asp:Label>
                    <asp:Textbox ID="option2Text" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="option3Text">Option 3</asp:Label>
                    <asp:Textbox ID="option3Text" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="option4Text">Option 4</asp:Label>
                    <asp:Textbox ID="option4Text" runat="server" />
                </li>
                <li>
                    <label runat="server">Solution --></label>
                    <div>
                        <asp:RadioButton GroupName="answer" ID="option1Radio" runat="server" Text="" />
                        <asp:Label ID="Label3" AssociatedControlID="option1Radio" runat="server" 
                            Text="Option1" CssClass="radio" ></asp:Label>
                        
                    </div>
                    <div>
                        <asp:RadioButton GroupName="answer" ID="option2Radio" runat="server" Text="" />
                        <asp:Label ID="Label4" AssociatedControlID="option2Radio" runat="server" 
                            Text="Option2" CssClass="radio" ></asp:Label>
                    </div>
                    
                </li>
                <li>
                    <div>
                        <asp:RadioButton GroupName="answer" ID="option3Radio" runat="server" Text="" />
                        <asp:Label ID="Label2" AssociatedControlID="option3Radio" runat="server" 
                            Text="Option3" CssClass="radio"></asp:Label>
                            
                    </div>
                    <div>
                        <asp:RadioButton GroupName="answer" ID="option4Radio" runat="server" Text="" />
                        <asp:Label ID="Label1" AssociatedControlID="option4Radio" runat="server" 
                            Text="Option4" CssClass="radio"></asp:Label>
                    </div>
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="marksCombo">Marks</asp:Label>
                    <asp:DropDownList ID="marksCombo" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="sectioncomboBox">Section</asp:Label>
                    <asp:DropDownList ID="sectioncomboBox" runat="server" />
                    <br />
                    <br />
                    <br />
                    <asp:Button runat="server"  Text="Submit" OnClick="add_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button runat="server" CommandName="Back" Text="Back" OnClick="back_Click" />
                </li>
             </ol>
        </fieldset>
        
    </div>
    </asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .SingleCheckbox {
            height: 35px;
            width: 146px;
        }
    </style>
</asp:Content>

