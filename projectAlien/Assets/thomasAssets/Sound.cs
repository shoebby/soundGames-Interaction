﻿using UnityEngine;

[System.Serializable]
public class Sound
{
    public string clipName;
    
    public AudioClip clip;

    [HideInInspector]
    public AudioSource source;
}
