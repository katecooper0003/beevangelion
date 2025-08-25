
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class soundToggle2 : UdonSharpBehaviour
{
    public musicToggleMain musicToggle;
    public AudioSource audSource;

    public override void Interact()
    {
        musicToggle.SoundButtonPressed(2);
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
