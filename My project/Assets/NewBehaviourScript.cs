using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    string HeroName = "gt68";
    int heroHeight = 165;
    int heroAge = 26;
    string heroSuperPower = "drifting";
    



    string villainName = "electric car";
    string vililanHeight = "65";
    string villainAge = "20";
    string villainSuperPower = "no sound";

    int ageDifference = 6;

    void Start()
    {
        
        print(" hello my name is "+ HeroName + " my height is "+ heroHeight + " my age is "+ heroAge + " my super power is "+ heroSuperPower);
        print(" hello my name is " + villainName + " my height is " + vililanHeight + " my age is " + villainAge + " my super power is "+ villainSuperPower);
        print("the age diffrance is " + ageDifference);
        print(heroHeight + 5);
        print(villainName + " is none");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
