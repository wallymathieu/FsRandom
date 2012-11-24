﻿[<AutoOpen>]
module RecycleBin.Random.MersenneTwister

/// <summary>
/// Keeps a random state used in the Mersenne Twister process.
/// </summary>
[<Class>]
type StateVector =
   /// <summary>
   /// Initializes a new instance with an integer.
   /// </summary>
   /// <param name="seed">A random seed integer.</param>
   static member Initialize : seed:uint32 -> StateVector
   /// <summary>
   /// Initializes a new instance with integers.
   /// </summary>
   /// <param name="seed">A random seed array.</param>
   static member Initialize : seed:uint32 [] -> StateVector
   
/// <summary>
/// Random number generator using Mersenne Twister algorithm (Matsumoto &amp; Nishimura 1998).
/// </summary>
/// <param name="seed">An instace of <see cref="StateVector" />.</param>
val mersenne : StateVector -> RandomBuilder<StateVector>