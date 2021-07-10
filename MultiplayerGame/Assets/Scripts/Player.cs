using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player : MonoBehaviour
{
    PhotonView view;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(!view.IsMine) {return;}

        if(view.IsMine){
            if(Input.GetKeyDown(KeyCode.Space)){
                rb.AddForce(0, 10, 0);
            }
        }
    }
}
