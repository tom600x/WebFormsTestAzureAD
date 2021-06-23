<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestAzureAD._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 <dl>


  <dt>IsAuthenticated</dt> 
     <dd><%= HttpContext.Current.User.Identity.IsAuthenticated %></dd>
     <dt>AuthenticationType</dt> 
     <dd><%= HttpContext.Current.User.Identity.AuthenticationType %></dd>
     <dt>Name</dt> <dd><%= HttpContext.Current.User.Identity.Name %></dd>
     <dt>Is in "Test Group"</dt>
     <dd><%= HttpContext.Current.User.IsInRole("TestGroup") %></dd> 
 
 </dl>


</asp:Content>
