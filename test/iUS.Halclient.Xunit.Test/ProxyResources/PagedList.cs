namespace iUS.Halclient.Test.ProxyResources
{
    internal class PagedList
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int KnownPagesAvailable { get; set; }
        public int TotalItemsCount { get; set; }
    }
}