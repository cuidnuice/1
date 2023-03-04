using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    public void Sound()
    {
        Debug.Log("발자국 소리");
    }

    public void Up()
    {
        Debug.Log("Up");
    }

    public void Down()
    {
        Debug.Log("Down");
    }
}
