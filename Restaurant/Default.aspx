<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Restaurant._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<h2>
    Welcome To Our Restaurant!
</h2>
   
        <asp:Button ID="HomeBtn" runat="server" Text="Restaurant Home" Width="500px" OnClick="HomeBtn_Click" />
    
    <br />
    <br />
    <asp:Button ID="MemberRegisterBtn" runat="server" Text="Member Register" Width="150px" OnClick="MemberRegisterBtn_Click" /> &nbsp;
    <asp:Button ID="MemberLoginBtn" runat="server" Text="Member Login" Width="150px" OnClick="MemberLoginBtn_Click" />
    <br />
    <br />
    <asp:Button ID="StaffPageBtn" runat="server" Text="Staff Page" Width="150px" OnClick="StaffPageBtn_Click" /> &nbsp;
    <asp:Button ID="StaffLoginBtn" runat="server" Text="Staff Login" Width="150px" OnClick="StaffLoginBtn_Click" />
</asp:Content>
