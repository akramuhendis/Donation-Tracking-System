using System;
using System.Linq.Expressions;
using DonationTrackingSystem.Domain.Entities;
using DonationTrackingSystem.Domain.Enums;

namespace DonationTrackingSystem.Domain.Specifications
{
    /// <summary>
    /// Bağış varlıkları için specification örnekleri
    /// </summary>
    public class BagisSpecification : ISpecification<Bagis>
    {
        public Expression<Func<Bagis, bool>> Criteria { get; }
        public List<Expression<Func<Bagis, object>>> Includes { get; } = new();
        public Expression<Func<Bagis, object>>? OrderBy { get; private set; }
        public Expression<Func<Bagis, object>>? OrderByDescending { get; private set; }
        public int Skip { get; private set; }
        public int Take { get; private set; }
        public bool IsPagingEnabled { get; private set; }

        public BagisSpecification()
        {
            Criteria = x => !x.IsDeleted;
        }

        public BagisSpecification(Guid bagisciId)
        {
            Criteria = x => x.BagisciId == bagisciId && !x.IsDeleted;
            Includes.Add(x => x.Bagisci!);
        }

        public BagisSpecification(DateTime startDate, DateTime endDate)
        {
            Criteria = x => x.BagisTaihi >= startDate && x.BagisTaihi <= endDate && !x.IsDeleted;
            OrderByDescending = x => x.BagisTaihi;
        }

        public BagisSpecification(BagisTuru bagisTuru)
        {
            Criteria = x => x.BagisTuru == bagisTuru && !x.IsDeleted;
            OrderByDescending = x => x.BagisTaihi;
        }

        public BagisSpecification(decimal minAmount, decimal maxAmount)
        {
            Criteria = x => x.Tutar >= minAmount && x.Tutar <= maxAmount && !x.IsDeleted;
            OrderBy = x => x.Tutar;
        }

        public void AddInclude(Expression<Func<Bagis, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }

        public void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled = true;
        }

        public void ApplyOrderBy(Expression<Func<Bagis, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
        }

        public void ApplyOrderByDescending(Expression<Func<Bagis, object>> orderByDescExpression)
        {
            OrderByDescending = orderByDescExpression;
        }
    }
} 