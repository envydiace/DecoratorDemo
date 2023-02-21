using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBehavior : MonoBehaviour
{
    GameObject mover;
    // Start is called before the first frame update
    void Start()
    {
        mover = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            var simple = new ConcreteComponent();
            mover.GetComponent<MoverBehavior>().SetComponent(simple);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            var simple = new ConcreteComponent();
            ConcreteDecoratorA concreteA = new ConcreteDecoratorA(simple);
            mover.GetComponent<MoverBehavior>().SetComponent(concreteA);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            var simple = new ConcreteComponent();
            ConcreteDecoratorB concreteB = new ConcreteDecoratorB(simple);
            mover.GetComponent<MoverBehavior>().SetComponent(concreteB);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            var simple = new ConcreteComponent();
            ConcreteDecoratorA concreteA = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB concreteB = new ConcreteDecoratorB(concreteA);
            mover.GetComponent<MoverBehavior>().SetComponent(concreteB);
        }
    }
}
