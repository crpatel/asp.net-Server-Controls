<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDropDown.aspx.cs" Inherits="DropDownList.frmDropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Drop Down List from Database<br />
            <asp:DropDownList ID="DropDownList1" DataValueField="pkCity" DataTextField="CityName" runat="server">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
