using GRPU.Utils;

namespace GRPU.Interfaces
{
    public interface ISingleSetup<T>
        where T : MonoSingle<T>
    {
        bool Done { get; }
        bool Setup();
    }
}