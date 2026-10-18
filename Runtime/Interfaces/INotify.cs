using System;

namespace KuroNeko.Library
{
    public interface INotify<T>
    {
        event Action<T> OnChanged;
        void Notify();
    }
}