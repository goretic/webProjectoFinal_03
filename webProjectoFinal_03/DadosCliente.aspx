<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="DadosCliente.aspx.cs" Inherits="webProjectoFinal_03.DadosCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 276px;
        }
        .auto-style3 {
            width: 370px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                    
    <h3>Dados do Cliente</h3>
    <br /> 
    <br />
    <asp:Panel ID="Painel" runat="server" BackColor="White" Enabled="False">
        <table class="auto-style3">
        <tr>
            <td class="auto-style4">Nome:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtNome" runat="server" Width="380px" BackColor="White"></asp:TextBox>
            </td>
            <td rowspan="7">
                <asp:ImageMap ID="ImageMap1" runat="server">
                </asp:ImageMap>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Rua:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtRua" runat="server" Width="380px" BackColor="White"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Localidade:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtLocalidade" runat="server" Width="380px" BackColor="White"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">País:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtPais" runat="server" Width="380px" BackColor="White"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Código Postal:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtCodigoPostal" runat="server" Width="380px" BackColor="White"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">NIF:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtNIF" runat="server" Width="380px" BackColor="White"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Telefone:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtTelefone" runat="server" Width="380px" BackColor="White"></asp:TextBox>
            </td>
        </tr>
                                 
    </table>

    </asp:Panel>
    <br />
    <asp:Button ID="cmdEditar" runat="server" Text="Editar" OnClick="cmdEditar_Click" />
    <asp:Button ID="cmdGravarAlteracao" runat="server" Text="Gravar" Visible="False" OnClick="cmdGravarAlteracao_Click" />
    <asp:Button ID="cmdEliminar" runat="server" Text="Eliminar" OnClick="cmdEliminar_Click" />
    <asp:Button ID="cmdGravarNovo" runat="server" OnClick="cmdGravarNovo_Click" Text="Gravar" />
    <br />
    <br />
    <a href="ListagemClientes.aspx">ListagemClientes.aspx</a><br />
</asp:Content>

