using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LearnMovements
{
    [RequireComponent(typeof(PlayerInput))]
    public class Player : MonoBehaviour
    {
        public Rigidbody Rigidbody { get; private set; }
        public PlayerInput Input { get; private set; }

        private PlayerMovementStateMachine movementStateMachine;

        private void Awake()
        {
            Rigidbody = GetComponent<Rigidbody>();

            Input = GetComponent<PlayerInput>();

            movementStateMachine = new PlayerMovementStateMachine(this);
        }

        private void Start()
        {

            movementStateMachine.ChangeState(movementStateMachine.IdlingState);
        }


        private void Update()
        {
            movementStateMachine.HandleInput();

            movementStateMachine.Update();
        }

        private void FixedUpdate()
        {
            movementStateMachine.PhysicsUpdate();
        }
    }
}
