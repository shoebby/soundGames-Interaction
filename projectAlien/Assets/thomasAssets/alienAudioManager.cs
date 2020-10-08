using System;
using UnityEngine;

public class alienAudioManager : MonoBehaviour
{
    public AlienSound[] sounds;
    public float clipPitch;

    private void Awake()
    {
        foreach (AlienSound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            clipPitch = s.source.pitch;
            s.source.pitch = s.pitch;

            s.source.spatialBlend = s.spatialBlend;

            s.source.minDistance = s.minDistance;
            s.source.maxDistance = s.maxDistance;
        }
    }

    public void AlienPlay(string clipName)
    {
        AlienSound s = Array.Find(sounds, sound => sound.clipName == clipName);
        s.source.Play();
    }
}
