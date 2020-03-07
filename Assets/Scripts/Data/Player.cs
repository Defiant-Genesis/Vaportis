/* Filename: Player.cs
 * Author: Caleb
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Player class
 * 
 * A class handling player stats and data.
 */
public class Player : MonoBehaviour
{
    public MenuHandler MenuManager;
    public int OptionsIndex;
    public int DeathIndex;
    [Header("Stats")]
    public float MaxHealth = 100;
    public float MaxStamina = 100;
    public float MaxHunger = 100;
    public float MaxThirst = 100;
    public float MaxExperience = 100;
    public float Armor = 10;
    [Tooltip("Hunger loss per second.")] public float HungerLossRate = 0.6f;
    [Tooltip("Thirst loss per second.")] public float ThirstLossRate = 0.4f;
    [HideInInspector] public float Health = 100;
    [HideInInspector] public float Stamina = 100;
    [HideInInspector] public float Hunger = 100;
    [HideInInspector] public float Thirst = 100;
    [HideInInspector] public float Experience = 0;

    // Start is called before the first frame update
    void Start()
    {
        MenuManager.Continue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0) Die();

        if (Input.GetButtonDown("Pause"))
        {
            if (MenuManager.active)
            {
                if (!MenuManager.isPaused)
                {
                    MenuManager.OpenMenu(OptionsIndex);
                    MenuManager.Pause();
                }
                else
                {
                    MenuManager.CloseMenu(OptionsIndex);
                    MenuManager.Continue();
                }
            }
        }

        Hunger -= Time.deltaTime * HungerLossRate;
        Thirst -= Time.deltaTime * ThirstLossRate;

        if(Hunger <= 0)
        {
            Hunger = 0;
            Health -= 5 * Time.deltaTime;
        }
        if(Thirst <= 0)
        {
            Thirst = 0;
            Health -= 5 * Time.deltaTime;
        }
    }

    /* Function: Update
     *  
     * Returns: Nothing 
     * 
     * Checks the quests goals and determines if the quest has been completed.
     */
    void Die()
    {
        MenuManager.Pause();
        MenuManager.OpenMenu(DeathIndex);
        MenuManager.Stop();
    }

}
