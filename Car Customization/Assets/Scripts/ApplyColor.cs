using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyColor : MonoBehaviour
{
    public FlexibleColorPicker Fcp;
    public Material material;
    void Start()
    {
        
    }

    
    void Update()
    {
        material.color = Fcp.color;
    }
}
