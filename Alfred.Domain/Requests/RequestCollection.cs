using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Alfred.Domain.Requests
{
    //Im wrapping list functionality in this class to simplify usage
    //This class is sealed so it cant be inherited
    public sealed class RequestCollection<TRequesType> where TRequesType : Request
    {
        private readonly IList<TRequesType> _requests;

        public RequestCollection()
        {
            _requests = new List<TRequesType>();
        }

        //Gets all requests (reminders, bill pay..ect)
        public IReadOnlyCollection<TRequesType> GetAllRequests()
        {
            IReadOnlyCollection<TRequesType> requests = new ReadOnlyCollection<TRequesType>(_requests);
            return requests;
        }

        public TRequesType GetLastRequest()
        {
            TRequesType request = _requests[_requests.Count - 1];
            return request;
        }

        public void Add(TRequesType request)
        {
            _requests.Add(request);
        }
    }
}
