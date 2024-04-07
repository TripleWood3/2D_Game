using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class TeamSystem : MonoBehaviour
{
    [SerializeField] public static TeamSystem instance;

    private Dictionary<string, Team> _teams; 
    private void Awake()
    {
        if (instance != null)
            Debug.Log("Duplicate TeamSystem");

        instance = this;
        _teams = new Dictionary<string, Team>();
    }

    public void Add(string name)
    {
        _teams.Add(name, new Team());
    }
    public void Remove(string name)
    {
        _teams.Remove(name);
    }
}

public class Team
{
    private HashSet<ITeamable> _member;
    public Team()
    {
        _member = new HashSet<ITeamable>();
    }
    public void Add(ITeamable c)
    {
        _member.Add(c);
    }
    public void Remove(ITeamable c)
    {
        _member.Remove(c);
    }
}

public interface ITeamable
{ 

}