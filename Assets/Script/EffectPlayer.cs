using UnityEngine;

public class EffectPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;

    public void PlayEffect()
    {
        AudioManager.Instance.PlayEffectSound(audioClip);
    }
}
