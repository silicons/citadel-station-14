using Robust.Shared.Prototypes;

namespace Content.Shared._Citadel.Worldgen.GridStructures;

/// <summary>
/// This is a prototype for...
/// </summary>
[Prototype]
public sealed partial class GridStructurePackPrototype : IPrototype
{
    /// <inheritdoc />
    [IdDataField]
    public string ID { get; private set; } = default!;
}
