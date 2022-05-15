using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public float spawnX;
    public float spawnY;
    public float initialTimeBetweenSpawns;
    public GameObject[] spawnList;
    private float timeLeft;
    void spawnObject()
    {
        int rnd = Random.Range(0, spawnList.Length);
        GameObject choosenObject = spawnList[rnd];
        Instantiate(choosenObject, new Vector2(spawnX, spawnY), new Quaternion(0, 0, 0, 0));
    }


    // Start is called before the first frame update
    void Start()
    {
        timeLeft = initialTimeBetweenSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = initialTimeBetweenSpawns;
            spawnObject();
        }
    }
}
