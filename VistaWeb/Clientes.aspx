<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="VistaWeb.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
    <div class="form-group row">
        <div class="col-md-4">
            <asp:Label ID="Label3" runat="server" Text="id Cliente:"></asp:Label>
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtidCliente" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click1" />
        </div>
    </div>

    <div class="form-group row">
        <div class="col-md-4">
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    </div>

    <div class="form-group row">
        <div class="col-md-4">
            <asp:Label ID="Label2" runat="server" Text="Telefono:"></asp:Label>
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnMostrar" runat="server" Text="Mostrar" CssClass="btn btn-primary" OnClick="btnValidarCliente_Click1" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="BtnGuardar_Click1" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" CssClass="btn btn-primary" OnClick="BtnActualizar_Click1" />
            <br />
            <br />
            <asp:GridView ID="DgClientes" runat="server" OnSelectedIndexChanged="DgClientes_SelectedIndexChanged" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="None" Width="600px" HorizontalAlign="Justify" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False">
                <Columns>
                    <asp:BoundField DataField="idCliente" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" ReadOnly="True" />
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" ReadOnly="True" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <br />
        </div>
    </div>
                     </center>
</asp:Content>
