using BardCompiler.Core.Models.Enums;

namespace BardCompiler.Core.Models.Events;

public sealed record NoteEvent(
    int Tick,
    int NoteNumber,
    int DurationTicks,
    int Velocity = 100,
    Instrument? PreferredInstrument = null
);
