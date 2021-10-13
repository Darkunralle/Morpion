using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class checkbox : MonoBehaviour, IPointerClickHandler//, IPointerEnterHandler
{
    // Jonction avec le fichier gamecontroler
    public gamecontroler game;
    // Variable pour les symbole des joueurs
    public Sprite cross;
    public Sprite circle;
    // Id de la box
    public int id;
    // Bool qui vérifie si la case a déja était jouer
    public bool played = false;

    // Start is called before the first frame update
    void Start()
    {
        // "Affectation" de la jonction sur une variable
        game = FindObjectOfType<gamecontroler>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Vérifie si la case a était jouer
        if(played == false)
        {
            // Vérifie a qui le tour
            if(game.turn == gamecontroler.Turnstate.PlayerOne)
            {
                GetComponent<Image>().sprite = cross;
                //GetComponent<Image>().color = Color.red;
                // Appelle la fonction de changement de tour
                game.changeTurn(id);
            }else if(game.turn == gamecontroler.Turnstate.PlayerTwo)
            {
                GetComponent<Image>().sprite = circle;
                //GetComponent<Image>().color = Color.blue;
                game.changeTurn(id);
            }

            // La case a était jouer
            played = true;
        // La case est déjà jouer
        }else if(played == true)
        {
            Debug.Log("Déja jouer");
        }


        
    }

    public void reset()
    {
        played = false;
        GetComponent<Image>().sprite = null;
    }

   /* public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pleaseeee a MEDIC BAG");
    }*/

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
