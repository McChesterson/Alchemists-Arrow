using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class SelectPlayerManager : NetworkBehaviour
{
    public Image playerSelection;
    public Color[] colorSelection = new Color[] { new Color(231, 40, 40, 255), new Color(0, 0, 255, 255), new Color(96, 195, 82, 255) };
    public Color currentColor;
    public int currentColorIndex;

    void Start()
    {
        currentColorIndex = 0;
        currentColor = colorSelection[currentColorIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsLocalPlayer) return;
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            SelectPlayerChangeServerRPC(1);
        }
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SelectPlayerChangeServerRPC(-1);
        }
    }
    [ServerRpc]
    public void SelectPlayerChangeServerRPC(int moveDirection)
    {
        if (moveDirection == -1 && currentColorIndex == 0) return;
        if (moveDirection == 1 && currentColorIndex == 2) return;
        currentColorIndex += moveDirection;
        playerSelection.color = colorSelection[currentColorIndex];
    }
}
