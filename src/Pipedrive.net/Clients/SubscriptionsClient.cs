﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Pipedrive.Helpers;

namespace Pipedrive
{
    /// <summary>
    /// A client for Pipedrive's Subscription API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developers.pipedrive.com/docs/api/v1/Subscriptions">Subscription API documentation</a> for more information.
    public class SubscriptionsClient : ApiClient, ISubscriptionsClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsClient"/> class.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public SubscriptionsClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }

        public Task<Subscription> GetByDealId(long dealId)
        {
            return ApiConnection.Get<Subscription>(ApiUrls.SubscriptionsByDealId(dealId));
        }

        public Task<Subscription> Get(long id)
        {
            return ApiConnection.Get<Subscription>(ApiUrls.Subscription(id));
        }

        public Task<IReadOnlyList<Payment>> GetPayments(long id)
        {
            return ApiConnection.GetAll<Payment>(ApiUrls.SubscriptionPayments(id));
        }

        public Task<Subscription> CreateRecurring(NewRecurringSubscription data)
        {
            Ensure.ArgumentNotNull(data, nameof(data));

            return ApiConnection.Post<Subscription>(ApiUrls.SubscriptionRecurring(), data);
        }

        public Task<Subscription> CreateInstallment(NewInstallmentSubscription data)
        {
            Ensure.ArgumentNotNull(data, nameof(data));

            return ApiConnection.Post<Subscription>(ApiUrls.SubscriptionInstallment(), data);
        }

        public Task<Subscription> CancelRecurring(long id, CancelRecurringSubscription data)
        {
            return ApiConnection.Put<Subscription>(ApiUrls.SubscriptionRecurringCancellation(id), data);
        }

        public Task Delete(long id)
        {
            return ApiConnection.Delete(ApiUrls.Subscription(id));
        }
    }
}
