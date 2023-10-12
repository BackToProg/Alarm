using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    
    public void Play()
    {
        _audioSource.Play();
    }
    
    public void Stop()
    {
        _audioSource.Stop();
    }

    public float ChangeVolumeValue(float volume)
    {
        _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, volume,
            Time.deltaTime * 0.2f);

        return _audioSource.volume;
    }
}
