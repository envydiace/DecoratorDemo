using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(Component comp) : base(comp)
    {
    }

    // Decorators may call parent implementation of the operation, instead
    // of calling the wrapped object directly. This approach simplifies
    // extension of decorator classes.

    public override void Power()
    {
        base.Power();
        Debug.Log("Have Power A");
    }
}