using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 0;
    private int blueDeactive;

    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        blueDeactive = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }

        if(gameObject.CompareTag("Blue") && i == blueDeactive)
        {
            rend.enabled = false;
        }

        Debug.Log(gameObject.name + ": " + (i++)); 
    }
}
