# Procedural - Jigsaw

A module for performing dynamic expansion of jigsaw-grid-based
patterns.

## Data Coherency / Thread Safety

- Jigsaw edges, and tiles, are structs. They are copied.
- Custom data in jigsaw edges, tiles, and pieces, should be thread-safe and safe to reference from more than one
  location.
- Jigsaw pieces are classes. You should treat them as immutable once constructed for the most part.
- Jigsaw patterns should be constructed and passed to jigsaw pieces.
- Jigsaw adjudicators generally should be stateless themselves because when, where, in what order their functions are
  called is implementation defined by the jigsaw solver.
- Jigsaw solvers may be stateful, because you can do whatever you want with them as they are the entrypoint of this API.

Generally, you're going to want to run jigsaw solvers on a separate thread. As of right now, buffers cannot be shared
between threads. Standard C# synchronization best practices apply; the pattern you should be using is 'send a buffer and
list of pieces over, run solver, get results back to main thread'.
