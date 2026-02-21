using UnityEngine;

public class AudioController
{
    /// <summary>
    /// BGMÇÃçƒê∂
    /// </summary>
    /// <param name="audioSource">BGMÇÃî≠ê∂åπ</param>
    /// <param name="audioClip">çƒê∂Ç∑ÇÈBGM</param>
    public void PlayBGM(AudioSource audioSource, AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    /// <summary>
    /// SEÇÃçƒê∂
    /// </summary>
    /// <param name="audioSource">SEÇÃî≠ê∂åπ</param>
    /// <param name="audioClip">çƒê∂Ç∑ÇÈSE</param>
    public void PlaySE(AudioSource audioSource, AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
