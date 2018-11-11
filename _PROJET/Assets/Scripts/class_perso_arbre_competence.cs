using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class class_perso_arbre_competence : MonoBehaviour {

    public struct perso_arbre_competences
    {
        int nb;
        noeuds[] arbre;
    }
    public struct noeuds
    {
        int active;
        noeuds_stats stats;
    }
     public struct noeuds_stats {
        int degats_percant_distance;
        int degats_normal_distance;
        int blindage;
        int degats_percant_melee;
        int degats_normal_mele;
        int nb_blocage;
        int vieMax;
        int blessure;
        int special;
        int portee;
        int action_restante;
        int actionMax;
    }
}
