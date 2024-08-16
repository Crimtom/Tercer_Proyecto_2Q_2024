<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="candidatos.aspx.cs" Inherits="Tercer_Proyecto_2Q_2024.Capa_Vistas.candidatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/StyleCandy.css" rel="stylesheet" />
    <title>Añadir Candidato</title>
</head>
<body style="height: 538px; width: 599px">
    <form id="form1" runat="server">
        <div>
            <header>
                <h2>Añadir Candidato</h2>
            </header>
            <section>
                <article style="height: 318px">

                    <asp:Label ID="Lb_cedula" runat="server" Text="Cédula"></asp:Label>
                    <asp:TextBox ID="Txt_cedula" runat="server"></asp:TextBox>

                    <asp:Label ID="Lb_nombre" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="Txt_nombre" runat="server"></asp:TextBox>

                    <asp:Label ID="Lb_partido" runat="server" Text="Partido Político"></asp:Label>
                    <asp:TextBox ID="Txt_partido" runat="server"></asp:TextBox>

                    <asp:Label ID="Lb_edad" runat="server" Text="Edad"></asp:Label>
                    <asp:TextBox ID="Txt_edad" runat="server"></asp:TextBox>

                    <asp:Label ID="Lb_plataf" runat="server" Text="Plataforma"></asp:Label>
                    <asp:TextBox ID="Txt_plataf" runat="server"></asp:TextBox>

                    <asp:Button ID="Boto_candysend" runat="server" Text="Añadir" />

                </article>
            </section>
        </div>
    </form>
</body>
</html>
