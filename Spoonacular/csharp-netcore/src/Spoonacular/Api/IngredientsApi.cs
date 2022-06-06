/*
 * spoonacular API
 *
 * The spoonacular Nutrition, Recipe, and Food API allows you to access over 380,000 recipes, thousands of ingredients, 800,000 food products, and 100,000 menu items. Our food ontology and semantic recipe search engine makes it possible to search for recipes using natural language queries, such as \"gluten free brownies without sugar\" or \"low fat vegan cupcakes.\" You can automatically calculate the nutritional information for any recipe, analyze recipe costs, visualize ingredient lists, find recipes for what's in your fridge, find recipes based on special diets, nutritional requirements, or favorite ingredients, classify recipes into types and cuisines, convert ingredient amounts, or even compute an entire meal plan. With our powerful API, you can create many kinds of food and especially nutrition apps.  Special diets/dietary requirements currently available include: vegan, vegetarian, pescetarian, gluten free, grain free, dairy free, high protein, whole 30, low sodium, low carb, Paleo, ketogenic, FODMAP, and Primal.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: mail@spoonacular.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Spoonacular.Client;

namespace Spoonacular.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIngredientsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Ingredients by ID Image
        /// </summary>
        /// <remarks>
        /// Visualize a recipe&#39;s ingredient list.
        /// </remarks>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The recipe id.</param>
        /// <param name="measure">Whether the the measures should be &#39;us&#39; or &#39;metric&#39;. (optional)</param>
        /// <returns>Object</returns>
        Object IngredientsByIDImage(decimal id, string? measure = default(string?));

        /// <summary>
        /// Ingredients by ID Image
        /// </summary>
        /// <remarks>
        /// Visualize a recipe&#39;s ingredient list.
        /// </remarks>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The recipe id.</param>
        /// <param name="measure">Whether the the measures should be &#39;us&#39; or &#39;metric&#39;. (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> IngredientsByIDImageWithHttpInfo(decimal id, string? measure = default(string?));
        /// <summary>
        /// Ingredients Widget
        /// </summary>
        /// <remarks>
        /// Visualize ingredients of a recipe. You can play around with that endpoint!
        /// </remarks>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">The content type. (optional)</param>
        /// <param name="language">The language of the input. Either &#39;en&#39; or &#39;de&#39;. (optional)</param>
        /// <param name="accept">Accept header. (optional)</param>
        /// <returns>string</returns>
        string VisualizeIngredients(string? contentType = default(string?), string? language = default(string?), string? accept = default(string?));

        /// <summary>
        /// Ingredients Widget
        /// </summary>
        /// <remarks>
        /// Visualize ingredients of a recipe. You can play around with that endpoint!
        /// </remarks>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">The content type. (optional)</param>
        /// <param name="language">The language of the input. Either &#39;en&#39; or &#39;de&#39;. (optional)</param>
        /// <param name="accept">Accept header. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> VisualizeIngredientsWithHttpInfo(string? contentType = default(string?), string? language = default(string?), string? accept = default(string?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIngredientsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Ingredients by ID Image
        /// </summary>
        /// <remarks>
        /// Visualize a recipe&#39;s ingredient list.
        /// </remarks>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The recipe id.</param>
        /// <param name="measure">Whether the the measures should be &#39;us&#39; or &#39;metric&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> IngredientsByIDImageAsync(decimal id, string? measure = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Ingredients by ID Image
        /// </summary>
        /// <remarks>
        /// Visualize a recipe&#39;s ingredient list.
        /// </remarks>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The recipe id.</param>
        /// <param name="measure">Whether the the measures should be &#39;us&#39; or &#39;metric&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> IngredientsByIDImageWithHttpInfoAsync(decimal id, string? measure = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Ingredients Widget
        /// </summary>
        /// <remarks>
        /// Visualize ingredients of a recipe. You can play around with that endpoint!
        /// </remarks>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">The content type. (optional)</param>
        /// <param name="language">The language of the input. Either &#39;en&#39; or &#39;de&#39;. (optional)</param>
        /// <param name="accept">Accept header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> VisualizeIngredientsAsync(string? contentType = default(string?), string? language = default(string?), string? accept = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Ingredients Widget
        /// </summary>
        /// <remarks>
        /// Visualize ingredients of a recipe. You can play around with that endpoint!
        /// </remarks>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">The content type. (optional)</param>
        /// <param name="language">The language of the input. Either &#39;en&#39; or &#39;de&#39;. (optional)</param>
        /// <param name="accept">Accept header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> VisualizeIngredientsWithHttpInfoAsync(string? contentType = default(string?), string? language = default(string?), string? accept = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIngredientsApi : IIngredientsApiSync, IIngredientsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class IngredientsApi : IIngredientsApi
    {
        private Spoonacular.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="IngredientsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IngredientsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngredientsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IngredientsApi(string basePath)
        {
            this.Configuration = Spoonacular.Client.Configuration.MergeConfigurations(
                Spoonacular.Client.GlobalConfiguration.Instance,
                new Spoonacular.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Spoonacular.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Spoonacular.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Spoonacular.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngredientsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IngredientsApi(Spoonacular.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Spoonacular.Client.Configuration.MergeConfigurations(
                Spoonacular.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Spoonacular.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Spoonacular.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Spoonacular.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngredientsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public IngredientsApi(Spoonacular.Client.ISynchronousClient client, Spoonacular.Client.IAsynchronousClient asyncClient, Spoonacular.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Spoonacular.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Spoonacular.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Spoonacular.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Spoonacular.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Spoonacular.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Ingredients by ID Image Visualize a recipe&#39;s ingredient list.
        /// </summary>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The recipe id.</param>
        /// <param name="measure">Whether the the measures should be &#39;us&#39; or &#39;metric&#39;. (optional)</param>
        /// <returns>Object</returns>
        public Object IngredientsByIDImage(decimal id, string? measure = default(string?))
        {
            Spoonacular.Client.ApiResponse<Object> localVarResponse = IngredientsByIDImageWithHttpInfo(id, measure);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Ingredients by ID Image Visualize a recipe&#39;s ingredient list.
        /// </summary>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The recipe id.</param>
        /// <param name="measure">Whether the the measures should be &#39;us&#39; or &#39;metric&#39;. (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public Spoonacular.Client.ApiResponse<Object> IngredientsByIDImageWithHttpInfo(decimal id, string? measure = default(string?))
        {
            Spoonacular.Client.RequestOptions localVarRequestOptions = new Spoonacular.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "image/png"
            };

            var localVarContentType = Spoonacular.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Spoonacular.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Spoonacular.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (measure != null)
            {
                localVarRequestOptions.QueryParameters.Add(Spoonacular.Client.ClientUtils.ParameterToMultiMap("", "measure", measure));
            }

            // authentication (apiKeyScheme) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.QueryParameters.Add(Spoonacular.Client.ClientUtils.ParameterToMultiMap("", "apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/recipes/{id}/ingredientWidget.png", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IngredientsByIDImage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Ingredients by ID Image Visualize a recipe&#39;s ingredient list.
        /// </summary>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The recipe id.</param>
        /// <param name="measure">Whether the the measures should be &#39;us&#39; or &#39;metric&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> IngredientsByIDImageAsync(decimal id, string? measure = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Spoonacular.Client.ApiResponse<Object> localVarResponse = await IngredientsByIDImageWithHttpInfoAsync(id, measure, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Ingredients by ID Image Visualize a recipe&#39;s ingredient list.
        /// </summary>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The recipe id.</param>
        /// <param name="measure">Whether the the measures should be &#39;us&#39; or &#39;metric&#39;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<Spoonacular.Client.ApiResponse<Object>> IngredientsByIDImageWithHttpInfoAsync(decimal id, string? measure = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Spoonacular.Client.RequestOptions localVarRequestOptions = new Spoonacular.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "image/png"
            };

            var localVarContentType = Spoonacular.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Spoonacular.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Spoonacular.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (measure != null)
            {
                localVarRequestOptions.QueryParameters.Add(Spoonacular.Client.ClientUtils.ParameterToMultiMap("", "measure", measure));
            }

            // authentication (apiKeyScheme) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.QueryParameters.Add(Spoonacular.Client.ClientUtils.ParameterToMultiMap("", "apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/recipes/{id}/ingredientWidget.png", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IngredientsByIDImage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Ingredients Widget Visualize ingredients of a recipe. You can play around with that endpoint!
        /// </summary>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">The content type. (optional)</param>
        /// <param name="language">The language of the input. Either &#39;en&#39; or &#39;de&#39;. (optional)</param>
        /// <param name="accept">Accept header. (optional)</param>
        /// <returns>string</returns>
        public string VisualizeIngredients(string? contentType = default(string?), string? language = default(string?), string? accept = default(string?))
        {
            Spoonacular.Client.ApiResponse<string> localVarResponse = VisualizeIngredientsWithHttpInfo(contentType, language, accept);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Ingredients Widget Visualize ingredients of a recipe. You can play around with that endpoint!
        /// </summary>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">The content type. (optional)</param>
        /// <param name="language">The language of the input. Either &#39;en&#39; or &#39;de&#39;. (optional)</param>
        /// <param name="accept">Accept header. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public Spoonacular.Client.ApiResponse<string> VisualizeIngredientsWithHttpInfo(string? contentType = default(string?), string? language = default(string?), string? accept = default(string?))
        {
            Spoonacular.Client.RequestOptions localVarRequestOptions = new Spoonacular.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/html"
            };

            var localVarContentType = Spoonacular.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Spoonacular.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (language != null)
            {
                localVarRequestOptions.QueryParameters.Add(Spoonacular.Client.ClientUtils.ParameterToMultiMap("", "language", language));
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", Spoonacular.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", Spoonacular.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            // authentication (apiKeyScheme) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.QueryParameters.Add(Spoonacular.Client.ClientUtils.ParameterToMultiMap("", "apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<string>("/recipes/visualizeIngredients", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("VisualizeIngredients", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Ingredients Widget Visualize ingredients of a recipe. You can play around with that endpoint!
        /// </summary>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">The content type. (optional)</param>
        /// <param name="language">The language of the input. Either &#39;en&#39; or &#39;de&#39;. (optional)</param>
        /// <param name="accept">Accept header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> VisualizeIngredientsAsync(string? contentType = default(string?), string? language = default(string?), string? accept = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Spoonacular.Client.ApiResponse<string> localVarResponse = await VisualizeIngredientsWithHttpInfoAsync(contentType, language, accept, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Ingredients Widget Visualize ingredients of a recipe. You can play around with that endpoint!
        /// </summary>
        /// <exception cref="Spoonacular.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">The content type. (optional)</param>
        /// <param name="language">The language of the input. Either &#39;en&#39; or &#39;de&#39;. (optional)</param>
        /// <param name="accept">Accept header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<Spoonacular.Client.ApiResponse<string>> VisualizeIngredientsWithHttpInfoAsync(string? contentType = default(string?), string? language = default(string?), string? accept = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Spoonacular.Client.RequestOptions localVarRequestOptions = new Spoonacular.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/html"
            };

            var localVarContentType = Spoonacular.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Spoonacular.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (language != null)
            {
                localVarRequestOptions.QueryParameters.Add(Spoonacular.Client.ClientUtils.ParameterToMultiMap("", "language", language));
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", Spoonacular.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", Spoonacular.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            // authentication (apiKeyScheme) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.QueryParameters.Add(Spoonacular.Client.ClientUtils.ParameterToMultiMap("", "apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<string>("/recipes/visualizeIngredients", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("VisualizeIngredients", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
