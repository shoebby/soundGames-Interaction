using System;
using UnityEngine;
using UnityEngine.Audio;

public class playerAudioManager : MonoBehaviour
{
    public Sound[] sounds;

    private void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
        }
    }

    public void Play(string clipName)
    {
        Sound s = Array.Find(sounds, sound => sound.clipName == clipName);
        s.source.Play();
    }
}
