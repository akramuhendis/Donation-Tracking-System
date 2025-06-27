using System;

namespace DonationTrackingSystem.Domain.Exceptions
{
    /// <summary>
    /// Domain katmanı için temel exception sınıfı
    /// </summary>
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }

        public DomainException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// Bağış işlemleri için özel exception
    /// </summary>
    public class BagisException : DomainException
    {
        public BagisException(string message) : base(message)
        {
        }
    }

    /// <summary>
    /// Kullanıcı işlemleri için özel exception
    /// </summary>
    public class KullaniciException : DomainException
    {
        public KullaniciException(string message) : base(message)
        {
        }
    }

    /// <summary>
    /// Muhasebe işlemleri için özel exception
    /// </summary>
    public class MuhasebeException : DomainException
    {
        public MuhasebeException(string message) : base(message)
        {
        }
    }
} 