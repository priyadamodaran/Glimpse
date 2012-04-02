using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Glimpse.Core2.Framework
{
    public class GlimpseMetadata
    {
        public GlimpseMetadata()
        {
            Plugins = new Dictionary<string, PluginMetadata>();

            //TODO: this is really bad... Nik needs to work on how we want to do this. Version numbers need to be taken intoaccount too
            Paths = new { history = "History", paging = "Pager", ajax = "Ajax", config = "Config", logo = "/Glimpse.axd?n=logo.png&Version=1.0.0", sprite = "/Glimpse.axd?n=sprite.png&Version=1.0.0", popup = "test-popup.html" };
        }

        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "plugins")]
        public IDictionary<string,PluginMetadata> Plugins { get; set; }

        [JsonProperty(PropertyName = "paths")]
        public object Paths { get; set; }
    }

    public class PluginMetadata
    {
        [JsonProperty(PropertyName = "documentationUri")]
        public string DocumentationUri { get; set; }

        [JsonProperty(PropertyName = "hasMetadata")]
        public bool HasMetadata { get { return !string.IsNullOrEmpty(DocumentationUri); } }
    }
}