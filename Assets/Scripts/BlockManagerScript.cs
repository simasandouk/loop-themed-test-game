using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public GameObject EditorWindowContent;
    public GameObject CommandBlock;
    public GameObject LoopBlock;

    public void SpawnLoop()
    {
        Instantiate(LoopBlock, EditorWindowContent.transform);
    }
    public void SpawnCommand()
    {
        Instantiate(CommandBlock, EditorWindowContent.transform);
    }

}
