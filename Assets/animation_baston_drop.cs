using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class animation_baston_drop : MonoBehaviour
{
    public  int test_fin = 1;
    public Vector3 test;
    public int[] pow2 = new int[6];
    public int[] pow = new int[6];
    public float[] modif = new float[12];
    public int nbJ = 3;

    public float[] modifSize(float [] modifs, int counter)
    {
        modifs = new float[counter];
        return (modifs);
    }
    public int[] powSize(int[] pow, int counter)
    {
        pow = new int[counter];
        return (pow);
    }
    Vector3 move(int[] pow, float[] modif, int nbPlayer)
    {
        Vector3 result;
        float x = 0;
        float z = 0;
        for (int a = 0; a < nbPlayer; a++)
        {
            x += pow[a] * modif[2 * a] / 100;
            z += pow[a] * modif[2 * a + 1] / 100;
        }
        int x2 = (int)x;
        int z2 = (int)z;
        result = new Vector3(x2, 0, z);
        return (result);
    }
    private void Start()
    {
        for (int a = 0; a < nbJ; a++)
        {
            modif[a * 2] = (Mathf.Cos(2 * Mathf.PI / nbJ * (a + 1))) * 100;
            modif[a * 2 + 1] = (Mathf.Sin(2 * Mathf.PI / nbJ * (a + 1))) * 100;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        int tests;
        MonoBehaviour.print("c bon");
        if (other.gameObject.tag == "J1")
        {
            MonoBehaviour.print("J1 gagne le loot");
        }
        if (other.gameObject.tag == "J2")
        {
            MonoBehaviour.print("J2 gagne le loot");
        }
        if (other.gameObject.tag == "J3")
        {
            MonoBehaviour.print("J3 gagne le loot");
        }
        if (other.gameObject.tag == "J4")
        {
            MonoBehaviour.print("J4 gagne le loot");
        }
        if (other.gameObject.tag == "J5")
        {
            MonoBehaviour.print("J5 gagne le loot");
        }
        if (other.gameObject.tag == "J6")
        {
            MonoBehaviour.print("J6 gagne le loot");
        }
    }
    private void Update()
    {
            for (int a = 0; a < nbJ; a++)
            {
                pow[a] = 0;
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
                pow[0] += 5;
            pow2[0] += 5;
            if (Input.GetKeyDown(KeyCode.Alpha2))
                pow[1] += 5;
            pow2[1] += 5;
            if (Input.GetKeyDown(KeyCode.Alpha3))
                pow[2] += 5;
            pow2[2] += 5;
            if (Input.GetKeyDown(KeyCode.Alpha4))
                pow[3] += 5;
            pow2[3] += 5;
            test = move(pow, modif, nbJ);
            Vector3 X = gameObject.GetComponent<Transform>().position += test;
    }
}
