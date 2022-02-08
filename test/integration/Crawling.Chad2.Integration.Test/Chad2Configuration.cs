using System.Collections.Generic;
using CluedIn.Crawling.Chad2.Core;

namespace CluedIn.Crawling.Chad2.Integration.Test
{
  public static class Chad2Configuration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { Chad2Constants.KeyName.ApiKey, "demo" }
            };
    }
  }
}
