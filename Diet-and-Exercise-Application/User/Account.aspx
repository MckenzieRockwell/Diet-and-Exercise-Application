<%@ Page Title="Account Management" Language="C#" MasterPageFile="~/Diet-and-Exercise-Application.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="Diet_and_Exercise_Application.Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h2 id="username" runat="server" />
    <asp:TextBox ID="textboxEmail" runat="server" CssClass="form-control" autocomplete="off" placeholder="Email" />
    <asp:TextBox ID="textboxPhone" runat="server" CssClass="form-control" TextMode="Phone" autocomplete="off" placeholder="Phone" />
    <asp:TextBox ID="textboxPasswordNew" runat="server" CssClass="form-control" TextMode="Password" autocomplete="off" placeholder="New Password" />
    <asp:TextBox ID="textboxPasswordConfirm" runat="server" CssClass="form-control" TextMode="Password" autocomplete="off" placeholder="Confirm New Password" />
    <hr />
    <asp:TextBox ID="textboxPassword" runat="server" CssClass="form-control" TextMode="Password" autocomplete="off" placeholder="Current Password" />
    <asp:Button ID="buttonSave" runat="server" CssClass="btn btn-block btn-primary" OnClick="buttonSave_Click" Text="Save Changes" />
    <div id="status" runat="server" />
    <asp:RegularExpressionValidator runat="server" ErrorMessage="A valid email address is required. " ControlToValidate="textboxEmail" ValidationExpression=".+@.+\..+" CssClass="alert alert-warning" />
    <asp:RequiredFieldValidator runat="server" ErrorMessage="Your current password is required to save changes. " ControlToValidate="textboxPassword" CssClass="alert alert-warning" />
    <asp:CompareValidator runat="server" ErrorMessage="New password confirmation must match new password. " ControlToValidate="textboxPasswordConfirm" ControlToCompare="textboxPasswordNew" CssClass="alert alert-warning" />
</asp:Content>
