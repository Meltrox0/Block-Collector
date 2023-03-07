using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{

    public GameObject CollectMe;

    public int blockSpawn;

    public Transform topLeft;
    public Transform bottomRight;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < blockSpawn; i++)
        {
           float newX = Random.Range(topLeft.position.x, bottomRight.position.x);
           float newZ = Random.Range(topLeft.position.z, bottomRight.position.z);
           Vector3 newPos = new Vector3(newX, transform.position.y, newZ);
           GameObject newObj = Instantiate(CollectMe, newPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
