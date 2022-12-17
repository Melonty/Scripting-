using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramp : MonoBehaviour
{

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        //Увеличение скорости бега игрока 
        other.GetComponent<Jump>().jumpStrength = 10;

    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        //Понижение скорости бега игрока
        other.GetComponent<Jump>().jumpStrength = 4;
    }
}