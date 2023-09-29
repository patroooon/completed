using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolChange : MonoBehaviour
{
    public ToolChange toolChange;
    public List<GameObject> tools = new List<GameObject>();
    public List<GameObject> hands = new List<GameObject>();
    
    public void SwapTools()
    {
        for (int i = 0; i < hands.Count; i++)
        {
            Tool toolInHand = hands[i].GetComponentInChildren<Tool>();

            Quaternion currentToolRotation = Quaternion.identity;
            Vector3 currentToolPosition = Vector3.zero;

            if (toolInHand != null)
            {
                currentToolRotation = toolInHand.gameObject.transform.localRotation;
                currentToolPosition = toolInHand.gameObject.transform.localPosition;


                Destroy(toolInHand.gameObject);
            }

            int randomTools = Random.Range(0, tools.Count);

            var newTool = Instantiate(tools[randomTools], hands[i].transform);
            newTool.transform.localPosition = currentToolPosition;
            newTool.transform.localRotation = currentToolRotation;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            toolChange.SwapTools();
        }
    }

}
