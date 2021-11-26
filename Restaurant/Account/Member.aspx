<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Restaurant.Account.Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 779px;
            width: 1032px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <h2>  Welcome <asp:Label ID="UserLabel" runat="server" Text=""></asp:Label>, you can start your order!</div>
         </h2>

    <h3>
        Menu
    </h3>
        <asp:ListBox ID="ListBox1" runat="server" Height="169px" Width="400px"></asp:ListBox>
        <br />
        <br />
     
        <asp:Button ID="ShowDetailBtn" runat="server" Text="Show Detail" OnClick="ShowDetailBtn_Click" Width="160px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="AddToCartBtn" runat="server" Text="Add to the Cart" Width="160px" OnClick="AddToCartBtn_Click" />
        <br />
        <br />
        <br />
        <asp:Label ID="NameLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="DescriptionLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="PriceLabel" runat="server"></asp:Label>
        <br />
       <h3>My Cart</h3>
        <p>
        <asp:ListBox ID="ListBox2" runat="server" Height="169px" Width="400px"></asp:ListBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Total Amount:"></asp:Label>
            <asp:Label ID="TotalAmountLabel" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Remove selected item" />
        </p>
        <p>&nbsp;</p>
    </form>
        
    </body>
</html>
