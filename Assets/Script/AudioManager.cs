using System;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : Singleton<AudioManager>
{
  private AudioSource audioSource;

  protected override void Awake()
  {base.Awake();
    audioSource = GetComponent<AudioSource>();
  }

  public void PlayEffectSound(AudioClip clip)
  {
    audioSource.PlayOneShot(clip);
  }
}
