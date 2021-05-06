<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="MudurYarDevamsizlikBilgisi.aspx.cs" Inherits="Proje.Web.MudurYardimcisi.MudurYarDevamsizlikBilgisi" %>

<%@ Register Src="~/UserKontrol/UserDevamsizlik.ascx" TagPrefix="uc1" TagName="UserDevamsizlik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>GURU Able - Free Lite Admin Template </title>
    <link rel="icon" href="assets/images/favicon.ico" type="image/x-icon" />
    <!-- Google font-->
    <link
      href="https://fonts.googleapis.com/css?family=Open+Sans:400,600,800"
      rel="stylesheet"
    />
    <!-- Required Fremwork -->
    <link
      rel="stylesheet"
      type="text/css"
      href="assets/css/bootstrap/css/bootstrap.min.css"
    />
    <!-- themify-icons line icon -->
    <link
      rel="stylesheet"
      type="text/css"
      href="assets/icon/themify-icons/themify-icons.css"
    />
    <!-- ico font -->
    <link
      rel="stylesheet"
      type="text/css"
      href="assets/icon/icofont/css/icofont.css"
    />
    <!-- Style.css -->
    <link rel="stylesheet" type="text/css" href="assets/css/style.css" />
    <link
      rel="stylesheet"
      type="text/css"
      href="assets/css/jquery.mCustomScrollbar.css"
    />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <uc1:UserDevamsizlik runat="server" ID="UserDevamsizlik" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
</asp:Content>
