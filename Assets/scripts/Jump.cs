using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
    //для курсора при прыжке//////////////////////////
    [SerializeField]
    public Texture2D jump;
    public Collider2D collider;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    /////////////////////////////////////////////////

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
        //пока что не работает//////////////////////////
        if(collider.isTrigger){
            Cursor.SetCursor(jump, hotSpot, cursorMode);
        }
        ////////////////////////////////////////////////
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
