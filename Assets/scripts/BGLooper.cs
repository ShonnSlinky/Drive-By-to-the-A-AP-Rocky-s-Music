using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

    int numBgPanels = 3;

	void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Triggered -- "+gameObject.name);
        float widthOfBGObject = ((BoxCollider2D)collider).size.x;
        Vector3 pos = collider.transform.position;
        pos.x += widthOfBGObject * numBgPanels + widthOfBGObject/(float)4.5;
        collider.transform.position = pos;
    }

}
