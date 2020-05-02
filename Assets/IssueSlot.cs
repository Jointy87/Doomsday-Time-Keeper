using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IssueSlot : MonoBehaviour
{

    //States
    bool isOccupied = false;

    //Cache
    BoxCollider2D bc;

    private void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        CheckForOccupation();
    }

    private void CheckForOccupation()
    {
        if(bc.IsTouchingLayers(LayerMask.GetMask("UI")))
        {
            isOccupied = true;
        }
        else
        {
            isOccupied = false;
        }
    }

    public bool FetchOccupationStatus()
    {
        return isOccupied;
    }
}
