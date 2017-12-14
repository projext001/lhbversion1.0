<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/0Main.Master" AutoEventWireup="true" CodeBehind="DBAdminHome.aspx.cs" Inherits="lhb_version_1._0.Views.Page.DBAdmin.DBAdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: 22px;
            color:red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="background-color:cornflowerblue; width:24%;position:absolute;height:100%">
            <ul>
                <li><a href="">LOGIN TO DB</a></li>
                <ul>
                    <li><a href="">EXECUTE QUERY</a></li>
                </ul>
                <li><a href="">CHECK STATUS</a></li>
            </ul>
    </div>
    <div style="width:74%; position:absolute;left: 25%;height:100%">
        DBADMIN<br />
        <br />
        <asp:TextBox ID="querybox" runat="server" Width="90%" style="align-self:center;"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Exec" runat="server" Text="Execute Simple Query" OnClick="Exec_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Upd" runat="server" Text="Execute Update" OnClick="Upd_Click" />
            <br />
        <br />
        <h3><span class="auto-style1">Note:</span><br class="auto-style1" />
            <span class="auto-style1">&nbsp;&nbsp;&nbsp; Do Not Execute Update using "Execute Simple Query" Button. It will return errors </span></h3>
        </div>
</asp:Content>
