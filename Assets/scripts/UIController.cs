using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {
    [SerializeField]
    GameObject Radio;
    [SerializeField]
    GameObject Back;
    [SerializeField]
    GameObject Menu;
    // Use this for initialization
    void Start () {
        Radio.SetActive(false);
	}
	
    public void OnPoupMenuOpen()
    {
        Radio.SetActive(true);
    }

    private void OnPoupMenuClose()
    {
        Radio.SetActive(false);
    }
    private void OnMenuOpen()
    {

    }
}
