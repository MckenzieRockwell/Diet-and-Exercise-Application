﻿<%@ Page Title="Add a Meal" Language="C#" MasterPageFile="~/Diet-and-Exercise-Application.Master" AutoEventWireup="true" CodeBehind="AddMeal.aspx.cs" Inherits="Diet_and_Exercise_Application.AddMeal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
        <div>
        <div id="MealEntrycontroldiv" class="outerbox">
            <div id ="selectmealcontrolbox"> 

                <asp:UpdatePanel ID="UpdatePanel1" runat="server">

                    <ContentTemplate>

                        <asp:Label ID="Label1" runat="server" Text="Select a meal"/>
                        <asp:DropDownList ID="savedMealSelect" runat="server"/>

                        <asp:Label ID="Label2" runat="server" Text="log meal"></asp:Label>
                        <asp:Button ID="logmealbtn_dd" runat="server" Text="log meal" />

                    </ContentTemplate>

                </asp:UpdatePanel>

            </div>


            <div id="NewMealcontrolbox" class="outerbox">
                <div id="creatMealAsisted" class="innerbox">
                    <div id="mealcomponentBox" class="innerMost">
                    <asp:UpdatePanel ID="UpdatePanelMealcompFoodGroup" runat="server">
                        <ContentTemplate>
                            <asp:Label ID="FoodgroupLabel" runat="server" Text="select a food group"></asp:Label>
                            <asp:DropDownList ID="FoodGroupSelect" runat="server"/>
                        </ContentTemplate>
                    </asp:UpdatePanel>

                    <asp:UpdatePanel ID="UpdatePanelMealcompfood" runat="server" Visible="False" EnableViewState="False">
                        <ContentTemplate>
                            <asp:DropDownList ID="MealComponentSelect" runat="server"/>
                            <asp:TextBox ID="quantorportion" runat="server"></asp:TextBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    </div>
                    <div id="Div1" class="mealComponenet">
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:Label ID="Label3" runat="server" Text="select a food group"></asp:Label>
                            <asp:DropDownList ID="DropDownList1" runat="server"/>
                        </ContentTemplate>
                    </asp:UpdatePanel>

                    <asp:UpdatePanel ID="UpdatePanel3" runat="server" Visible="False" EnableViewState="False">
                        <ContentTemplate>
                            <asp:DropDownList ID="DropDownList2" runat="server"/>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    </div>



                    <div id="SaveAMealforTesting">
                        <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                            <ContentTemplate>

                                <asp:Label ID="SaveAMealLabel" runat="server" Text="Save a meal of for quick selection" ></asp:Label>
                                <asp:TextBox ID="proteintxtb" runat="server" placeholder="Grams of protein" OnTextChanged="updateCalSum" AutoPostBack="true"></asp:TextBox>
                                <asp:TextBox ID="carbstxtb" runat="server" placeholder="Grams of carbs" OnTextChanged="updateCalSum" AutoPostBack="true"></asp:TextBox>
                                <asp:TextBox ID="fattxtb" runat="server" placeholder="grams of fat" OnTextChanged="updateCalSum" AutoPostBack="true"></asp:TextBox>
                                <asp:Label ID="calsumlabel" runat="server" Text="Label"></asp:Label>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>



                    <asp:UpdatePanel ID="newMealcomponentSlot" runat="server">
                        <Triggers>
                            <asp:AsyncPostBackTrigger EventName="Click" ControlID="AddMealComponent" />
                        </Triggers>
                        <ContentTemplate>
                            <asp:Label ID="newddlID" runat="server" Text="Label"></asp:Label>
                        </ContentTemplate>
                    </asp:UpdatePanel>


                    <div>
                        <asp:Button ID="AddMealComponent" runat="server" Text="Add a meal component" OnClick="AddMealComponent_Click" />
                    </div>

                </div>



                <div id="creatMealDirectInput" class="innerbox">
                    <asp:TextBox ID="carbInput" runat="server"></asp:TextBox>
                    <asp:TextBox ID="fatInput" runat="server"></asp:TextBox>
                    <asp:TextBox ID="protienInput" runat="server"></asp:TextBox>
                    <asp:TextBox ID="QuantityInput" runat="server"></asp:TextBox>       
                </div>

                <div id="creatamealsummarybox" class="innerbox">
                    Meal nutrient summary
                    <asp:Label ID="CalorieSumLabel" runat="server" Text="Label"></asp:Label>
                    <asp:Label ID="CarbSumlabel" runat="server" Text="Label"></asp:Label>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>

                </div>

                <asp:Button ID="SaveMeal" runat="server" Text="Save Meal" />
                <asp:Button ID="SaveAndLogMeal" runat="server" Text="Save and log meal" />
                <asp:Button ID="LogAndDiscardMeal" runat="server" Text="Log and discard meal" />
                <asp:Button ID="clearInputs" runat="server" Text="Clear Inputs" />

            </div>
            
        </div>
    </div>
</asp:Content>
