<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datagrid1.aspx.cs" EnableEventValidation="false" Inherits="Laboratorio_4_SDH.datagrid1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Laboratorio 4</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gridDetalleFact" runat="server"  
                AutoGenerateColumns="false"
                BackColor="White" 
                BorderColor="#E7E7FF" 
                BorderStyle="None" 
                BorderWidth="1px"
                CellPadding="3"
                GridLines="Horizontal" 
                Height="172px" 
                Width="239px" 
                OnRowDataBound="gridDetalleFact_RowDataBound" 
                OnSelectedIndexChanged="gridDetalleFact_SelectedIndexChanged"
                >
                <Columns>
                    <asp:BoundField DataField="IdFactura" HeaderText="Factura" />
                    <asp:BoundField DataField="numLinea" HeaderText="NumeroLinea" />
                    <asp:BoundField DataField="codProducto" HeaderText="Codigo" />
                    <asp:BoundField DataField="detProducto" HeaderText="Producto" />
                    <asp:BoundField DataField="cantProducto" HeaderText="Cantidad" />
                    <asp:BoundField DataField="costUnitario" HeaderText="Costo" />
                    <asp:BoundField DataField="totalLinea" HeaderText="Total" />
                </Columns>
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>
            <br />
            <br />
            <table>
                <tr>
                    <td>Factura</td>
                    <td><asp:TextBox ID="txtIdFactura" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Número Línea</td>
                    <td><asp:TextBox ID="txtnumLinea" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Código</td>
                    <td><asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Producto</td>
                    <td><asp:TextBox ID="txtProducto" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Cantidad</td>
                    <td><asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Costo</td>
                    <td><asp:TextBox ID="txtCosto" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Total</td>
                    <td><asp:TextBox ID="txtTotal" runat="server"></asp:TextBox></td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
