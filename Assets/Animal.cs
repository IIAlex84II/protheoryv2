using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Animal : MonoBehaviour
{
    protected float weightKg,jumpHeightMeter,bodyHeightMeter,maxSpeedKmh;
    protected string favFood, Sound;
    public TextMeshProUGUI textBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowStats()
    {

        textBox.text= this.GetType().ToString() + "- Weight: " + weightKg + ", jumpHeight: " + jumpHeightMeter + " , Height: " + bodyHeightMeter + " , max speed: " + maxSpeedKmh;
    }
    public virtual void  Attack()
    {
        textBox.text= "Attack";
    }
    
}
