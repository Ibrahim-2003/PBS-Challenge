using UnityEngine.Audio;
using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    
    
    #region Static Instance
    private static AudioManager instance;
    public static AudioManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<AudioManager>();
                if(instance == null)
                {
                    instance = new GameObject("Spawned AudioManager", typeof(AudioManager)).GetComponent<AudioManager>();
                }
            }

            return instance;
        }
        private set
        {
            instance = value;
        }
    }
    #endregion

    #region Fields
    private AudioSource musicSource;
    private AudioSource musicSource2;
    private AudioSource sfxSource;
    private AudioSource sfxSource2;
    private AudioSource sfxSource3;

    private bool firstMusicSourceIsPlaying;
    #endregion

    private void Awake()
    {
        //Keep for all scenes
        DontDestroyOnLoad(this.gameObject);

        //Create audio sources, and save as references
        musicSource = this.gameObject.AddComponent<AudioSource>();
        musicSource2 = this.gameObject.AddComponent<AudioSource>();
        sfxSource = this.gameObject.AddComponent<AudioSource>();
        sfxSource2 = this.gameObject.AddComponent<AudioSource>();
        sfxSource3 = this.gameObject.AddComponent<AudioSource>();


        //Loop the music tracks
        musicSource.loop = true;
        musicSource2.loop = true;

    }

    public void ControlLoop(int lupe)
    {
        if(lupe == 0)
        {
            musicSource.loop = false;
            musicSource2.loop = false;
        }else if(lupe == 1)
        {
            musicSource.loop = true;
            musicSource2.loop = true;
        }else{
            Debug.Log("You placed the wrong lupe value!");
        }
    }

    public void StopMusic(AudioClip musicClip)
    {
        AudioSource activeSource = (firstMusicSourceIsPlaying) ? musicSource : musicSource2;
        activeSource.clip = musicClip;
        SetMusicVolume(0);
        activeSource.Stop();
    }
    public void StopSFX(AudioClip clip)
    {
        sfxSource.volume = 0;
        sfxSource.Stop();
    }

    public void StopSFX2(AudioClip clip)
    {
        sfxSource2.volume = 0;
        sfxSource2.Stop();
    }

    public void StopSFX3(AudioClip clip)
    {
        sfxSource2.volume = 0;
        sfxSource2.Stop();
    }

    public void PlayMusic(AudioClip musicClip)
    {
        //Determine which source is active
        AudioSource activeSource = (firstMusicSourceIsPlaying) ? musicSource : musicSource2;

        activeSource.clip = musicClip;
        activeSource.volume = 1;
        activeSource.Play();
    }
    public void PlayMusicWithFade(AudioClip newClip, float transitionTime = 1.0f)
    {
        //Determine which source is active
        AudioSource activeSource = (firstMusicSourceIsPlaying) ? musicSource : musicSource2;

        StartCoroutine(UpdateMusicWithFade(activeSource, newClip, transitionTime));
    }
    public void PlayMusicWithCrossFade(AudioClip musicClip, float transitionTime = 1.0f)
    {
        //Determine which source is active
        AudioSource activeSource = (firstMusicSourceIsPlaying) ? musicSource : musicSource2;
        AudioSource newSource = (firstMusicSourceIsPlaying) ? musicSource2 : musicSource;

        //Swap the source
        firstMusicSourceIsPlaying = !firstMusicSourceIsPlaying;

        //Set the fields of the audio source, then start the coroutine to crossfade
        newSource.clip = musicClip;
        newSource.Play();
        StartCoroutine(UpdateMusicWithCrossFade(activeSource, newSource, transitionTime));
    }


    private IEnumerator UpdateMusicWithFade(AudioSource activeSource, AudioClip newClip, float transitionTime)
    {
        //Make sure source is active and playing
        if(!activeSource.isPlaying)
            activeSource.Play();

        float t = 0.0f;

        //Fade out
        for (t = 0; t < transitionTime; t += Time.deltaTime)
        {
            activeSource.volume = (1 - (t / transitionTime));
            yield return null;
        }

        activeSource.Stop();
        activeSource.clip = newClip;
        activeSource.Play();

        //Fade in
        for (t = 0; t < transitionTime; t += Time.deltaTime)
        {
            activeSource.volume = (t / transitionTime);
            yield return null;
        }
    }

    private IEnumerator UpdateMusicWithCrossFade(AudioSource original, AudioSource newSource, float transitionTime)
    {
        float t = 0.0f;
        for (t = 0.0f; t <= transitionTime; t += Time.deltaTime)
        {
            original.volume = (1 - (t / transitionTime));
            newSource.volume = (t / transitionTime);
            yield return null;
        }

        original.Stop();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
    public void PlaySFX(AudioClip clip, float volume)
    {
        sfxSource.PlayOneShot(clip, volume);
    }

    public void PlaySFX2(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
    public void PlaySFX2(AudioClip clip, float volume)
    {
        sfxSource.PlayOneShot(clip, volume);
    }

    public void PlaySFX3(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
    public void PlaySFX3(AudioClip clip, float volume)
    {
        sfxSource.PlayOneShot(clip, volume);
    }

    public void SetMusicVolume(float volume)
    {
        musicSource.volume = volume;
        musicSource2.volume = volume;
    }
    public void SetSFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }

}
