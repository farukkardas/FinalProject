using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string SameProductError = "Aynı isme sahip ürün eklenemez!";
        public static string ProductWillNotAdded = "Daha fazla ürün ekleyemezsiniz!";
        public static string AuthorizationDenied = "Yetki reddedildi";
        public static string UserAlreadyExists = "Üye zaten mevcut!";
        public static string SuccessfulLogin = "Başarıyla giriş yapıldı";
        public static string PasswordError = "Şifre yanlış";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string UserRegistered = "Kullanıcı kaydoldu";
        public static string AccessTokenCreated = "Access Tokeni oluşturuldu";
    }
}
