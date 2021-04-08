﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="NotGirisi.aspx.cs" Inherits="Proje.Web.NotGirisi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>GURU Able - Free Lite Admin Template </title>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="page-wrapper">
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
                  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
</asp:Content>
