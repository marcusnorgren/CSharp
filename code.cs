using:
//Ex:
using (object)
{
....
}
// using makes sure object is destroyed when the using-block is exited, i.e. object only needed inside using-block.

Subscribe to events:
this.Load += new System.EventHandler(this.Form1_Load);
// Use the addition assignment operator (+=) to attach an event handler to the event. 
// In the following example, assume that an object named publisher has an event named RaiseCustomEvent. 
// Note that the subscriber class needs a reference to the publisher class in order to subscribe to its events.
