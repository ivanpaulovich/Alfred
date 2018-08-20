using Alfred.Domain.ValueObjects;

namespace Alfred.Domain.Requests
{
    public class StateManager : IEntity
    {
        public Id Id { get; private set; }

        private RequestState _stateOfRequest;

        public StateManager LoadStateManager(
            Id id,
            RequestState stateOfRequest)
        {
            StateManager stateManager = new StateManager();
            stateManager.Id = id;
            stateManager._stateOfRequest = stateOfRequest;
            return stateManager;
        }

        public void Open()
        {

        }

        public void Set()
        {

        }

        public void Complete()
        {
        }

        public void Cancel()
        {
        }
    }
}
