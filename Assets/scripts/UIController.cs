using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {
    [SerializeField]
    GameObject radio;
    [SerializeField]
    GameObject street;
    [SerializeField]
    GameObject menu;

    // Use this for initialization
    void Start () {
        radio.SetActive(false);
        street.SetActive(false);
	}
	
    public void OnPoupMenuOpen()
    {
        Cursor.visible = false;
        radio.SetActive(true);
        street.SetActive(true);
       // Time.timeScale = 0;

    }

    public void OnPoupMenuClose()
    {
        Cursor.visible = true;
        radio.SetActive(false);
        street.SetActive(false);
       // Time.timeScale = 1;
    }
    public void OnMenuOpen()
    {
        Debug.Log("OnMenuOpen is active!");
    }
}
