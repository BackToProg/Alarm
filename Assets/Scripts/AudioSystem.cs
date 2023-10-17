using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private readonly float _volumeChangeSpeed = 0.1f;
    private float _currentVolume;
    private float _volume;
    
    public void Play()
    {
        StopCoroutine(StopAlarm());
        StartCoroutine(StartAlarm());
    }
    
    public void Stop()
    {
        StopCoroutine(StartAlarm());
        StartCoroutine(StopAlarm());
    }

    private float ChangeVolumeValue(float volume)
    {
        _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, volume,
            Time.deltaTime * _volumeChangeSpeed);

        return _audioSource.volume;
    }
    
    
    private IEnumerator StartAlarm()
    {
        _audioSource.Play();
        _volume = 1;
        _currentVolume = 0;

        while (_currentVolume <= 1)
        {
            _currentVolume = ChangeVolumeValue(_volume);

            yield return null;
        }
    }

    private IEnumerator StopAlarm()
    {
        _volume = 0;
        _currentVolume = 1;

        while (_currentVolume >= 0)
        {
            _currentVolume = ChangeVolumeValue(_volume);

            yield return null;
        }
        
        _audioSource.Stop();
    }
}
