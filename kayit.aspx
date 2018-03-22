<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kayit.aspx.cs" Inherits="kayit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>KUARA</title>
  
  
  

      
    <style type="text/css">
        
         .baslik{top:12% ;left:36% ;position:absolute;color:rgba(100, 0, 0, 0.91); font:47px Elephant, Helvetica, Sans-seri;}
        .tablo {
            top: 40%;
            left: 33%;
            position: absolute;
            border-style:groove;
            border-color: rgba(100, 0, 0, 0.79);
            border-radius: 15px;
            height:400px; width:500px;
            text-align:center;
             background-color:rgba(245, 245, 245, 0.91); 
             
        }
        .box{  width:175px; height:25px;}
        .label{color:darkslategray;font-size:20px;}
        .button {
            top: 81%;
            left: 55%;
            position: absolute;
            font-size: 18px;
            background-color:rgba(100, 0, 0, 0.79);
            border-style:groove;
            color:white;
            border-color:rgba(100, 0, 0, 0.79); width:95px; height:35px;  
        }
    </style>
  
  
</head>
<body>
     <asp:Image ID="Image1" runat="server" ImageUrl="~/image/kuara-1.png" />
    <form id="form1" runat="server">
    <div>
    <table class="baslik"> 
             <tr>
                 <td>
                     <h1> KUARA </h1>
                 </td>
             </tr>
         </table>
        <table class="tablo">
            <tr><td>
                <asp:Label ID="Label1" runat="server" Text="Adınız:" CssClass="label"></asp:Label></td><td></td><td>
                    <asp:Label ID="Label2" runat="server" Text="Soyadınız:"  CssClass="label" ></asp:Label></td></tr>
       
            <tr><td>
                <asp:TextBox ID="ad"  CssClass="box" runat="server" ></asp:TextBox>  </td><td></td>
                
                <td>
                    <asp:TextBox ID="soyad" CssClass="box" runat="server"></asp:TextBox> </td></tr>
           
            <tr><td>
                <asp:Label ID="Label3" runat="server" Text="Email:"  CssClass="label" ></asp:Label></td><td></td></tr>
       
            <tr><td>
                <asp:TextBox ID="email"  CssClass="box" runat="server" TextMode="Email"></asp:TextBox>  </td><td></td><td>
                    </td></tr>
            <tr><td>
                <asp:Label ID="Label4" runat="server" Text="Şifre:"  CssClass="label"></asp:Label></td><td></td></tr>
       
            <tr><td>
                <asp:TextBox ID="sifre"  CssClass="box" runat="server"></asp:TextBox>  </td><td ></td><td>
                    </td></tr>
            <tr> 
                <td></td> <td> 
                    <asp:Button ID="Button1" runat="server" Text="KAYDET" CssClass="button" OnClick="Button1_Click" /> </td>
                      </tr>
            <tr><td>
                <asp:Label ID="Label5" runat="server" Text=""></asp:Label></td></tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
