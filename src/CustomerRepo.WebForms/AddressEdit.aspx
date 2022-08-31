<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddressEdit.aspx.cs" Inherits="CustomerRepo.WebForms.AddressEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div>
        <div class="form-group">
            <asp:Label Text="Customer Id" runat="server"></asp:Label>
            <asp:TextBox ID="customerId" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label Text="Address line 1" runat="server"></asp:Label>
            <asp:TextBox ID="addressLine1" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label Text="Address line 2" runat="server"></asp:Label>
            <asp:TextBox ID="addressLine2" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label Text="Address type" runat="server"></asp:Label>
            <asp:TextBox ID="addressType" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label Text="City" runat="server"></asp:Label>
            <asp:TextBox ID="city"  class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label Text="Postal Code" runat="server"></asp:Label>
            <asp:TextBox ID="postalCode" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label Text="State" runat="server"></asp:Label>
            <asp:TextBox ID="state" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label Text="Country" runat="server"></asp:Label>
            <asp:TextBox ID="country" class="form-control" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Button class="btn btn-primary" Text="Save" runat="server" OnClick="OnClickSave"/>
        </div>
    </div>

</asp:Content>
