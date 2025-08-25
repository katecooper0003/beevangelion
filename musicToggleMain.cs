
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class musicToggleMain : UdonSharpBehaviour
{
    public soundToggle1 st1;
    public soundToggle2 st2;
    public soundToggle3 st3;
    public int current = 0;
    public void SoundButtonPressed(int num)
    {
	//Stops all songs playing
        st1.StopSound();
        st2.StopSound();
        st3.StopSound();
        
	//If selection was not already playing, set current song and play new one.
	//This ensures that pressing the same song twice will just stop the song and not overlay onto itself
        if(num != current)
        {
            current = num;
            if(current == 1)
            {
                st1.PlaySound();
                
            }
            else if(current == 2)
            {
                st2.PlaySound();
            }
            else if (current == 3)
            {
                st3.PlaySound();
            }
        }
        
        
    }
}
