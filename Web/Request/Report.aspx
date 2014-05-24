<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="Kadmyo.Rapor" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <li class="active">Rapor</li>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Chart ID="Chart1"   runat="server"  BorderlineColor="Transparent" Palette="Fire" Height="600px" Width="1000px" >
        <Series> 
             <asp:Series Name="csRequest" ChartType="Pie" Palette="SeaGreen"  IsValueShownAsLabel="false" IsXValueIndexed="true"/>
            
        </Series>
        <ChartAreas>
             <asp:ChartArea Name="caRequest" Area3DStyle-Enable3D="true" />        
        </ChartAreas>
    </asp:Chart>    
</asp:Content>
