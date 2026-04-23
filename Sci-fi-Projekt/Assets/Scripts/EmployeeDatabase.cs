using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EmployeeDatabase", menuName = "Scriptable Objects/EmployeeDatabase")]
public class EmployeeDatabase : ScriptableObject
{
    //---------------------------------------------------------
    public List<string> employeeFirstNames = new List<string>()
    {
        "Dyllan",
        "Celina",
        "Ragou",
        "Seal",
        "Lahy",
        "Teto",
        "Miku",
        "Oscar",
        "Kaio",
        "Lucas",
        "Magnus",
        "Sam",
        "Brandon",
        "Maddison",
        "Corey",
        "Finnegan",
        "Regina",
        "Katie",
        "Russell",
        "Heathcliff",
        "Don",
        "Ishmael",
        "Brennan",
        "Jordan",
        "Mike",
        "Molly",
        "Will",
        "Emily",
        "Josh",
        "Reginald",
        "Bernard",
        "Matt",
        "Monica",
        "Stella",
        "Avery",
        "Gretchen",
        "Freddy",
        "Fred",
        "Shaggy",
        "Velma",
        "Duncan",
        "Reese",
        "Gustav",
        "Alexander",
        "Sascha",
        "Erin",
        "Angelica",
        "Eliza",
        "Peggy"
    };
    public List<string> alienFirstNames = new List<string>()
    {
        "Glub",
        "Glob",
        "Gaboogle",
        "fauwgfcawu",
        "Xenomorph",
        "Qu",
        "AM",
        "Strorcanz",
        "Y'alogaal",
        "Zabadee",
        "Name",
        "FirstName",
        "Alien",
        "",
        "wasd",
        "Effigy",
        "Boink",
        "Zørlocke",
        "Blep",
        "Blip",
        "Blippidy",
        "Zerb",
        "Gorb",
        "Gnorb",
        "Virgilius",
        "Gnarpy"
    };
    //---------------------------------------------------------
    public List<string> employeeLastNames = new List<string>()
    {
        "Smith",
        "Jones",
        "Celina",
        "George",
        "Marowich",
        "Russell",
        "Johnson",
        "Peterson",
        "Blackbeard",
        "Tibone",
        "Robertson",
        "Jimson",
        "Gonzales",
        "Wesley",
        "Mcdonald",
        "Sunset",
        "Badguy",
        "Hamilton",
        "Schuyler"
    };
    public List<string> alienLastNames = new List<string>()
    {
        "Zuckerberg",
        "Za'a'loogaboog",
        "LastName",
        "Name",
        "",
        "Zmith",
        "Kilalhumans",
        "Alaeinsrul",
        "Notanalien",
        "The Mother",
        "Zargolbargle",
        "Elias",
        "Ahab",
        "game.names:getHumanName()"
    };
    //---------------------------------------------------------
    public List<string> employeeDepartment = new List<string>()
    {
        "Radiation",
        "Mining",
        "Alien Testing",
        "Guarding",
        "Research",
        "Alien Aircraft Testing",
        "Accounting",
        "Research and study",
        "Agriculture",
        "Cyber Security",
        "Alien Literature Analysis",
        "Entertainment",
        "Xenogastronomy",
        "Janitorial",
        "Wash and Repair",
    };
    public List<string> alienDepartment = new List<string>()
    {
        "Human killing",
        "Minning",
        "Alien escaping",
        "Grding",
        "Resurch",
        "Being human",
        "UFO Piloting",
        "Human Disguise",
        "Food?",
        "bugs",
        "Full of Burger",
        "Middleschool teacher?",
        "Astrology",
        "Youtube",
        "Theater Club",
        "The Kitchens",
        "Geomancy",
        "Grogomancy",
        "The janitor",
        "Trailblazing",
        "Reddit Moderation",
        "Seams Stressing",
        "Watch and Destroy",
        "Hamilton",
        "Angelica",
        "Eliza",
        "Peggy"

    };
    //--------------------------------------------------
    public List<string> employeePOB = new List<string>()
    {
        "Nykøbing Falster",
        "Randers",
        "New york",
        "Manchester",
        "England",
        "Mexico City",
        "Beijing",
        "Moscow",
        "Hamilton",
        "Hamburg",
        "Indianapolis",
        "Mumbai",
        "Cairo",
        "Santiago",
        "Bosingen",

    };
    public List<string> alienPOB = new List<string>()
    {
        "The Death Star",
        "Mars",
        "The Moon",
        "Urth",
        "Earth",
        "Brittle Hollow",
        "Eye of the Universe",
        "The Interloper",
        "The Quantom Moon",
        "The Sun",
        "Timber Hearth",
        "The Dark Bramble",
        "The Stranger",
        "Definitely Earth",
        "",
        "Erid"
    };
    //--------------------------------------------------
    public List<string> employeeDOB = new List<string>()
    {
        "March 29 1991",
        "April 5 2003",
        "April 3 2008",
        "January 5 1982",
        "February 27 1973",
        "June 13 1959",
        "September 21 1981",
        "May 2 2005",
        "August 9 1959",
        "December 8 1997"
    };
    public List<string> alienDOB = new List<string>()
    {
        "December 23 1693",
        "",
        "14 October 2004",
        "19 Aepril 2001",
        "August 11 2029",
        "March 42 1989",
        "July 01 1973"
    };
    //-------------------------------------------------

    public List<Sprite> sprites = new List<Sprite>();
    public List<Sprite> employeeIdCardLogos = new List<Sprite>();
    public List<Sprite> alienIdCardLogos = new List<Sprite>();
}
