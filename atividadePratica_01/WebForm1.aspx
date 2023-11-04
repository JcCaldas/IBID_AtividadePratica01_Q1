<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="atividadePratica_01.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculadora</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="position:center">
            <asp:Label ID="Label1" runat="server" Text="Calculadora"></asp:Label>
        </div>
        <br />
        Insira o primeiro número: <asp:TextBox ID="txtPrimeiroNumero" runat="server" ToolTip="Primeiro Número"></asp:TextBox>
        <br />
        <br />
        Insira o segundo número:
        <asp:TextBox ID="txtSegundoNumero" runat="server"></asp:TextBox>
        <br />
        <br />
        Escolha a operação a baixo:<br />
        <br />
        <asp:DropDownList ID="ddlOperacoes" runat="server" OnSelectedIndexChanged="ddlOperacoes_SelectedIndexChanged">
            <asp:ListItem Value="0">-- Selecione a operação --</asp:ListItem>
            <asp:ListItem Value="1">Soma</asp:ListItem>
            <asp:ListItem Value="2">Subtração</asp:ListItem>
            <asp:ListItem Value="3">Divisão</asp:ListItem>
            <asp:ListItem Value="4">Multiplicação</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
        <br />
        <br />
        <asp:Label ID="lblResultadoNaTela" runat="server"></asp:Label>
    </form>
</body>
</html>
