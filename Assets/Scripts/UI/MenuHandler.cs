/* Filename: MenuHandler.cs
 * Author: Caleb
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* MenuHandler Class
 * 
 * Allows you to open and close UI objects at will.
 */
public class MenuHandler : MonoBehaviour
{
    public List<GameObject> menus;
    [HideInInspector] public bool active = true;
    [HideInInspector] public bool isPaused = false;

    /* Function: OpenMenu
     * 
     * Args:
     *  int index: the index of the menu to open.
     *  
     * Returns: Nothing.
     * 
     * Makes the target menu visible.
     */
    public void OpenMenu(int index)
    {
        if (active) menus[index].SetActive(true);
    }

    /* Function: CloseMenu
     * 
     * Args:
     *  int index: the index of the menu to close.
     *  
     * Returns: Nothing.
     * 
     * Makes the target menu close.
     */
    public void CloseMenu(int index)
    {
        if(active) menus[index].SetActive(false);
    }

    /* Function: Pause
     *  
     * Returns: Nothing 
     * 
     * Freezes the time of the game.
     */
    public void Pause()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        isPaused = true;
    }

    /* Function: Continue
     *  
     * Returns: Nothing 
     * 
     * Unfreezes the time of the game.
     */
    public void Continue()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        isPaused = false;
    }

    /* Function Stop
     * 
     * Returns: Nothing
     * 
     * Deactivates the menu handler.
     */
    public void Stop()
    {
        active = false;
    }
}
