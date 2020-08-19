using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    Rigidbody rb;
    int character;
    float s;
    int jump, jump_max;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        character = character_select.getCN();
        Debug.Log(character);
        if(character == 2){
            s = 2f;
            jump_max = 1;
        }else if(character == 3){
            s = 1f;
            jump_max = 2;
        }else{
            s = 1f;
            jump_max = 1;
        }
        jump = jump_max;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f,0f,0.1f*s);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f*s,0f,0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f,0f,-0.1f*s);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f*s,0f,0f);
        }
        if (Input.GetKeyDown(KeyCode.Space) && jump > 0)
        {
            rb.AddForce(0f,300f,0f);
            jump -= 1;
        }

        if(transform.position.y < -5f){
            transform.position = new Vector3(0f,0f,0f);
        }
    }
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "ground"){
            jump = jump_max;
        }
    }
}
