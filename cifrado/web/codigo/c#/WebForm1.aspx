<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            width: 839px;
            height: 434px;
        }
    </style>
</head>
<body style="height: 454px">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="TEXTO PLANO"></asp:Label>
        <p style="width: 259px">
            <asp:TextBox ID="textoPlano" runat="server" OnTextChanged="TextBox1_TextChanged" Width="235px" OnDataBinding="textoPlano_DataBinding" onkeyup="" AutoPostBack="True"></asp:TextBox>
&nbsp;&nbsp;
        </p>
        <asp:Panel ID="Panel1" runat="server" BackColor="#66FFFF" Height="121px" HorizontalAlign="Left" Width="278px">
            <asp:Label ID="Label2" runat="server" Text="CESAR"></asp:Label>
            <br />
            <br />
            &nbsp;<asp:Label ID="Label3" runat="server" Text="DESPLAZAMIENTO"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
                        
            
            
            <asp:TextBox ID="TextBox2" runat="server" Height="16px" style="margin-left: 7px" Width="64px"></asp:TextBox>
            <br />
            CIFRADO&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="134px"></asp:TextBox>
            <br />
            &nbsp;&nbsp;<br /> &nbsp;<asp:Panel ID="Panel2" runat="server" BackColor="#FF66CC" Height="85px">
                INVERSO<br />
                <br />
                CIFRADO
                <asp:TextBox ID="inverso" runat="server" Width="189px"></asp:TextBox>
                <br />
                <asp:Panel ID="Panel3" runat="server" BackColor="#CCCC00">
                    INVERSO GRUPAL<br /> GRUPO&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <br />
                    CIFRADO&nbsp;
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </asp:Panel>
                <asp:Button ID="Button1" runat="server" Text="OK" />
            </asp:Panel>
            
            
            
            </asp:Panel>

    </form>
</body>
</html>
