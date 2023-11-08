using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animation : MonoBehaviour
{
    public GameObject Canvas;
    public Animator animator1;
    public Animator animator2;
    public GameObject door;
    

    private void Start()
    {
        
        animator1.enabled = false;
        animator2.enabled = false;
        
    }
    private void Update()
    {
        // animator1.enabled = true;
        //Open.onClick.AddListener(open);
    }   
    public void open()
    {
        animator1.enabled = true;
        Canvas.SetActive(false);
        animator2.enabled = true;
        

    }
   




}
