using System;

namespace iUS.Halclient.Models
{
    public sealed class NoActiveResource : Exception
    {
        public NoActiveResource()
            : base("No active resource; you must successfully navigate to a resource before using this command.")
        {
        }
    }
}