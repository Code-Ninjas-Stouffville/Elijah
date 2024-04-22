using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Sounds
{
    public string name = "";
    public AudioClip clip;
    public float volume = 1;
    public bool loop = false;

    //Fix audio clipping
    [HideInInspector]
    public List<AudioSource> sources;
}
