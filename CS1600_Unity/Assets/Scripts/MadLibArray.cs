using UnityEngine;

public class MadLibArray : MonoBehaviour {

    string[] Name = { "James", "Timmy", "Brittney", "Jill", "Cory", "Kim", "Russel", "jack" };
    string[] Noun = { "cookie", "Flamingo", "desk", "plane", "computer", "monkey", "hand" };
    string[] Adverb = { "quickly", "slowly", "cleverly", "skillfuly", "deeply", "blindly" };
    string[] FamousPerson = { "Obama", "Donald Trump", "Mickey Mouse", "Adolf Hitler", "Michael Jackson", "brittney spears", "Morgan Freeman"};
    string[] Verb = { "Run", "jump", "punch", "dance", "High-Five", "skate", "burn" };
    string[] BodyPart = { "head", "knee", "hand", "foot", "mouth", "eye", "ear", "nose" };
    string[] Holiday = { "christmas", "easter", "Civil Rights Day", "presidents day", "Halloween", "Valentines Day", "Thanksgiving" };
    string[] Exclimation = { "Freak!", "Dang It!", "Crumbs!", "Blast!", "Land Sakes!", "good golly!", "Darn!" };
    string[] Distance = { "Five Feet", "Half a Mile", "A Stones throw", "One inch", "Hecka Far", "Light Years", " A Considerable length" };
    string[] Animal = { "Cat", "elephant", "Badger", "snake", "monkey", "giraffe", "swan", "Tiger", "Lion" };
    string[] Adjective = { "Mind Blowing", "Racially insensitive", "microscopic", "enormous","masculine","shrinky" };
    string[] place = { "New York", "Ukraine", "China", "North Pole", "USA", "europe", "Venus", "Jupitor" };
    string[] insult = { "poo-poo Head", "Jerk", "meanie", "racist", "rude", "insensitive", "doormat", "dumby" };
    string[] ingVerb = { "dying", "crawling", "twerking", "falling", "Breaking", "Burning", "Gyrating" };
    string[] weapon = { "bomb", "knife", "Uzi", "Rocket Launcher", "Sword", "cell phone", "pipe" };

    // Use this for initialization
    void Start() {
        int nameNum = Random.Range(0, Name.Length);
        int nounNum = Random.Range(0, Noun.Length);
        int adverbNum = Random.Range(0, Adverb.Length);
        int famousPersonNum = Random.Range(0, FamousPerson.Length);
        int verbNum = Random.Range(0, Verb.Length);
        int bodypartNum = Random.Range(0, BodyPart.Length);
        int holidayNum = Random.Range(0, Holiday.Length);
        int exclimationNum = Random.Range(0, Exclimation.Length);
        int exclimationNum2 = Random.Range(0, Exclimation.Length);
        int distanceNum = Random.Range(0, Distance.Length);
        int animalNum = Random.Range(0, Animal.Length);
        int adjectiveNum = Random.Range(0, Adjective.Length);
        int placeNum = Random.Range(0, place.Length);
        int insultNum = Random.Range(0, insult.Length);
        int ingVerbNum = Random.Range(0, ingVerb.Length);
        int famousPersonNum2 = Random.Range(0, FamousPerson.Length);
        int famousPersonNum3 = Random.Range(0, FamousPerson.Length);
        int weaponNum = Random.Range(0, weapon.Length);

        string madLib = string.Format("There once was a person by the name of {0}. One day {0} was walking along when they ran into a {1}. The {1} said: \"Hey, ive got a {2} {3} for you...\" \" {4}\" said {0}. \"How is that even possible?\" The {1} said \"It just is. Hey did you know {5} is\n coming up?\" \"Wow that is my favorite holiday\" exclaimed {0}. \" what are you going to dress up as?\" asked the {1}. \"{6}\" said {0}. \"{8}\" shouted the {1} \"Thats what I was going to dress up as... I guess ill have to be {7}.\n \"You know\" Shouted the {1}. I traveled {9} just to get insulted by a {10} named {0}. \"Im sorry\" said {0} \"Where are you from anyways?\" \"{11}\" said the {1}. \"That place is {12} {13}\" said {0} \"I know\" said the {1}. \"It hurts my {14} just thinking about it.\" \"I like to {15}!\" said {0}. \"That freaks me out!\" shouted the {1}. Then {16} came with a {17} and blew everything up. THE END.", Name[nameNum], Animal[animalNum], Adjective[adjectiveNum], Noun[nounNum], Exclimation[exclimationNum], Holiday[holidayNum], FamousPerson[famousPersonNum], FamousPerson[famousPersonNum2], Exclimation[exclimationNum2], Distance[distanceNum], insult[insultNum], place[placeNum], Adverb[adverbNum], ingVerb[ingVerbNum], BodyPart[bodypartNum],Verb[verbNum], FamousPerson[famousPersonNum3], weapon[weaponNum]);
        print(madLib);
	}
	
}
