using UnityEngine;
using System.Collections;

public class ScriptMoveRight : AbstractMoveScript
{
    public PlayerScripts Player;

    public override void UpdateState(bool state)
    {
        Player.MovesRight = state || Input.GetAxis("Horizontal") > 0f;
    }
}
