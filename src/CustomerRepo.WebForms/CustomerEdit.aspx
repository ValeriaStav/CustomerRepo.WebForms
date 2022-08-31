<%@ Page Title="CustomerEdit" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerEdit.aspx.cs" Inherits="CustomerRepo.WebForms.CustomerEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="form-group">
        <asp:Label Text="First Name" runat="server" />
        <asp:TextBox ID="firstName" CssClass="form-control" runat="server" />
    </div>
    
    <div class="form-group">
        <asp:Label Text="Last Name" runat="server" />
        <asp:TextBox ID="lastName" CssClass="form-control" runat="server" />
    </div>
    
    <div class="form-group">
        <asp:Label Text="Customer Phone Number" runat="server" />
        <asp:TextBox ID="customerPhoneNumber" CssClass="form-control" runat="server" />
    </div>
    
    <div class="form-group">
        <asp:Label Text="Customer Email" runat="server" />
        <asp:TextBox ID="customerEmail" CssClass="form-control" runat="server" />
    </div>
    
    <div class="form-group">
        <asp:Label Text="Total Purchase Amount" runat="server" />
        <asp:TextBox ID="totalPurchaseAmount" CssClass="form-control" runat="server" />
    </div>

    <asp:Button CssClass="btn btn-primary" Text="Save" runat="server" OnClick="OnClickSave" />

</asp:Content>
