using System.Collections.Generic;
using CluedIn.Crawling.Chad1.Core;

namespace CluedIn.Crawling.Chad1.Integration.Test
{
  public static class Chad1Configuration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { Chad1Constants.KeyName.ApiKey, "demo" }
            };
    }
  }
}
