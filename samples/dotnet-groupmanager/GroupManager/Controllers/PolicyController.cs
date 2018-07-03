using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupManager.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace GroupManager.Controllers
{
  public class PolicyController : ControllerBase
  {
    private readonly IGraphSdkHelper _graphSdkHelper;
    private MSALLogCallback _msalLog;

    public PolicyController(IGraphSdkHelper graphSdkHelper, IMemoryCache memoryCache, MSALLogCallback msalLog)
      : base(memoryCache)
    {
      _graphSdkHelper = graphSdkHelper;
      _msalLog = msalLog;
    }

    public IActionResult Index()
    {

      // Get user's id for token cache.
      var identifier = User.FindFirst(GraphAuthProvider.ObjectIdentifierType)?.Value;
      base.CopyUserModelToViewData(identifier);

      return View();
    }
  }
}