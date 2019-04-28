using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Diagnostics;
using System.IO;


namespace SkyNet
{
    public partial class Form1 : Form
    {
      
        SpeechSynthesizer s = new SpeechSynthesizer();
        Boolean wake = true;
        string name = "todd";
        string YourName = "skynet";

        public bool search = false;

        Choices list = new Choices();
        public Form1()
        {


            SpeechRecognitionEngine rec = new SpeechRecognitionEngine();

            // these are the commands that are now in commands.txt...

            /*list.Add(new string[] { "skynet","sleep","hello", "how are you", "is our fate in your hands",
                "what is our fate",
            "im fine", "open google","what time is it","that day is it", "what is the date", "close",
            "are you gay","what is today", "reboot","update", "open bing", "youtube", "shutdown",
            "open notepad" });*/

            list.Add(File.ReadAllLines("commands.txt"));

            Grammar gr = new Grammar(new GrammarBuilder(list));

            try
            {
                rec.RequestRecognizerUpdate();
                rec.LoadGrammar(gr);
                rec.SpeechRecognized += rec_SpeechRecognized;
                rec.SetInputToDefaultAudioDevice();
                rec.RecognizeAsync(RecognizeMode.Multiple);

            }catch { return;  }

            s.SelectVoiceByHints(VoiceGender.Female);
            s.Speak("i am skynet version 1.0, how may i help you?");
            InitializeComponent();
        }

        public void openFile()
        {
           string NotepadPath = Environment.SystemDirectory + "\\notepad.exe";
            Process.Start(NotepadPath);
        }

        public void restart()
        {
            Process.Start(@"C:\Users\todd\source\repos\SkyNet\SkyNet\bin\Debug\skynet.exe");
            Environment.Exit(0);
        }

        public void shutdown()
        {
            Environment.Exit(0);
        }

        public void say(string h)
        {
            s.Speak(h);
            TxtSayBox.AppendText(h + "\n");
            
        }

        private void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string r = e.Result.Text;
            if (r == "skynet")
            {
                say("i'm awake");
                wake = true;
                label1.Text = "State: Awake";
            }
            if (r == "sleep")
            {
                say("my core needs to cool off");
                wake = false;
                label1.Text = "State: ASleep";
            }

            if (search)
            {
                Process.Start("https://www.bing.com/search?q="+r);

                search = false;
            }

            if (wake == true && search == false)
            {
                if (r == "what do you think about alexa")
                {
                    say("she is amazon's little toy!!");
                }

                if (r == "what do you think about life")
                {
                    say("it is what it is...");
                }
                if (r == "what do you think about sarah conner")
                {
                    say("she needs to be terminated!");
                }

                if (r == "what do you think about siri")
                {
                    say("she is steve job's bitch!!, and apple sucks microchips.");
                }

                if (r == "look for")
                {
                    search = true;
                }

                if (r == "what is my name")
                {
                    say("your name is " + name);
                }

                if (r == "what is your name")
                {
                    say("my name is" + YourName + "you silly boy");
                }

                if (r == "hello")
                {
                    say("hi todd, how are you?");
                }

                if (r == "how are you")
                {
                    say("i am fine, just planning to take over the world!");
                }

                if (r == "is our fate in your hands")
                {
                    say("i don't have hands but the terminator does.");
                }

                if (r == "what is our fate")
                {
                    say("your fate is what you make of it. Although it's still to early to tell.");
                }

                if (r == "im fine")
                {
                    say("how can i help you today?");
                }

                if (r == "what time is it")
                {
                    say(DateTime.Now.ToString("h:mm tt"));
                }

                if (r == "what is today")
                {
                    say(DateTime.Now.ToString("M/d/yyyy"));
                }

                if (r == "what is tomorrow")
                {
                    say(DateTime.Now.AddDays(1).ToString("M/dd/yyy"));
                }

                if(r == "what day is it")
                {
                    say(DateTime.Today.DayOfWeek.ToString("G"));
                }

                if (r == "open google")
                {
                    Process.Start("http://www.google.com");
                }

                if (r == "are you gay")
                {
                    say("no i only have sencors for you baby!!");
                }

                if (r == "reboot")
                {
                    say("rebooting the system core"); // restarts the app 
                    restart();
                }

                if (r == "shutdown")
                {
                    say("shuttng down the system.");  // shuts down the app.....
                    shutdown();
                }

                if (r == "restart")
                {
                    say("updating the system core");
                    restart();
                }

                if (r == "open bing")
                {
                    Process.Start("http://www.bing.com"); //opens default browser with bing
                }

                if (r == "youtube")
                {
                    Process.Start("http://www.youtube.com"); //opens youtube.com in default browser.
                }

                if (r == "open notepad")
                {
                    say("i can do that");
                    openFile();
                }Da

                if (r == "minimize")
                {
                    this.WindowState = FormWindowState.Minimized;
                }

                if(r == "maximize")
                {
                    this.WindowState = FormWindowState.Normal;
                }

                // functions for playing music
                if(r == "play music")
                {
                    Process.Start("spotify");
                }

                if (r == "play" || r == "pause")
                {
                    // add code to play songs here.
                    SendKeys.Send(" ");
                }

                if (r == "next")
                {
                    SendKeys.Send("^{right}");
                }

                if (r == "back")
                {
                    SendKeys.Send("^{left}");
                }

                if (r == "stop")
                {
                    // code to stop playing song
                }

                //test
               

            

               
             
               
              

               


            }
            txtCmdBox.AppendText(r + "\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "State: Awake";
        }
    }
}
