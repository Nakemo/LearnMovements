using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LearnMovements
{
    public class PlayerWalkingState : PlayerMovementState
    {
        public PlayerWalkingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }
    }
}
