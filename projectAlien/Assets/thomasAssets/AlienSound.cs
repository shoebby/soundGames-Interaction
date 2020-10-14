using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class AlienSound
{
    public string clipName;

    public AudioClip clip;

    public float pitch = 0.5f;

    public float spatialBlend = 1f;

    public float minDistance = 5f;
    public float maxDistance = 50f;

    public AudioRolloffMode RollOffMode;

    [HideInInspector]
    public AudioSource source;
}
