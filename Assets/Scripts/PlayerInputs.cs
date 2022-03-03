using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    public int playerCount;
    [HideInInspector]
    public string vertical, horizontal;
    [HideInInspector]
    public KeyCode jump, interaction, fire, taunt;
    private void Awake()
    {
        DetermineInputs();
    }
    private void DetermineInputs()
    {
        switch (playerCount)
        {
            case 1:
                vertical = "P1Vertical";
                horizontal = "P1Horizontal";
                jump = KeyCode.F;
                interaction = KeyCode.T;
                fire = KeyCode.G;
                taunt = KeyCode.R;
                break;
            case 2:
                vertical = "P2Vertical";
                horizontal = "P2Horizontal";
                jump = KeyCode.RightAlt;
                interaction = KeyCode.Comma;
                fire = KeyCode.RightControl;
                taunt = KeyCode.Period;
                break;
        }
            


    }
}
