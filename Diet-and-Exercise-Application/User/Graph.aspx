<%@ Page Title="Graphing Tools" Language="C#" MasterPageFile="~/Diet-and-Exercise-Application.Master" AutoEventWireup="true" CodeBehind="Graph.aspx.cs" Inherits="Diet_and_Exercise_Application.Graph" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <asp:Chart ID="chart" runat="server" Palette="None">
        <ChartAreas>
            <asp:ChartArea Name="area"></asp:ChartArea>
        </ChartAreas>
        <Legends>
            <asp:Legend Name="legend"></asp:Legend>
        </Legends>
    </asp:Chart>
</asp:Content>
