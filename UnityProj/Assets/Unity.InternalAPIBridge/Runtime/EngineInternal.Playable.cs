using UnityEngine.Animations;
using UnityEngine.Audio;

public static partial class EngineInternal
{

    public static void SetLoopTime(this AnimationClipPlayable playable, bool loop)
    {
        playable.SetLoopTime(loop);
    }

    public static void SetOverrideLoopTime(this AnimationClipPlayable playable, bool loop)
    {
        playable.SetOverrideLoopTime(loop);
    }

    public static void SetVolume(this AudioClipPlayable playable, float value)
    {
        playable.SetVolume(value);
    }
}
