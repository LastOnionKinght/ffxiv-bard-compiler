using BardCompiler.Core.Models.Enums;
using BardCompiler.Core.Models.Events;

namespace BardCompiler.Core.Models;

public sealed class Track
{
    public string Name { get; }
    public Instrument Instrument { get; set; }

    private readonly List<object> _events = new();
    public IReadOnlyList<object> Events => _events;

    public Track(string name, Instrument instrument)
    {
        Name = name;
        Instrument = instrument;
    }

    public void AddNote(NoteEvent note) => _events.Add(note);

    public void AddToneChange(ToneEvent tone) => _events.Add(tone);
}
