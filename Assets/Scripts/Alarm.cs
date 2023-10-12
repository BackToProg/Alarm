using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    [SerializeField] private AudioSystem _audioSystem;
    
    private float _volume;
    private float _currentVolume;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            StopCoroutine(Stop());
            StartCoroutine(Play());
        }
    }
    
    private void OnTriggerExit(Collider collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            StopCoroutine(Play());
            StartCoroutine(Stop());
        }
    }

    private IEnumerator Play()
    {
        _audioSystem.Play();
        _volume = 1;
        _currentVolume = 0;

        while (_currentVolume <= 1)
        {
            _currentVolume = _audioSystem.ChangeVolumeValue(_volume);

            yield return null;
        }
    }

    private IEnumerator Stop()
    {
        _volume = 0;
        _currentVolume = 1;

        while (_currentVolume >= 0)
        {
            _currentVolume = _audioSystem.ChangeVolumeValue(_volume);

            yield return null;
        }
    }
}
