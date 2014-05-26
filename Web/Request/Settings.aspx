<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="sakaryauni.Request.Settings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="span6">
        <div class="widget-box">
            <div class="widget-header">
                <h5>Anasayfa</h5>
            </div>
            <div class="widget-body">
                <div class="widget-main">
                    <div>
                        <asp:GridView ID="dgrList" runat="server" CssClass="table table-striped table-bordered table-hover"
                            AutoGenerateColumns="False" DataKeyNames="USERID" OnSelectedIndexChanged="dgrList_SelectedIndexChanged"
                          >
                            <Columns>
                                <asp:TemplateField HeaderText="Düzenle">
                                    <ItemTemplate>
                                        <asp:LinkButton runat="server" ID="btnReq" CommandName="Select" Text='<%# Eval("USERID").ToString() + ".  "  +  Eval("NAME").ToString() +"  " +Eval("SURNAME").ToString() %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>


                            </Columns>
                        </asp:GridView>
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
                            <asp:TextBox ID="txtName" runat="server" ></asp:TextBox>

                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label" for="form-field-1">Soyadı</label>
                        <div class="controls">
                            <asp:TextBox ID="txtSurname" runat="server" ></asp:TextBox>
                        </div>
                    </div>

                    <div class="control-group">
                        <label class="control-label" for="form-field-1">Tc</label>
                        <div class="controls">
                            <asp:TextBox ID="tc" runat="server" ></asp:TextBox>
                        </div>
                    </div>
                      <div class="control-group">
                        <label class="control-label" for="form-field-1">Mail</label>
                        <div class="controls">
                            <asp:TextBox ID="txtmail" runat="server" ></asp:TextBox>
                        </div>
                    </div>
                      <div class="control-group">
                        <label class="control-label" for="form-field-1">Kullanıcı adı</label>
                        <div class="controls">
                            <asp:TextBox ID="txtkullan" runat="server" ></asp:TextBox>
                        </div>
                    </div>
                      <div class="control-group">
                        <label class="control-label" for="form-field-1">Şifre</label>
                        <div class="controls">
                            <asp:TextBox ID="txtsifre" runat="server" ></asp:TextBox>
                        </div>
                    </div>
                    <div class="control-group" runat="server" id="cgOther" visible="false">
                        <div class="controls">
                        </div>
                    </div>




                    <div class="form-actions">


                        <asp:Button ID="btnSave" class="btn btn-info" runat="server" Text="Kaydet" OnClick="btnSave_Click" />
                        <asp:HyperLink ID="btnCancel" class="btn btn-warn" runat="server"  Text="İptal" />

                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
