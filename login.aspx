<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>KUARA</title>
    <style>
        .baslik{top:12% ;left:36% ;position:absolute;color:rgba(100, 0, 0, 0.91); font:47px Elephant, Helvetica, Sans-seri;}
        .tablo{height:220px; width:500px;  top:43%; left:33%; position:absolute;font-style:oblique; border-style:groove; border-color:rgba(100, 0, 0, 0.79); border-radius:13px; background-color:rgba(245, 245, 245, 0.91); text-align:center;}
       .deneme{width:175px; height:25px;}
        .label{color:darkslategray;font-size:20px;}
        .buton {
            top: 78%;
            left: 55%;
            position: absolute;
            font-size: 18px;
            background-color:rgba(100, 0, 0, 0.79);
            border-style:groove;
            color:white;
            border-color:rgba(100, 0, 0, 0.79); width:75px; height:30px;  
        }
        .not{top:130%;left:20%;position:absolute; color:red;}
        .kayit{top: 42%;
            left: 68%;
            position: absolute;
            font-size: 18px;
            border-style:groove; border-color:rgba(100, 0, 0, 0.79);
            background-color:rgba(100, 0, 0, 0.79);
            color:white; 
            width:100px; height:40px;
        }
    </style>
</head>
<body>
  
    <asp:Image ID="Image1" runat="server" ImageUrl="~/image/kuara-1.png" />
    
   <form id="form2" runat="server">
        <div>
         <table class="baslik"> 
             <tr>
                 <td>
                     <h1> KUARA </h1>
                 </td>
             </tr>
         </table>
            <table class="tablo">
                <tr> 
                    <td>
                        <asp:Label ID="Label1" CssClass="label" runat="server" Text="E-MAIL:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="email" CssClass="deneme" runat="server" TextMode="Email"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                <td>
                        <asp:Label ID="Label2" CssClass="label" runat="server" Text="PAROLA:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="sifre" CssClass="deneme" runat="server" TextMode="Password"></asp:TextBox>
                    </td> 
                    
                 </tr>  
                <tr>
                    <td>
                        <asp:Label ID="lblnot" CssClass="not" runat="server" Text=""></asp:Label>

                    </td>
                    
                </tr> 
              <tr> 
                  <td> <asp:Button ID="Button1" CssClass="buton" runat="server" Text="Giriş" OnClick="giris_Click"  /> </td>
                    </tr>
            </table>
          
            
                
            <asp:Button ID="Button2" runat="server" Text="Kayıt ol" CssClass="kayit" OnClick="kayit_Click" />


        </div>
    </form>
</body>
</html>
