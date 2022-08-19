﻿namespace Plugin.Maui.SimpleAudioPlayer;

public class AudioManager : IAudioManager
{
    static IAudioManager? currentImplementation;

    public static IAudioManager Current => currentImplementation ??= new AudioManager();

    /// <inheritdoc />
    public ISimpleAudioPlayer CreatePlayer(Stream audioStream)
    {
        ArgumentNullException.ThrowIfNull(audioStream);

        return new AudioPlayer(audioStream);
    }

    /// <inheritdoc />
    public ISimpleAudioPlayer CreatePlayer(string fileName)
    {
        ArgumentNullException.ThrowIfNull(fileName);

        return new AudioPlayer(fileName);
    }
}
