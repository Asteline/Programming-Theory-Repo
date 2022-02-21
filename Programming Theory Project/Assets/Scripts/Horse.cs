using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : Animal
{
    [SerializeField]
    private AudioSource neigh;
    [SerializeField]
    private Animator horse_anim;

    private void OnMouseDown()
    {
        MakeSound(neigh);
        Eat(horse_anim);
        PrintMessage();
        horse = "The Horse!";
        PrintMessage(horse);
    }
    public override void MakeSound(AudioSource neigh_v)
    {
        neigh_v.Play();
    }

    private void Eat(Animator horse_anim_v)
    {
        horse_anim_v.SetTrigger("Neigh_t");
    }

    public override void PrintMessage()
    {
        base.PrintMessage();
    }
    public override void PrintMessage(string theHorse)
    {
        Debug.Log(theHorse);
    }
}
