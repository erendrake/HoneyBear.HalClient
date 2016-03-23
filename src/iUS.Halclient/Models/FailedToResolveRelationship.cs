using System;

namespace iUS.Halclient.Models
{
    public sealed class FailedToResolveRelationship : Exception
    {
        public FailedToResolveRelationship(string relationship)
            : base($"Failed to resolve relationship:{relationship}")
        {
        }
    }
}