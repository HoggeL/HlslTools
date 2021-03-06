﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Composition;
using ShaderTools.CodeAnalysis.Host.Mef;

namespace ShaderTools.CodeAnalysis.Editor
{
    /// <summary>
    /// Specifies the exact type of the service exported by the ILanguageService.
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    internal class ExportContentTypeLanguageServiceAttribute : ExportLanguageServiceAttribute
    {
        public string DefaultContentType { get; set; }

        public ExportContentTypeLanguageServiceAttribute(string defaultContentType, string language)
            : base(typeof(IContentTypeLanguageService), language)
        {
            this.DefaultContentType = defaultContentType ?? throw new ArgumentNullException(nameof(defaultContentType));
        }
    }
}
