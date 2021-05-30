<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserNotGirisi.ascx.cs" Inherits="Proje.Web.UserKontrol.UserNotGirisi" %>


<div class="page-wrapper">
    <div class="card">
        <div class="card-block">
            <h4 class="sub-title text-capitalize">Not Girişi</h4>

        </div>
        <!-- Page-header start -->
        <div class="card-block">
            <div class="form-group row" hidden="true">
                    <label class="col-sm-2 col-form-label">Not Id</label>
                    <div class="col-sm-10">
                        <input runat="server" id="txtNotId" type="text" class="form-control" />

                    </div>
                </div>
            <div class="form-group row" hidden="true">
                    <label class="col-sm-2 col-form-label">Öğrenci Id</label>
                    <div class="col-sm-10">
                        <input runat="server" id="txtOgrenciId" type="text" class="form-control" />

                    </div>
                </div>
            <div class="form-group row">
                <label class="col-sm-2 col-form-label">Numara Girin</label>
                <div class="col-sm-6">
                    <input runat="server" id="txtOgrenciNoAra" type="text" class="form-control" />
                    <asp:RequiredFieldValidator runat="server" ID="rfvOgrenciAra" CssClass="text-danger font-weight-bold" ControlToValidate="txtOgrenciNoAra" ErrorMessage="Lütfen öğrenci numarası giriniz." ValidationGroup="OgrenciAra"></asp:RequiredFieldValidator>
                </div>
                <button runat="server" id="btnAra" class="btn btn-success btn-round" onserverclick="btnAra_ServerClick" validationgroup="OgrenciAra">
                    Öğrenci Ara
                </button>
            </div>
        </div>
        <!-- Page-header end -->
        <div class="card-block">
            <h4 class="sub-title text-capitalize">Öğrenci Bilgileri
            </h4>
            <form>
                <div class="form-group row">
                    <label class="col-sm-2 col-form-label">Öğrenci Numarası</label>
                    <div class="col-sm-10">
                        <input runat="server" id="txtOgrenciNo" type="text" class="form-control" />
                        <asp:RequiredFieldValidator runat="server" ID="rfvOgrenciNo" CssClass="text-danger font-weight-bold" ControlToValidate="txtOgrenciNo" ErrorMessage="Lütfen öğrenci numarasını giriniz." ValidationGroup="OgrenciKaydet"></asp:RequiredFieldValidator>

                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-sm-2 col-form-label">Öğrenci Adı</label>
                    <div class="col-sm-10">
                        <input runat="server" id="txtOgrenciAd" type="text" class="form-control" />
                        <asp:RequiredFieldValidator runat="server" ID="rfvOgrenciAd" CssClass="text-danger font-weight-bold" ControlToValidate="txtOgrenciAd" ErrorMessage="Lütfen öğrenci adı giriniz." ValidationGroup="OgrenciKaydet"></asp:RequiredFieldValidator>

                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-sm-2 col-form-label">Öğrenci Soyadı</label>
                    <div class="col-sm-10">
                        <input runat="server" id="txtOgrenciSoyad" type="text" class="form-control" />
                        <asp:RequiredFieldValidator runat="server" ID="rfvOgrenciSoyad" CssClass="text-danger font-weight-bold" ControlToValidate="txtOgrenciSoyad" ErrorMessage="Lütfen öğrenci soyadını giriniz." ValidationGroup="OgrenciKaydet"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-sm-2 col-form-label">Sınıf</label>
                    <div class="col-sm-4">
                        <asp:DropDownList runat="server" ID="ddlSinif" CssClass="form-control"></asp:DropDownList>
                        <asp:RequiredFieldValidator runat="server" ID="rfvSinif" CssClass="text-danger font-weight-bold" ControlToValidate="ddlSinif" ErrorMessage="Lütfen öğrenci sınıfını seçiniz." ValidationGroup="OgrenciKaydet"></asp:RequiredFieldValidator>
                    </div>

                </div>
                <div class="form-group row">
                    <label class="col-sm-2 col-form-label">1. Sınav Notu</label>
                    <div class="col-sm-10">
                        <input runat="server" id="txtSinav1" type="text" class="form-control" />
                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-sm-2 col-form-label">2. Sınav Notu</label>
                    <div class="col-sm-10">
                        <input runat="server" id="txtSinav2" type="text" class="form-control" />
                    </div>
                </div>

                <div class="form-group row">
                    <label class="col-sm-2 col-form-label">Performans Ödevi Notu</label>
                    <div class="col-sm-10">
                        <input runat="server" id="txtPerformans" type="text" class="form-control" />
                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-sm-2 col-form-label">Proje Ödevi Notu</label>
                    <div class="col-sm-10">
                        <input runat="server" id="txtProje" type="text" class="form-control" />
                    </div>
                </div>
                <div class="card-block" style="text-align: center">
                    <button runat="server" id="btnKaydet" class="btn btn-info btn-round col-sm-2" onserverclick="btnKaydet_ServerClick" validationgroup="OgrenciKaydet">
                        Kaydet
                    </button>
                    <button runat="server" id="btnGuncelle" class="btn btn-warning btn-round col-sm-2" onserverclick="btnGuncelle_ServerClick" validationgroup="OgrenciKaydet">
                        Güncelle
                    </button>
                    <button runat="server" id="btnSil" class="btn btn-danger btn-round col-sm-2" onserverclick="btnSil_ServerClick" validationgroup="OgrenciKaydet">
                        Sil
                    </button>

                </div>
            </form>
        </div>
    </div>

</div>

<div id="styleSelector"></div>


