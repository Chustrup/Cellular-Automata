using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{

    public RenderTexture texture;


    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (texture != null)
        {
            Graphics.Blit(texture, destination);
        }
    }
}
