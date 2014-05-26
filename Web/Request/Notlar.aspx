<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Notlar.aspx.cs" Inherits="Kadmyo.Request.Notlar" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <li class="active">Anasayfa</li>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="span6">
     <div class="widget-box">
										<div class="widget-header">
											<h5>Anasayfa</h5>
										</div>
										<div class="widget-body">
											<div class="widget-main">
										            <div class=control-group>
                                                        <asp:TextBox ID="txtSearch" runat="server"  placeholder="Ögrenci No" ></asp:TextBox>
                                                        <asp:TextBox ID="txttc" runat="server"  placeholder="Tc" ></asp:TextBox>
           
 </div>
                                                <div class=control-group>
                                                       <asp:TextBox ID="txtSearch2" runat="server"  placeholder="İsim" ></asp:TextBox>
                                                       <asp:TextBox ID="txtsoyad" runat="server"  placeholder="Soyisim" ></asp:TextBox>
                                                       <asp:Button ID="btnSearch"  CssClass="btn btn-small btn-info" runat="server"  OnClick="Search_Click" Text="ARA"  />   
                                                       <br />
                                                     <br />
                                                     <asp:Label ID="lbders" runat="server" Text="Dersi Seçiniz :"></asp:Label>
                                                       <asp:DropDownList ID="DERS" runat="server" AutoPostBack="True" DataTextField="DERSADI" OnSelectedIndexChanged="DERS_SelectedIndexChanged">
                                                       </asp:DropDownList>
                                                    </div>
                                                    <div>
           <asp:GridView ID="dgrList" runat="server" CssClass="table table-striped table-bordered table-hover" 
               AutoGenerateColumns="False"  DataKeyNames="USERID" 
                OnSelectedIndexChanged="dgrList_SelectedIndexChanged" >
                                                       <Columns>
                                                             <asp:TemplateField HeaderText="Ögrenciler">
                                                               <ItemTemplate>
                                                                   <asp:HiddenField runat="server" ID="hdID" Value='<%# Eval("USERID") %>' />
                                                                   <asp:LinkButton runat="server" ID="btnReq" CommandName="Select" Text='<%# Eval("USERID").ToString() + ".  "  +  Eval("NAME").ToString() +"  " +Eval("SURNAME").ToString() %>' />
                                                               </ItemTemplate>
                                                           </asp:TemplateField>
                                                          <asp:TemplateField HeaderText="Notlar">
                                                               <ItemTemplate>
                                                                   <asp:Label ID="Label1" runat="server" Text="vize1"></asp:Label>
                                                                   <asp:TextBox ID="vize1" runat="server" Text="0" Height="26px" Width="31px"></asp:TextBox>
                                                                   <asp:Label ID="Label2" runat="server" Text="vize2"></asp:Label>
                                                                    <asp:TextBox ID="vize2" runat="server" Text="0" Height="26px" Width="31px"></asp:TextBox>
                                                                   <asp:Label ID="Label3" runat="server" Text="final"></asp:Label>
                                                                    <asp:TextBox ID="final" runat="server" Text="0" Height="26px" Width="31px"></asp:TextBox>
                                                               </ItemTemplate>
                                                           </asp:TemplateField>
                                                          
                                                       </Columns>
                                                   </asp:GridView>
                                                        <asp:Button ID="gonder" runat="server" OnClick="gonder_Click" Text="GÖNDER" />
                                                        <asp:Label ID="mesaj" runat="server" Text=""></asp:Label>
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
									<label class="control-label" for="form-field-1">Ögrenci No</label>
									<div class="controls">
                                          <asp:TextBox ID="txtUser" runat="server" ReadOnly="true"  ></asp:TextBox>

									</div>
					 </div>

                     <div class="control-group">
									<label class="control-label" for="form-field-1">Adı</label>
									<div class="controls">
                                          <asp:TextBox ID="txtName" runat="server" ReadOnly="true" ></asp:TextBox>

									</div>
					 </div>
                      <div class="control-group">
									<label class="control-label" for="form-field-1">Soyadı</label>
									<div class="controls">
                                          <asp:TextBox ID="txtSurname" runat="server" ReadOnly="true" ></asp:TextBox>
									</div>
					 </div>

                     <div class="control-group">
									<label class="control-label" for="form-field-1">Tc</label>
									<div class="controls">
                                          <asp:TextBox ID="tc" runat="server" ReadOnly="true" ></asp:TextBox>
									</div>
					 </div>

                    <div class="control-group" runat="server" id="cgOther" visible="false">
									<div class="controls">
									</div>
								</div>
         

          

         <div class="form-actions">
             
                                       
                <asp:Button ID="btnSave" class="btn btn-info" runat="server" OnClick="btnSave_Click" Text="Kaydet" />
                <asp:HyperLink ID="btnCancel" class="btn btn-warn" runat="server" OnClick="btnCancel_Click" Text="İptal" />
               
								</div>

      </div>
         </div>
      </div>
</div>                                     
</asp:Content>

