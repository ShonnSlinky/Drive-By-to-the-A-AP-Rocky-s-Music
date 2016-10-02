//создание прицела и особого курсора для прыжка
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Cur : MonoBehaviour {

    [SerializeField]
    public Texture2D shoot;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    // Use this for initialization
    void Start () {
        Cursor.SetCursor(shoot, hotSpot, cursorMode);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
