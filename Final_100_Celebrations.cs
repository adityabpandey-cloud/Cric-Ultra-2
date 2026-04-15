using UnityEngine;
using System.Collections.Generic;

public class Final_100_Celebrations : MonoBehaviour {
    
    private Dictionary<string, string> top100Styles = new Dictionary<string, string>() {
        // --- INDIA (IPL & WC STARS) ---
        { "Virat Kohli", "King_Aggressive_Roar" }, { "MS Dhoni", "Captain_Cool_Bat_Raise" },
        { "Rohit Sharma", "The_Hitman_Pull_Pose" }, { "Hardik Pandya", "Rockstar_Arms_Wide" },
        { "Suryakumar Yadav", "I_Am_Here_Gesture" }, { "Shubman Gill", "Prince_The_Bow" },
        { "Ravindra Jadeja", "The_Sword_Play" }, { "Jasprit Bumrah", "I_Am_The_Best_Point" },
        { "Mohammed Siraj", "Siuuu_Celebration" }, { "Rishabh Pant", "Spiderman_Gymnastics" },
        { "KL Rahul", "Shut_The_Noise_Ears" }, { "Yashasvi Jaiswal", "Young_King_Salute" },
        { "Rinku Singh", "Gods_Plan_Point" }, { "Shreyas Iyer", "Smooth_Walk_Celebration" },
        { "Sanju Samson", "Classy_Cap_Touch" }, { "Kuldeep Yadav", "Magician_Finger_Roll" },
        { "Axar Patel", "Consistent_Bapu_Clap" }, { "Arshdeep Singh", "Airplane_Run" },
        { "Mohammed Shami", "The_Sultan_Prayer" }, { "Ishan Kishan", "High_Five_Sprint" },
        { "Ruturaj Gaikwad", "Calm_Leader_Smile" }, { "Riyan Parag", "Assamese_Bihu_Dance" },
        { "Tilak Varma", "Young_Gun_Heart_Sign" }, { "Washington Sundar", "Classic_Offie_Spin" },
        { "Yuzvendra Chahal", "Side_Leaning_Pose" }, { "Deepak Chahar", "Swing_King_Bow" },
        { "Shivam Dube", "Sixer_King_Stance" }, { "Ravi Bishnoi", "Aggressive_Leggie_Jump" },
        { "T. Natarajan", "Yorker_King_ThumbsUp" }, { "Varun Chakravarthy", "Mystery_Stare" },

        // --- AUSTRALIA ---
        { "Travis Head", "Aggressive_World_Cup_Point" }, { "Pat Cummins", "The_Silencer_Shh" },
        { "Glenn Maxwell", "The_Big_Show_Flex" }, { "David Warner", "Pushpa_Step" },
        { "Mitchell Starc", "Swing_Death_Stare" }, { "Steve Smith", "Thinking_Genius_Nod" },
        { "Marcus Stoinis", "The_Hulk_Muscle_Flex" }, { "Josh Hazlewood", "Standard_Aussie_Clap" },
        { "Adam Zampa", "Coffee_Lover_Spin" }, { "Tim David", "Power_Hitter_Point" },
        { "Mitchell Marsh", "The_Bison_Roar" }, { "Cameron Green", "Giant_High_Five" },

        // --- SOUTH AFRICA (RABADA & CO.) ---
        { "Kagiso Rabada", "Spearhead_Point_Sky" }, { "Heinrich Klaasen", "Power_Shout" },
        { "Quinton de Kock", "The_Quinny_Smile" }, { "David Miller", "Killer_Miller_Pose" },
        { "Anrich Nortje", "150Kmph_Fire_Signal" }, { "Aiden Markram", "Captain_Class_Raise" },
        { "Tabraiz Shamsi", "Magic_Trick_Shoe_Call" }, { "Keshav Maharaj", "Namaste_Celebration" },

        // --- ENGLAND ---
        { "Jos Buttler", "The_Boss_Bow" }, { "Liam Livingstone", "Longest_Six_Look" },
        { "Harry Brook", "The_Brook_Blink" }, { "Sam Curran", "Young_MVP_Slide" },
        { "Adil Rashid", "Leggie_Googly_Point" }, { "Phil Salt", "Aggressive_Opener_Flex" },
        { "Jofra Archer", "The_Archer_Bow" }, { "Mark Wood", "Horse_Gallop_Run" },
        { "Ben Stokes", "Legend_Finger_Sky" }, { "Jonny Bairstow", "The_Yorkshire_Roar" },

        // --- WEST INDIES ---
        { "Nicholas Pooran", "Trini_Swag_Point" }, { "Andre Russell", "Dre_Russ_Dance" },
        { "Sunil Narine", "No_Expression_Style" }, { "Rovman Powell", "Caribbean_Muscle" },
        { "Shimron Hetmyer", "Hair_Style_Point" }, { "Alzarri Joseph", "Antigua_Express_Stare" },
        { "Gudakesh Motie", "Spin_Wizard_Wave" }, { "Shai Hope", "Classical_Grace_Raise" },

        // --- NEW ZEALAND ---
        { "Kane Williamson", "Gentleman_Nod" }, { "Rachin Ravindra", "The_New_Gen_Prince" },
        { "Daryl Mitchell", "Team_Man_Hustle" }, { "Trent Boult", "Flamingo_Stance" },
        { "Mitchell Santner", "Cool_Glasses_Look" }, { "Glenn Phillips", "Gymnast_Jump" },
        { "Tim Southee", "Experienced_Point" }, { "Lockie Ferguson", "Mustache_Twirl" },

        // --- PAKISTAN ---
        { "Babar Azam", "Cover_Drive_King_Raise" }, { "Shaheen Afridi", "Arms_Wide_Eagle" },
        { "Mohammad Rizwan", "Prayer_Celebration" }, { "Naseem Shah", "Aggressive_Teen_Roar" },
        { "Shadab Khan", "AllRounder_Style" }, { "Haris Rauf", "Tearaway_Pace_Point" },

        // --- AFGHANISTAN ---
        { "Rashid Khan", "Airplane_Mode_Spin" }, { "Rahmanullah Gurbaz", "Afghan_Lion_Roar" },
        { "Mohammad Nabi", "The_President_Salute" }, { "Fazalhaq Farooqi", "The_Swinging_Afghan" },
        { "Naveen-ul-Haq", "Ears_Covered_Style" },

        // --- SRI LANKA ---
        { "Wanindu Hasaranga", "Neymar_Style_Mask" }, { "Pathum Nissanka", "Graceful_Strokeplay" },
        { "Matheesha Pathirana", "Malinga_Junior_Point" }, { "Maheesh Theekshana", "Mystery_Point" },
        { "Charith Asalanka", "Captain_Leading_Front" },

        // --- OTHERS (GLOBAL STARS / MINNOWS) ---
        { "Sikandar Raza", "Zimbabwe_Pride_Point" }, { "Paul Stirling", "Irish_Power_Clap" },
        { "Brandon McMullen", "Scotland_Rising_Star" }, { "Marco Erasmus", "Italy_Pro_Pride" },
        { "Monank Patel", "USA_Captain_Style" }, { "Aaron Jones", "The_Six_Hitter_USA" },
        { "Sandeep Lamichhane", "Nepal_Spin_Magic" }, { "Bas de Leede", "Dutch_Fighting_Spirit" }
    };

    public void StartCelebration(string name) {
        if (top100Styles.ContainsKey(name)) {
            Debug.Log("Cric-Ultra 26: Playing Signature Animation: " + top100Styles[name]);
        } else {
            Debug.Log("Playing: Standard_Professional_Celebration");
        }
    }
}
