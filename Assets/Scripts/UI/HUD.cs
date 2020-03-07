/* Filename: HUD.cs
 * Author: Caleb
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* HUD class
 * 
 * A class to update UI elements for the HUD. 
 */
public class HUD : MonoBehaviour
{
    public Player Player;
    public Slider Health;
    public Slider Stamina;
    public Slider Hunger;
    public Slider Thirst;
    public Slider Experience;

    // Update is called once per frame
    void Update()
    {
        Health.value = Player.Health / Player.MaxHealth;
        Stamina.value = Player.Stamina / Player.MaxStamina;
        Hunger.value = Player.Hunger / Player.MaxHunger;
        Thirst.value = Player.Thirst / Player.MaxThirst;
        Experience.value = Player.Experience / Player.MaxExperience;
    }
}
