using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Alfred.Application.UseCases.RegisterSubscriber;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Twilio.TwiML;
using Twilio.TwiML.Messaging;
using ValidateRequestExample.Filters;

namespace Alfred.WebApi.UseCases.Register
{
    [Route("api/subscribe")]
    [ApiController]
    public class RegisterSubscribersController : Controller
    {
        public class TwilioMessagingRequest
        {
            public string Body { get; set; }
        }

        private readonly IRegisterSubscriberAppService _registerSubscriberAppService;

        public RegisterSubscribersController(IRegisterSubscriberAppService registerSubscriberAppService)
        {
            _registerSubscriberAppService = registerSubscriberAppService;
        }


        // GET api/subscriber
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "sub1", "sub2" };
        }

        // POST api/subscriber
        //[ValidateTwilioRequest]
        [Produces("text/xml")]
        [HttpPost]
        public void Post(string value)
        {

        }

        [Route("message")]
        [AcceptVerbs("POST")]
        //[ValidateTwilioRequest]
        public HttpResponseMessage PostMessage([FromBody] TwilioMessagingRequest messagingRequest)
        {
            var message =
                $"Your text to me was {messagingRequest.Body.Length} characters long. " +
                "Webhooks are neat :)";

            var response = new MessagingResponse();
            response.Append(new Message(message));

            return ToResponseMessage(response.ToString());
        }

        private static HttpResponseMessage ToResponseMessage(string response)
        {
            return new HttpResponseMessage
            {
                Content = new StringContent(response, Encoding.UTF8, "application/xml")
            };
        }
    }

}