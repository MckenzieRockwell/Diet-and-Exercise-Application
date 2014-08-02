<%@ Page Title="Register" Language="C#" MasterPageFile="~/Diet-and-Exercise-Application.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Diet_and_Exercise_Application.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <asp:TextBox ID="textboxUsername" runat="server" CssClass="form-control" placeholder="Username" />
    <asp:TextBox ID="textboxPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Password" />
    <asp:TextBox ID="textboxPasswordConfirm" runat="server" CssClass="form-control" TextMode="Password" placeholder="Confirm Password" />
    <asp:Button ID="buttonRegister" runat="server" CssClass="btn btn-block btn-primary" OnClick="buttonRegister_Click" Text="Register" />
    <asp:Label ID="labelDanger" runat="server" CssClass="alert alert-danger" Visible="false" />
    <asp:RequiredFieldValidator runat="server" ErrorMessage="A username is required. " ControlToValidate="textboxUsername" CssClass="alert alert-warning" />
    <asp:RequiredFieldValidator runat="server" ErrorMessage="A password is required. " ControlToValidate="textboxPassword" CssClass="alert alert-warning" />
    <asp:RequiredFieldValidator runat="server" ErrorMessage="Password confirmation is required. " ControlToValidate="textboxPasswordConfirm" CssClass="alert alert-warning" />
    <asp:CompareValidator runat="server" ErrorMessage="Password confirmation must match password. " ControlToValidate="textboxPasswordConfirm" ControlToCompare="textboxPassword" CssClass="alert alert-warning" />
    <asp:RegularExpressionValidator runat="server" ErrorMessage="A valid email address is required. " ControlToValidate="textboxEmail" ValidationExpression=".+@.+\..+" CssClass="alert alert-warning" />
</asp:Content>
