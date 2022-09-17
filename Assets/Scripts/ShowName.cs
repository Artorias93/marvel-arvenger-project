using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowName : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public CollectorLabel GameManager;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.CompareTag("Player"))
            {
                GameManager.HideAll();
                GameObject pg = hit.collider.gameObject.transform.parent.gameObject;
                pg.transform.Find("ID").gameObject.SetActive(true);
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0)) GameManager.HideAll();
        }
    }

}

