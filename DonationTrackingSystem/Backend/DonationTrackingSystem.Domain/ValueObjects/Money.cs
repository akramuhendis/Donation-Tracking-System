using System;

namespace DonationTrackingSystem.Domain.ValueObjects
{
    /// <summary>
    /// Para miktarları için değer nesnesi
    /// </summary>
    public class Money
    {
        public decimal Amount { get; private set; }
        public string Currency { get; private set; }

        public Money(decimal amount, string currency = "TRY")
        {
            if (amount < 0)
                throw new ArgumentException("Para miktarı negatif olamaz.");

            if (string.IsNullOrWhiteSpace(currency))
                throw new ArgumentException("Para birimi boş olamaz.");

            Amount = amount;
            Currency = currency.ToUpper();
        }

        public static Money operator +(Money left, Money right)
        {
            if (left.Currency != right.Currency)
                throw new InvalidOperationException("Farklı para birimleri toplanamaz.");

            return new Money(left.Amount + right.Amount, left.Currency);
        }

        public static Money operator -(Money left, Money right)
        {
            if (left.Currency != right.Currency)
                throw new InvalidOperationException("Farklı para birimleri çıkarılamaz.");

            var result = left.Amount - right.Amount;
            if (result < 0)
                throw new InvalidOperationException("Sonuç negatif olamaz.");

            return new Money(result, left.Currency);
        }

        public static bool operator ==(Money left, Money right)
        {
            return left.Amount == right.Amount && left.Currency == right.Currency;
        }

        public static bool operator !=(Money left, Money right)
        {
            return !(left == right);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Money other)
                return Amount == other.Amount && Currency == other.Currency;
            return false;
        }

        public override int GetHashCode() => HashCode.Combine(Amount, Currency);

        public override string ToString() => $"{Amount:C} {Currency}";
    }
} 