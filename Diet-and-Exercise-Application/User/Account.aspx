<%@ Page Title="Account Management" Language="C#" MasterPageFile="~/Diet-and-Exercise-Application.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="Diet_and_Exercise_Application.Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <asp:TextBox ID="textboxUsername" runat="server" CssClass="form-control" disabled="disabled" />
    <asp:TextBox ID="textboxPasswordOld" runat="server" CssClass="form-control" TextMode="Password" placeholder="Old Password" />
    <asp:TextBox ID="textboxPasswordNew" runat="server" CssClass="form-control" TextMode="Password" placeholder="New Password" />
    <asp:TextBox ID="textboxPasswordConfirm" runat="server" CssClass="form-control" TextMode="Password" placeholder="Confirm Password" />
</asp:Content>
