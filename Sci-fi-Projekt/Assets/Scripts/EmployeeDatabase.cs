using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EmployeeDatabase", menuName = "Scriptable Objects/EmployeeDatabase")]
public class EmployeeDatabase : ScriptableObject
{
    public List<string> EmployeeNames = new List<string>()
    {
        "Dyllan",
        "Celina",
        "Ragou",
        "Drømme Celina",
        "Seal5",
        "Lahyhyhy",
        "Teto",
        "Miku Hatsune",
        "CupcakKe"
    };

    public List<string> EmployeeDepartment = new List<string>()
    {
        "Radiation",
        "Mining",
        "Alien testing",
        "Guarding",
        "Research"
    };

    public List<string> EmployeePOB = new List<string>()
    {
        "Nykøbing Falster",
        "Randers",
        "plads 3",
        "palds 5",
        "Sted"
    };

    public List<string> EmployeeDOB = new List<string>()
    {
        "1991 March 29",
        "2001 April 15",
        "2008 April 3",
        "1954 December 24"
    };

    public List<Sprite> sprites = new List<Sprite>();
}
