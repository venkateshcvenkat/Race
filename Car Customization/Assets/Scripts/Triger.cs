using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triger : MonoBehaviour
{
    public GameObject menu;
    public GameObject Light;
    public Turn_Move Rotate;

    public Animator UI;


    private void Start()
    {
        Light.SetActive(false);
        menu.SetActive(false);
        Rotate.enabled = false;
        UI.enabled = false;

    }
    private void Update()
    {
       
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            menu.SetActive(true);
            Light.SetActive(true);
            Rotate.enabled = true;
            UI.enabled = true;
            
            
        }
    }
    
        
       
    
    
}
