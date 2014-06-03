<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DersEkleme.aspx.cs" Inherits="sakaryauni.Request.DersEkleme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="span6">
        <div class="widget-box">
            <div class="widget-header">
                <h5>Ekleme Bölümü</h5>
            </div>
            <div class="widget-body">
                <div class="widget-main">
                    <div>
                        <div class="control-group">
                            <asp:RadioButtonList ID="sec" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="sec_SelectedIndexChanged">
                                <asp:ListItem Value="1" Selected="True">Ders Ekleme</asp:ListItem>
                                <asp:ListItem Value="2">Bölüm Ekleme</asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                        <div class="control-group" runat="server" id="ders">
                            <asp:TextBox ID="txtDersadı" runat="server" placeholder="Dersadı"></asp:TextBox>
                        </div>
                    </div>
                    <div class="control-group" runat="server" id="bolum" visible="false">
                        <asp:TextBox ID="txtBolumAdı" runat="server" placeholder="BölümAdı"></asp:TextBox>
                    </div>
                     <div class="form-actions">
                        <asp:Button ID="btnSave" class="btn btn-info" runat="server"  Text="Kaydet" OnClick="btnSave_Click" />
                        <asp:HyperLink ID="btnCancel" class="btn btn-warn" runat="server" OnClick="btnCancel_Click" Text="İptal" />

                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
