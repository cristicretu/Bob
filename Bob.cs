using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Diagnostics;

namespace C_SpeechRecognition
{
    public partial class Bob : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer spSynth = new SpeechSynthesizer();
        public Bob()
        {
            InitializeComponent();
        }

        const int MAX = 26;

        String[] l = {"Where does the General keep his armies? In his sleevies.",
                      "How does a squid go into battle? Well-armored.",
                    "What's the best thing about Switzerland? I don't know, but their flag is a huge plus.",
                    "Where do you find a cow with no legs? Right where you left it.",
                    "What's E.T. short for? Because he's only got little legs.",
                    "What do you call a Frenchman wearing sandals? Phillipe Phillope.",
                    "Never criticize someone until you have walked a mile in their shoes. That way, when you criticize them, you'll be a mile away, and you'll have their shoes.",
                    "Two men meet on opposite sides of a river.  One shouts to the other, I need you to help me get to the other side! The other guy replies, You're on the other side!",
                    "What's the difference between a hippo and a zippo? One is really heavy, and the other is a little lighter.",
                    "What do Alexander the Great and Winnie the Pooh have in common? Same middle name.",
                    "What did the mayonnaise say when the refrigerator door was opened? Close the door, I'm dressing.",
                    "I stand corrected! Said the man in the orthopedic shoes.",
                    "I used to be addicted to soap. But I'm clean now.",
                    "What did the left eye say to the right eye? Between you and me, something smells.",
                    "Why is England the wettest country? Because the queen has reigned there for years.",
                    "It's hard to explain puns to kleptomaniacs. They always take things so literally.",
                    "What do you call it when Batman skips church? Christian Bale.",
                    "A guy goes to a pet store to buy a goldfish. The salesman asks him, Do you want an aquarium? The guy responds, I don't care what star sign it is!",
                    "What do you call bears with no ears? B–",
                    "What's a foot long and slippery? A slipper.",
                    "I want to die peacefully in my sleep like my grandfather did. Not screaming in terror like the passengers in his car.",
                    "They all laughed when I said I wanted to be a comedian. Well, they're not laughing now!",
                    "Two cows are grazing in a field. One cow says to the other, You ever worry about that mad cow disease? The other cow says, Why would I care? I'm a helicopter!",
                    "I told my physical therapist that I broke my arm in two places. He told me to stop going to those places.",
                    "What did the swordfish say to the marlin? You're looking sharp.",
                    "How do you make holy water? You boil the hell out of it.",
                    };

