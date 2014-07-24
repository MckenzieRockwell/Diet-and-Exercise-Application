<%@ Page Title="Graphing Tools" Language="C#" MasterPageFile="~/Diet-and-Exercise-Application.Master" AutoEventWireup="true" CodeBehind="Graph.aspx.cs" Inherits="Diet_and_Exercise_Application.Graph" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <asp:Chart ID="Chart1" runat="server" Width="256" Height="256">
        <Series>
            <asp:Series Name="Series1" ChartType="Pie" Legend="Legend1">
                <Points>
                    <asp:DataPoint YValues="1" />
                    <asp:DataPoint YValues="2" />
                    <asp:DataPoint YValues="3" />
                    <asp:DataPoint YValues="4" />
                </Points>
            </asp:Series>
        </Series>
        <Legends>
            <asp:Legend Name="Legend1"></asp:Legend>
        </Legends>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
</asp:Content>
