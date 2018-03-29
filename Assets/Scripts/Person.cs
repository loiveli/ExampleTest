using System.Collections;
using System.Collections.Generic;


public class Person  {

    // Use this for initialization
    public string[] names;
    
    public Person (params string[] nimet) {
        names = nimet;
	}
	
	// Update is called once per frame
	public string getLastName () {
        return names[names.Length-1];
	}
    public string getFirstName()
    {
        return names[0];
    }
    public string getName(int nimiIndex)
    {
        return names[nimiIndex];
    }
    public string getFullName()
    {
        string fullName = "";
        foreach (string nimi in names)
        {
            
            fullName=fullName + nimi +" ";
            
        }
        return fullName;
    }
    public void setName(string tempName, int nameIndex)
    {
        names[nameIndex] = tempName;
    }
    
}
