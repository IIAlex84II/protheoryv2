using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        weightKg = 4f;
        bodyHeightMeter = .3f;
        Sound = "Meow";
        favFood = "Milk and Mice";
        maxSpeedKmh = 50;


    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void Attack()
    {
        base.textBox.text= "Cat bites and scratches. ";
    }
}
