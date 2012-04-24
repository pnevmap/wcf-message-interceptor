wcf-message-interceptor
=======================

This is a mode to intercept a wcf service call tracing request and response messages.

Usage:

//GenericWebserviceClient client = new GenericWebserviceClient();
client.Endpoint.Behaviors.Add(new WCF.MessageInpectorBehavior());
//client.GenericMethod()