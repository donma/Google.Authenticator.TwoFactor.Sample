<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sample.aspx.cs" Inherits="Google.Authenticator.Create.Sample.sample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <li>AccountSecretKey :
                    <asp:Literal ID="ltlAccountSecretKey" runat="server"></asp:Literal>
                </li>

                <li>Qr Code for USER :
                    <asp:Literal ID="ltlQRCode" runat="server"></asp:Literal>
                </li>

                <li>Qr Code content :
                    <asp:Literal ID="ltlQRCodeContent" runat="server"></asp:Literal>
                </li>

                <li>Qr Code content :
                    <asp:TextBox ID="txtUserType" runat="server"></asp:TextBox>
                    <asp:Button ID="btnValid" runat="server" Text="User Valid" OnClick="btnValid_Click" />
                    <asp:Literal ID="ltlResult" runat="server"></asp:Literal>
                </li>
            </ul>
        </div>
    </form>
</body>
</html>
