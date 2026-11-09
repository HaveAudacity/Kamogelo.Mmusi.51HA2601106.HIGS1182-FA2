using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;   // Single shared reference so any script can play sounds easily

    public AudioSource musicSource;        // Dedicated source for looping background music
    public AudioSource sfxSource;          // Dedicated source for one-off sound effects

    public AudioClip backgroundMusic;
    public AudioClip pickupSound;
    public AudioClip shootSound;
    public AudioClip hitSound;
    [Range(0f, 1f)] public float musicVolume = 0.5f;   // Background music volume (0 = silent, 1 = full)
    [Range(0f, 1f)] public float sfxVolume = 1f;       // Sound effects volume

    void Start()
    {
        instance = this;

        // Start background music looping immediately when the game begins
        musicSource.clip = backgroundMusic;
        musicSource.loop = true;
        musicSource.volume = musicVolume;
        sfxSource.volume = sfxVolume;
        musicSource.Play();
    }

    void Update()
    {
    }

    // Plays a one-off sound effect without interrupting the music or any other sound currently playing
    public void PlaySound(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
    // Changes the music volume at runtime (clamped between 0 and 1)
    public void SetMusicVolume(float volume)
    {
        musicVolume = Mathf.Clamp01(volume);
        musicSource.volume = musicVolume;
        Debug.Log("Music volume set to " + musicVolume);
    }

    // Changes the sound effects volume at runtime (clamped between 0 and 1)
    public void SetSfxVolume(float volume)
    {
        sfxVolume = Mathf.Clamp01(volume);
        sfxSource.volume = sfxVolume;
        Debug.Log("SFX volume set to " + sfxVolume);
    }
}