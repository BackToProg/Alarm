using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private float _volumeCnangeSpeed = 0.2f;
    
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
            Time.deltaTime * _volumeCnangeSpeed);

        return _audioSource.volume;
    }
}