        private int randomNumber(int min, int max)
        {
            var rand = new Random();
            return rand.Next(min, max);
        }
        string usr = PoliHack_App_Esentza.Meniu.get_user();
        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {


            switch (e.Result.Text)
            {
                case "Are you a real human":

                    spSynth.SpeakAsync("Maybe");
                    break;
                case "Do you speak romanian":
                    spSynth.SpeakAsync("Not for now. Maybe with the next update.");
                    break;
                case "Good afternoon!":
                    spSynth.SpeakAsync("Good afternoon, " + usr);
                    break;
                case "Good evening":
                    spSynth.SpeakAsync("Good evening, " + usr);
                    break;
                case "Good morning":
                    spSynth.SpeakAsync("Good morning, " + usr);
                    break;
                case "Good night":
                    spSynth.SpeakAsync("Good night and sweet dreams, " + usr);
                    break;
                case "Goodbye":
                    spSynth.SpeakAsync("See you next time");
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    while (true)
                    {
                        if (stopwatch.ElapsedMilliseconds >= 3000)
                            break;
                    }
                    Application.Exit();
                    break;
                case "Hello, Bob":
                    spSynth.SpeakAsync("Hello, " + usr + " how are you?");
                    break;
                case "How many hours did i use my PC":
                    int ticks = PoliHack_App_Esentza.Meniu.get_counts();
                    int h = ticks / 3600, minutes = (ticks % 3600) / 60;
                    spSynth.SpeakAsync("You used your PC for " + h.ToString() + " hours ");
                    if (minutes != 0)
                        spSynth.SpeakAsync("and " + minutes.ToString() + " minutes");
                    break;
                case "How old are you":
                    spSynth.SpeakAsync("One version old");
                    break;
                case "I'm exhausted":
                    spSynth.SpeakAsync("You should take a break. Go to sleep!");
                    break;
                case "I tested positive for COVID 19":
                    spSynth.SpeakAsync("Don't worry everything will be ok, I'm here to help");
                    break;
                case "I think I have COVID 19":
                    spSynth.SpeakAsync("Trouble breathing, persistent pain or preassure in chest, confusion, headache, fever, lost of taste and smell are the most common symptoms. Do you have any of them?");
                    break;
                case "See you tomorrow":
                    spSynth.SpeakAsync("I'll miss you");
                    stopwatch = Stopwatch.StartNew();
                    while (true)
                    {
                        if (stopwatch.ElapsedMilliseconds >= 3000)
                            break;
                    }
                    Application.Exit();
                    break;
                case "Tell me a joke":
                    var rand = new Random();
                    spSynth.SpeakAsync(l[randomNumber(0, 25)]);
                    break;
                case "Thank you":
                    spSynth.SpeakAsync("I'm here everytime to help you, " + usr);
                    break;
                case "What's the time":
                    spSynth.SpeakAsync("It's " + DateTime.Now.ToString("H:mm:ss"));
                    break;
                case "What's your IQ":
                    spSynth.SpeakAsync(Int32.MaxValue.ToString());
                    break;
                case "What are the symptoms of COVID 19":
                    spSynth.SpeakAsync("Trouble breathing, persistent pain or preassure in chest, confusion, headache, fever, lost of taste and smell are the most common symptoms");
                    break;
                case "What day is today":
                    spSynth.SpeakAsync("It's " + DateTime.Now.ToString("D"));
                    break;
                case "What do you do with my data":
                    spSynth.SpeakAsync("Nothing");
                    break;
                case "Where do you live":
                    spSynth.SpeakAsync("In the cloud");
                    break;
                case "Who made you":
                    spSynth.SpeakAsync("Team Esentza");
                    break;
                case "You're useless":
                    spSynth.SpeakAsync("I'm sorry");
                    break;
                case "You’re annoying":
                    spSynth.SpeakAsync("I'm trying my best");
                    break;
                case "You’re boring":
                    spSynth.SpeakAsync("SAME AS YOU");
                    break;

            }
        }

