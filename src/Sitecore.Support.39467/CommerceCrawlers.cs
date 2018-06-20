namespace Sitecore.Support.Commerce.Engine.Connect.Search.Crawlers
{
  using System.Threading;
  using Sitecore.ContentSearch;
  using Sitecore.Diagnostics;

  public class SellableItemsCrawler : Sitecore.Commerce.Engine.Connect.Search.Crawlers.SellableItemsCrawler
  {
    public override void RefreshFromRoot(IProviderUpdateContext context, IIndexable indexableStartingPoint, IndexingOptions indexingOptions, CancellationToken cancellationToken)
    {
      // This is the copy of the base method needed here to avoid ERROR: indexableStartingPoint SitecoreIndexableItem is not an instance of CommerceCatalogIndexableItem
      Assert.ArgumentNotNull(context, "context");
      if (base.ShouldStartIndexing(indexingOptions))
      {
        this.Update(context, cancellationToken);
      }
    }
  }

  public class CategoriesCrawler : Sitecore.Commerce.Engine.Connect.Search.Crawlers.CategoriesCrawler
  {
    public override void RefreshFromRoot(IProviderUpdateContext context, IIndexable indexableStartingPoint, IndexingOptions indexingOptions, CancellationToken cancellationToken)
    {
      // This is the copy of the base method needed here to avoid ERROR: indexableStartingPoint SitecoreIndexableItem is not an instance of CommerceCatalogIndexableItem
      Assert.ArgumentNotNull(context, "context");
      if (base.ShouldStartIndexing(indexingOptions))
      {
        this.Update(context, cancellationToken);
      }
    }
  }

  public class CatalogsCrawler : Sitecore.Commerce.Engine.Connect.Search.Crawlers.CatalogsCrawler
  {
    public override void RefreshFromRoot(IProviderUpdateContext context, IIndexable indexableStartingPoint, IndexingOptions indexingOptions, CancellationToken cancellationToken)
    {
      // This is the copy of the base method needed here to avoid ERROR: indexableStartingPoint SitecoreIndexableItem is not an instance of CommerceCatalogIndexableItem
      Assert.ArgumentNotNull(context, "context");
      if (base.ShouldStartIndexing(indexingOptions))
      {
        this.Update(context, cancellationToken);
      }
    }
  }
}
