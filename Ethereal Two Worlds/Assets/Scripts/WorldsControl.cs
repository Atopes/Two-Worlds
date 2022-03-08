using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldsControl : MonoBehaviour
{
    public GameObject BlueWalls;
    public GameObject RedWalls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            BlueWalls.SetActive(!BlueWalls.activeSelf);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            RedWalls.SetActive(!RedWalls.activeSelf);
        }
    }
}
