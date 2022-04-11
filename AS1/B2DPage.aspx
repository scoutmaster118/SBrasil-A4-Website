<%@ Page Title="B2D" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="B2DPage.aspx.cs" Inherits="AS1.MainPage" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<!DOCTYPE html>


<html>
<head>
    <title></title>
</head>
<body>
<div class="jumbotron">
        <h1>Assignment 2 </h1>
    </div>


    <div class="row">
        <div class="column">
            <asp:Button ID="btnNumSubmit" runat="server" Text="Submit Number" Width="178px" class="btn btn-primary" />
        </div>
        <div class="column">
            <asp:Button ID="btnB2D" runat="server" Text="B2D" class="btn btn-primary" Width="150" Enabled="false"/>
            <asp:Button ID="btnD2B" runat="server" Text="D2B" class="btn btn-primary" Width="150" Enabled="false" />
            
        </div>
    </div>
    <div class="row">
        <div class="column">
            <asp:TextBox ID="txtInput" runat="server" Height="119px" Width="595px" placeholder="Input your number here"></asp:TextBox>
            
        </div>
        <div class="column">
            <asp:TextBox ID="txtOutput" runat="server" Height="119px" Width="595px" placeholder="output number"></asp:TextBox>
            
        </div>
    </div>
    <div class="row">
        <div class="column">
            <asp:Label ID="lblsubmit" runat="server"></asp:Label>
        </div>
        <div class="column">
        </div>
    </div>
</body>
</html>
    

</asp:Content>