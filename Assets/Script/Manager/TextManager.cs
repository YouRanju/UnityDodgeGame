using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

    public static int count = 1;
    public GameObject ready;
    public GameObject gameover;
    public Text bullet;
    public Text time;


    private float ftime;

    private void Update()
    {
        if(GameControl.isGameStart)
        {
            Ready();
            Bullet();
            fTime();
        }

        if(GameControl.isGameOver)
        {
            gameover.SetActive(true);
            this.enabled = false;
        }
    }

    private void Ready()
    {
        ready.SetActive(false);
    }

    private void Bullet()
    {
        bullet.text = "총알 수: " + count;
    }

    private void fTime()
    {
        ftime += Time.deltaTime;
        time.text = "초: " + string.Format("{0:N3}", ftime);
    }
}
