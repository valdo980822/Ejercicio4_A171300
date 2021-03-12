<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ejercicio4_a171300.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 223px;
        }
    </style>
</head>
<body style="height: 191px">
    <form id="form1" runat="server">
        <h1>Cuadrado</h1>
        Base<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            Altura<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
          <p>
            Resultado<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Calcular" Width="69px" OnClick="Button1_Click" />
       
        <p>
          
            &nbsp;</p>
        <h1>Triangulo</h1>
        Base<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <p>
            Altura<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            Resultado<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button2" runat="server" Text="Calcular" Width="69px" OnClick="Button2_Click" />
       
        <p>
            &nbsp;</p>
         <h1>Circulo</h1>
        Radio<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <p>
            Resultado<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </p>
       
        <asp:Button ID="Button3" runat="server" Text="Calcular" Width="69px" OnClick="Button3_Click" />
       
        <p>
            &nbsp;</p>
       
    </form>
</body>
</html>
