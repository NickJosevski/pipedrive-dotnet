﻿using System;

namespace Pipedrive
{
    /// <summary>
    /// Class for retrieving Pipedrive API URLs
    /// </summary>
    public static class ApiUrls
    {
        static readonly Uri _activitiesUrl = new Uri("activities", UriKind.Relative);

        static readonly Uri _activityFieldsUrl = new Uri("activityFields", UriKind.Relative);

        static readonly Uri _activityTypesUrl = new Uri("activityTypes", UriKind.Relative);

        static readonly Uri _currenciesUrl = new Uri("currencies", UriKind.Relative);

        static readonly Uri _dealsUrl = new Uri("deals", UriKind.Relative);

        static readonly Uri _dealFieldsUrl = new Uri("dealFields", UriKind.Relative);

        static readonly Uri _filesUrl = new Uri("files", UriKind.Relative);

        static readonly Uri _leadsUrl = new Uri("leads", UriKind.Relative);

        static readonly Uri _notesUrl = new Uri("notes", UriKind.Relative);

        static readonly Uri _noteFieldsUrl = new Uri("noteFields", UriKind.Relative);

        static readonly Uri _organizationsUrl = new Uri("organizations", UriKind.Relative);

        static readonly Uri _organizationFieldsUrl = new Uri("organizationFields", UriKind.Relative);

        static readonly Uri _personsUrl = new Uri("persons", UriKind.Relative);

        static readonly Uri _personFieldsUrl = new Uri("personFields", UriKind.Relative);

        static readonly Uri _pipelinesUrl = new Uri("pipelines", UriKind.Relative);

        static readonly Uri _productsUrl = new Uri("products", UriKind.Relative);

        static readonly Uri _productFieldsUrl = new Uri("productFields", UriKind.Relative);

        static readonly Uri _stagesUrl = new Uri("stages", UriKind.Relative);

        static readonly Uri _subscriptionsUrl = new Uri("subscriptions", UriKind.Relative);

        static readonly Uri _usersUrl = new Uri("users", UriKind.Relative);

