using System.Data.Services;
using System.Data.Services.Common;
using System.ServiceModel;
using AppBay.Console.Models;

namespace AppBay.Console
{
  [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
  public class AppBayService : DataService<Entities>
  {
    public static void InitializeService(DataServiceConfiguration config)
    {
      config.SetEntitySetAccessRule("Jobs", EntitySetRights.All);
      config.SetEntitySetAccessRule("JobResults", EntitySetRights.AllRead);
      config.SetEntitySetAccessRule("Packages", EntitySetRights.All);
      config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
      config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
      config.UseVerboseErrors = true;
    }
  }
}
