<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KullaniciGiris.aspx.cs" Inherits="recyclecoin.KullaniciEkle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="styles/font-awesome2.css" rel="stylesheet" />
    <link href="styles/style2.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <h1>kULLANICI GİRİŞ </h1>
	<div class="clear-loading spinner">
		<span></span>
	</div>
	<div class="w3ls-login box box--big">
		<!-- form starts here -->
		</div>
			<div class="agile-field-txt">
				<asp:Label ID="Label1" runat="server" ForeColor="White" Text="Kullanıcı Adı:"></asp:Label>
				<label>&nbsp;</label>&nbsp;<asp:TextBox ID="txtKadi" runat="server" style="margin-left: 20px; margin-top: 0px;" OnTextChanged="txtKadi_TextChanged"></asp:TextBox>
			</div>
			<div class="agile-field-txt">
				<asp:Label ID="Label2" runat="server" ForeColor="White" Text="Şifre:"></asp:Label>
                <label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>
&nbsp;<div class="agile_label">
                    <a href="#"></a>
                </div>
                <asp:TextBox ID="txtSifre" runat="server" TextMode="Password"></asp:TextBox>
			</div>
			<!-- script for show password -->
			<script>
                function myFunction() {
                    var x = document.getElementById("myInput");
                    if (x.type === "password") {
                        x.type = "text";
                    } else {
                        x.type = "password";
                    }
                }
            </script>
			<!-- //end script -->
				<asp:Button ID="Button2" runat="server" Height="23px" OnClick="Button2_Click" style="margin-left: 0px" Text="Kayıt sayfası git" Width="138px" />
				<label><i class="fa fa-unlock-alt" aria-hidden="true">
        <asp:Button ID="Button1" runat="server" Text="Giris yap" Width="159px" OnClick="Button1_Click" />
        </i> </label>
				
		</form>
	</div>
	<!-- //form ends here -->
	<!--copyright-->
	<div class="copy-wthree">
		<p>&nbsp;
</body>
</html>
