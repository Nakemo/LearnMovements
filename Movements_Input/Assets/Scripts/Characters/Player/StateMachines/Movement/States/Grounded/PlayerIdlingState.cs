using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LearnMovements
{
    public class PlayerIdlingState : PlayerMovementState
    {
        public PlayerIdlingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }
    }
}
