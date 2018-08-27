using Alfred.Domain.ValueObjects;

namespace Alfred.Domain.Requests
{
    public sealed class RequestStateManager : IEntity
    {
        public Id Id { get; private set; }

        private RequestState _stateOfRequest;

        private RequestStateManager() { }

        public RequestStateManager Load( Id id, RequestState stateOfRequest)
        {
            RequestStateManager stateManager = new RequestStateManager
            {
                Id = id,
                _stateOfRequest = stateOfRequest
            };
            return stateManager;
        }

        public void SetState(RequestState stateOfRequest)
        {
            _stateOfRequest = stateOfRequest;
        }

        public RequestState GetState()
        {
           return _stateOfRequest;
        }

    }
}
