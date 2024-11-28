using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public static AudioManager instance;

    public Som[] soms;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);  

        foreach (Som s in soms)
        {
            s.source =gameObject.AddComponent<AudioSource>();
            s.source.clip =s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    void Start()
    {
        Play("musica de fundo");
    }

    public void Play(string name)
    {
       Som s = Array.Find(soms, som => som.nome == name);
        if (s == null)
        {
            return;
        }
        s.source.Play();
    }
}
