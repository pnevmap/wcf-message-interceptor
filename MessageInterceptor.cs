using System.ServiceModel.Dispatcher;
using System.ServiceModel.Description;

namespace WCF
{
    class MessageInpector : IClientMessageInspector
    {
        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message
         reply, object correlationState)
        {
				// Do what you want with reply
        }

        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message
         request, System.ServiceModel.IClientChannel channel)
        {
				// Do what you want with request
            return null;
        }
    }


    class MessageInpectorBehavior : IEndpointBehavior
    {
        public void AddBindingParameters(ServiceEndpoint serviceEndpoint,
         System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        { }

        public void ApplyClientBehavior(ServiceEndpoint serviceEndpoint,
        System.ServiceModel.Dispatcher.ClientRuntime behavior)
        {
            //Add the inspector
            behavior.MessageInspectors.Add(new MessageInpector());
        }

        public void ApplyDispatchBehavior(ServiceEndpoint serviceEndpoint,
        System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher)
        {
        }

        public void Validate(ServiceEndpoint serviceEndpoint)
        {
        }

    }

}