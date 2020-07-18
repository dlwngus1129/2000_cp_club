using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class destroy : MonoBehaviour
    {
        
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        void OnTriggerEnter2D(Collider2D col)
        {
            if (GameObject.FindWithTag("Player"))                   // Player라는 태그의 오브젝트와 닿았을때
            {
                Destroy(GameObject.Find("add_jump_count_ob(Clone)"));  // 추가점프 블럭을 파괴
                ex.jump_count--;
                add_jump_count.respawn_x = true;
            }

        }
    }
