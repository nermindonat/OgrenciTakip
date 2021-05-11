<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="MudurNotGirisi.aspx.cs" Inherits="Proje.Web.Mudur.MudurNotGirisi" %>

<%@ Register Src="~/UserKontrol/UserNotGirisi.ascx" TagPrefix="uc1" TagName="UserNotGirisi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <title>GURU Able - Free Lite Admin Template</title>
    <!-- HTML5 Shim and Respond.js IE9 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
    <!-- Meta -->
    <meta charset="utf-8" />
    <meta
      name="viewport"
      content="width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui"
    />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="description" content="CodedThemes" />
    <meta
      name="keywords"
      content="flat ui, admin  Admin , Responsive, Landing, Bootstrap, App, Template, Mobile, iOS, Android, apple, creative app"
    />
    <meta name="author" content="CodedThemes" />
    <!-- Favicon icon -->
    <link rel="icon" href="assets/images/favicon.ico" type="image/x-icon" />
    <!-- Google font-->
    <link
      href="https://fonts.googleapis.com/css?family=Open+Sans:400,600,800"
      rel="stylesheet"
    />
    <!-- Required Fremwork -->
    <!-- <link
      rel="stylesheet"
      type="text/css"
      href="assets/css/bootstrap/css/bootstrap.min.css"
    /> -->
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

    <link
      rel="stylesheet"
      href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css"
      integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS"
      crossorigin="anonymous"
    />
    <script
      src="https://code.jquery.com/jquery-3.3.1.slim.min.js"
      integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"
      crossorigin="anonymous"
    ></script>
    <script
      src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js"
      integrity="sha384-wHAiFfRlMFy6i5SRaxvfOCifBUQy1xHdJ/yoi7FRNXMRBu5WHdZYu1hA6ZOblgut"
      crossorigin="anonymous"
    ></script>
    <script
      src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js"
      integrity="sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k"
      crossorigin="anonymous"
    ></script>

    <script
      src="http://code.jquery.com/jquery-3.3.1.min.js"
      integrity="sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8="
      crossorigin="anonymous"
    ></script>
    <link
      rel="stylesheet"
      href="https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css"
    />
    <script src="https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <uc1:UserNotGirisi runat="server" id="UserNotGirisi" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">

</asp:Content>