        private void Bob_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "Are you a real human",
                                        "Do you speak romanian",
                                        "Good afternoon",
                                        "Good evening",
                                        "Good morning",
                                        "Good night",
                                        "Goodbye",
                                        "Hello, Bob",
                                        "How many hours did i use my PC",
                                        "How old are you",
                                        "I'm exhausted",
                                        "I tested positive for COVID 19",
                                        "I think I have COVID 19",
                                        "See you tomorrow",
                                        "Tell me a joke",
                                        "Thank you",
                                        "What's the time",
                                        "What's your IQ",
                                        "What are the symptoms of COVID 19",
                                        "What day is today",
                                        "What do you do with my data",
                                        "Where do you live",
                                        "Who made you",
                                        "You're useless",
                                        "You’re annoying",
                                        "You’re boring", });
            GrammarBuilder gr_build = new GrammarBuilder();
            gr_build.Append(commands);
            Grammar _grammar = new Grammar(gr_build);

            recEngine.LoadGrammarAsync(_grammar);
            recEngine.SetInputToDefaultAudioDevice();

            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
        }

        private void EnableMicrophone_Click(object sender, EventArgs e)
        {
            if (DisableMicrophone.Enabled == false)
            {
                DisableMicrophone.Enabled = true;
                recEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "Are you a real human?";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: Maybe";
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("Maybe");
                    break;
                case 1:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "Do you speak romanian";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: Not for now. Maybe with the next update.";
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("Not for now. Maybe with the next update.");
                    break;
                case 2:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "Good afternoon!";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: " + "Good afternoon, " + usr;
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("Good afternoon, " + usr);
                    break;
                case 3:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "Good evening!";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: " + "Good evening, " + usr;
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("Good evening, " + usr);
                    break;
                case 4:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "Good morning";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: " + "Good morning, " + usr;
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("Good morning, " + usr);
                    break;
                case 5:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "Good night";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: Good night and sweet dreams, " + usr;
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("Good night and sweet dreams, " + usr);
                    break;
                case 6:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "Goodbye!";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: " + "See you next time" + usr;
                    richTextBox1.Text += "\n";

                    spSynth.SpeakAsync("See you next time");
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    while (true)
                    {
                        if (stopwatch.ElapsedMilliseconds >= 3000)
                            break;
                    }
                    Application.Exit();
                    break;
                case 7:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "Hello, Bob!";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: Hello, " + usr + " how are you?";
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("Hello, " + usr + " how are you?");
                    break;
                case 8:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "How many hours did I use my PC?\n";
                    int ticks = PoliHack_App_Esentza.Meniu.get_counts();
                    int h = ticks / 3600, minutes = (ticks % 3600) / 60;
                    string s = "You used your PC for ";
                    bool ok = false;
                    if (h != 0)
                    {
                        ok = true;
                        s += h.ToString() + " hours ";
                        if (minutes != 0)
                            s += "and ";
                    }
                    if (minutes != 0)

                    {
                        ok = true; 
                        s += minutes.ToString() + " minutes";
                    }
                    if (ok == false)
                        s = "You just started your PC";
                    s += '\n';
                    string a = "Bob: " + s;
                    richTextBox1.Text += a;

                    spSynth.SpeakAsync(s);
                    break;
                case 9:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "How old are you";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: One version old\n";
                    spSynth.SpeakAsync("One version old");
                    break;

                case 10:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "I'm exhausted";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: You should take a break. Go to sleep!";
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("You should take a break. Go to sleep!");
                    break;
                case 11:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "I tested positive for COVID 19";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: Don't worry everything will be ok, I'm here to help";
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("Don't worry everything will be ok, I'm here to help");
                    break;
                case 12:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "I think I have COVID 19";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: Trouble breathing, persistent pain or preassure in chest, confusion, headache, fever, lost of taste and smell are the most common symptoms of COVID 19. Do you have any of them?";
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("Trouble breathing, persistent pain or preassure in chest, confusion, headache, fever, lost of taste and smell are the most common symptoms of COVID 19. Do you have any of them?");
                    break;
                case 13:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "See you tomorrow";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: I'll miss you";
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("I'll miss you");
                    stopwatch = Stopwatch.StartNew();
                    while (true)
                    {
                        if (stopwatch.ElapsedMilliseconds >= 3000)
                            break;
                    }
                    Application.Exit();
                    break;
                case 14:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "Tell me a joke";
                    richTextBox1.Text += "\n";
                    int ind = randomNumber(0, 25);
                    richTextBox1.Text += "Bob: " + l[ind];
                    richTextBox1.Text += "\n";
                    var rand = new Random();
                    spSynth.SpeakAsync(l[ind]);
                    break;
                case 15:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "Thank you";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: I'm here everytime to help you, " + usr; 
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("I'm here everytime to help you, " + usr);
                    break;
                case 16:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "What's the time?";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: It's " + DateTime.Now.ToString("H:mm:ss");
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("It's " + DateTime.Now.ToString("H:mm:ss"));
                    break;
                case 17:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "What's your IQ?";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: " + Int32.MaxValue.ToString() + " for cunoscatori";
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync(Int32.MaxValue.ToString() + " for cunoscatori");
                    break;

                case 18:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "What are the symptoms of COVID 19?";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: Trouble breathing, persistent pain or preassure in chest, confusion, headache are the most common symptoms.";
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("Trouble breathing, persistent pain or preassure in chest, confusion, headache are the most common symptoms.");
                    break;

                case 19:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "What day is today?";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: It's " + DateTime.Now.ToString("D");
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("It's " + DateTime.Now.ToString("D"));
                    break;

                case 20:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "What do you do with my data?";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: Nothing";
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("Nothing");
                    break;

                case 21:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "Where do you live?";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: In the cloud";
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("In the cloud");
                    break;



                case 22:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "Who made you?";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: Team Esentza";
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("Team Esentza");
                    break;
                case 23:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "You're useless";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: I'm sorry";
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("I'm sorry");
                    break;
                case 24:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "You’re annoying";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: I'm trying my best";
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("I'm trying my best");
                    break;
                case 25:
                    richTextBox1.Text += usr + ": ";
                    richTextBox1.Text += "You're boring";
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Bob: SAME AS YOU";
                    richTextBox1.Text += "\n";
                    spSynth.SpeakAsync("SAME AS YOU");
                    break;
            }
        }
        private void Bobita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisableMicrophone_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            DisableMicrophone.Enabled = false;
        }
    }
}
