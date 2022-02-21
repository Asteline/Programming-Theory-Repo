using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick : Animal
{
    [SerializeField]
    private AudioSource chirp;
    [SerializeField]
    private Animator chick_anim;

    private void OnMouseDown()
    {
        MakeSound(chirp);
        Jump(chick_anim);
        PrintMessage();
        chick = "The Chick!";
        PrintMessage(chick);
    }
    public override void MakeSound(AudioSource chirp_v)
    {
        chirp_v.Play();
    }

    private void Jump(Animator chick_anim_v)
    {
        chick_anim_v.SetTrigger("Chirp_t");
    }

    public override void PrintMessage()
    {
        base.PrintMessage();
    }
    public override void PrintMessage(string theChick)
    {
        Debug.Log(theChick);
    }
}
