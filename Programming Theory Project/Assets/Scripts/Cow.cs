using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : Animal
{
    [SerializeField]
    private AudioSource moo;
    [SerializeField]
    private Animator cow_anim;

    private void OnMouseDown()
    {
        MakeSound(moo);
        Eat(cow_anim);
        PrintMessage();
        cow = "The Cow!";
        PrintMessage(cow);
    }
    public override void MakeSound(AudioSource moo_v)
    {
        moo_v.Play();
    }

    private void Eat(Animator cow_anim_v)
    {
        cow_anim_v.SetTrigger("Moo_t");
    }

    public override void PrintMessage()
    {
        base.PrintMessage();
    }
    public override void PrintMessage(string theCow)
    {
        Debug.Log(theCow);
    }
}
