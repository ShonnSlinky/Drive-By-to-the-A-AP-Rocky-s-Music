using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
    //для курсора при прыжке и стрельбе//////////////////////////
    [SerializeField]
    public Texture2D jump;

    [SerializeField]
    public Texture2D shoot;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    /////////////////////////////////////////////////

    Animator anim;
	// Use this for initialization
	void Start () {
        Cursor.SetCursor(shoot, hotSpot, cursorMode);
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
/***************для изменения курсора*****************/
    public void OnMouseEnter()
    {
        Cursor.SetCursor(jump, hotSpot, cursorMode);
    }
    public void OnMouseExit()
    {
        Cursor.SetCursor(shoot, hotSpot, cursorMode);
    }
/*****************************************************/
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