        static readonly Uri _webhooksUrl = new Uri("webhooks", UriKind.Relative);

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the activities.
        /// </summary>
        /// <returns></returns>
        public static Uri Activities()
        {
            return _activitiesUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified activity.
        /// </summary>
        /// <param name="id">The id of the activity</param>
        public static Uri Activity(long id)
        {
            return new Uri($"activities/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the activity fields in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri ActivityFields()
        {
            return _activityFieldsUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the activity types in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri ActivityTypes()
        {
            return _activityTypesUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified activity type.
        /// </summary>
        /// <param name="id">The id of the activity type</param>
        public static Uri ActivityType(long id)
        {
            return new Uri($"activityTypes/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the currencies in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri Currencies()
        {
            return _currenciesUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the deals in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri Deals()
        {
            return _dealsUrl;
        }

        /// <summary>
        /// return the <see cref="Uri"/> that return all the found deals.
        /// </summary>
        /// <returns>A Uri.</returns>
        public static Uri DealsSearch()
        {
            return new Uri("deals/search", UriKind.Relative);
        }

        public static Uri DealsSummary()
        {
            return new Uri("deals/summary", UriKind.Relative);
        }

        public static Uri DealsTimeline()
        {
            return new Uri("deals/timeline", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified deal.
        /// </summary>
        /// <param name="id">The id of the deal</param>
        public static Uri Deal(long id)
        {
            return new Uri($"deals/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the files of the specified deal.
        /// </summary>
        /// <param name="id">The id of the deal</param>
        public static Uri DealFiles(long id)
        {
            return new Uri($"deals/{id}/files", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the updates of the specified deal.
        /// </summary>
        /// <param name="id">The id of the deal</param>
        public static Uri DealUpdates(long id)
        {
            return new Uri($"deals/{id}/flow", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the mail messages of the specified deal.
        /// </summary>
        /// <param name="id">The id of the deal</param>
        public static Uri DealMailMessages(long id)
        {
            return new Uri($"deals/{id}/mailMessages", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the followers of the specified deal.
        /// </summary>
        /// <param name="id">The id of the deal</param>
        public static Uri DealFollowers(long id)
        {
            return new Uri($"deals/{id}/followers", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for deleting the follower of the specified deal.
        /// </summary>
        /// <param name="id">The id of the deal</param>
        /// <param name="dealFollowerId">The id of the deal follower</param>
        public static Uri DeleteDealFollower(long id, long dealFollowerId)
        {
            return new Uri($"deals/{id}/followers/{dealFollowerId}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the activities of the specified deal.
        /// </summary>
        /// <param name="id">The id of the deal</param>
        public static Uri DealActivities(long id)
        {
            return new Uri($"deals/{id}/activities", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the persons of the specified deal.
        /// </summary>
        /// <param name="id">The id of the deal</param>
        public static Uri DealPersons(long id)
        {
            return new Uri($"deals/{id}/persons", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the participants of the specified deal.
        /// </summary>
        /// <param name="id">The id of the deal</param>
        public static Uri DealParticipants(long id)
        {
            return new Uri($"deals/{id}/participants", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for deleting the participant of the specified deal.
        /// </summary>
        /// <param name="id">The id of the deal</param>
        /// <param name="dealParticipantId">The id of the deal participant</param>
        public static Uri DeleteDealParticipant(long id, long dealParticipantId)
        {
            return new Uri($"deals/{id}/participants/{dealParticipantId}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns products attached to deal.
        /// </summary>
        /// <param name="id">The id of the deal</param>
        public static Uri DealProducts(long id)
        {
            return new Uri($"deals/{id}/products", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for adding a product to a deal.
        /// </summary>
        /// <param name="id">The id of the deal</param>
        public static Uri AddProductToDeal(long id)
        {
            return new Uri($"deals/{id}/products", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for updating a product on a deal.
        /// </summary>
        /// <param name="id">The id of the deal</param>
        /// <param name="dealProductId">The id of the deal-product</param>
        public static Uri UpdateDealProduct(long id, long dealProductId)
        {
            return new Uri($"deals/{id}/products/{dealProductId}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for deleting a product on a deal.
        /// </summary>
        /// <param name="id">The id of the deal</param>
        /// <param name="dealProductId">The id of the deal-product</param>
        public static Uri DeleteDealProduct(long id, long dealProductId)
        {
            return new Uri($"deals/{id}/products/{dealProductId}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the activity fields in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri DealFields()
        {
            return _dealFieldsUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified deal field.
        /// </summary>
        /// <param name="id">The id of the deal field</param>
        public static Uri DealField(long id)
        {
            return new Uri($"dealFields/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the files in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri Files()
        {
            return _filesUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified file.
        /// </summary>
        /// <param name="id">The id of the file</param>
        public static Uri File(long id)
        {
            return new Uri($"files/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the leads in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri Leads()
        {
            return _leadsUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified lead.
        /// </summary>
        /// <param name="id">The id of the lead</param>
        /// <returns></returns>
        public static Uri Lead(Guid id)
        {
            return new Uri($"leads/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the notes in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri Notes()
        {
            return _notesUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified note.
        /// </summary>
        /// <param name="id">The id of the note</param>
        public static Uri Note(long id)
        {
            return new Uri($"notes/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the note fields in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri NoteFields()
        {
            return _noteFieldsUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the organizations in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri Organizations()
        {
            return _organizationsUrl;
        }

        /// <summary>
        /// return the <see cref="Uri"/> that return all the found organizations.
        /// </summary>
        /// <returns>A Uri.</returns>
        public static Uri OrganizationsSearch()
        {
            return new Uri("organizations/search", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified organization.
        /// </summary>
        /// <param name="id">The id of the organization</param>
        public static Uri Organization(long id)
        {
            return new Uri($"organizations/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the deals of the specified organization.
        /// </summary>
        /// <param name="id">The id of the organization</param>
        public static Uri OrganizationDeals(long id)
        {
            return new Uri($"organizations/{id}/deals", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the followers of the specified organization.
        /// </summary>
        /// <param name="id">The id of the organization</param>
        public static Uri OrganizationFollowers(long id)
        {
            return new Uri($"organizations/{id}/followers", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for deleting the follower of the specified organization.
        /// </summary>
        /// <param name="id">The id of the organization</param>
        /// <param name="organizationFollowerId">The id of the organization follower</param>
        public static Uri DeleteOrganizationFollower(long id, long organizationFollowerId)
        {
            return new Uri($"organizations/{id}/followers/{organizationFollowerId}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the mail messages of the specified organization.
        /// </summary>
        /// <param name="id">The id of the organization</param>
        public static Uri OrganizationMailMessages(long id)
        {
            return new Uri($"organizations/{id}/mailMessages", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the activities of the specified organization.
        /// </summary>
        /// <param name="id">The id of the organization</param>
        public static Uri OrganizationActivities(long id)
        {
            return new Uri($"organizations/{id}/activities", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the files of the specified organization.
        /// </summary>
        /// <param name="id">The id of the organization</param>
        public static Uri OrganizationFiles(long id)
        {
            return new Uri($"organizations/{id}/files", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the updates of the specified organization.
        /// </summary>
        /// <param name="id">The id of the organization</param>
        public static Uri OrganizationUpdates(long id)
        {
            return new Uri($"organizations/{id}/flow", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the organization fields in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri OrganizationFields()
        {
            return _organizationFieldsUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified organization field.
        /// </summary>
        /// <param name="id">The id of the organization field</param>
        public static Uri OrganizationField(long id)
        {
            return new Uri($"organizationFields/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the all the persons of the specified organization.
        /// </summary>
        /// <param name="id">The id of the organization</param>
        public static Uri OrganizationPersons(long id)
        {
            return new Uri($"organizations/{id}/persons", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the persons in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri Persons()
        {
            return _personsUrl;
        }

        /// <summary>
        /// return the <see cref="Uri"/> that return all the found persons.
        /// </summary>
        /// <returns>A Uri.</returns>
        public static Uri PersonsSearch()
        {
            return new Uri("persons/search", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified person.
        /// </summary>
        /// <param name="id">The id of the person</param>
        public static Uri Person(long id)
        {
            return new Uri($"persons/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the deals of the specified person.
        /// </summary>
        /// <param name="id">The id of the person</param>
        public static Uri PersonDeals(long id)
        {
            return new Uri($"persons/{id}/deals", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the activities of the specified person.
        /// </summary>
        /// <param name="id">The id of the person</param>
        public static Uri PersonActivities(long id)
        {
            return new Uri($"persons/{id}/activities", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the files of the specified person.
        /// </summary>
        /// <param name="id">The id of the person</param>
        public static Uri PersonFiles(long id)
        {
            return new Uri($"persons/{id}/files", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the updates of the specified person.
        /// </summary>
        /// <param name="id">The id of the person</param>
        public static Uri PersonUpdates(long id)
        {
            return new Uri($"persons/{id}/flow", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the followers of the specified person.
        /// </summary>
        /// <param name="id">The id of the person</param>
        public static Uri PersonFollowers(long id)
        {
            return new Uri($"persons/{id}/followers", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for deleting the follower of the specified person.
        /// </summary>
        /// <param name="id">The id of the person</param>
        /// <param name="personFollowerId">The id of the person follower</param>
        public static Uri DeletePersonFollower(long id, long personFollowerId)
        {
            return new Uri($"persons/{id}/followers/{personFollowerId}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the mail messages of the specified person.
        /// </summary>
        /// <param name="id">The id of the organization</param>
        public static Uri PersonMailMessages(long id)
        {
            return new Uri($"persons/{id}/mailMessages", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the person fields in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri PersonFields()
        {
            return _personFieldsUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified person field.
        /// </summary>
        /// <param name="id">The id of the person field</param>
        public static Uri PersonField(long id)
        {
            return new Uri($"personFields/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the pipelines in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri Pipelines()
        {
            return _pipelinesUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified pipeline.
        /// </summary>
        /// <param name="id">The id of the pipeline</param>
        public static Uri Pipeline(long id)
        {
            return new Uri($"pipelines/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the deals of the specified pipeline.
        /// </summary>
        /// <param name="id">The id of the pipeline</param>
        public static Uri PipelineDeal(long id)
        {
            return new Uri($"pipelines/{id}/deals", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the products in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri Products()
        {
            return _productsUrl;
        }

        /// <summary>
        /// return the <see cref="Uri"/> that returns all the found products.
        /// </summary>
        /// <returns>A Uri.</returns>
        public static Uri ProductsSearch()
        {
            return new Uri("products/search", UriKind.Relative);
        }

        /// <summary>
        /// return the <see cref="Uri"/> that returns the product.
        /// </summary>
        /// <returns></returns>
        public static Uri Product(long id)
        {
            return new Uri($"products/{id}", UriKind.Relative);
        }

        /// <summary>
        /// return the <see cref="Uri"/> that returns the deals for a specific product.
        /// </summary>
        /// <returns></returns>
        public static Uri ProductDeals(long id)
        {
            return new Uri($"products/{id}/deals", UriKind.Relative);
        }

        /// <summary>
        /// return the <see cref="Uri"/> that returns the files for a specific product.
        /// </summary>
        /// <returns></returns>
        public static Uri ProductFiles(long id)
        {
            return new Uri($"products/{id}/files", UriKind.Relative);
        }

        /// <summary>
        /// return the <see cref="Uri"/> that returns the followers for a specific product.
        /// </summary>
        /// <returns></returns>
        public static Uri ProductFollowers(long id)
        {
            return new Uri($"products/{id}/followers", UriKind.Relative);
        }

        /// <summary>
        /// return the <see cref="Uri"/> can be used for deleting a follower from a product.
        /// </summary>
        /// <returns></returns>
        public static Uri ProductDeleteFollower(long id, long userId)
        {
            return new Uri($"products/{id}/followers/{userId}", UriKind.Relative);
        }

        /// <summary>
        /// return the <see cref="Uri"/> that returns the permitted users for a specific product.
        /// </summary>
        /// <returns></returns>
        public static Uri ProductPermittedUsers(long id)
        {
            return new Uri($"products/{id}/permittedUsers", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the product fields in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri ProductFields()
        {
            return _productFieldsUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified product field.
        /// </summary>
        /// <param name="id">The id of the product field</param>
        public static Uri ProductField(long id)
        {
            return new Uri($"productFields/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the stages in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri Stages()
        {
            return _stagesUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified stage.
        /// </summary>
        /// <param name="id">The id of the stage</param>
        public static Uri Stage(long id)
        {
            return new Uri($"stages/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for all the deals of the specified stage.
        /// </summary>
        /// <param name="id">The id of the stage</param>
        public static Uri StageDeal(long id)
        {
            return new Uri($"stages/{id}/deals", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the subscriptions in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri Subscriptions()
        {
            return _subscriptionsUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that creates a recurring subscription.
        /// </summary>
        /// <returns></returns>
        public static Uri SubscriptionRecurring()
        {
            return new Uri($"subscriptions/recurring", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that creates a installment subscription.
        /// </summary>
        /// <returns></returns>
        public static Uri SubscriptionInstallment()
        {
            return new Uri($"subscriptions/installment", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the subscriptions for a specific deal.
        /// </summary>
        /// <param name="dealId">The id of the deal</param>
        public static Uri SubscriptionsByDealId(long dealId)
        {
            return new Uri($"subscriptions/find/{dealId}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the payments for a specific subscription.
        /// </summary>
        /// <param name="id">The id of the subscription</param>
        public static Uri SubscriptionPayments(long id)
        {
            return new Uri($"subscriptions/{id}/payments", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified subscription.
        /// </summary>
        /// <param name="id">The id of the subscription</param>
        public static Uri SubscriptionRecurringCancellation(long id)
        {
            return new Uri($"subscriptions/recurring/{id}/cancel", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified subscription.
        /// </summary>
        /// <param name="id">The id of the subscription</param>
        public static Uri Subscription(long id)
        {
            return new Uri($"subscriptions/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the users in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri Users()
        {
            return _usersUrl;
        }

        /// <summary>
        /// return the <see cref="Uri"/> that return all the finded users.
        /// </summary>
        /// <returns></returns>
        public static Uri UsersFind()
        {
            return new Uri("users/find", UriKind.Relative);
        }

        /// <summary>
        /// return the <see cref="Uri"/> that return all the finded users.
        /// </summary>
        /// <returns></returns>
        public static Uri UsersMe()
        {
            return new Uri("users/me", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified user.
        /// </summary>
        /// <param name="id">The id of the user</param>
        public static Uri User(long id)
        {
            return new Uri($"users/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the webhooks.
        /// </summary>
        /// <returns></returns>
        public static Uri Webhooks()
        {
            return _webhooksUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> for the specified activity.
        /// </summary>
        /// <param name="id">The id of the webhook</param>
        public static Uri Webhook(long id)
        {
            return new Uri($"{_webhooksUrl}/{id}", UriKind.Relative);
        }

        /// <summary>
        /// Creates the relative <see cref="Uri"/> for initiating the OAuth Web login Flow
        /// </summary>
        /// <returns></returns>
        public static Uri OAuthAuthorize()
        {
            return new Uri("oauth/authorize", UriKind.Relative);
        }

        /// <summary>
        /// Creates the relative <see cref="Uri"/> to request an OAuth access token.
        /// </summary>
        /// <returns></returns>
        public static Uri OAuthAccessToken()
        {
            return new Uri("oauth/token", UriKind.Relative);
        }

        /// <summary>
        /// Creates the relative <see cref="Uri"/> to request an OAuth access token.
        /// </summary>
        /// <returns></returns>
        public static Uri OAuthRevokeToken()
        {
            return new Uri("oauth/revoke", UriKind.Relative);
        }
    }
}
