using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid_manager : MonoBehaviour
{
    private int rows = 3;
    private int cols = 2;
    private float tilesize = 1;
    void Start()
    {
        gengrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void gengrid()
    {
        GameObject referenceTile = (GameObject)Instantiate(Resources.Load("stadium-ground-texture"));
        for(int row=0; row < rows; row++)
        {
            for(int col = 0; col < cols; col++)
            {

                GameObject tile = (GameObject)Instantiate(referenceTile, transform);

                float posX = col * tilesize;
                float posY = row * -tilesize;

                tile.transform.position = new Vector3(posX, posY);
            }
        }
        Destroy(referenceTile);
    }
}
