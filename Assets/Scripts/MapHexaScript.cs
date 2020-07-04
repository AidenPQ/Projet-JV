using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapHexaScript : MonoBehaviour
{

    public List<GameObject> ListeHexa;
    public Vector3 Axe1;
    public Vector3 Axe2;
    public Vector3 Axe3;
    public int nb_framesAnim = 60;

    private GameObject[] ListPlayers;
    private bool MoveController = false;
    private GameObject PlayerInMovement = null;
    private int movement_phase = 0;
    private GameObject Hex_destination;
    private Queue<Vector3> Anim_movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject SearchHexa(Vector3 position)
    {
        GameObject Hexa = ListeHexa[0];
        float diffposmin = (Hexa.transform.position - position).sqrMagnitude;
        for (int i = 1; i < ListeHexa.Capacity; i++)
        {
            Vector3 diffpos = ListeHexa[i].transform.position - position;
            if (diffpos.sqrMagnitude < diffposmin)
            {
                diffposmin = diffpos.sqrMagnitude;
                Hexa = ListeHexa[i];
            }
        }
        return Hexa;
    }
}
