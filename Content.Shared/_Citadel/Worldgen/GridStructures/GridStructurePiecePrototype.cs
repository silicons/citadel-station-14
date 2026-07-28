using Robust.Shared.Prototypes;

namespace Content.Shared._Citadel.Worldgen.GridStructures;

/// <summary>
/// This is a prototype for...
/// </summary>
[Prototype()]
public sealed partial class GridStructurePiecePrototype : IPrototype
{
    /// <inheritdoc/>
    [IdDataField]
    public string ID { get; } = default!;
}
