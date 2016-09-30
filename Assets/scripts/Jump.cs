using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update() {
        //управление прыжком на нажатие клавиши w
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("Jump", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("Jump", false);
        }
    }
        //управление прыжком на нажатие клавиши мыши 
        public void OnMouseDown()
        {
        anim.SetBool("Jump", true);
        }
        public void OnMouseUp()
        {
        anim.SetBool("Jump", false);
        }


}
