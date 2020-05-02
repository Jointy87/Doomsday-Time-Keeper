using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IssueSlot : MonoBehaviour
{

    //States
    bool isOccupied = false;

    //Cache
    BoxCollider2D bc;

    private void Awake()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    public bool FetchOccupationStatus()
    {
        CheckForOccupation();
        return isOccupied;
    }
    private void CheckForOccupation()
    {
        if (bc.IsTouchingLayers(LayerMask.GetMask("UI")))
        {
            isOccupied = true;
        }
        else
        {
            isOccupied = false;
        }
    }
}
