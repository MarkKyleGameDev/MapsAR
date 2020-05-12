using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapPlace : MonoBehaviour
{
    private Ray ray; // The ray
    private RaycastHit hit; // What we hit
    public UIControl ui;
    GameObject filterScreenBtn;

    // Start is called before the first frame update
    void Start()
    {
        filterScreenBtn = GameObject.Find("FilterScreenBtn");
        ui = FindObjectOfType<UIControl>();
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Place Clicked!");
            //Destroy(gameObject);
            ui.displayInfo.SetActive(true);
            filterScreenBtn.SetActive(false);

        }
    }
}
