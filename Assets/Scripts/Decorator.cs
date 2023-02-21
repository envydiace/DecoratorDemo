using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public abstract class Decorator : Component 
{
    protected Component _component;

    public Decorator(Component component)
    {
        this._component = component;
    }

    public void SetComponent(Component component)
    {
        this._component = component;
    }

    // The Decorator delegates all work to the wrapped component.

    public virtual void Power()
    {
        if (this._component != null)
        {
            _component.Power();
        }
    }
}
