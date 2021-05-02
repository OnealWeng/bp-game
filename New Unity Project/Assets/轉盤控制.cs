using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 轉盤控制 : MonoBehaviour
{
    float rotSpeed=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            this.rotSpeed = 10;
        }
        transform.Rotate(0,0,this.rotSpeed);

         
         if(Input.GetMouseButtonDown(1)){
             while(true){
            this.rotSpeed *=0.96f;
            if(Input.GetMouseButtonDown(3))break;
             }
        }
    }
}
