using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class CarControl : MonoBehaviour
{
    public GameObject CarControls;


    private void Awake()
    {
        CarControls.GetComponent<CarController>().enabled = true;
    }





    
}
