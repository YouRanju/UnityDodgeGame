using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    public static bool isGameStart = false;
    public static bool isGameOver = false;

    private void Update()
    {
        if(Input.anyKeyDown)
        {
            isGameStart = true;
        }

        if(isGameOver)
        {
            isGameStart = false;
        }
    }

}
