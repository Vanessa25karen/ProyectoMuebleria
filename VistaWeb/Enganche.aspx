<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Enganche.aspx.cs" Inherits="VistaWeb.Enganche" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Renta de Unidades</h1>
    <br />
    <div class="form-group row">
        <div class="col-md-2">
            <asp:Label ID="Label1" runat="server" Text="Id. Cliente:"></asp:Label>
        </div>
        <div class="col-md-10">
            <asp:TextBox ID="txtIdCliente" CssClass="form-control" runat="server" TextMode="Number" Width="416px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnValidarCliente" runat="server" Text="Validar cliente" CssClass="btn btn-primary" OnClick="btnValidarCliente_Click1" />
                &nbsp;<!--OnClick="btnValidarCliente_Click" />-->&nbsp;<asp:RequiredFieldValidator ID="rfvIdCliente" runat="server" ErrorMessage="Id. de cliente es requerido" ControlToValidate="txtIdCliente" CssClass="alert alert-info" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="form-group row">
        <div class="col-md-4">
            <asp:Label ID="Label2" runat="server" Text="Sala disponible:"></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:DropDownList ID="ddVehiculos" CssClass="form-control" runat="server" Width="841px">
                <asp:ListItem Enabled="True">Fancy</asp:ListItem>
                <asp:ListItem Enabled="True">Manchester</asp:ListItem>
                <asp:ListItem Enabled="True">Late</asp:ListItem>
                <asp:ListItem Enabled="True">Pop</asp:ListItem>
            </asp:DropDownList><asp:RequiredFieldValidator ID="rfvVehiculos" runat="server" ErrorMessage="Seleccione la sala a apartar" ControlToValidate="ddVehiculos" CssClass="alert alert-info" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-4">
            &nbsp;</div>
    </div>
    <div class="form-group row">
        <div class="col-md-4">
            <asp:Label ID="Label3" runat="server" Text="Enganche:"></asp:Label>
        </div>
        <div class="col-md-8">
            <asp:TextBox ID="txtInicioRenta" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvInicioRenta" runat="server" ErrorMessage="Cantidad requerida" ControlToValidate="txtInicioRenta" CssClass="alert alert-info" Display="Dynamic"></asp:RequiredFieldValidator>
            <!--<asp:RangeValidator ID="rvInicioRenta" runat="server" ErrorMessage="Cantidad no valida" ControlToValidate="txtInicioRenta" CssClass="alert alert-info" Display="Dynamic" Type="Date"></asp:RangeValidator>-->
        </div>
    </div>
    <div class="form-group row">
        <div class="col-md-4">
        </div>
        <div class="col-md-8">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRentar" CssClass="btn btn-outline-primary" runat="server" Text="Guardar" OnClick="btnRentar_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancelar" CssClass="btn btn-outline-secondary" runat="server" Text="Cancelar" ValidationGroup="grupo1" OnClick="btnCancelar_Click" />
        </div>
    </div>
    <div class="form-group row">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <!--OnClick="btnRentar_Click"-->
        &nbsp;&nbsp;&nbsp; &nbsp;
        <!--OnClick="btnCancelar_Click"--> 
    </div>
    <div class="row">
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>        
    </div>

</asp:Content>
