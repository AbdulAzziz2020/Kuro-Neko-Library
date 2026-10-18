using Cysharp.Threading.Tasks;

namespace KuroNeko.Library
{
    public interface ISaveService
    {
        void ForceSave<T>(string key, T value);
        T ForceLoad<T>(string key);
        UniTask<T> LoadAsync<T>(string key);
        UniTask SaveAsync<T>(string key, T value);
    }
}