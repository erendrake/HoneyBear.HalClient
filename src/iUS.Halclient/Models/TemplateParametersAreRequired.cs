using System;

namespace iUS.Halclient.Models
{
    public sealed class TemplateParametersAreRequired : Exception
    {
        public TemplateParametersAreRequired(ILink link)
            : base($"Template parameters are required for link={link}.")
        {
        }
    }
}