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

    /// <summary>
    /// The type  DriveRequestBuilder.
    /// </summary>
    public partial class DriveRequestBuilder : BaseRequestBuilder, IDriveRequestBuilder
    {
        /// <summary>
        /// Constructs a new DriveRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="oneDriveClient">The <see cref="IOneDriveClient"/> for handling requests.</param>
        public DriveRequestBuilder(
            string requestUrl,
            IOneDriveClient oneDriveClient)
            : base(requestUrl, oneDriveClient)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDriveRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDriveRequest Request(IList<Option> options)
        {
            return new DriveRequest(this.RequestUrl, this.OneDriveClient, options);
        }

    
        /// <summary>
        /// Gets the request builder for Items.
        /// </summary>
        /// <returns>The <see cref="IItemsCollectionRequestBuilder"/>.</returns>
        public IItemsCollectionRequestBuilder Items
        {
            get
            {
                return new ItemsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("items"), this.OneDriveClient);
            }
        }
    
        /// <summary>
        /// Gets the request builder for Shared.
        /// </summary>
        /// <returns>The <see cref="ISharedCollectionRequestBuilder"/>.</returns>
        public ISharedCollectionRequestBuilder Shared
        {
            get
            {
                return new SharedCollectionRequestBuilder(this.AppendSegmentToRequestUrl("shared"), this.OneDriveClient);
            }
        }
    
        /// <summary>
        /// Gets the request builder for Special.
        /// </summary>
        /// <returns>The <see cref="ISpecialCollectionRequestBuilder"/>.</returns>
        public ISpecialCollectionRequestBuilder Special
        {
            get
            {
                return new SpecialCollectionRequestBuilder(this.AppendSegmentToRequestUrl("special"), this.OneDriveClient);
            }
        }
    
        /// <summary>
        /// Gets the request builder for DriveAllPhotos.
        /// </summary>
        /// <returns>The <see cref="IDriveAllPhotosRequestBuilder"/>.</returns>
        public IDriveAllPhotosRequestBuilder AllPhotos()
        {
            return new DriveAllPhotosRequestBuilder(
                this.AppendSegmentToRequestUrl("view.allPhotos"),
                this.OneDriveClient);
        }
    
        /// <summary>
        /// Gets the request builder for DriveRecent.
        /// </summary>
        /// <returns>The <see cref="IDriveRecentRequestBuilder"/>.</returns>
        public IDriveRecentRequestBuilder Recent()
        {
            return new DriveRecentRequestBuilder(
                this.AppendSegmentToRequestUrl("view.recent"),
                this.OneDriveClient);
        }
    
        /// <summary>
        /// Gets the request builder for DriveSharedWithMe.
        /// </summary>
        /// <returns>The <see cref="IDriveSharedWithMeRequestBuilder"/>.</returns>
        public IDriveSharedWithMeRequestBuilder SharedWithMe()
        {
            return new DriveSharedWithMeRequestBuilder(
                this.AppendSegmentToRequestUrl("view.sharedWithMe"),
                this.OneDriveClient);
        }
    
    }
}
