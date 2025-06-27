using System.Threading.Tasks;
using DonationTrackingSystem.Domain.Entities;

namespace DonationTrackingSystem.Domain.Validators
{
    /// <summary>
    /// Bağış işlemleri için validation arayüzü
    /// </summary>
    public interface IBagisValidator
    {
        /// <summary>
        /// Bağış tutarının geçerli olup olmadığını kontrol eder
        /// </summary>
        Task<bool> ValidateTutarAsync(decimal tutar);

        /// <summary>
        /// Bağışçının bağış yapabilir durumda olup olmadığını kontrol eder
        /// </summary>
        Task<bool> ValidateBagisciAsync(Guid bagisciId);

        /// <summary>
        /// Bağış türünün geçerli olup olmadığını kontrol eder
        /// </summary>
        Task<bool> ValidateBagisTuruAsync(Enums.BagisTuru bagisTuru);

        /// <summary>
        /// Bağış tarihinin geçerli olup olmadığını kontrol eder
        /// </summary>
        Task<bool> ValidateBagisTarihiAsync(System.DateTime bagisTarihi);

        /// <summary>
        /// Tüm validation kurallarını kontrol eder
        /// </summary>
        Task<ValidationResult> ValidateBagisAsync(Bagis bagis);
    }

    /// <summary>
    /// Validation sonucu için değer nesnesi
    /// </summary>
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public string[] Errors { get; set; } = Array.Empty<string>();

        public static ValidationResult Success() => new() { IsValid = true };
        public static ValidationResult Failure(params string[] errors) => new() { IsValid = false, Errors = errors };
    }
} 