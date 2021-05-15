using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDown1 : MonoBehaviour
{

    public GameObject drop;

    public void ToggleChanger(bool newValue)
    {
        drop.SetActive(newValue);

    }

}
