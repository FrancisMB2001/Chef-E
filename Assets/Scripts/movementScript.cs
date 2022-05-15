using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    public float OriginalSpeed = 10.0f;
    private float MovementSpeed = 0;

    Vector2 originalPos;

    // Start is called before the first frame update
    void Start()
    {
        MovementSpeed = OriginalSpeed;
        Vector2 originalPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(MovementSpeed * Time.deltaTime, 0, 0, Space.Self);
    }
}
