<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserOgrenciBilgisi.ascx.cs" Inherits="OgrenciBilgisi" %>

 <div class="card">
        <div class="card-block">
            <h4 class="sub-title text-capitalize">Öğrenci Arama</h4>
            <div class="form-group row ">
                <label class="col-sm-2 col-form-label">Öğrenci Numarası Girin</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control">
                </div>
                <button class="btn btn-danger btn-round col-sm-1">
                    Ara
                                                   
                </button>
            </div>

        </div>
        <div class="card-block">
            <h4 class="sub-title text-capitalize">Öğrenci Bilgileri</h4>
            <form>
                <div class="form-group row">
                    <label class="col-sm-2 col-form-label">Öğrenci Numarası</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control">
                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-sm-2 col-form-label">Öğrenci Adı</label>
                    <div class="col-sm-10">
                        <input type="text" id="ogrenciAd" class="form-control">
                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-sm-2 col-form-label">Öğrenci Soyadı</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control">
                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-sm-2 col-form-label">Öğrenci Sınıfı</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control">
                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-sm-2 col-form-label">Adresi</label>
                    <div class="col-sm-10">
                        <textarea rows="5" cols="5" class="form-control" placeholder="Default textarea"></textarea>
                    </div>

                </div>
                <div class="card-block " style="text-align: center;">
                    <button runat="server" id="btnKaydet" class="btn btn-success btn-round col-sm-2" onserverclick="btnKaydet_ServerClick">
                        Kaydet
                    </button>
                    <button runat="server" id="btnGuncelle" class="btn btn-info btn-round  col-sm-2" onserverclick="btnGuncelle_ServerClick">
                        Güncelle
                    </button>
                    <button runat="server" id="btnSil" class="btn btn-warning btn-round col-sm-2" onserverclick="btnSil_ServerClick">
                        Sil
                    </button>
                </div>
            </form>

        </div>
    </div>
</asp:Content>