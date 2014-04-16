<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="ListagemClientes.aspx.cs" Inherits="webProjectoFinal_03.ListagemClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="ddtopo">
        <h5>Listagem de Clientes</h5>
    </div>
    
    <asp:Button ID="cmdNovoCliente" runat="server" Text="Novo" OnClick="cmdNovoCliente_Click" />

    <div id="ddcont">
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ClientePK" DataSourceID="EntityDataSource1" Height="90px" Width="488px">
            <Columns>
                <asp:BoundField DataField="ClientePK" HeaderText="ClientePK" ReadOnly="True" SortExpression="ClientePK" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                <asp:BoundField DataField="Rua" HeaderText="Rua" SortExpression="Rua" />
                <asp:BoundField DataField="Localidade" HeaderText="Localidade" SortExpression="Localidade" />
                <asp:BoundField DataField="Pais" HeaderText="Pais" SortExpression="Pais" />
                <asp:BoundField DataField="CodigoPostal" HeaderText="CodigoPostal" SortExpression="CodigoPostal" />
                <asp:BoundField DataField="NIF" HeaderText="NIF" SortExpression="NIF" />
                <asp:BoundField DataField="Telefone" HeaderText="Telefone" SortExpression="Telefone" />
                <asp:HyperLinkField DataNavigateUrlFields="ClientePK" DataNavigateUrlFormatString="~/DadosCliente.aspx?id={0}" HeaderText="Ver" Text="Detalhes" />
            </Columns>
        </asp:GridView>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=dbEntities" DefaultContainerName="dbEntities" EnableFlattening="False" EntitySetName="Cliente">
        </asp:EntityDataSource>
        <br />
        <br />
        <br />
    </div>
</asp:Content>

