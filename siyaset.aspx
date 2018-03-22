<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="siyaset.aspx.cs" Inherits="siyaset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .box{top:40%; left:35%; position:absolute; width:250px; height:30px; border-style:groove; border-color:rgba(100, 0, 0, 0.75); background-color:rgba(186, 179, 179, 0.19);}
        .table{top:50%; left:32%; position:absolute;}
        .butom {
            top: 40%;
            left: 55%;
            position: absolute;
            font-size: 18px;
            border-style: groove;
            border-color: rgba(100, 0, 0, 0.79);
            background-color: rgba(100, 0, 0, 0.79);
            color: white;
            width: 100px;
            height: 34px;
        }
        .yaziiiii{top:17%; left:36%; position:absolute; color:rgba(100, 0, 0, 0.73);}
        .tablooo{top:10%; left:75%; position:absolute;  color:rgba(100, 0, 0, 0.77); text-align:center;}
         </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <table class="yaziiiii">
        <tr>
            <td>
                <h1>SİYASET</h1>
            </td>
        </tr>
    </table>
   

    <table class="tablooo">
         <tr>
            <td><h3>Toplam yorum sayısı</h3>
                
            </td>
             </tr>
            <tr>
          <td>
              <asp:gridview ID="yorumsayisi" runat="server"></asp:gridview>
               
               </td>
            </tr>
     
    </table>



    <table>
        <tr>
            <td>
                <asp:TextBox ID="yorum" CssClass="box" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="yorum_gonder" CssClass="butom" runat="server" Text="Gönder" OnClick="yorum_gonder_Click" />
            </td>
        </tr>
    </table>


    <table class="table">
        <tr>
            <td>
                <asp:GridView ID="muzikk" runat="server" CellPadding="4" AutoGenerateColumns="False" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>
                    <Columns>
                        <asp:BoundField DataField="firstname"></asp:BoundField>
                        <asp:BoundField DataField="lastname"></asp:BoundField>
                        <asp:BoundField DataField="yorum"></asp:BoundField>
                    </Columns>

                    <EditRowStyle BackColor="#999999"></EditRowStyle>

                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></FooterStyle>

                    <HeaderStyle BackColor="white" Font-Bold="True" ForeColor="White"></HeaderStyle>

                    <PagerStyle HorizontalAlign="Center" BackColor="#284775" ForeColor="White"></PagerStyle>

                    <RowStyle BackColor="#d0cccd" ForeColor="#333333"></RowStyle>

                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

                    <SortedAscendingCellStyle BackColor="#E9E7E2"></SortedAscendingCellStyle>

                    <SortedAscendingHeaderStyle BackColor="#506C8C"></SortedAscendingHeaderStyle>

                    <SortedDescendingCellStyle BackColor="#FFFDF8"></SortedDescendingCellStyle>

                    <SortedDescendingHeaderStyle BackColor="#6F8DAE"></SortedDescendingHeaderStyle>
                </asp:GridView>
            </td>
        </tr>
    </table>

</asp:Content>
