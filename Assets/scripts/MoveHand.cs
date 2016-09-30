using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveHand : MonoBehaviour {

    [SerializeField]
    public GameObject hand;

    // Use this for initialization
    void Start () {
        //отключение видимости курсора
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        //вычисляются координаты курсора...
        float mousePosX = Input.mousePosition.x;
        float mousePosY = Input.mousePosition.y;
        //затем подставляются в новый вектор (положение) объекта на экране
        hand.transform.position = new Vector2(mousePosX, mousePosY);

    }
}
