﻿using iUS.Halclient.Models;
using Newtonsoft.Json;
using System;

namespace iUS.Halclient.Serialization
{
    public sealed class HalResourceJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existing, JsonSerializer serializer)
            => HalResourceJsonReader.ReadResource(reader, serializer);

        public override bool CanConvert(Type objectType) => typeof(IResource).IsAssignableFrom(objectType);
    }
}