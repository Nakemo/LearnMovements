using UnityEngine;

namespace LearnMovements
{
    public class PlayerMovementState : IState
    {
        protected PlayerMovementStateMachine stateMachine;

        protected Vector2 movementInput;
        public PlayerMovementState(PlayerMovementStateMachine playerMovementStateMachine) 
        {
            stateMachine = playerMovementStateMachine;     
        }     

        public virtual void Enter() 
        {
            Debug.Log("State: " + GetType().Name);
        }

        public virtual void Exit()
        {

        }

        public virtual void HandleInput()
        {

        }
        public virtual void Update()
        {

        }

        public virtual void PhysicsUpdate()
        {

        }
    }
}
