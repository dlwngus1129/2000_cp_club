using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add_jump_count : MonoBehaviour
{
    public GameObject Yellow_block;
    public static bool respawn_x = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("add_jump_count_ob(Clone)")==false && respawn_x ==true)
        {
            Invoke("respawn", 2f);
            respawn_x = false;
        }
    }
   void respawn()
    {
        Instantiate(Yellow_block, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
