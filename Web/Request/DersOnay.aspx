<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DersOnay.aspx.cs" Inherits="sakaryauni.Request.DersOnay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="span6">
        <div class="widget-box">
            <div class="widget-header">
                <h5>DersOnay</h5>
            </div>
            <div class="widget-body">
                <div class="widget-main">

                    <div>
                        <div>
                            <asp:GridView ID="dgrListOnay" runat="server" CssClass="table table-striped table-bordered table-hover"
                                AutoGenerateColumns="False" DataKeyNames="DERSID" OnSelectedIndexChanged="dgrListOnay_SelectedIndexChanged" DataMember="DERSID">
                                <Columns>
                                    <asp:TemplateField HeaderText="NAME">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" ID="btnReq" CommandName="Select" Text='<%# Eval("NAME").ToString()+" "+ Eval("SURNAME").ToString() %>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="DERSADI">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" ID="s" CommandName="Select" Text='<%# Eval("DERSADI").ToString() %>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                </Columns>
                            </asp:GridView>
                            <br />
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <div class="span6">
        <div class="widget-header">
            <h5>Detay</h5>


        </div>
        <div class="widget-body">
            <div class="widget-main">
                <div class="form-horizontal">
                    <div class="control-group">
                        <label class="control-label" for="form-field-1">Adı</label>
                        <div class="controls">
                            <asp:TextBox ID="txtName" runat="server" ReadOnly="true"></asp:TextBox>

                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label" for="form-field-1">Soyadı</label>
                        <div class="controls">
                            <asp:TextBox ID="txtSurname" runat="server" ReadOnly="true"></asp:TextBox>
                        </div>
                    </div>

                    <div class="control-group">
                        <label class="control-label" for="form-field-1">DersAdı</label>
                        <div class="controls">
                            <asp:TextBox ID="txtDersadı" runat="server" ReadOnly="true"></asp:TextBox>
                        </div>
                    </div>

                    <div class="control-group" runat="server" id="cgOther" visible="false">
                        <div class="controls">
                        </div>
                    </div>

                    <div class="form-actions">
                        <asp:Button ID="btnOnay" class="btn btn-info" runat="server"  Text="Onayla" OnClick="btnOnay_Click" />
                         <asp:Button ID="btnkal" class="btn btn-info" runat="server"  Text="Kaldır" OnClick="btnkal_Click" />
                        <asp:Button ID="btnCancel" class="btn btn-warn" runat="server" OnClick="btnCancel_Click" Text="İptal" />
                    </div>

                </div>
            </div>
        </div>
    </div>

</asp:Content>
