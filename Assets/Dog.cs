using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // Start is called before the first frame update
    void Start()
    {
         weightKg=20f;
        bodyHeightMeter = .7f;
        Sound = "Bark";
        favFood = "Sausages and Steaks";
        maxSpeedKmh = 50;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Attack()
    {
        base.textBox.text= "Dog bites. ";
    }
}
