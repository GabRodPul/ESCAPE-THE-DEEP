// #define OPT_UNSAFE

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GRPU.Utils
{
    public class NullOptionException : Exception
    {
        public NullOptionException() { }

        public NullOptionException(string message) : base(message) { }

        public NullOptionException(string message, Exception inner) : base(message, inner) { }
    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct OptionRef<T>
        where T : class
    {
        private readonly T value;

#if false
        private Option<T>() { }
#endif
        private OptionRef(T v)
        {
            this.value = v;
        }

        public static OptionRef<T> Create(T v) => new(v);
        public static OptionRef<T> None { get => new OptionRef<T> (); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsSome() => value is not null;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsSomeAnd(Func<T, bool> f) => IsSome() && f(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNone() => value is null;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNoneAnd(Func<T, bool> f) => IsNone() && f(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Expect(string message) 
            => IsSome() 
                ? value 
                : throw new NullOptionException(message);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Unwrap(string message)
            => IsSome()
                ? value
                : throw new NullOptionException();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T UnwrapOr(T d) => IsSome() ? value : d;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T UnwrapOrElse(Func<T> f) => IsSome() ? value : f();

#if OPT_UNSAFE
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe T UnwrapUnchecked() => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Ref<T> ToRef() => throw new NotImplementedException();
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public OptionRef<U> Select<U>(Func<T, U> f)
            where U : class
            => IsSome() 
                ? OptionRef<U>.Create(f(value))
                : OptionRef<U>.None;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U SelectOr<U>(U d, Func<T, U> f)
            where U : unmanaged
            => IsSome() ? f(value) : d;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U SelectOrElse<U>(Func<U> d, Func<T, U> f)
            where U : unmanaged
            => IsSome() ? f(value) : d();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public OptionRef<T> Where(Func<T, bool> predicate)
            => IsNone() 
            ? OptionRef<T>.None 
            : predicate(value) ? this : OptionRef<T>.None;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public OptionRef<T> Or(OptionRef<T> other) => IsSome() ? this : other;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public OptionRef<T> OrElse(Func<OptionRef<T>> otherF) => IsSome() ? this : otherF();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public OptionRef<T> Xor(OptionRef<T> other)
            => ( IsSome(), other.IsSome() ) switch
            {
                (  true, false ) => this,
                ( false,  true ) => other,
                _ => OptionRef<T>.None
            };
    }
}