using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject S_Camera;

    //wheels
    public GameObject Original;
    public GameObject Spare1;
    public GameObject Spare2;
    public GameObject Spare3;
    public GameObject Spare4;
    public GameObject Spare5;

    //Bottom Buttons

    public GameObject WheelButton;
    public GameObject ColorsButton;
    public GameObject StrickerButton;
    public GameObject SteeringButton;
    public GameObject SuperCharger;
    public GameObject Wings;


    //steering
    public GameObject SteeringOrginal;
    public GameObject Steering1;
    public GameObject Steering2;
    public GameObject Steering3;
    public GameObject Back;

    //SuperCharger
    public GameObject Sp1;
    public GameObject Sp2;
    //wings
    public GameObject W1;
    public GameObject W2;
    public GameObject W3;

    //Animation
    public Animator Wheels;
    public Animator Color;
    public Animator Scolor;
    public Animator Steering;
    public Animator Supercharger;
    public Animator Wing;


    //camera
    public void back()
    {
        S_Camera.SetActive(false);
    }
   


    //Wheels
    public void original()
    {
        Original.SetActive(true);
        Spare1.SetActive(false);
        Spare2.SetActive(false);
        Spare3.SetActive(false);
        Spare4.SetActive(false);
        Spare5.SetActive(false);
    }
    public void spare1()
    {
        Original.SetActive(false);
        Spare1.SetActive(true);
        Spare2.SetActive(false);
        Spare3.SetActive(false);
        Spare4.SetActive(false);
        Spare5.SetActive(false);
    }
    public void spare2()
    {
        Original.SetActive(false);
        Spare1.SetActive(false);
        Spare2.SetActive(true);
        Spare3.SetActive(false);
        Spare4.SetActive(false);
        Spare5.SetActive(false);
    }
    public void spare3()
    {
        Original.SetActive(false);
        Spare1.SetActive(false);
        Spare2.SetActive(false);
        Spare3.SetActive(true);
        Spare4.SetActive(false);
        Spare5.SetActive(false);
    }
    public void spare4()
    {
        Original.SetActive(false);
        Spare1.SetActive(false);
        Spare2.SetActive(false);
        Spare3.SetActive(false);
        Spare4.SetActive(true);
        Spare5.SetActive(false);
    }
    public void spare5()
    {
        Original.SetActive(false);
        Spare1.SetActive(false);
        Spare2.SetActive(false);
        Spare3.SetActive(false);
        Spare4.SetActive(false);
        Spare5.SetActive(true);
    }
    //Bottom Button
    public void wheelButton()
    {
        WheelButton.SetActive(true);
        ColorsButton.SetActive(false);
        StrickerButton.SetActive(false);
        SteeringButton.SetActive(false);
        SuperCharger.SetActive(false);
        Wings.SetActive(false);
        
    }
    public void colorsButton()
    {
        WheelButton.SetActive(false);
        ColorsButton.SetActive(true);
        StrickerButton.SetActive(false);
        SteeringButton.SetActive(false);
        SuperCharger.SetActive(false);
        Wings.SetActive(false);
    }
    public void strickerButton()
    {
        WheelButton.SetActive(false);
        ColorsButton.SetActive(false);
        StrickerButton.SetActive(true);
        SteeringButton.SetActive(false);
        SuperCharger.SetActive(false);
        Wings.SetActive(false);
    }

    public void steeringbut()
    {
        WheelButton.SetActive(false);
        ColorsButton.SetActive(false);
        StrickerButton.SetActive(false);
        SteeringButton.SetActive(true);
        SuperCharger.SetActive(false);
        Wings.SetActive(false);
    }
    public void supercharger()
    {
        WheelButton.SetActive(false);
        ColorsButton.SetActive(false);
        StrickerButton.SetActive(false);
        SteeringButton.SetActive(false);
        SuperCharger.SetActive(true);
        Wings.SetActive(false);
    }
    public void wings()
    {
        WheelButton.SetActive(false);
        ColorsButton.SetActive(false);
        StrickerButton.SetActive(false);
        SteeringButton.SetActive(false);
        SuperCharger.SetActive(false);
        Wings.SetActive(true);
    }




    //Steering
    public void steeringoriginal()
    {
        SteeringOrginal.SetActive(true);
        Steering1.SetActive(false);
        Steering2.SetActive(false);
        Steering3.SetActive(false);
        Back.SetActive(true);
        S_Camera.SetActive(true);

    }
    public void sterring1()
    {
        SteeringOrginal.SetActive(false);
        Steering1.SetActive(true);
        Steering2.SetActive(false);
        Steering3.SetActive(false);
        S_Camera.SetActive(true);
        Back.SetActive(true);
    }
    public void sterring2()
    {
        SteeringOrginal.SetActive(false);
        Steering1.SetActive(false);
        Steering2.SetActive(true);
        Steering3.SetActive(false);
        Back.SetActive(true);
        S_Camera.SetActive(true);
    }
    public void sterring3()
    {
        SteeringOrginal.SetActive(false);
        Steering1.SetActive(false);
        Steering2.SetActive(false);
        Steering3.SetActive(true);
        Back.SetActive(true);
        S_Camera.SetActive(true);
    }

    public void sp1()
    {
        Sp1.SetActive(true);
        Sp2.SetActive(false);
    }
    public void sp2()
    {
        Sp1.SetActive(false);
        Sp2.SetActive(true);
    }

    //wings

    public void w1()
    {
        W1.SetActive(true);
        W2.SetActive(false);
        W3.SetActive(false);
    }
    public void w2()
    {
        W1.SetActive(false);
        W2.SetActive(true);
        W3.SetActive(false);
    }
    public void w3()
    {
        W1.SetActive(false);
        W2.SetActive(false);
        W3.SetActive(true);
    }

}
