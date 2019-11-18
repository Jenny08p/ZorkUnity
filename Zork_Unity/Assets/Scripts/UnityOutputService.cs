using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zork_Common;


public class UnityOutputService : MonoBehaviour, IOutputService
{
    [SerializeField]
    private Text OutputTextPrefab;

    [SerializeField]
    private Transform OutputTextContainer;

    [SerializeField]
    private int MaxTextLines = 60;
    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public void Write(string value)
    {
        throw new System.NotImplementedException();
    }

    public void Write(object value)
    {
        throw new System.NotImplementedException();
    }

    public void WriteLine(string value)
    {
        if (mOutputLines.Count >= MaxTextLines)
        {
            Destroy(mOutputLines[0]);
            mOutputLines.RemoveAt(0);
        }
        var outputLine = Instantiate(OutputTextPrefab);
        outputLine.transform.SetParent(OutputTextContainer, false);
        outputLine.text = value;
    }

    public void WriteLine(object value)
    {
        throw new System.NotImplementedException();
    }
    public UnityOutputService()
    {
        mOutputLines = new List<GameObject>(); 
    }

    private List<GameObject> mOutputLines;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
