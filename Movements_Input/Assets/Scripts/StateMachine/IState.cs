namespace LearnMovements
{
    public class IState
    {
        public void Enter();

        public void Exit();

        public void HandleInput();

        public void Update();

        public void PhysicsUpdate();
    }
}
