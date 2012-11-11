`ConcurrentList<T>` is a thread-safe, lock-free implementation of a data structure implementing the `IList<T>` interface, with the following omissions:

1. `Remove`
2. `RemoveAt`
2. `Insert`

The design of this data structure is described in the following post from the blog The Philosopher Developer:

http://philosopherdeveloper.wordpress.com/2011/02/23/how-to-build-a-thread-safe-lock-free-resizable-array/
