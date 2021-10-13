using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroler : MonoBehaviour
{
    public enum Turnstate
    {
        None = 0,
        PlayerOne = 1,
        PlayerTwo = 2
    };

    public Turnstate turn;
    // Liste comprenant quel case le joueur a cliqué
    public List<int> pOC;
    public List<int> pTC;

    // Grille comprenant les "cases" du jeu de morpion
    public GameObject grid;
    // Boutton start pour afficher la grille
    public GameObject launch;
    // Fond
    public GameObject fond;
    public checkbox[] resCheck;

    // Start is called before the first frame update
    void Start()
    {
        // Initialise le tour de base
        turn = Turnstate.PlayerOne;

        // Fait disparaitre la grille au démarage
        grid.gameObject.SetActive(false);
        fond.gameObject.SetActive(true);
    }

    public void displayGrid()
    {
        // Active la grille quand le fonction est appelé (Appuie sur le boutton) et désactive le boutton
        grid.gameObject.SetActive(true);
        launch.gameObject.SetActive(false);
        fond.gameObject.SetActive(false);
    }

    // Désactivation de la grille
    public void desactivate()
    {
        
        resCheck = FindObjectsOfType<checkbox>();

        foreach (checkbox box in resCheck)
        {
            box.reset();
        }
        pOC.Clear();
        pTC.Clear();
        turn = Turnstate.PlayerOne;

    }

    // Fonction qui permet de changer le tour des joueur et ajoute l'id de la case modifier avant d'appeller la ofnction de check de victoire
    public void changeTurn(int _id)
    {
        if (turn == Turnstate.PlayerOne) { 
            turn = Turnstate.PlayerTwo;
            pOC.Add(_id);
        }
        else if (turn == Turnstate.PlayerTwo) {
            turn = Turnstate.PlayerOne;
            pTC.Add(_id);
        }

        check();
    }

    // Fonction qui vérifie la victoire
    void check()
    {
        // Condition victoire joueur 1
        if ((pOC.Contains(1) && pOC.Contains(5) && pOC.Contains(9)) || (pOC.Contains(3) && pOC.Contains(5) && pOC.Contains(7)) || (pOC.Contains(1) && pOC.Contains(2) && pOC.Contains(3)) || (pOC.Contains(4) && pOC.Contains(5) && pOC.Contains(6)) || (pOC.Contains(7) && pOC.Contains(8) && pOC.Contains(9)) || (pOC.Contains(1) && pOC.Contains(4) && pOC.Contains(7)) || (pOC.Contains(2) && pOC.Contains(5) && pOC.Contains(8)) || (pOC.Contains(3) && pOC.Contains(6) && pOC.Contains(9)))
        {
            // Désactive la grille a la victoire
            desactivate();
            Debug.Log("P1 Win");
            
        }
        else if ((pTC.Contains(1) && pTC.Contains(5) && pTC.Contains(9)) || (pTC.Contains(3) && pTC.Contains(5) && pTC.Contains(7)) || (pTC.Contains(1) && pTC.Contains(2) && pTC.Contains(3)) || (pTC.Contains(4) && pTC.Contains(5) && pTC.Contains(6)) || (pTC.Contains(7) && pTC.Contains(8) && pTC.Contains(9)) || (pTC.Contains(1) && pTC.Contains(4) && pTC.Contains(7)) || (pTC.Contains(2) && pTC.Contains(5) && pTC.Contains(8)) || (pTC.Contains(3) && pTC.Contains(6) && pTC.Contains(9)))
        {
            desactivate();
            Debug.Log("P2 Win");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
