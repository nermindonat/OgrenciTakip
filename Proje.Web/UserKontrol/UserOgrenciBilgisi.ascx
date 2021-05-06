<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserOgrenciBilgisi.ascx.cs" Inherits="Proje.Web.UserKontrol.UserOgrenciBilgisi" %>

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
                        <input type="text" class="form-control">
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
                    <button class="btn btn-info btn-round  col-sm-2">
                        Güncelle
                                                                   
                    </button>
                    <button class="btn btn-warning btn-round col-sm-2">
                        Sil
                                                                   
                    </button>
                </div>
            </form>

        </div>
    </div>
</asp:Content>