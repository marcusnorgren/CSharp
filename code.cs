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


Properties
// You learned from the previous chapter that private variables can only be accessed within the same class (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties.
// A property is like a combination of a variable and a method, and it has two methods: a get and a set method:
class Person
{
  private string name; // field

  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
}
// The Name property is associated with the name field. It is a good practice to use the same name for both the property and the private field, but with an uppercase first letter.
The get method returns the value of the variable name.
The set method assigns a value to the name variable. The value keyword represents the value we assign to the property.
