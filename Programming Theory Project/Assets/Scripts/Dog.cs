using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    [SerializeField]
    private AudioSource bark;
    [SerializeField]
    private Animator dog_anim;

    private void OnMouseDown()
    {
        MakeSound(bark);
        Bark(dog_anim);
        PrintMessage();
        dog = "The Dog!";
        PrintMessage(dog);
    }
    public override void MakeSound(AudioSource bark_v)
    {
        bark_v.Play();
    }

    private void Bark(Animator dog_anim_v)
    {
        dog_anim_v.SetTrigger("Bark_t");
    }

    public override void PrintMessage()
    {
        base.PrintMessage();
    }
    public override void PrintMessage(string theDog)
    {
        Debug.Log(theDog);
    }
}
