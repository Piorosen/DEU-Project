using System;
using System.Collections.Generic;
namespace DEUProject.Server
{
    public interface ISite
    {
        List<MainModel> GetSite(bool bNotice = false, int Page = 1);
    }
}
