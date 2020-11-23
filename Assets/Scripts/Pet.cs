using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{

    public int hunger;
    public int happiness;
    public int boredom;

    public float elapsedHunger;
    public float elapsedHappiness;
    public float elapsedBoredom;

    public SliderBar hungerBar;
    public SliderBar happinessBar;
    public SliderBar boredomBar;


    // Start is called before the first frame update
    void Start()
    {
        hunger = 1000;
        happiness = 1000;
        boredom = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedHunger += Time.deltaTime;
        elapsedHappiness += Time.deltaTime;
        elapsedBoredom += Time.deltaTime;

        if (elapsedHunger >= 0.1f)
        {
            elapsedHunger = elapsedHunger % 1f;
            ChangeHunger(-1);
            elapsedHunger = 0;
        }
        if (elapsedHappiness >= 0.5f)
        {
            elapsedHappiness = elapsedHappiness % 1f;
            ChangeHappiness(-1);
            elapsedHappiness = 0;
        }
        if (elapsedBoredom >= 0.2f)
        {
            elapsedBoredom = elapsedBoredom % 1f;
            ChangeBoredom(-1);
            elapsedBoredom = 0;
        }
        UpdateBars();
    }

    public void ChangeHunger(int amount)
    {
        hunger += amount;
    }

    public void ChangeHappiness(int amount)
    {
        happiness += amount;
    }

    public void ChangeBoredom(int amount)
    {
        boredom += amount;
    }

    public void UpdateBars()
    {
        hungerBar.SetHealth(hunger);
        happinessBar.SetHealth(happiness);
        boredomBar.SetHealth(happiness);
    }
}
