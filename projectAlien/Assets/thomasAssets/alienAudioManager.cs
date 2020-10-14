using System;
using UnityEngine;

public class alienAudioManager : MonoBehaviour
{
    public AlienSound[] sounds;

    private void Awake()
    {
        foreach (AlienSound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.pitch = s.pitch;

            s.source.spatialBlend = s.spatialBlend;

            s.source.minDistance = s.minDistance;
            s.source.maxDistance = s.maxDistance;
        }
    }

    public void AlienPlay(string clipName, float clipPitch)
    {
        AlienSound s = Array.Find(sounds, sound => sound.clipName == clipName);
        s.source.pitch = clipPitch;
        s.source.Play();
        Debug.Log(clipName);
    }
}
