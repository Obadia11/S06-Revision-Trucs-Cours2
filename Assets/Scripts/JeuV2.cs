using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JeuV2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _etiquettePoints;
    [SerializeField] private TextMeshProUGUI _etiquetteTemps;

    public int pointsJeu = 0;
    public int tempsJeu = 000;

    void Start()
    {
        pointsJeu = 0;
        
        // Éxecute la méthode AugmenterTemps 
        InvokeRepeating("AugmenterTemps", 0f, 1f);
        tempsJeu = 0;
    }

    public void AugmenterPoints()
    {
        // Augmenter les points du jeu
        pointsJeu++;
        // Actualiser l'UI
        _etiquettePoints.text = "$" + pointsJeu.ToString();
    }

    public void AugmenterTemps()
    {
        // Compter le temps du jeu
        tempsJeu++;
        // Actualiser l'UI
        _etiquetteTemps.text = "H" + tempsJeu.ToString();
    }
}
