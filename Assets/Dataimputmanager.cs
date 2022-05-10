using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dataimputmanager : MonoBehaviour
{

    public Text txtUserName;

    public void ShowGreetings()
    {
        Debug.Log("Hola " + txtUserName.text);
    }
    public void ShowDouble() {

    if (txtUserName.text != "")
    {
        Debug.Log(int.Parse(txtUserName.text) * 2);
    }
    else
    {
        Debug.Log("No puede estar vacio");
    }
}
}
