<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="NovoDocumento.aspx.cs" Inherits="webProjectoFinal_03.NovoDocumento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-size: small;
        }
        .auto-style3 {
            width: 62px;
        }
        .auto-style6 {
            width: 289px;
        }
        .auto-style8 {
            width: 62px;
            height: 25px;
        }
        .auto-style9 {
            width: 289px;
            height: 25px;
        }
        .auto-style10 {
            height: 25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <p>
        <strong><span class="auto-style2">Criar Novo Documento</span><br class="auto-style2" />
        </strong>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Série:</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="cmbSerie" runat="server" DataSourceID="SerieDS" DataTextField="Descricao" DataValueField="SeriePK">
                    </asp:DropDownList>
                    <asp:TextBox ID="txtNumero" runat="server" style="margin-bottom: 0px" Width="61px"></asp:TextBox>
                    <asp:EntityDataSource ID="SerieDS" runat="server" ConnectionString="name=dbEntities" DefaultContainerName="dbEntities" EnableFlattening="False" EntitySetName="Serie" Select="it.[SeriePK], it.[Descricao], it.[Numero]">
                    </asp:EntityDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Cliente:</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="EntityDataSourceCliente" DataTextField="Nome" DataValueField="ClientePK">
                    </asp:DropDownList>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <asp:EntityDataSource ID="EntityDataSourceCliente" runat="server" ConnectionString="name=dbEntities" DefaultContainerName="dbEntities" EnableFlattening="False" EntitySetName="Cliente" Select="it.[ClientePK], it.[Nome]">
                    </asp:EntityDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">Data:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6" style="text-align: right">Total:</td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtTotal" runat="server" style="text-align: left"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            </table>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Código" />
                <asp:BoundField HeaderText="Nome" />
                <asp:BoundField HeaderText="Qtd." />
                <asp:BoundField HeaderText="Preço" />
                <asp:BoundField HeaderText="IVA" />
                <asp:BoundField HeaderText="Valor iva" />
                <asp:BoundField HeaderText="Total Iva" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        grid</p>
    <p>
    </p>
</asp:Content>

