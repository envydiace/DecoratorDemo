using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBehavior : MonoBehaviour
{
    public Component component;
    // Start is called before the first frame update
    public void SetComponent(Component component)
    {
        this.component = component;
    }
    void Start()
    {
        component = new ConcreteComponent();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(component != null)
            {
                component.Power();
            }
        }
    }
}
