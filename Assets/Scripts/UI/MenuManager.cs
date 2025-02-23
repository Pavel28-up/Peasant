using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public Menu[] menus;

    public void Opening(string menuName)
    {
        for (int i = 0;  i < menus.Length; i++)
        {
            if (menus[i].menuName == menuName)
            {
                if (!menus[i].isOpened)
                    Open(menus[i]);
                else
                    Closed(menus[i]);
            }
        }
    }

    public void Open(Menu menu)
    {
        for (int i = 0; i < menus.Length; i++)
        {
            menus[i].Close();
        }
        menu.Open();
    }

    public void Closed(Menu menu)
    {
        menu.Close();
    }
}
