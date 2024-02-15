using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityDirectionControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateGravity()
    {
        if (PlayerState.gravitySourceVector == null) return;

        PlayerState.gravityVector = (PlayerState.gravitySourceVector - PlayerState.playerCoordinateVector).normalized;

    }
}