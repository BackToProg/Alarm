using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    
    private float _volume = 0;
    private void Update()
    {
        _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _volume,
            Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _volume = 1;
            _audioSource.Play();
        }
    }
    
    private void OnTriggerExit(Collider collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _volume = 0;
        }
    }
}
