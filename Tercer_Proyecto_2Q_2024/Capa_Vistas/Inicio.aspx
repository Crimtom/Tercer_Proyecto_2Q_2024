<%@ Page Language="C#" MasterPageFile="../MainMenu.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Tercer_Proyecto_2Q_2024.Capa_Vistas.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/StyleStart.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="start_fondo" style="height: 945px; width: 100%;">
            <section class="welcome">
                <article class="weltext" style="height: 244px; width: 774px;">
                    <h1 class="menu_title">Bienvenido al Sistema de Elecciones</h1>
                    <br />
                    En esta aplicación WEB podrá votar por un candidato correspondiente a las elecciones presidenciales actuales.
                </article>
            </section>
        </div>
</asp:Content>