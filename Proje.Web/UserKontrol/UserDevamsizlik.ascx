<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserDevamsizlik.ascx.cs" Inherits="Proje.Web.UserKontrol.UserDevamsizlik" %>

<div class="row">
                        <div class="col-sm-12">
                          <div class="card">
                            <div class="card-block">
                              <h4 class="sub-title text-capitalize">
                                Devamsızlık Girişi
                              </h4>
                            </div>
                            <div class="card-block">
                              <div class="form-group row">
                                <label class="col-sm-2 col-form-label"
                                  >Öğrenci Numarası Girin</label
                                >
                                <div class="col-sm-6">
                                  <input type="text" class="form-control" />
                                </div>
                                <button class="btn btn-danger btn-round">
                                  Öğrenci Ara
                                </button>
                              </div>
                            </div>
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
                                  <label class="col-sm-2 col-form-label"
                                    >Öğrenci Sınıfı</label
                                  >
                                  <div class="col-sm-10">
                                    <input type="text" class="form-control" />
                                  </div>
                                </div>
                                <div class="form-group row">
                                  <label class="col-sm-2 col-form-label"
                                    >Devamsızlık Tarihi</label
                                  >
                                  <div class="col-sm-4">
                                    <!-- <input type="text" class="form-control" /> -->
                                    <input
                                      class="col-sm-10"
                                      type="date"
                                      id="myDate"
                                      value="2014-02-09"
                                      style="
                                        padding-bottom: 1%;
                                        padding-top: 1%;
                                      "
                                    />
                                  </div>

                                  <label class="col-sm-2 col-form-label"
                                    >Devamsızlık Türü</label
                                  >
                                  <div class="col-sm-4">
                                    <select name="select" class="form-control">
                                      <option value="opt1">
                                        Devamsızlık Türünü Seçiniz
                                      </option>
                                      <option value="opt2">Tam Gün</option>
                                      <option value="opt3">Yarım Gün</option>
                                    </select>
                                  </div>
                                </div>

                                <div
                                  class="card-block"
                                  style="text-align: center"
                                >
                                  <button
                                    class="btn btn-info btn-round col-sm-2"
                                  >
                                    Kaydet
                                  </button>
                                  <button
                                    class="btn btn-warning btn-round col-sm-2"
                                  >
                                    Güncelle
                                  </button>
                                </div>
                              </form>
                            </div>
                          </div>
                        </div>
                      </div>
</asp:Content>