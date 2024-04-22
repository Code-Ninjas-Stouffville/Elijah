using System;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sounds[] sounds;

    public void Play(string arg)
    {
        var clip = Array.Find(sounds, s => s.name == arg);

        if(clip == null)
        {
            return;
        }
        else
        {
            var Loaded = clip.sources.Find(x => x.isPlaying == false);

            if (Loaded)
                Loaded.Play();
            else
            {
                AudioSource snd = gameObject.AddComponent<AudioSource>();
                clip.sources.Add(snd);
                snd.clip = clip.clip;
                snd.volume = clip.volume;
                snd.loop = clip.loop;
                snd.playOnAwake = false;
                snd.Play();
            }
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
