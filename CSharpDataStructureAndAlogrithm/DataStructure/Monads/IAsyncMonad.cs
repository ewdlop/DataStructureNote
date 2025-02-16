﻿// AsyncResult.cs - Async Result monad implementation
namespace DataStructure.Monads
{
    public interface IAsyncMonad<T>
    {
        public abstract Task<IMonad<TResult?>> BindAsync<TResult>(Func<T?, Task<IMonad<TResult?>>> func);
        public abstract Task<IMonad<TResult?>> MapAsync<TResult>(Func<T?, Task<TResult?>> func);
    }
}
