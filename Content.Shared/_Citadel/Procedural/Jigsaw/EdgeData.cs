namespace Content.Shared._Citadel.Procedural.Jigsaw;

public struct EdgeData()
{
    /// <summary>
    /// Our bits. The other side may 'require' or 'forbid' this.
    /// </summary>
    public ulong Match = 0;

    /// <summary>
    /// Our 'require' bits. The other side must have all the bits in here set.
    /// </summary>
    public ulong? Require = null;

    /// <summary>
    /// Our 'forbid' bits. The other side must have none of the bits in here set.
    /// </summary>
    public ulong? Forbid = null;

    /**
     * The weight of this edge as a hint to solvers.
     *
     * The higher it is, the more prioritized it is to be joined first.
     *
     * Edges that are more picky generally be more weighty, because
     * otherwise, less picky edges may get 'first pick' and choke them out.
     */
    public int Weight = 0;
}
