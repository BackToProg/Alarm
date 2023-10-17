using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    [SerializeField] private AudioSystem _audioSystem;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _audioSystem.Play();
        }
    }
    
    private void OnTriggerExit(Collider collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _audioSystem.Stop();
        }
    }
}
