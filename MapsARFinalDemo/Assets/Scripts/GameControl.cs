using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public UIControl ui;
    GameObject filterScreenBtn;
    // Start is called before the first frame update
    void Start()
    {
        filterScreenBtn = GameObject.Find("FilterScreenBtn");
        ui = FindObjectOfType<UIControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Close Button Clicked!");
            //Destroy(gameObject);
            ui.displayInfo.SetActive(false);
            ui.filterScreen.SetActive(false);
            filterScreenBtn.SetActive(true);
        }
    }

    public void filterScreen()
    {
        Debug.Log("Filter Button Clicked!");
        //Destroy(gameObject);
        ui.filterScreen.SetActive(true);
        filterScreenBtn.SetActive(false);
    }

    public void closeBtn()
    {
        Debug.Log("Close Button Clicked!");
        //Destroy(gameObject);
        ui.displayInfo.SetActive(false);
        ui.filterScreen.SetActive(false);
        filterScreenBtn.SetActive(true);

    }

}
