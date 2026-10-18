using Cysharp.Threading.Tasks;

namespace KuroNeko.Library
{
    public interface ISaveLoad
    {
        bool Exist(string key);
        void Delete(string key);
        UniTask SaveAsync<T>(string key, T data);
        UniTask<T> LoadAsync<T>(string key);
    }
}