// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Builder;

namespace SvelteKitDotNet.Extensions
{
    internal class DefaultSpaBuilder : ISpaBuilder
    {
        public IApplicationBuilder ApplicationBuilder { get; }

        public SpaOptions Options { get; set; }

        public DefaultSpaBuilder(IApplicationBuilder applicationBuilder, SpaOptions options)
        {
            ApplicationBuilder = applicationBuilder 
                ?? throw new ArgumentNullException(nameof(applicationBuilder));

            Options = options
                ?? throw new ArgumentNullException(nameof(options));
        }
    }
}
