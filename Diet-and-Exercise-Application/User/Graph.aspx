﻿<%@ Page Title="Graphing Tools" Language="C#" MasterPageFile="~/Diet-and-Exercise-Application.Master" AutoEventWireup="true" CodeBehind="Graph.aspx.cs" Inherits="Diet_and_Exercise_Application.Graph" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <asp:Chart ID="Chart1" runat="server" Palette="None">
        <Series>
            <asp:Series Name="Series1" ChartType="Line" Legend="Legend1">
                <Points>
                    <asp:DataPoint XValue="1" YValues="1" />
                    <asp:DataPoint XValue="2" YValues="2" />
                    <asp:DataPoint XValue="3" YValues="3" />
                    <asp:DataPoint XValue="4" YValues="4" />
                </Points>
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
        </ChartAreas>
        <Legends>
            <asp:Legend Name="Legend1"></asp:Legend>
        </Legends>
    </asp:Chart>
    <script src="../js/chart.js"></script>
</asp:Content>
