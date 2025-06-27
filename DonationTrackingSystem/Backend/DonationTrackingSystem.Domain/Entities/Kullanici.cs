using System;
using System.ComponentModel.DataAnnotations;
using DonationTrackingSystem.Domain.Enums;
using DonationTrackingSystem.Domain.Common;

namespace DonationTrackingSystem.Domain.Entities
{
    /// <summary>
    /// Sistemdeki kullanıcıların bilgilerini tutan sınıf
    /// </summary>
    public class Kullanici : AuditableEntity // AuditableEntity ile izleme alanları da gelir
    {
        /// <summary>
        /// Kullanıcının adı
        /// </summary>
        [Required, MaxLength(50)]
        public string Ad { get; set; }  = string.Empty;

        /// <summary>
        /// Kullanıcının soyadı
        /// </summary>
        [Required, MaxLength(50)]
        public string Soyad { get; set; } = string.Empty;

        /// <summary>
        /// Kullanıcının e-posta adresi
        /// </summary>
        [Required, EmailAddress]
        public string Eposta { get; set; } = string.Empty;

        /// <summary>
        /// Kullanıcının şifresi
        /// </summary>
        [Required, MinLength(6)]
        public string Sifre { get; set; } = string.Empty;

        /// <summary>
        /// Kullanıcının sistemdeki rolü (örn: Admin, Kullanıcı)
        /// </summary>
        public Rol Rol { get; set; }

        /// <summary>
        /// Kullanıcının sisteme kayıt olduğu tarih
        /// </summary>
        public DateTime KayitTarihi { get; set; } = DateTime.UtcNow;
    }
}
