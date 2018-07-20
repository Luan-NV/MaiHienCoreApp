using System;
using System.Collections.Generic;
using System.Text;
using MaiHienCoreApp.Application.ViewModels.Common;

namespace MaiHienCoreApp.Application.Interfaces
{
    public interface ICommonService
    {
        FooterViewModel GetFooter();
        List<SlideViewModel> GetSlides(string groupAlias);
        SystemConfigViewModel GetSystemConfig(string code);
    }
}