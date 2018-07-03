﻿using GroupManager.Helpers;
using GroupManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace GroupManager.Controllers
{
  public class ControllerBase : Controller
  {
    private readonly IMemoryCache _memoryCache;

    public ControllerBase() { }

    public ControllerBase(IMemoryCache memoryCache) => _memoryCache = memoryCache;

    public void CopyUserModelToViewData(string userId)
    {
      var userModel = GetUserModelFromCache(userId);
      ViewData["userId"] = userId;
      ViewData["userName"] = userModel?.Name;
      ViewData["userEmail"] = userModel?.Email;
      ViewData["Picture"] = userModel?.PictureBase64;
    }

    public UserModel GetUserModelFromCache(string userId)
    {
      return new InMemoryUserCache(userId, _memoryCache).ReadUserStateValue();
    }

    public void SaveUserModelInCache(UserModel userModel)
    {
      new InMemoryUserCache(userModel.Id, _memoryCache).SaveUserStateValue(userModel);
    }
  }
}
