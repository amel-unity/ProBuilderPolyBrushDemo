using UnityEngine;

[ExecuteAlways]
public class ShakeManager : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        Shader.SetGlobalVector("_PlayerPosition", player.transform.position);
    }
}


