<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="add_list.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tamrin Slide 02</title>
    <style type="text/css">
        .style1 {
            width: 100%;
            height:200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1" border="1">
            <tr>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server" Height="120px" Width="190px">
                        <asp:ListItem>Roman</asp:ListItem>
                        <asp:ListItem>Aria Black</asp:ListItem>
                        <asp:ListItem>Garamond</asp:ListItem>
                        <asp:ListItem>Somona</asp:ListItem>
                        <asp:ListItem>Symbol</asp:ListItem>
                        <asp:ListItem>Times</asp:ListItem>
                        <asp:ListItem>Helvetica</asp:ListItem>
                        <asp:ListItem>Arial</asp:ListItem>
                    </asp:ListBox>
                </td>
                <td>
                    <asp:Button ID="btnadd" runat="server" Text="&gt;" onclick="btnadd_Click" />
                    <br />
                    <br />
                    <asp:Button ID="btnaddall" runat="server" Text="&gt;&gt;" 
                        onclick="btnaddall_Click" />
                    <br />
                    <br />
                    <asp:Button ID="btndel" runat="server" Text="&lt;" onclick="btndel_Click" />
                    <br />
                    <br />
                    <asp:Button ID="btndelall" runat="server" Text="&lt;&lt;" />
                </td>
                <td>
                    <asp:ListBox ID="ListBox2" runat="server" Height="120px" Width="190px">
                    </asp:ListBox>
                </td>
            </tr>
        </table>

    </div>
    </form>
</body>
</html>
