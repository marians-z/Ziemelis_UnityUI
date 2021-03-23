using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Vardaparadisana : MonoBehaviour
{
    public string text;
    public string year;
    public GameObject input1;
    public GameObject input2;
    public GameObject tekstaAttelot;
    public void saveyear() {
        text =input1.GetComponent<Text>().text;
        year =input2.GetComponent<Text>().text;
        tekstaAttelot.GetComponent<Text>().text=text.ToUpper()+" "+year.ToUpper()+ " gadus vecs";

    }

}
