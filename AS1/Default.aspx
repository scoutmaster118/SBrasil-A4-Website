<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AS1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Assignment 4 </h1>
    </div>


    <div class="row">
        <div class="column">
            <p>How to use:</p>
            <p>1.Type what you want into the input box<br />2.press enter or the submit button<br />3. Press button for desigered output</p>
        </div>
        <div class="column">
            <asp:Button ID="btnGreen" runat="server" Text="Green Text" class="btn btn-success" Width="150" TabIndex="3" />
            <asp:Button ID="btnReversed" runat="server" Text="Reverse words" class="btn btn-danger" Width="150" TabIndex="4" />
            <asp:Button ID="btnBold" runat="server" Text="Bold" class="btn btn-info" Width="60" TabIndex="5"/>
            <asp:Button ID="btnIni" runat="server" Text="Italicize" class="btn btn-warning" Width="150" TabIndex="6" />
            <asp:Button ID="btnB2D" runat="server" Text="B2D" class="btn btn-primary" Width="150" Enabled="false" TabIndex="7"/>
            <asp:Button ID="btnD2B" runat="server" Text="D2B" class="btn btn-primary" Width="150" Enabled="false" TabIndex="8"/>
        </div>
    </div>
    <div class="row">
        <div class="column">
            <asp:Panel runat="server" DefaultButton="btnSubmit" >
                 <asp:TextBox ID="txtInput" runat="server" Height="119px" Width="595px" placeholder="Input your text here" TabIndex="1"></asp:TextBox>
                 <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-primary" Width="150" TabIndex="2"/>
            </asp:Panel>
           
        </div>
        <div class="column">
            <asp:TextBox ID="txtOutput" runat="server" Height="119px" Width="595px" placeholder="output text"></asp:TextBox>
            
        </div>
    </div>
    <div class="row">
        <div class="column">
            <asp:Label ID="lblsubmit" runat="server"></asp:Label>
        </div>
        <div class="column">
        </div>
    </div>








</asp:Content>
