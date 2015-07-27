using UnityEngine;
using System.Collections;

public class MainParser : MonoBehaviour {
    [Header("Words to look for")]
    public string[] passingVerbs;
    public string[] shootingVerbs;

    //count number of keywords
    int numPass;
    int numShoot;
	
	public void Parse(string[] parseString)
    {
        for (int i = 0; i < parseString.Length; i++)
        {
            //look for specific verbs in the inputted string
            for (int p = 0; p < passingVerbs.Length; p++)
            {
                if (parseString[i] == passingVerbs[p])
                {
                    numPass++;
                }
            }
            for (int s = 0; s < shootingVerbs.Length; s++)
            {
                if (parseString[i] == passingVerbs[s])
                {
                    numShoot++;
                }
            }
        }
    }
}
