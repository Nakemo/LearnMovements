using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LearnMovements
{
    public class PlayerRunningState : PlayerMovementState
    {
        public PlayerRunningState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }
    }
}
