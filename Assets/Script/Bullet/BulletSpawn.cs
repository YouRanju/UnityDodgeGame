using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour {

    public GameObject bullet;
    public float spawnTime = 1f;

    Transform spawnPoints;

    void Start()
    {
        InvokeRepeating("_Spawn", spawnTime, spawnTime);
        spawnPoints = GetComponent<Transform>();
    }

    void _Spawn()
    {
        if (GameControl.isGameOver)
        {
            this.enabled = false;
        }
        if (GameControl.isGameStart)
        {
            spawnPoints.position = new Vector2(GetRandomCordinate(), GetRandomCordinate());
            Instantiate(bullet, spawnPoints.position, spawnPoints.rotation);
            TextManager.count += 1;
        }
    }

    private float GetRandomCordinate()
    {
        var cordinate = Random.Range(-7, 7);
        while (cordinate > 1.5 && cordinate < 1.5)
        {
            cordinate = Random.Range(-5, 5);
        }

        return cordinate;
    }
}
