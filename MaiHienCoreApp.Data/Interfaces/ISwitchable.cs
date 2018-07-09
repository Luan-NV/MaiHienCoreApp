using MaiHienCoreApp.Data.Enums;

namespace MaiHienCoreApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}