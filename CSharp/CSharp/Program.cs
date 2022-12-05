﻿using CSharp.DelegateAndEvents;
using CSharp.Topics;
using System.Text;

if (true)
{
    #region Generics 

    Generics<string> objGenericsString = new Generics<string>("Yogesh");
    objGenericsString.GetType();

    Generics<int> objGenericsInt = new Generics<int>(1);
    objGenericsInt.GetType();

    #endregion
}


if (false)
{
    #region StringBuilder  
    ExampleStringBuilderClass.ExampleStringBuilder();
    #endregion
}

if (false)
{
    #region Event Delegates Example

    EventDelegateHelper.Example_Event();
    EventDelegateHelper.ExampleDelegates();

    #endregion
}

