using CSharp.DelegateAndEvents;


if (true)
{
    Example_Event();
    ExampleDelegates();
}

#region Delegates and Events 
static void Example_Event()
{
    //Event Example
    EventPublisher objEvent = new EventPublisher();

    //Default Event - without data (Empty Args)
    EventSubClass1 subscriber1 = new EventSubClass1();
    objEvent.EventSample += subscriber1.SubClassMethod1;

    //Event with data 
    CustomEventClass subscriber2 = new CustomEventClass();
    objEvent.CustomEventSample += subscriber2.CustomMethod1;

    //Publisher call 
    EventSubscriberData ObjSubscriberData = new EventSubscriberData("Yogesh");
    objEvent.PublisherMethod(ObjSubscriberData);
}

static void ExampleDelegates()
{
    //Delegate Example 
    DelegateExample objDel = new DelegateExample();
}

#endregion