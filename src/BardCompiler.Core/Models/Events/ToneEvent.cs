using BardCompiler.Core.Models.Enums;

namespace BardCompiler.Core.Models.Events;

public sealed record ToneEvent(
    int Tick,
    Tone Tone
);
