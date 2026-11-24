# Text To Speech Example

A small Windows Forms program from January 2010 that reads typed text aloud with the voices installed in
Windows, using .NET's `System.Speech` (SAPI). Choose a voice, set the speed, and press **Speak**. You can
pause and resume, or **Save** the speech to a WAV file.

## Building

Open `TextToSpeech.sln` in Visual Studio 2008 or later. It targets .NET Framework 3.5 and needs Windows,
because `System.Speech` uses the Windows speech voices.

The project signs its assembly with `MyKey.snk` and its ClickOnce manifests with
`TextToSpeech_TemporaryKey.pfx`. Those are private keys, so they are **not** in this repository. To build,
either create your own key (`sn -k TextToSpeech\MyKey.snk`) or turn off signing in the project
properties.

## Files

| Path | What it is |
|---|---|
| `TextToSpeech/Form1.cs` | Voice list, speed, Speak/Stop, Pause/Resume, Save as WAV |
| `TextToSpeech/Form1.Designer.cs` | The form layout |
| `TextToSpeech/Program.cs` | Entry point |
| `TextToSpeech/Properties/` | Assembly info, resources, settings, app manifest |

## Provenance

The source files are unchanged from the original project ZIP (last saved January 28, 2010). These were
left out:

- `MyKey.snk` and `TextToSpeech_TemporaryKey.pfx` (private signing keys)
- `TextToSpeech.suo` and `TextToSpeech.csproj.user` (Visual Studio user settings)
- `publish/` (the ClickOnce build output). It is attached to the `v1.0` release instead.

I decompiled the published `TextToSpeech.exe` and it matches this source: the same methods and the same
text.

## License

MIT. See [LICENSE](LICENSE).
