
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class policeboat : UdonSharpBehaviour
{
    
    public Animator animBoat;

    public override void Interact()
    {
        if(animBoat.GetInteger("policeBoatState") == 0)
        {
            animBoat.SetInteger("policeBoatState", 1);
        }
        else if(animBoat.GetInteger("policeBoatState") == 1)
        {
            animBoat.SetInteger("policeBoatState", 2);
        }
        else if(animBoat.GetInteger("policeBoatState") == 2)
        {
            animBoat.SetInteger("policeBoatState", 0);
        }
        
    }
}
