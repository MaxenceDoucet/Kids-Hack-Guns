using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class animation_baston_drop : MonoBehaviour {
    public Vector3 test;
    int nbJ = 4;
    public int[] pow;
    public float[] modif;

    public void modifSize(int counter) {
        modif = new float[counter];
    }
    public void powSize(int counter)
    {
        pow = new int[counter];
    }
    Vector3 move(int[] pow, float[] modif, int nbPlayer)
    {
        Vector3 result;
        float x = 0;
        float z = 0;
        for (int a = 0; a < nbPlayer; a++)
        {
            x += pow[a] * modif[2 * a]/100;
            z += pow[a] * modif[2 * a + 1]/100;
        }
        int x2 = (int)x;
        int z2 = (int)z;
        result = new Vector3(x2, 0, z);
        return (result);
    }
    private void Start()
    {
        modifSize(nbJ * 2);
        powSize(nbJ);
        for (int a = 0; a < nbJ; a++)
        {
            modif[a * 2] = (Mathf.Cos(2 * Mathf.PI / nbJ * (a+1)))*100;
            modif[a * 2 + 1] = (Mathf.Sin(2 * Mathf.PI / nbJ * (a+1)))*100;
        }
    }
    private void FixedUpdate()
    {
        for (int a = 0; a < nbJ; a++)
        {
            pow[a] = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
            pow[0] += 2;
        if (Input.GetKeyDown(KeyCode.Alpha2))
            pow[1] += 2;
        if (Input.GetKeyDown(KeyCode.Alpha3))
            pow[2] += 2;
        if (Input.GetKeyDown(KeyCode.Alpha4))
            pow[3] += 2;
        test = move(pow, modif, nbJ);
        Vector3 X = gameObject.GetComponent<Transform>().position += test;
    }
}
