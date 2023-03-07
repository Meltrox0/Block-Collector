using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorControl : MonoBehaviour
{
    public float speed = 5f;
    public GameObject CollectMe;

    int BlocksCollected = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 newPos = transform.position;

       if(Input.GetKey(KeyCode.D)){
       newPos.x = newPos.x + speed * Time.deltaTime;}

       if(Input.GetKey(KeyCode.A)){
       newPos.x = newPos.x - speed * Time.deltaTime;}

       if(Input.GetKey(KeyCode.W)){
       newPos.z = newPos.z + speed * Time.deltaTime;}

       if(Input.GetKey(KeyCode.S)){
       newPos.z = newPos.z - speed * Time.deltaTime;}
       
       transform.position = newPos;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Collect")
        {
            Destroy(other.gameObject);
            BlocksCollected ++;
            Debug.Log(BlocksCollected);
            Vector3 newPos = new Vector3(15, 1, BlocksCollected - 5);
            GameObject newObj = Instantiate(CollectMe, newPos, Quaternion.identity);
        }
    }
}
