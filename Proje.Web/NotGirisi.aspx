﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="NotGirisi.aspx.cs" Inherits="Proje.Web.NotGirisi" %>

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
  <div class="card">
                      <div class="card-block">
                        <h4 class="sub-title text-capitalize">Not Girişi</h4>
                       
                      </div>
                      <!-- Page-header start -->
                      <div class="card-block">
                        <div class="form-group row">
                          <label class="col-sm-2 col-form-label"
                            >Numara Girin</label
                          >
                          <div class="col-sm-6">
                            <input type="text" class="form-control" />
                          </div>
                          <button class="btn btn-danger btn-round">Öğrenci Ara</button>
                        </div>
                      </div>
                      <!-- Page-header end -->
                      <div class="card-block">
                        <h4 class="sub-title text-capitalize">
                          Öğrenci Bilgileri
                        </h4>
                        <form>
                          <div class="form-group row">
                            <label class="col-sm-2 col-form-label"
                              >Öğrenci Numarası</label
                            >
                            <div class="col-sm-10">
                              <input type="text" class="form-control" />
                            </div>
                          </div>
                          <div class="form-group row">
                            <label class="col-sm-2 col-form-label"
                              >Öğrenci Adı</label
                            >
                            <div class="col-sm-10">
                              <input type="text" class="form-control" />
                            </div>
                          </div>
                          <div class="form-group row">
                            <label class="col-sm-2 col-form-label"
                              >Öğrenci Soyadı</label
                            >
                            <div class="col-sm-10">
                              <input type="text" class="form-control" />
                            </div>
                          </div>
                          <div class="form-group row">
                            <label class="col-sm-2 col-form-label">Öğrenci Sınıfı</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control">
                            </div>
                        </div>
                          <div class="form-group row">
                            <label class="col-sm-2 col-form-label"
                              >1. Sınav Notu</label
                            >
                            <div class="col-sm-10">
                              <input type="text" class="form-control" />
                            </div>
                          </div>
                          <div class="form-group row">
                            <label class="col-sm-2 col-form-label"
                              >2. Sınav Notu</label
                            >
                            <div class="col-sm-10">
                              <input type="text" class="form-control" />
                            </div>
                          </div>

                          <div class="form-group row">
                            <label class="col-sm-2 col-form-label"
                              >Performans Notu</label
                            >
                            <div class="col-sm-10">
                              <input type="text" class="form-control" />
                            </div>
                          </div>
                          <div class="form-group row">
                            <label class="col-sm-2 col-form-label"
                              >Proje Ödevi Notu</label
                            >
                            <div class="col-sm-10">
                              <input type="text" class="form-control" />
                            </div>
                          </div>
                          <div class="card-block" style="text-align: center">
                            <button class="btn btn-info btn-round col-sm-2">
                              Kaydet
                            </button>
                            <button class="btn btn-warning btn-round col-sm-2">
                              Güncelle
                            </button>
                          </div>
                        </form>
                      </div>
                    </div>
                    <div class="card" style="padding-bottom: 2%">
                      <div class="card-header">
                        <h5>Öğrenci Listesi</h5>
                        <div class="card-header-right">
                          <ul class="list-unstyled card-option">
                            <li><i class="icofont icofont-simple-left"></i></li>
                            <li>
                              <i class="icofont icofont-maximize full-card"></i>
                            </li>
                            <li>
                              <i
                                class="icofont icofont-minus minimize-card"
                              ></i>
                            </li>
                            <li>
                              <i
                                class="icofont icofont-refresh reload-card"
                              ></i>
                            </li>
                            <li>
                              <i class="icofont icofont-error close-card"></i>
                            </li>
                          </ul>
                        </div>
                      </div>
                      <div
                        class="card-block table-border-style"
                        style="padding-left: 5%"
                      >
                        <div class="table-responsive" style="width: 90%">
                          <table class="table table-hover" id="myTable">
                            <thead>
                              <tr>
                                <th>Numara</th>
                                <th>Ad</th>
                                <th>Soyad</th>
                                <th>Sınıf</th>
                                <th>1. Sınav</th>
                                <th>2. Sınav</th>
                                <th>Performans Notu</th>
                                <th>Proje Notu</th>
                              </tr>
                            </thead>
                            <tbody>
                              <tr>
                                <td>1</td>
                                <td>Şule</td>
                                <td>Atan</td>
                                <td>9/A</td>
                                <td>60</td>
                                <td>70</td>
                                <td>80</td>
                                <td>80</td>
                              </tr>
                              <tr>
                                <td>2</td>
                                <td>Nermin</td>
                                <td>Donat</td>
                                <td>9/B</td>
                                <td>50</td>
                                <td>100</td>
                                <td>70</td>
                                <td>80</td>
                              </tr>
                             
                         
                            </tbody>
                          </table>
                        </div>
                      </div>
                    </div>
     <div class="fixed-button">
          <a href="https://codedthemes.com/item/guru-able-admin-template/"
             target="_blank"
             class="btn btn-md btn-primary">
              <i class="fa fa-shopping-cart" aria-hidden="true"></i> Upgrade To Pro
          </a>
      </div>

      <!-- Warning Section Starts -->
      <!-- Older IE warning message -->
      <!--[if lt IE 9]>
      <div class="ie-warning">
        <h1>Warning!!</h1>
        <p>
          You are using an outdated version of Internet Explorer, please upgrade
          <br />to any of the following web browsers to access this website.
        </p>
        <div class="iew-container">
          <ul class="iew-download">
            <li>
              <a href="http://www.google.com/chrome/">
                <img src="assets/images/browser/chrome.png" alt="Chrome" />
                <div>Chrome</div>
              </a>
            </li>
            <li>
              <a href="https://www.mozilla.org/en-US/firefox/new/">
                <img src="assets/images/browser/firefox.png" alt="Firefox" />
                <div>Firefox</div>
              </a>
            </li>
            <li>
              <a href="http://www.opera.com">
                <img src="assets/images/browser/opera.png" alt="Opera" />
                <div>Opera</div>
              </a>
            </li>
            <li>
              <a href="https://www.apple.com/safari/">
                <img src="assets/images/browser/safari.png" alt="Safari" />
                <div>Safari</div>
              </a>
            </li>
            <li>
              <a
                href="http://windows.microsoft.com/en-us/internet-explorer/download-ie"
              >
                <img src="assets/images/browser/ie.png" alt="" />
                <div>IE (9 & above)</div>
              </a>
            </li>
          </ul>
        </div>
        <p>Sorry for the inconvenience!</p>
      </div>
    <![endif]-->
      <!-- Warning Section Ends -->
      <!-- Required Jquery -->
      <!-- <script
      type="text/javascript"
      src="assets/js/jquery/jquery.min.js"
    ></script> -->
      <script type="text/javascript"
              src="assets/js/jquery-ui/jquery-ui.min.js"></script>
      <!-- <script
      type="text/javascript"
      src="assets/js/popper.js/popper.min.js"
    ></script> -->
      <!-- <script
      type="text/javascript"
      src="assets/js/bootstrap/js/bootstrap.min.js"
    ></script> -->
      <!-- jquery slimscroll js -->
      <script type="text/javascript"
              src="assets/js/jquery-slimscroll/jquery.slimscroll.js"></script>
      <!-- modernizr js -->
      <script type="text/javascript"
              src="assets/js/modernizr/modernizr.js"></script>
      <script type="text/javascript"
              src="assets/js/modernizr/css-scrollbars.js"></script>
      <!-- classie js -->
      <script type="text/javascript" src="assets/js/classie/classie.js"></script>
      <!-- Custom js -->
      <!-- <script type="text/javascript" src="assets/js/script.js"></script> -->
      <script src="assets/js/pcoded.min.js"></script>
      <script src="assets/js/demo-12.js"></script>
      <script src="assets/js/jquery.mCustomScrollbar.concat.min.js"></script>

      <script>
          $(document).ready(function () {
              $("#myTable").DataTable();
          });
      </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">

</asp:Content>
