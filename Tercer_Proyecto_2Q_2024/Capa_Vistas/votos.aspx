<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="votos.aspx.cs" Inherits="Tercer_Proyecto_2Q_2024.Capa_Vistas.votos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/StyleVoto.css" rel="stylesheet" />
    <title>Votar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
                <h2>Votar</h2>
                <section>
                    <article>
                    
                        <asp:Label ID="Lb_Vcedula" runat="server" Text="Cédula"></asp:Label>
                        <asp:TextBox ID="Txt_Vcedula" runat="server"></asp:TextBox>

                        <asp:Label ID="Lb_Vnombre" runat="server" Text="Nombre"></asp:Label>
                        <asp:TextBox ID="Txt_Vnombre" runat="server"></asp:TextBox>

                        <asp:Label ID="Lb_Vedad" runat="server" Text="Edad"></asp:Label>
                        <asp:TextBox ID="Txt_Vedad" runat="server"></asp:TextBox>

                        <asp:Label ID="Lb_candid" runat="server" Text="Candidato a Votar"></asp:Label>
                        <asp:TextBox ID="Txt_candid" runat="server"></asp:TextBox>

                        <asp:Button ID="Boto_votar" runat="server" Text="Votar" />

                    </article>
                </section>
            </header>
        </div>
    </form>
</body>
</html>
