<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CalculadoraWSWeb._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center; height: 80px;">
    
        <p>
    
        <asp:Label ID="Label1" runat="server" Text="Calculadora" style="font-size: xx-large"></asp:Label>
           
        </p>
        <br />
           
    </div>

        <div class="auto-style1" style="height: 185px">


            <br />
            &nbsp;<asp:Label ID="Label2" runat="server" Text="Digite el número 1"></asp:Label>
&nbsp;<asp:TextBox ID="Txt_numero1" runat="server" style="margin-left: 0px" Width="78px"></asp:TextBox>
&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Txt_numero1" ErrorMessage="Por Favor, Digite solo Numeros " ValidationExpression="^[0-9]*$">*</asp:RegularExpressionValidator>
            &nbsp;
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Digite el número 2"></asp:Label>
&nbsp;<asp:TextBox ID="Txt_numero2" runat="server" Width="79px"></asp:TextBox>
&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Txt_numero2" ErrorMessage="Ingrese solo numeros" ValidationExpression="^[0-9]*$">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="Btn_sumar" runat="server" OnClick="Btn_sumar_Click" Text="+" Width="36px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn_Restar" runat="server" OnClick="Btn_Restar_Click" Text="-" Width="35px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn_multiplicar" runat="server" OnClick="Btn_multiplicar_Click" Text="*" Width="35px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn_dividir" runat="server" OnClick="Button1_Click" Text="/" Width="35px" />
            <br />
            <br />
            Resultado&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Lb_resultado" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            <strong>Nota:</strong> Por favor solo ingresar Numeros<br />
            <br />
            <asp:Label ID="Lb_numero" runat="server"></asp:Label>
            <br />
            <br />
            <br />
        


        </div>

    </form>
</body>
</html>
