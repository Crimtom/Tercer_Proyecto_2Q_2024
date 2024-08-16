<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="candidatos.aspx.cs" Inherits="Tercer_Proyecto_2Q_2024.Capa_Vistas.candidatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/StyleCandy.css" rel="stylesheet" />
    <title>Añadir Candidato</title>
</head>
<body style="height: 538px; width: 1187px">
    <form id="form1" runat="server">
        <div style="width: 1205px">
            <header>
                <h2>Añadir Candidato</h2>
            </header>
            <section style="width: 806px; height: 451px">
                <article style="height: 318px">

                    <asp:Label ID="Lb_cedula" runat="server" Text="Cédula" CssClass="title_ced"></asp:Label>
                    <asp:TextBox ID="Txt_cedula" runat="server" CssClass="class_ced"></asp:TextBox>

                    <asp:Label ID="Lb_nombre" runat="server" Text="Nombre" CssClass="title_nom"></asp:Label>
                    <asp:TextBox ID="Txt_nombre" runat="server" CssClass="class_nom"></asp:TextBox>

                    <asp:Label ID="Lb_partido" runat="server" Text="Partido Político" CssClass="title_par"></asp:Label>
                    <asp:TextBox ID="Txt_partido" runat="server" CssClass="class_par"></asp:TextBox>

                    <asp:Label ID="Lb_edad" runat="server" Text="Edad" CssClass="title_eda"></asp:Label>
                    <asp:TextBox ID="Txt_edad" runat="server" CssClass="class_eda"></asp:TextBox>

                    <asp:Label ID="Lb_plataf" runat="server" Text="Plataforma" CssClass="title_pla"></asp:Label>
                    <asp:TextBox ID="Txt_plataf" runat="server" CssClass="class_pla"></asp:TextBox>

                    <asp:Button ID="Boto_candysend" runat="server" Text="Añadir" CssClass="b_candi"/>

                </article>
            </section>
        </div>
    </form>
</body>
</html>
