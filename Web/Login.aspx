<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Kadmyo.Login" %>

<%@ Register Src="~/Layout/Head.ascx" TagPrefix="uc1" TagName="Head" %>
<%@ Register Src="~/Layout/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>





<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="utf-8" />
		<title>Gümüşhane Üniversitesi</title>

		<meta name="description" content="User login page" />
		<meta name="viewport" content="width=device-width, initial-scale=1.0" />

		<!--basic styles-->

        <uc1:Head runat="server" ID="Head" />

		<!--inline styles related to this page-->
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <style type="text/css">
            .auto-style1 {
                width: 553px;
                color: #FFFFFF;
                background-color: #808080;
                height: 254px;
            }
            #txtKayit {
                text-align: left;
            }
        </style>
    </head>

	<body class="login-layout">
         <form id="form1" runat="server">
		<div class="main-container container-fluid" id="txtgiris" runat="server">
			<div class="main-content">
				<div class="row-fluid">
					<div class="span12">
						<div class="login-container">
							<div class="row-fluid">
								<div class="center">
									<h1>
										<i class="icon-leaf green">Gümüşhane</i> Üniversitesi
									</h1>
									<h4 class="blue">© Bilgisayar programcıligi</h4>
								</div>
							</div>
							<div class="space-6"></div>
							<div class="row-fluid" >
								<div class="position-relative">
									<div id="login-box" class="login-box visible widget-box no-border">
										<div class="widget-body">
											<div class="widget-main">
												<h4 class="header blue lighter bigger">
													<i class="icon-coffee green"></i>
													Sisteme Giriş
												</h4>

												<div class="space-6"></div>
                                               
												
													<fieldset>
														<label>
															<span class="block input-icon input-icon-right">
                                                                <asp:TextBox ID="kadi"  class="span12" runat="server"/>
																<i class="icon-user"></i>
															</span>
														</label>

														<label>
															<span class="block input-icon input-icon-right">
                                                                <asp:TextBox ID="sifre" runat="server"  TextMode="Password" class="span12" ></asp:TextBox>
																
																<i class="icon-lock"></i>
															</span>
														</label>

														<div class="space"></div>

														<div class="clearfix">
															 
                                                           
                                                            <asp:Button ID="Button1" runat="server" Text="Giriş"  class="width-35 pull-right btn btn-small btn-primary" OnClick="giris_Click"/>
														</div>
                                                        
														<div class="space-4"> </div>
													</fieldset>
												
                         
												 
											</div><!--/widget-main-->

											<div class="toolbar clearfix">
												<div>
                                                    <asp:LinkButton ID="LinkButton1" runat="server" class="forgot-password-link" OnClick="LinkButton1_Click"  >Üyelik kaydı</asp:LinkButton>
                                                    
												</div>
											</div>
										</div><!--/widget-body-->
									</div><!--/login-box-->
								</div><!--/position-relative-->
							</div>

                            
							</div>
					</div><!--/.span-->
				</div><!--/.row-fluid-->
			</div>

		</div><!--/.main-container-->
        <div class="main-container container-fluid" runat="server" visible="false" id="txtkayit">
			<div class="main-content">
				<div class="row-fluid">
					<div class="span12">
						<div class="login-container">
							<div class="row-fluid">
								<div class="center">
									<h1>
										<i class="icon-leaf green">Gümüşhane</i> Üniversitesi
									</h1>
									<h4 class="blue">© Bilgisayar programcıligi</h4>
								</div>
							</div>
							<div class="space-6"></div>
							<div class="row-fluid" >
								<div class="position-relative">
									<div id="login-box1" class="login-box visible widget-box no-border">
										<div class="widget-body">
											<div class="widget-main">
												<h4 class="header blue lighter bigger">
													<i class="icon-coffee green"></i>
													Sisteme Kayıt
												</h4>

												<div class="space-6"></div>
                                               
												
													<fieldset>
                                                        <label>
                                                             <asp:Label ID="Label2" runat="server" Text="Numara"></asp:Label>
															<span class="block input-icon input-icon-right">
                                                                <asp:TextBox ID="Numara"  class="span12" runat="server"/>
																<i class="icon-edit"></i>
															</span>
														</label>
														<label>
                                                             <asp:Label ID="Label3" runat="server" Text="Adi"></asp:Label>
															<span class="block input-icon input-icon-right">
                                                                <asp:TextBox ID="Name"  class="span12" runat="server"/>
																<i class="icon-edit"></i>
															</span>
														</label>
                                                        <label> 
                                                            <asp:Label ID="Label1" runat="server" Text="Soyadi"></asp:Label>
															<span class="block input-icon input-icon-right">
                                                                <asp:TextBox ID="Surname"   class="span12" runat="server"/>
																<i class="icon-edit"></i>
															</span>
														</label>
                                                        <label>
                                                             <asp:Label ID="Label4" runat="server" Text="Kullanici adi"></asp:Label>
															<span class="block input-icon input-icon-right">
                                                                <asp:TextBox ID="Username"   class="span12" runat="server"/>
																<i class="icon-edit"></i>
															</span>
														</label>
                                                         <label>
                                                              <asp:Label ID="Label5" runat="server" Text="Tc"></asp:Label>
															<span class="block input-icon input-icon-right">
                                                                <asp:TextBox ID="txttc"  class="span12" runat="server"/>
																<i class="icon-edit"></i>
															</span>
														</label>
                                                        <label>
                                                             <asp:Label ID="Label6" runat="server" Text="E-mail"></asp:Label>
															<span class="block input-icon input-icon-right">
                                                                <asp:TextBox ID="Mail"   class="span12" runat="server"/>
																<i class="icon-edit"></i>
															</span>
														</label>
                                                          <label>
                                                               <asp:Label ID="Label7" runat="server" Text="Bölüm"></asp:Label>
															<span class="block input-icon input-icon-right">
                                                                <asp:DropDownList ID="bolum" runat="server" class="span12"   DataMember="EPISODEID" DataTextField="EPISODENAME"  ></asp:DropDownList>
																
															</span>
														</label>
                                                        <label>
                                                             <asp:Label ID="Label8" runat="server" Text="Şifre"></asp:Label>
															<span class="block input-icon input-icon-right">
                                                                <asp:TextBox ID="Password" runat="server" TextMode="Password"  class="span12" ></asp:TextBox>
																
																<i class="icon-lock"></i>
															</span>
														</label>

                                                          <label>
                                                               <asp:Label ID="Label9" runat="server" Text="Yönetici"></asp:Label>
															<span class="block input-icon input-icon-right">
                                                                <asp:RadioButtonList ID="admin" runat="server" >
                                                                    <asp:ListItem Value="True">Admin</asp:ListItem>
                                                                    <asp:ListItem Value="False">&#214;grenci</asp:ListItem>
                                                                </asp:RadioButtonList>
                                                                <asp:Label ID="lbadmin" runat="server" Text=""></asp:Label>
															</span>
														</label>
														<div class="space"></div>

														<div class="clearfix">
                                                           
                                                            <asp:Button ID="Save" runat="server" Text="Kaydet"  class="width-35 pull-right btn btn-small btn-primary" OnClick="Save_Click" />
														</div>
                                                        
														<div class="space-4"> </div>
													</fieldset>
												
                         
												 
											</div><!--/widget-main-->

											<div class="toolbar clearfix">
												<div>
                                                    <asp:LinkButton ID="Giriş" runat="server" class="forgot-password-link" OnClick="Giris_Click1"   >Giriş</asp:LinkButton>
                                                    
												</div>
											</div>
										</div><!--/widget-body-->
									</div><!--/login-box-->
								</div><!--/position-relative-->
							</div>

                            
							</div>
					</div><!--/.span-->
				</div><!--/.row-fluid-->
			</div>

		</div>     
</form>
        <uc1:Footer runat="server" ID="Footer" />

		<script type="text/javascript">
		    function show_box(id) {
		        $('.widget-box.visible').removeClass('visible');
		        $('#' + id).addClass('visible');
		    }
		</script>
	</body>
</html>

