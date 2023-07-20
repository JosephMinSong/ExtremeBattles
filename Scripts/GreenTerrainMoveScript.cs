using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTerrainMoveScript : MonoBehaviour
{   
    public GameObject terrain;
    public float moveSpeed;
    public float deadZone;

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(terrain);
        }
    }
}
