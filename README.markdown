`ConcurrentList<T>` is an implementation of the `IList<T>` interface designed for lock-free concurrency, with the following notable omissions\*:

1. `Remove`
2. `RemoveAt`
3. `Insert`

In other words, `ConcurrentList<T>` is an *append-only* collection type supporting random indexed access to its elements.

The design of this data structure is described in the following post from the blog The Philosopher Developer:

http://philosopherdeveloper.wordpress.com/2011/02/23/how-to-build-a-thread-safe-lock-free-resizable-array/

For comparison purposes, this library also includes a `SynchronizedList<T>` type, which is a thin wrapper around the BCL's `List<T>` class with the appropriate operations synchronized via `lock` statements.

\* The members of `IList<T>` not implemented by `ConcurrentList<T>` are explicit (not public) and throw exceptions when called.