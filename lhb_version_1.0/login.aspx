<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/0Main.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="lhb_version_1._0.Views.Page.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="left">
        <table>
            <tr>
                <td>
                    <asp:label runat="server" text="User I.D."></asp:label></td>
                <td>
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="name" ErrorMessage="Enter your I.D." ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td><asp:label runat="server" text="Pass Key"></asp:label></td>
                <td>
                    <asp:TextBox ID="pass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="pass" ErrorMessage="Enter your Key" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF3300" HeaderText="Please" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        <br />
    </div>
</asp:Content>