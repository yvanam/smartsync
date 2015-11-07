// ------------------------------------------------------------------------------
//  Copyright (c) 2015 Microsoft Corporation
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// The type ItemAllPhotosRequest.
    /// </summary>
    public partial class ItemAllPhotosRequest : BaseRequest, IItemAllPhotosRequest
    {
    
        /// <summary>
        /// Constructs a new ItemAllPhotosRequest.
        /// </summary>
        public ItemAllPhotosRequest(
            string requestUrl,
            IOneDriveClient oneDriveClient,
            IList<Option> options)
            : base(requestUrl, oneDriveClient, options)
        {
    
        }
    
        /// <summary>
        /// Issues the GET request.
        /// </summary>
        public async Task<IItemAllPhotosCollectionPage> GetAsync()
        {
    
            var response = await this.SendAsync<ItemAllPhotosCollectionResponse>(null);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    response.Value.AdditionalData = response.AdditionalData;
                    
                    object nextPageLink;
                    response.AdditionalData.TryGetValue("@odata.nextLink", out nextPageLink);

                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        response.Value.InitializeNextPageRequest(
                            this.OneDriveClient,
                            nextPageLinkString);
                    }
                }
            
                return response.Value;
            }

            return null;
    
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IItemAllPhotosRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IItemAllPhotosRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IItemAllPhotosRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("top", value.ToString()));
            return this;
        }

    }
}
