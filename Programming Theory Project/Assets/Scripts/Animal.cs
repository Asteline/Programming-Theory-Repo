using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public static string horse { get; set; }
    public static string dog { get; set; }
    public static string cow { get; set; }
    public static string chick { get; set; }

    public virtual void MakeSound(AudioSource animalAudioSource)
    {
        animalAudioSource.Play();
    }

    public virtual void PrintMessage()
    {
        Debug.Log("This is my favourite animal!");
    }
    public abstract void PrintMessage(string msg);
}
