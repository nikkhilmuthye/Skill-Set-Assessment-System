<%@ Page Title="Add Picture Multiple Choice Question" MasterPageFile="~/Site2.Master" Language="C#" AutoEventWireup="true" CodeBehind="AddPictureQuestionMultipleAnswer.aspx.cs" Inherits="WebApplication1.AddPictureQuestionMultipleAnswer" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <article>
    <div style="margin-right: 671px">
        <fieldset>
            <legend>Add Picture Multiple Choice Question</legend>
            <div runat="server" style="margin-right: 224px; height: 777px; width: 416px;">
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="examTypeCombo" Width="304px">Exam Type</asp:Label>
                    <asp:DropDownList ID="examTypeCombo" runat="server" Height="27px" Width="214px" />
                    
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
                    <asp:Label runat="server" AssociatedControlID="option4Text" Width="894px">Option 4</asp:Label>
                    <asp:Textbox ID="option4Text" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="solutionText">Solution</asp:Label>
                    <asp:Textbox ID="solutionText" runat="server" />
                </li>
                <li>
                    <div class="SingleCheckbox">
                        <asp:CheckBox ID="option1Check" runat="server" Text="" />
                        <asp:Label ID="Label3" AssociatedControlID="option1Check" runat="server" 
                            Text="Option1" CssClass="CheckBoxLabel"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        
                    </div>
                    <div class="SingleCheckbox">
                        <asp:CheckBox ID="option2Check" runat="server" Text="" />
                        <asp:Label ID="Label4" AssociatedControlID="option2Check" runat="server" 
                            Text="Option2" CssClass="CheckBoxLabel"></asp:Label>
                    </div>
                    
                </li>
                <li>
                    <div class="SingleCheckbox">
                        <asp:CheckBox ID="option3Check" runat="server" Text="" />
                        <asp:Label ID="Label2" AssociatedControlID="option3Check" runat="server" 
                            Text="Option3" CssClass="CheckBoxLabel"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        
                    </div>
                    <div class="SingleCheckbox">
                        <asp:CheckBox ID="option4Check" runat="server" Text="" />
                        <asp:Label ID="Label1" AssociatedControlID="option4Check" runat="server" 
                            Text="Option4" CssClass="CheckBoxLabel"></asp:Label>
                    </div>
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="marksCombo">Marks</asp:Label>
                    <asp:DropDownList ID="marksCombo" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="sectioncomboBox">Section</asp:Label>
                    <asp:DropDownList ID="sectioncomboBox" runat="server" Height="24px" Width="172px" />
                 
                </li>
             </ol>

            </div>
        </fieldset>
                    
        <asp:Button runat="server"  Text="Submit" OnClick="add_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button runat="server" CommandName="Back" Text="Back" OnClick="back_Click" />
    </div>
    </article>

    <aside>
        <asp:FileUpload ID="fileuploadImage" runat="server" />
        <asp:Button ID="btnUpload" runat="server" Text="Preview" onclick="btnUpload_Click" />

        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "ImageHandler.ashx?ImID="+ Eval("ImageID") %>' Height="150px" Width="150px"/>
    </aside>
    </asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .SingleCheckbox {
            height: 35px;
            width: 146px;
        }
    </style>
</asp:Content>

