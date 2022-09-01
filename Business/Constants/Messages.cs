
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string FormAdded = "form eklendi";
        public static string UserAdded = "kullanıcı eklendi";
        public static string userInvalid = "kullanıcı  bulunamadı";
        public static string ProductListed = "ürünler listelendi";



        public static string MaintanceTime = "Sunucu bakımda";
        public static string  userDeleted = "kullanıcı silindi";
        public static string UserGet="Maillere göre kullanıcılar getirildi";
        public static string claimDeleted = "Maillere göre kullanıcılar getirildi";
        public static string claimAdded = "Maillere göre kullanıcılar getirildi";
        public static string claimBrought = "Maillere göre kullanıcılar getirildi";
        public static string InfoGetted = "Maillere göre kullanıcılar getirildi";

        public static string InvalidUnitPrice { get; internal set; }
        
        public static string CategoryLimitExceed { get; internal set; }
        public static string AuthorizationDenied { get; internal set; }
        public static string UserNotFound { get; internal set; }
        public static string UserRegistered { get; internal set; }
        public static string PasswordError { get; internal set; }
        public static string SuccessfulLogin { get; internal set; }
        public static string UserAlreadyExists { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
        public static string UserUpdated { get; internal set; }
        public static string claimUpdated { get; internal set; }
        public static string Notnull { get; internal set; }
    }
}
