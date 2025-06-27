using System;
using System.Text.RegularExpressions;

namespace DonationTrackingSystem.Domain.ValueObjects
{
    /// <summary>
    /// E-posta adresi için değer nesnesi
    /// </summary>
    public class Email
    {
        public string Value { get; private set; }

        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("E-posta adresi boş olamaz.");

            if (!IsValidEmail(value))
                throw new ArgumentException("Geçersiz e-posta formatı.");

            Value = value.ToLowerInvariant();
        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        public static implicit operator string(Email email) => email.Value;
        public static explicit operator Email(string value) => new Email(value);

        public override bool Equals(object? obj)
        {
            if (obj is Email other)
                return Value == other.Value;
            return false;
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value;
    }
} 