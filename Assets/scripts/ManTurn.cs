using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ManTurn : MonoBehaviour {
    Animator anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();       
}
    // Update is called once per frame
    void Update () {
        double posX = Screen.width / 3;
        double posM = Input.mousePosition.x;
        if (posM<=posX)
        {
            anim.SetBool("center", false);
            anim.SetBool("left", true);
            anim.SetBool("right", false);
        }
        if (posX<= posM & posM<=(posX*2))
        {
            anim.SetBool("center", true);
            anim.SetBool("left", false);
            anim.SetBool("right", false);
        }
        if ((posX*2) <= posM & posM  <= (posX*3))
        {
              anim.SetBool("center", false);
              anim.SetBool("left", false);
              anim.SetBool("right", true);
        }
    }
}
