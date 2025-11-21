using System.Collections.Generic;

namespace Data
{
    public interface IFileBackend
    {
        bool Store(List<string> entries);
        List<string> Load();
    }
}