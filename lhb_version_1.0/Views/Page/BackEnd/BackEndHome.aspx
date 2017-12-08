<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/0Main.Master" AutoEventWireup="true" CodeBehind="BackEndHome.aspx.cs" Inherits="lhb_version_1._0.Views.Page.BackEnd.BackEndHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color:cornflowerblue; width:24%;position:absolute;height:100%">
    </div>
    
    <div style="width:74%; position:absolute;left: 25%;height:100%">
        <div style="width:inherit; height:auto">

            <asp:RadioButton ID="RadioButton1" runat="server" />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server">ID</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

        </div>
    </div>
</asp:Content>
