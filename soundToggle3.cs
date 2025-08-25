using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class soundToggle3 : UdonSharpBehaviour
{
    public musicToggleMain musicToggle;
    public AudioSource audSource;

    public override void Interact()
    {
        musicToggle.SoundButtonPressed(3);
    }

    public void PlaySound()
    {
        audSource.Play();
    }
    public void StopSound()
    {
        audSource.Stop();
    }
}