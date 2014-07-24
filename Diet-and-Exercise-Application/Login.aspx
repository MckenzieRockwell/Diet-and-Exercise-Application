﻿<%@ Page Title="Login" Language="C#" MasterPageFile="~/Diet-and-Exercise-Application.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Diet_and_Exercise_Application.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <asp:Literal ID="literalStatusMessage" runat="server" />
    <asp:TextBox ID="textboxUsername" runat="server" CssClass="form-control" placeholder="Username" />
    <asp:TextBox ID="textboxPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Password" />
    <asp:Button ID="buttonLogin" runat="server" CssClass="btn btn-block btn-primary" OnClick="buttonLogin_Click" Text="Login" />
</asp:Content>
