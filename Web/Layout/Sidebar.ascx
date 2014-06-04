<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Sidebar.ascx.cs" Inherits="Kadmyo.Layout.Sidebar" %>
<div class="sidebar" id="sidebar">
				<div class="sidebar-shortcuts" id="sidebar-shortcuts">
					<div class="sidebar-shortcuts-large" id="sidebar-shortcuts-large">
						
						
						
					
					</div>

					 
				</div><!--#sidebar-shortcuts-->

				<ul class="nav nav-list">
                    <li>
						<asp:HyperLink runat="server" ID="lnkRequest" NavigateUrl="~/Request/List">
							<i class="icon-desktop"></i>
							<span class="menu-text"> Anasayfa </span>
						</asp:HyperLink>
					</li>
					<li>
						<asp:HyperLink  ID="Notlar" runat="server" NavigateUrl="~/Request/Notlar">
							<i class="icon-credit-card"></i>
							<span class="menu-text"> Notlar </span>
						</asp:HyperLink>
					</li>
                    <li>
						<asp:HyperLink ID="devam" runat="server" NavigateUrl="~/Request/devam">
							<i class="icon-group"></i>
							<span class="menu-text"> Devamsızlık</span>
						</asp:HyperLink>
					</li>
                      <li>
						<asp:HyperLink ID="dbolum" runat="server" NavigateUrl="~/Request/DersEkleme" Visible="False">
							<i class="icon-group"></i>
							<span class="menu-text"> Ders-BolumEkleme</span>
						</asp:HyperLink>
					</li>
                    <li>
						<asp:HyperLink ID="dersSecim" runat="server" NavigateUrl="~/Request/DersSecimi">
							<i class="icon-group"></i>
							<span class="menu-text">DersEkle</span>
						</asp:HyperLink>
					</li>
                     
                     <li>
						<asp:HyperLink ID="dersOnay" runat="server" NavigateUrl="~/Request/DersOnay">
							<i class="icon-group"></i>
							<span class="menu-text">DersOnay</span>
						</asp:HyperLink>
					</li>
                   
                    <li>
						<asp:HyperLink ID="lnkSettings" runat="server" NavigateUrl="~/Request/Settings">
							<i class="icon-cog"></i>
							<span class="menu-text"> Ayarlar </span>
						</asp:HyperLink>
					</li>
 
				</ul><!--/.nav-list-->

			</div>