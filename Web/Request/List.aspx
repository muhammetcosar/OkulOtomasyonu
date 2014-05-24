<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Kadmyo.About" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <li class="active">Bilgilerim</li>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div class="span6">
     <div class="widget-box">
										<div class="widget-header">
											<h5>Notlar</h5>
										</div>
										<div class="widget-body">
											<div class="widget-main">
										            
                                                    <div>
                            <div>
           <asp:GridView ID="dgrList" runat="server" CssClass="table table-striped table-bordered table-hover" 
               AutoGenerateColumns="False"  DataKeyNames="USERID" 
                OnSelectedIndexChanged="dgrList_SelectedIndexChanged" >
                                                       <Columns>
                                                            <asp:TemplateField HeaderText="DERSADI">
                                                               <ItemTemplate>
                                                                   <asp:LinkButton runat="server" ID="btnReq" CommandName="Select" Text='<%# Eval("DERSADI").ToString() %>' />
                                                               </ItemTemplate>
                                                           </asp:TemplateField>
                                                           <asp:TemplateField HeaderText="1 Vize">
                                                               <ItemTemplate>
                                                                   <asp:LinkButton runat="server" ID="btnReq" CommandName="Select" Text='<%# Eval("VIZE1").ToString() %>' />
                                                                    
                                                                    
                                                               </ItemTemplate>
                                                           </asp:TemplateField>
                                                           <asp:TemplateField HeaderText="2 Vize">
                                                               <ItemTemplate>
                                                                   <asp:LinkButton runat="server" ID="btnReq" CommandName="Select" Text='<%# Eval("VIZE2").ToString() %>' />
                                                               </ItemTemplate>
                                                           </asp:TemplateField>
                                                           
                                                               <asp:TemplateField HeaderText="Final">
                                                               <ItemTemplate>
                                                                   <asp:LinkButton runat="server" ID="btnReq" CommandName="Select" Text='<%# Eval("FINAL").ToString() %>' />
                                                               </ItemTemplate>
                                                           </asp:TemplateField>
                                                       </Columns>
                                                   </asp:GridView>
      </div>
                                                 </div>
                                            </div> 
										</div>
									</div>
 
  </div>  
  
 <div class="span6">
      <div class="widget-header">
					<h5>Devamsızlık</h5>
      </div>
      <div class="widget-body"> 
          <div class="widget-main">
                <div class="form-horizontal">
                    <asp:GridView ID="dgrListD" runat="server" CssClass="table table-striped table-bordered table-hover" 
               AutoGenerateColumns="False"  DataKeyNames="USERID" 
                >
                                                       <Columns>
                                                            <asp:TemplateField HeaderText="DERSADI">
                                                               <ItemTemplate>
                                                                   <asp:LinkButton runat="server" ID="btnReq" CommandName="Select" Text='<%# Eval("DERSADI").ToString() %>' />
                                                                     <br /><small>- <%# Convert.ToDateTime(Eval("EDATE")) %> </small>
                                                               </ItemTemplate>
                                                           </asp:TemplateField>
                                                           <asp:TemplateField HeaderText="DERS1">
                                                               <ItemTemplate>
                                                                   <asp:LinkButton runat="server" ID="btnReq" CommandName="Select" Text='<%# Eval("DERS1").ToString() %>' />
                                                                   
                                                               </ItemTemplate>
                                                           </asp:TemplateField>
                                                           <asp:TemplateField HeaderText="DERS2">
                                                               <ItemTemplate>
                                                                   <asp:LinkButton runat="server" ID="btnReq" CommandName="Select" Text='<%# Eval("DERS2").ToString() %>' />
                                                                  
                                                               </ItemTemplate>
                                                           </asp:TemplateField>
                                                           
                                                               
                                                       </Columns>
                                                   </asp:GridView>
      </div>
         </div>
      </div>
</div>                                     
    
    </asp:Content>
