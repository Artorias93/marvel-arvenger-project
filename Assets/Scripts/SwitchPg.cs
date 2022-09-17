using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SwitchPg : MonoBehaviour
{
    public void switching()
    {
        if (transform.GetChild(0).gameObject.activeSelf)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(3).transform.GetChild(0).GetComponent<TMP_Text>().text = transform.GetChild(1).gameObject.name;
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(3).transform.GetChild(0).GetComponent<TMP_Text>().text = transform.GetChild(0).gameObject.name;
        }
    }

}
