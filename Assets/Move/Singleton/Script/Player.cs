using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.W))
        {
            SoundManager.Instance.Sound();
            
            transform.position += new Vector3(0, 0, 1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SoundManager.Instance.Sound();
            transform.position += new Vector3(0, 0, -1);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            SoundManager.Instance.Sound();
            transform.position += new Vector3(-1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            SoundManager.Instance.Sound();
            transform.position += new Vector3(1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SoundManager.Instance.Up();
            transform.position += new Vector3(0, 1, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SoundManager.Instance.Down();
            transform.position += new Vector3(0, -1, 0);
        }
    }
}
