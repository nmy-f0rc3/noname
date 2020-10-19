using UnityEngine;
using System.Collections;

public class ScriptMoveLeft : AbstractMoveScript
{
    public PlayerScripts Player;

    public override void UpdateState(bool state)
    {
        Player.MovesLeft = state || Input.GetAxis("Horizontal") < 0f;
    }
}
