namespace Content.Shared._Citadel.Procedural.Jigsaw.Impl.Bitfield;

public struct Edge
{
    /// <summary>
    /// Our bits. The other side may 'require' or 'forbid' this.
    /// </summary>
    public ulong Match;

    /// <summary>
    /// Our 'require' bits. The other side must have all the bits in here set.
    /// </summary>
    public ulong Require;

    /// <summary>
    /// Our 'forbid' bits. The other side must have none of the bits in here set.
    /// </summary>
    public ulong Forbid;
}
