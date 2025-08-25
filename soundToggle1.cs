//context: Each music button in unity has one of these files attached to send a message to musicToggleMain

using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class soundToggle1 : UdonSharpBehaviour
{
    public musicToggleMain musicToggle;
    public AudioSource audSource;

    public override void Interact()
    {
        musicToggle.SoundButtonPressed(1);
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
