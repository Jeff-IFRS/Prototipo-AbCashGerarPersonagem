using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeraPersonagem : MonoBehaviour {

    public string Planet;
    public string Race;
    public string Name;
    public int LastName;
    public int Rank;
    public string stringAge;
    public int Age;
    public string stringAgility;
    public int Agility;
    public string stringKnowledge;
    public int Knowledge;
    public string Status;
    public bool Transportrequiriment;
    public string Likes;
    public string Dislikes;
    public string Galaxy;

    //Textos que recebem as variaveis
    [Header("Textos")]
    public Text NameText;
    public Text PlanetText;
    public Text RaceText;
    public Text AgeText;
    public Text AgilityText;
    public Text InteligenceText;

    void Start() {
        Set_maxrank();
    }

    //"seta" o rank máximo para o personagem
    public void Set_maxrank() 
    {
        Select_randomrank(3);
    }

    //seleciona aleatóriamente o rank do personagem
    private void Select_randomrank(int maxrank) {
        Rank = Random.Range(1, maxrank);
        Select_randomplanet();
    }

    //seleciona aleatóriamente o planeta de origem do personagem
    private void Select_randomplanet() {
        string[] planets = new string[] {"Venus", "Terra", "Marte"};
        Planet = planets[Random.Range(0, planets.Length)];
        Galaxy = "Via Láctea";
        Select_race();
    }

    //seleciona aleatóriamente a raça do personagem conforme o planeta
    private void Select_race(){
        if (Planet == "Terra") {
            Race = "Terraqueo";
        }else if (Planet == "Marte") {
            string[] races = new string[] {"Marciano", "Terraqueo"};
            Race = races[Random.Range(0, races.Length)]; 
        } else {
            Race = "Venusiano";
        }
        Select_name();
    }

    //seleciona o nome do personagem conforme a raça
    private void Select_name(){
        if (Race == "Venusiano") {
            string[] venusian_names = new string[] {
                "Akna",
                "Bhaskan",
                "Cantis", 
                "Danu",
                "Edhino",
                "Freyja",
                "Galhant",
                "Haiont",
                "Iran"
            };
            Name = venusian_names[Random.Range(0, venusian_names.Length)];
        } else if (Race == "Terraqueo") {
            string[] terraqueous_names = new string[] {
                "Ana",
                "Bruno",
                "Brenda",
                "Carlos",
                "Duany",
                "Eduardo",
                "Eduarda",
                "Felipe",
                "Filipa",
                "Gabriel",
                "Gabriela",
                "Humberto",
                "Iuri",
                "Julia",
                "Kauan",
                "Luan",
                "Marcus",
                "Rafael",
                "Rafaela"
            };
            Name = terraqueous_names[Random.Range(0, terraqueous_names.Length)];
        } else {
            string[] marcian_names = new string[] {
                "Dejah",
                "Twell",
                "Aelita",
                "Tars"
            };
            Name = marcian_names[Random.Range(0,marcian_names.Length)];
        }
        Set_Age();
    }

    //seleciona a idade conforme a raça
    private void Set_Age(){
        if (Race == "Terraqueo") {
            Age = Random.Range(17, 31);
        } else if (Race == "Venusiano") {
            Age = Random.Range(30, 51);
        } else {
            Age = Random.Range(10, 17);
        }
        stringAge = Age.ToString();
        Set_Agility();
    }

    //seleciona o nível de agilidade conforme a raça, idade e rank.
    private void Set_Agility() {
        int random_agility = Random.Range(1, 10);
        if (Race == "Terraqueo") {
            Agility = (random_agility * 2 * Rank);
        } else if (Race == "Venusiano") {
            Agility = (random_agility * 4 * Rank);
        } else {
            Agility = (random_agility * 1 * Rank);
        }
        stringAgility = Agility.ToString();
        Set_knowledge();
    }

    //seleciona o nível de conhecimento conforme a idade, raça e rank.
    private void Set_knowledge(){
        int random_knowledge = Random.Range(1, 10);
        if (Race == "Terraqueo") {
            Knowledge = (random_knowledge * 1 * Rank) + Age;
        } else if (Race == "Venusiano") {
            Knowledge = (random_knowledge * 2 * Rank) + Age;
        } else {
            Knowledge = (random_knowledge * 4 * Rank) + Age;
        }
        stringKnowledge = Knowledge.ToString();
        Transport_Requirement();
    }

    //verifica se o alien é ou não do sitema onde fica a sede em que trabalha. Se não for, um de seus requerimentos vai ser o transporte.
    private void Transport_Requirement() {
        string local_System = "Andromeda";
        if (Galaxy != local_System) {
            Transportrequiriment = true;
        }
        ShowText();
    }

    void ShowText(){
        NameText.text = Name;
        PlanetText.text = Planet;
        RaceText.text = Race;
        AgeText.text = stringAge;
        AgilityText.text = stringAgility;
        InteligenceText.text = stringKnowledge;
    }
}
