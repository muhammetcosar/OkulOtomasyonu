<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DersSecimi.aspx.cs" Inherits="sakaryauni.Request.DersSecimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="span6">
        <div class="widget-box">
            <div class="widget-header">
                <h5>Notlar</h5>
            </div>
            <div class="widget-body">
                <div class="widget-main">
                    <div>
                        <asp:RadioButtonList ID="Rbders" runat="server" DataValueField="DERSADI" DataMember="DERSADI">
                        </asp:RadioButtonList>
                        <asp:Button ID="btngonder" class="btn btn-info" runat="server" Text="Gonder" OnClick="btngonder_Click" />
                    </div>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
