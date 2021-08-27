using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    public float moveSpeed;
    public float MinY;
    public float MaxY;

    private GameObject obj;
    public float oldPosition;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        oldPosition = 10;
        moveSpeed = 2;
        MinY = -1.5f;
        MaxY = -0.9f;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed, 0, 0));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("Reset"))
            obj.transform.position = new Vector3(oldPosition, Random.Range(MinY, MaxY + 1), 10);
    }
}
