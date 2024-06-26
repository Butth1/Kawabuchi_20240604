using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour
{
    //プレイヤーの移動速度
    public float speed = 10f;
    Rigidbody myRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
       myRigidbody=GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //左右のキー入力により速度を変更
        myRigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, 0f);
    }
}
