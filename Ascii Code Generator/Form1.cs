using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Ascii_Code_Generator
{
    public partial class Form1 : Form
    {
        private List<String> bigFontList;
        private List<String> starWarsFontList;
        private List<String> smallFontList;
        private List<String> charactersList;
        private List<String> oneCharacterList;

        private string filePath = @"C:\Ascii\file.txt";
        private string dirPath = @"C:\Ascii";

        private string[] alphabets = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        private char[] alphabetsChars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

        public Form1 ()
        {
            InitializeComponent();

            DirectoryInfo di = Directory.CreateDirectory( dirPath );

            //TextWriter t = new StreamWriter( filePath, true );

            //File.Create( filePath );

            File.WriteAllText( filePath, "" );

            bigFontList = new List<String>();
            charactersList = new List<String>();
            oneCharacterList = new List<String>();
            smallFontList = new List<String>();
            starWarsFontList = new List<String>();

            popoulateBigFontList();
            populateSmallFontList();
            populateStarWarsFontList();
        }

        private String getBigCharacterFromIndex ( int index )
        {
            if ( index > 25 ) {
                return "nothing found";
            }
            String line = "";
            int start = index * 11;
            int end = start + 11;
            for ( int i = start; i < end; i++ ) {
                line += bigFontList[ i ] + bigFontList[ i + 11 ] + bigFontList[ i + 22 ] + Environment.NewLine;
            }

            return line;
        }

        private String getBigCharacterFromIndex ( List<int> args )
        {
            String allLines = "";
            List<String> chars = new List<String>();

            List<List<String>> combineList = new List<List<String>>();

            for ( int i = 0; i < 11; i++ ) {
                //Console.Write( "cout << \"" );
                foreach ( var index in args ) {
                    int start = index * 11;
                    int end = start + 11;
                    Console.Write( bigFontList[ start + i ] );
                    File.AppendAllText( filePath, bigFontList[ start + i ] );
                }
                Console.WriteLine();
                File.AppendAllText( filePath, Environment.NewLine );
            }

            Console.WriteLine();
            File.AppendAllText( filePath, Environment.NewLine );

            string[] lines = File.ReadAllLines( filePath );

            List<string> codeLines = new List<string>();

            foreach ( var item in lines ) {
                Console.Write( "cout << \"" );
                Console.Write( item );
                Console.WriteLine( "\"" );
                string newLine = "cout << \"" + item + "\"<<endl;";
                newLine = newLine.Replace( "\\", "\\\\" );
                codeLines.Add( newLine );
            }

            File.WriteAllLines( filePath, codeLines );

            return allLines;
        }

        private String getStarWarsCharacterFromIndex ( List<int> args )
        {
            

            String allLines = "";
            List<String> chars = new List<String>();

            //List<List<String>> combineList = new List<List<String>>();

            for ( int i = 0; i < 6; i++ ) {
                //Console.Write( "cout << \"" );
                foreach ( var index in args ) {
                    int start = index * 6;
                    int end = start + 6;
                    Console.Write( starWarsFontList[ start + i ] );
                    File.AppendAllText( filePath, starWarsFontList[ start + i ] );
                }
                Console.WriteLine();
                File.AppendAllText( filePath, Environment.NewLine );
            }

            Console.WriteLine();
            File.AppendAllText( filePath, Environment.NewLine );

            string[] lines = File.ReadAllLines( filePath );

            List<string> codeLines = new List<string>();

            foreach ( var item in lines ) {
                Console.Write( "cout << \"" );
                Console.Write( item );
                Console.WriteLine( "\"" );
                string newLine = "cout << \"" + item + "\"<<endl;";
                newLine = newLine.Replace( "\\", "\\\\" );
                codeLines.Add( newLine );
            }

            File.WriteAllLines( filePath, codeLines );

            return allLines;
        }

        private String getSmallCharacterFromIndex ( int index )
        {
            if ( index > 25 ) {
                return "nothing found";
            }
            String line = "";
            int start = index * 5;
            int end = start + 5;
            for ( int i = start; i < end; i++ ) {
                line += smallFontList[ i ] + smallFontList[ i + 5 ] + smallFontList[ i + 10 ] + Environment.NewLine;
            }

            return line;
        }

        private String getSmallCharacterFromIndex ( int[] args )
        {
            String line = "";
            foreach ( var index in args ) {
                if ( index > 25 ) {
                    return "nothing found";
                }
                int start = index * 5;
                int end = start + 5;
                for ( int i = start; i < end; i++ ) {
                    line += smallFontList[ i ];
                    line += Environment.NewLine;
                }
            }

            return line;
        }

        private void populateStarWarsFontList ()
        {
            starWarsFontList.Add( @"     ___     " );
            starWarsFontList.Add( @"    /   \    " );
            starWarsFontList.Add( @"   /  ^  \   " );
            starWarsFontList.Add( @"  /  /_\  \  " );
            starWarsFontList.Add( @" /  _____  \ " );
            starWarsFontList.Add( @"/__/     \__\" );
            starWarsFontList.Add( @".______  " );
            starWarsFontList.Add( @"|   _  \ " );
            starWarsFontList.Add( @"|  |_)  |" );
            starWarsFontList.Add( @"|   _  < " );
            starWarsFontList.Add( @"|  |_)  |" );
            starWarsFontList.Add( @"|______/ " );
            starWarsFontList.Add( @"  ______ " );
            starWarsFontList.Add( @" /      |" );
            starWarsFontList.Add( @"|  ,----'" );
            starWarsFontList.Add( @"|  |     " );
            starWarsFontList.Add( @"|  `----." );
            starWarsFontList.Add( @" \______|" );
            starWarsFontList.Add( @" _______  " );
            starWarsFontList.Add( @"|       \ " );
            starWarsFontList.Add( @"|  .--.  |" );
            starWarsFontList.Add( @"|  |  |  |" );
            starWarsFontList.Add( @"|  '--'  |" );
            starWarsFontList.Add( @"|_______/ " );
            starWarsFontList.Add( @" _______ " );
            starWarsFontList.Add( @"|   ____|" );
            starWarsFontList.Add( @"|  |__   " );
            starWarsFontList.Add( @"|   __|  " );
            starWarsFontList.Add( @"|  |____ " );
            starWarsFontList.Add( @"|_______|" );
            starWarsFontList.Add( @" _______ " );
            starWarsFontList.Add( @"|   ____|" );
            starWarsFontList.Add( @"|  |__   " );
            starWarsFontList.Add( @"|   __|  " );
            starWarsFontList.Add( @"|  |     " );
            starWarsFontList.Add( @"|__|     " );
            starWarsFontList.Add( @"  _______ " );
            starWarsFontList.Add( @" /  _____|" );
            starWarsFontList.Add( @"|  |  __  " );
            starWarsFontList.Add( @"|  | |_ | " );
            starWarsFontList.Add( @"|  |__| | " );
            starWarsFontList.Add( @" \______| " );
            starWarsFontList.Add( @" __    __ " );
            starWarsFontList.Add( @"|  |  |  |" );
            starWarsFontList.Add( @"|  |__|  | " );
            starWarsFontList.Add( @"|   __   |" );
            starWarsFontList.Add( @"|  |  |  |" );
            starWarsFontList.Add( @"|__|  |__|" );
            starWarsFontList.Add( @" __ " );
            starWarsFontList.Add( @"|  |" );
            starWarsFontList.Add( @"|  |" );
            starWarsFontList.Add( @"|  |" );
            starWarsFontList.Add( @"|  |" );
            starWarsFontList.Add( @"|__|" );
            starWarsFontList.Add( @"       __ " );
            starWarsFontList.Add( @"      |  |" );
            starWarsFontList.Add( @"      |  |" );
            starWarsFontList.Add( @".--.  |  |" );
            starWarsFontList.Add( @"|  `--'  |" );
            starWarsFontList.Add( @" \______/ " );
            starWarsFontList.Add( @" __  ___ " );
            starWarsFontList.Add( @"|  |/  / " );
            starWarsFontList.Add( @"|  '  /  " );
            starWarsFontList.Add( @"|    <   " );
            starWarsFontList.Add( @"|  .  \  " );
            starWarsFontList.Add( @"|__|\__\ " );
            starWarsFontList.Add( @" __      " );
            starWarsFontList.Add( @"|  |     " );
            starWarsFontList.Add( @"|  |     " );
            starWarsFontList.Add( @"|  |     " );
            starWarsFontList.Add( @"|  `----." );
            starWarsFontList.Add( @"|_______|" );
            starWarsFontList.Add( @".___  ___." );
            starWarsFontList.Add( @"|   \/   |" );
            starWarsFontList.Add( @"|  \  /  |" );
            starWarsFontList.Add( @"|  |\/|  |" );
            starWarsFontList.Add( @"|  |  |  |" );
            starWarsFontList.Add( @"|__|  |__|" );
            starWarsFontList.Add( @".__   __." );
            starWarsFontList.Add( @"|  \ |  |" );
            starWarsFontList.Add( @"|   \|  |" );
            starWarsFontList.Add( @"|  . `  |" );
            starWarsFontList.Add( @"|  |\   |" );
            starWarsFontList.Add( @"|__| \__|" );
            starWarsFontList.Add( @"  ______  " );
            starWarsFontList.Add( @" /  __  \ " );
            starWarsFontList.Add( @"|  |  |  |" );
            starWarsFontList.Add( @"|  |  |  |" );
            starWarsFontList.Add( @"|  `--'  |" );
            starWarsFontList.Add( @" \______/ " );
            starWarsFontList.Add( @".______  " );
            starWarsFontList.Add( @"|   _  \ " );
            starWarsFontList.Add( @"|  |_)  |" );
            starWarsFontList.Add( @"|   ___/ " );
            starWarsFontList.Add( @"|  |     " );
            starWarsFontList.Add( @"| _|     " );
            starWarsFontList.Add( @"  ______      " );
            starWarsFontList.Add( @" /  __  \    " );
            starWarsFontList.Add( @"|  |  |  |   " );
            starWarsFontList.Add( @"|  |  |  |   " );
            starWarsFontList.Add( @"|  `--'  '--." );
            starWarsFontList.Add( @" \_____\_____\" );
            starWarsFontList.Add( @".______      " );
            starWarsFontList.Add( @"|   _  \     " );
            starWarsFontList.Add( @"|  |_)  |    " );
            starWarsFontList.Add( @"|      /     " );
            starWarsFontList.Add( @"|  |\  \----." );
            starWarsFontList.Add( @"| _| `._____|" );
            starWarsFontList.Add( @"     _______." );
            starWarsFontList.Add( @"    /       |" );
            starWarsFontList.Add( @"   |   (----`" );
            starWarsFontList.Add( @"    \   \    " );
            starWarsFontList.Add( @".----)   |   " );
            starWarsFontList.Add( @"|_______/    " );
            starWarsFontList.Add( @".___________." );
            starWarsFontList.Add( @"|           |" );
            starWarsFontList.Add( @"`---|  |----`" );
            starWarsFontList.Add( @"    |  |     " );
            starWarsFontList.Add( @"    |  |     " );
            starWarsFontList.Add( @"    |__|     " );
            starWarsFontList.Add( @" __    __    " );
            starWarsFontList.Add( @"|  |  |  |" );
            starWarsFontList.Add( @"|  |  |  |" );
            starWarsFontList.Add( @"|  |  |  |" );
            starWarsFontList.Add( @"|  `--'  |" );
            starWarsFontList.Add( @" \______/ " );
            starWarsFontList.Add( @"____    ____" );
            starWarsFontList.Add( @"\   \  /   /" );
            starWarsFontList.Add( @" \   \/   / " );
            starWarsFontList.Add( @"  \      /  " );
            starWarsFontList.Add( @"   \    /   " );
            starWarsFontList.Add( @"    \__/    " );
            starWarsFontList.Add( @"____    __    ____ " );
            starWarsFontList.Add( @"\   \  /  \  /   / " );
            starWarsFontList.Add( @" \   \/    \/   /  " );
            starWarsFontList.Add( @"  \            /   " );
            starWarsFontList.Add( @"   \    /\    /    " );
            starWarsFontList.Add( @"    \__/  \__/     " );
            starWarsFontList.Add( @"___   ___          " );
            starWarsFontList.Add( @"\  \ /  / " );
            starWarsFontList.Add( @" \  V  /  " );
            starWarsFontList.Add( @"  >   <   " );
            starWarsFontList.Add( @" /  .  \  " );
            starWarsFontList.Add( @"/__/ \__\ " );
            starWarsFontList.Add( @"____    ____" );
            starWarsFontList.Add( @"\   \  /   /" );
            starWarsFontList.Add( @" \   \/   / " );
            starWarsFontList.Add( @"  \_    _/  " );
            starWarsFontList.Add( @"    |  |    " );
            starWarsFontList.Add( @"    |__|    " );
            starWarsFontList.Add( @" ________  " );
            starWarsFontList.Add( @"|       /  " );
            starWarsFontList.Add( @"`---/  /   " );
            starWarsFontList.Add( @"   /  /    " );
            starWarsFontList.Add( @"  /  /----." );
            starWarsFontList.Add( @" /________|" );

            starWarsFontList.Add( @"     " );
            starWarsFontList.Add( @"     " );
            starWarsFontList.Add( @"     " );
            starWarsFontList.Add( @"     " );
            starWarsFontList.Add( @"     " );
            starWarsFontList.Add( @"     " );

            starWarsFontList.Add( @" __    " );
            starWarsFontList.Add( @"/_ |   " );
            starWarsFontList.Add( @" | |   " );
            starWarsFontList.Add( @" | |   " );
            starWarsFontList.Add( @" | |   " );
            starWarsFontList.Add( @" |_|   " );
            starWarsFontList.Add( @" ___     " );
            starWarsFontList.Add( @"|__ \    " );
            starWarsFontList.Add( @"   ) |   " );
            starWarsFontList.Add( @"  / /    " );
            starWarsFontList.Add( @" / /_    " );
            starWarsFontList.Add( @"|____|   " );
            starWarsFontList.Add( @" ____    " );
            starWarsFontList.Add( @"|___ \   " );
            starWarsFontList.Add( @"  __) |  " );
            starWarsFontList.Add( @" |__ <   " );
            starWarsFontList.Add( @" ___) |  " );
            starWarsFontList.Add( @"|____/   " );
            starWarsFontList.Add( @" _  _    " );
            starWarsFontList.Add( @"| || |   " );
            starWarsFontList.Add( @"| || |_  " );
            starWarsFontList.Add( @"|__   _| " );
            starWarsFontList.Add( @"   | |   " );
            starWarsFontList.Add( @"   |_|   " );
            starWarsFontList.Add( @" _____   " );
            starWarsFontList.Add( @"| ____|  " );
            starWarsFontList.Add( @"| |__    " );
            starWarsFontList.Add( @"|___ \   " );
            starWarsFontList.Add( @" ___) |  " );
            starWarsFontList.Add( @"|____/   " );
            starWarsFontList.Add( @"   __    " );
            starWarsFontList.Add( @"  / /    " );
            starWarsFontList.Add( @" / /_    " );
            starWarsFontList.Add( @"| '_ \   " );
            starWarsFontList.Add( @"| (_) |  " );
            starWarsFontList.Add( @" \___/   " );
            starWarsFontList.Add( @" ______  " );
            starWarsFontList.Add( @"|____  | " );
            starWarsFontList.Add( @"    / /  " );
            starWarsFontList.Add( @"   / /   " );
            starWarsFontList.Add( @"  / /    " );
            starWarsFontList.Add( @" /_/     " );
            starWarsFontList.Add( @"  ___    " );
            starWarsFontList.Add( @" / _ \   " );
            starWarsFontList.Add( @"| (_) |  " );
            starWarsFontList.Add( @" > _ <   " );
            starWarsFontList.Add( @"| (_) |  " );
            starWarsFontList.Add( @" \___/   " );
            starWarsFontList.Add( @"  ___    " );
            starWarsFontList.Add( @" / _ \   " );
            starWarsFontList.Add( @"| (_) |  " );
            starWarsFontList.Add( @" \__, |  " );
            starWarsFontList.Add( @"   / /   " );
            starWarsFontList.Add( @"  /_/    " );
            starWarsFontList.Add( @"  ___    " );
            starWarsFontList.Add( @" / _ \   " );
            starWarsFontList.Add( @"| | | |  " );
            starWarsFontList.Add( @"| | | |  " );
            starWarsFontList.Add( @"| |_| |  " );
            starWarsFontList.Add( @" \___/   " );
        }

        private void popoulateBigFontList ()
        {
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |      __      | |" );
            bigFontList.Add( @"| |     /  \     | |" );
            bigFontList.Add( @"| |    / /\ \    | |" );
            bigFontList.Add( @"| |   / ____ \   | |" );
            bigFontList.Add( @"| | _/ /    \ \_ | |" );
            bigFontList.Add( @"| ||____|  |____|| |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |   ______     | |" );
            bigFontList.Add( @"| |  |_   _ \    | |" );
            bigFontList.Add( @"| |    | |_) |   | |" );
            bigFontList.Add( @"| |    |  __'.   | |" );
            bigFontList.Add( @"| |   _| |__) |  | |" );
            bigFontList.Add( @"| |  |_______/   | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |     ______   | |" );
            bigFontList.Add( @"| |   .' ___  |  | |" );
            bigFontList.Add( @"| |  / .'   \_|  | |" );
            bigFontList.Add( @"| |  | |         | |" );
            bigFontList.Add( @"| |  \ `.___.'\  | |" );
            bigFontList.Add( @"| |   `._____.'  | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |  ________    | |" );
            bigFontList.Add( @"| | |_   ___ `.  | |" );
            bigFontList.Add( @"| |   | |   `. \ | |" );
            bigFontList.Add( @"| |   | |    | | | |" );
            bigFontList.Add( @"| |  _| |___.' / | |" );
            bigFontList.Add( @"| | |________.'  | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |  _________   | |" );
            bigFontList.Add( @"| | |_   ___  |  | |" );
            bigFontList.Add( @"| |   | |_  \_|  | |" );
            bigFontList.Add( @"| |   |  _|  _   | |" );
            bigFontList.Add( @"| |  _| |___/ |  | |" );
            bigFontList.Add( @"| | |_________|  | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |  _________   | |" );
            bigFontList.Add( @"| | |_   ___  |  | |" );
            bigFontList.Add( @"| |   | |_  \_|  | |" );
            bigFontList.Add( @"| |   |  _|      | |" );
            bigFontList.Add( @"| |  _| |_       | |" );
            bigFontList.Add( @"| | |_____|      | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |    ______    | |" );
            bigFontList.Add( @"| |  .' ___  |   | |" );
            bigFontList.Add( @"| | / .'   \_|   | |" );
            bigFontList.Add( @"| | | |    ____  | |" );
            bigFontList.Add( @"| | \ `.___]  _| | |" );
            bigFontList.Add( @"| |  `._____.'   | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |  ____  ____  | |" );
            bigFontList.Add( @"| | |_   ||   _| | |" );
            bigFontList.Add( @"| |   | |__| |   | |" );
            bigFontList.Add( @"| |   |  __  |   | |" );
            bigFontList.Add( @"| |  _| |  | |_  | |" );
            bigFontList.Add( @"| | |____||____| | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |     _____    | |" );
            bigFontList.Add( @"| |    |_   _|   | |" );
            bigFontList.Add( @"| |      | |     | |" );
            bigFontList.Add( @"| |      | |     | |" );
            bigFontList.Add( @"| |     _| |_    | |" );
            bigFontList.Add( @"| |    |_____|   | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |     _____    | |" );
            bigFontList.Add( @"| |    |_   _|   | |" );
            bigFontList.Add( @"| |      | |     | |" );
            bigFontList.Add( @"| |   _  | |     | |" );
            bigFontList.Add( @"| |  | |_' |     | |" );
            bigFontList.Add( @"| |  `.___.'     | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |  ___  ____   | |" );
            bigFontList.Add( @"| | |_  ||_  _|  | |" );
            bigFontList.Add( @"| |   | |_/ /    | |" );
            bigFontList.Add( @"| |   |  __'.    | |" );
            bigFontList.Add( @"| |  _| |  \ \_  | |" );
            bigFontList.Add( @"| | |____||____| | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |   _____      | |" );
            bigFontList.Add( @"| |  |_   _|     | |" );
            bigFontList.Add( @"| |    | |       | |" );
            bigFontList.Add( @"| |    | |   _   | |" );
            bigFontList.Add( @"| |   _| |__/ |  | |" );
            bigFontList.Add( @"| |  |________|  | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| | ____    ____ | |" );
            bigFontList.Add( @"| ||_   \  /   _|| |" );
            bigFontList.Add( @"| |  |   \/   |  | |" );
            bigFontList.Add( @"| |  | |\  /| |  | |" );
            bigFontList.Add( @"| | _| |_\/_| |_ | |" );
            bigFontList.Add( @"| ||_____||_____|| |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .-----------------." );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| | ____  _____  | |" );
            bigFontList.Add( @"| ||_   \|_   _| | |" );
            bigFontList.Add( @"| |  |   \ | |   | |" );
            bigFontList.Add( @"| |  | |\ \| |   | |" );
            bigFontList.Add( @"| | _| |_\   |_  | |" );
            bigFontList.Add( @"| ||_____|\____| | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |     ____     | |" );
            bigFontList.Add( @"| |   .'    `.   | |" );
            bigFontList.Add( @"| |  /  .--.  \  | |" );
            bigFontList.Add( @"| |  | |    | |  | |" );
            bigFontList.Add( @"| |  \  `--'  /  | |" );
            bigFontList.Add( @"| |   `.____.'   | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |   ______     | |" );
            bigFontList.Add( @"| |  |_   __ \   | |" );
            bigFontList.Add( @"| |    | |__) |  | |" );
            bigFontList.Add( @"| |    |  ___/   | |" );
            bigFontList.Add( @"| |   _| |_      | |" );
            bigFontList.Add( @"| |  |_____|     | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |    ___       | |" );
            bigFontList.Add( @"| |  .'   '.     | |" );
            bigFontList.Add( @"| | /  .-.  \    | |" );
            bigFontList.Add( @"| | | |   | |    | |" );
            bigFontList.Add( @"| | \  `-'  \_   | |" );
            bigFontList.Add( @"| |  `.___.\__|  | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |  _______     | |" );
            bigFontList.Add( @"| | |_   __ \    | |" );
            bigFontList.Add( @"| |   | |__) |   | |" );
            bigFontList.Add( @"| |   |  __ /    | |" );
            bigFontList.Add( @"| |  _| |  \ \_  | |" );
            bigFontList.Add( @"| | |____| |___| | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |    _______   | |" );
            bigFontList.Add( @"| |   /  ___  |  | |" );
            bigFontList.Add( @"| |  |  (__ \_|  | |" );
            bigFontList.Add( @"| |   '.___`-.   | |" );
            bigFontList.Add( @"| |  |`\____) |  | |" );
            bigFontList.Add( @"| |  |_______.'  | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |  _________   | |" );
            bigFontList.Add( @"| | |  _   _  |  | |" );
            bigFontList.Add( @"| | |_/ | | \_|  | |" );
            bigFontList.Add( @"| |     | |      | |" );
            bigFontList.Add( @"| |    _| |_     | |" );
            bigFontList.Add( @"| |   |_____|    | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| | _____  _____ | |" );
            bigFontList.Add( @"| ||_   _||_   _|| |" );
            bigFontList.Add( @"| |  | |    | |  | |" );
            bigFontList.Add( @"| |  | '    ' |  | |" );
            bigFontList.Add( @"| |   \ `--' /   | |" );
            bigFontList.Add( @"| |    `.__.'    | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| | ____   ____  | |" );
            bigFontList.Add( @"| ||_  _| |_  _| | |" );
            bigFontList.Add( @"| |  \ \   / /   | |" );
            bigFontList.Add( @"| |   \ \ / /    | |" );
            bigFontList.Add( @"| |    \ ' /     | |" );
            bigFontList.Add( @"| |     \_/      | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| | _____  _____ | |" );
            bigFontList.Add( @"| ||_   _||_   _|| |" );
            bigFontList.Add( @"| |  | | /\ | |  | |" );
            bigFontList.Add( @"| |  | |/  \| |  | |" );
            bigFontList.Add( @"| |  |   /\   |  | |" );
            bigFontList.Add( @"| |  |__/  \__|  | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |  ____  ____  | |" );
            bigFontList.Add( @"| | |_  _||_  _| | |" );
            bigFontList.Add( @"| |   \ \  / /   | |" );
            bigFontList.Add( @"| |    > `' <    | |" );
            bigFontList.Add( @"| |  _/ /'`\ \_  | |" );
            bigFontList.Add( @"| | |____||____| | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |  ____  ____  | |" );
            bigFontList.Add( @"| | |_  _||_  _| | |" );
            bigFontList.Add( @"| |   \ \  / /   | |" );
            bigFontList.Add( @"| |    \ \/ /    | |" );
            bigFontList.Add( @"| |    _|  |_    | |" );
            bigFontList.Add( @"| |   |______|   | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |   ________   | |" );
            bigFontList.Add( @"| |  |  __   _|  | |" );
            bigFontList.Add( @"| |  |_/  / /    | |" );
            bigFontList.Add( @"| |     .'.' _   | |" );
            bigFontList.Add( @"| |   _/ /__/ |  | |" );
            bigFontList.Add( @"| |  |________|  | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @"     " );
            bigFontList.Add( @"     " );
            bigFontList.Add( @"     " );
            bigFontList.Add( @"     " );
            bigFontList.Add( @"     " );
            bigFontList.Add( @"     " );
            bigFontList.Add( @"     " );
            bigFontList.Add( @"     " );
            bigFontList.Add( @"     " );
            bigFontList.Add( @"     " );
            bigFontList.Add( @"     " );

            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |     __       | |" );
            bigFontList.Add( @"| |    /  |      | |" );
            bigFontList.Add( @"| |    `| |      | |" );
            bigFontList.Add( @"| |     | |      | |" );
            bigFontList.Add( @"| |    _| |_     | |" );
            bigFontList.Add( @"| |   |_____|    | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |    _____     | |" );
            bigFontList.Add( @"| |   / ___ `.   | |" );
            bigFontList.Add( @"| |  |_/___) |   | |" );
            bigFontList.Add( @"| |   .'____.'   | |" );
            bigFontList.Add( @"| |  / /____     | |" );
            bigFontList.Add( @"| |  |_______|   | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |    ______    | |" );
            bigFontList.Add( @"| |   / ____ `.  | |" );
            bigFontList.Add( @"| |   `'  __) |  | |" );
            bigFontList.Add( @"| |   _  |__ '.  | |" );
            bigFontList.Add( @"| |  | \____) |  | |" );
            bigFontList.Add( @"| |   \______.'  | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |   _    _     | |" );
            bigFontList.Add( @"| |  | |  | |    | |" );
            bigFontList.Add( @"| |  | |__| |_   | |" );
            bigFontList.Add( @"| |  |____   _|  | |" );
            bigFontList.Add( @"| |      _| |_   | |" );
            bigFontList.Add( @"| |     |_____|  | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |   _______    | |" );
            bigFontList.Add( @"| |  |  _____|   | |" );
            bigFontList.Add( @"| |  | |____     | |" );
            bigFontList.Add( @"| |  '_.____''.  | |" );
            bigFontList.Add( @"| |  | \____) |  | |" );
            bigFontList.Add( @"| |   \______.'  | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |    ______    | |" );
            bigFontList.Add( @"| |  .' ____ \   | |" );
            bigFontList.Add( @"| |  | |____\_|  | |" );
            bigFontList.Add( @"| |  | '____`'.  | |" );
            bigFontList.Add( @"| |  | (____) |  | |" );
            bigFontList.Add( @"| |  '.______.'  | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |   _______    | |" );
            bigFontList.Add( @"| |  |  ___  |   | |" );
            bigFontList.Add( @"| |  |_/  / /    | |" );
            bigFontList.Add( @"| |      / /     | |" );
            bigFontList.Add( @"| |     / /      | |" );
            bigFontList.Add( @"| |    /_/       | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |     ____     | |" );
            bigFontList.Add( @"| |   .' __ '.   | |" );
            bigFontList.Add( @"| |   | (__) |   | |" );
            bigFontList.Add( @"| |   .`____'.   | |" );
            bigFontList.Add( @"| |  | (____) |  | |" );
            bigFontList.Add( @"| |  `.______.'  | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |    ______    | |" );
            bigFontList.Add( @"| |  .' ____ '.  | |" );
            bigFontList.Add( @"| |  | (____) |  | |" );
            bigFontList.Add( @"| |  '_.____. |  | |" );
            bigFontList.Add( @"| |  | \____| |  | |" );
            bigFontList.Add( @"| |   \______,'  | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );

            bigFontList.Add( @" .----------------. " );
            bigFontList.Add( @"| .--------------. |" );
            bigFontList.Add( @"| |     ____     | |" );
            bigFontList.Add( @"| |   .'    '.   | |" );
            bigFontList.Add( @"| |  |  .--.  |  | |" );
            bigFontList.Add( @"| |  | |    | |  | |" );
            bigFontList.Add( @"| |  |  `--'  |  | |" );
            bigFontList.Add( @"| |   '.____.'   | |" );
            bigFontList.Add( @"| |              | |" );
            bigFontList.Add( @"| '--------------' |" );
            bigFontList.Add( @" '----------------' " );
        }

        private void populateSmallFontList ()
        {
            smallFontList.Add( @"     /\    " );
            smallFontList.Add( @"    /  \   " );
            smallFontList.Add( @"   / /\ \  " );
            smallFontList.Add( @"  / ____ \ " );
            smallFontList.Add( @" /_/__  \_\" );
            smallFontList.Add( @" |  _ \    " );
            smallFontList.Add( @" | |_) |   " );
            smallFontList.Add( @" |  _ <    " );
            smallFontList.Add( @" | |_) |   " );
            smallFontList.Add( @" |____/_   " );
            smallFontList.Add( @"  / ____|  " );
            smallFontList.Add( @" | |       " );
            smallFontList.Add( @" | |       " );
            smallFontList.Add( @" | |____   " );
            smallFontList.Add( @"  \_____|  " );
            smallFontList.Add( @" |  __ \   " );
            smallFontList.Add( @" | |  | |  " );
            smallFontList.Add( @" | |  | |  " );
            smallFontList.Add( @" | |__| |  " );
            smallFontList.Add( @" |_____/   " );
            smallFontList.Add( @" |  ____|  " );
            smallFontList.Add( @" | |__     " );
            smallFontList.Add( @" |  __|    " );
            smallFontList.Add( @" | |____   " );
            smallFontList.Add( @" |______|  " );
            smallFontList.Add( @" |  ____|  " );
            smallFontList.Add( @" | |__     " );
            smallFontList.Add( @" |  __|    " );
            smallFontList.Add( @" | |       " );
            smallFontList.Add( @" |_|____   " );
            smallFontList.Add( @"  / ____|  " );
            smallFontList.Add( @" | |  __   " );
            smallFontList.Add( @" | | |_ |  " );
            smallFontList.Add( @" | |__| |  " );
            smallFontList.Add( @"  \_____|  " );
            smallFontList.Add( @" | |  | |  " );
            smallFontList.Add( @" | |__| |  " );
            smallFontList.Add( @" |  __  |  " );
            smallFontList.Add( @" | |  | |  " );
            smallFontList.Add( @" |_|__|_|  " );
            smallFontList.Add( @" |_   _|   " );
            smallFontList.Add( @"   | |     " );
            smallFontList.Add( @"   | |     " );
            smallFontList.Add( @"  _| |_    " );
            smallFontList.Add( @" |_____|   " );
            smallFontList.Add( @"      | |  " );
            smallFontList.Add( @"      | |  " );
            smallFontList.Add( @"  _   | |  " );
            smallFontList.Add( @" | |__| |  " );
            smallFontList.Add( @"  \____/   " );
            smallFontList.Add( @" | |/ /    " );
            smallFontList.Add( @" | ' /     " );
            smallFontList.Add( @" |  <      " );
            smallFontList.Add( @" | . \     " );
            smallFontList.Add( @" |_|\_\    " );
            smallFontList.Add( @" | |       " );
            smallFontList.Add( @" | |       " );
            smallFontList.Add( @" | |       " );
            smallFontList.Add( @" | |____   " );
            smallFontList.Add( @" |______|  " );
            smallFontList.Add( @" |  \/  |  " );
            smallFontList.Add( @" | \  / |  " );
            smallFontList.Add( @" | |\/| |  " );
            smallFontList.Add( @" | |  | |  " );
            smallFontList.Add( @" |_|  |_|  " );
            smallFontList.Add( @" | \ | |   " );
            smallFontList.Add( @" |  \| |   " );
            smallFontList.Add( @" | . ` |   " );
            smallFontList.Add( @" | |\  |   " );
            smallFontList.Add( @" |_|_\_|   " );
            smallFontList.Add( @"  / __ \   " );
            smallFontList.Add( @" | |  | |  " );
            smallFontList.Add( @" | |  | |  " );
            smallFontList.Add( @" | |__| |  " );
            smallFontList.Add( @"  \____/   " );
            smallFontList.Add( @" |  __ \   " );
            smallFontList.Add( @" | |__) |  " );
            smallFontList.Add( @" |  ___/   " );
            smallFontList.Add( @" | |       " );
            smallFontList.Add( @" |_|___    " );
            smallFontList.Add( @"  / __ \   " );
            smallFontList.Add( @" | |  | |  " );
            smallFontList.Add( @" | |  | |  " );
            smallFontList.Add( @" | |__| |  " );
            smallFontList.Add( @"  \___\_\  " );
            smallFontList.Add( @" |  __ \   " );
            smallFontList.Add( @" | |__) |  " );
            smallFontList.Add( @" |  _  /   " );
            smallFontList.Add( @" | | \ \   " );
            smallFontList.Add( @" |_|__\_\  " );
            smallFontList.Add( @"  / ____|  " );
            smallFontList.Add( @" | (___    " );
            smallFontList.Add( @"  \___ \   " );
            smallFontList.Add( @"  ____) |  " );
            smallFontList.Add( @" |_____/_  " );
            smallFontList.Add( @" |__   __| " );
            smallFontList.Add( @" | || | |  " );
            smallFontList.Add( @" | || | |  " );
            smallFontList.Add( @" | || | |  " );
            smallFontList.Add( @" | ||_| |  " );
            smallFontList.Add( @" _\____/ __" );
            smallFontList.Add( @" \ \    / /" );
            smallFontList.Add( @" _\ \  / / " );
            smallFontList.Add( @" \ \ \/ /  " );
            smallFontList.Add( @"  \ \  /\  " );
            smallFontList.Add( @"   \ \/  \/" );
            smallFontList.Add( @"    \  /\  " );
            smallFontList.Add( @" __  \/_ \/" );
            smallFontList.Add( @" \ \ / /   " );
            smallFontList.Add( @"  \ V /    " );
            smallFontList.Add( @"   > <     " );
            smallFontList.Add( @"  / . \    " );
            smallFontList.Add( @" /_/ \_\__ " );
            smallFontList.Add( @" \ \   / / " );
            smallFontList.Add( @"  \ \_/ /  " );
            smallFontList.Add( @"   \   /   " );
            smallFontList.Add( @"    | |    " );
            smallFontList.Add( @"  __|_|_   " );
            smallFontList.Add( @" |___  /   " );
            smallFontList.Add( @"    / /    " );
            smallFontList.Add( @"   / /     " );
            smallFontList.Add( @"  / /__    " );
            smallFontList.Add( @" /_____|   " );
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            File.WriteAllText( filePath, "" );
            String line = "";
            foreach ( var item in bigFontList ) {
                if ( item.Contains( " Next" ) ) {
                    charactersList.Add( line );
                    line = "";
                }
                line += item + "\n";
            }

            string input = textBox1.Text;
            input = input.ToUpper();

            if ( input.Contains( Environment.NewLine ) ) {
                input = input.Replace( Environment.NewLine, " " );
                MessageBox.Show( "It supports 1 Line Text" );
            }

            char[] chars = input.ToCharArray();

            foreach ( var item in chars ) {
                Console.WriteLine( item );
            }

            List<int> charPositions = new List<int>();

            foreach ( var item in chars ) {
                int index = Array.IndexOf( alphabetsChars, item );
                charPositions.Add( index );
            }

            foreach ( var item in charPositions ) {
                Console.WriteLine( item );
            }

            //getBigCharacterFromIndex( charPositions );
            getStarWarsCharacterFromIndex( charPositions );

            // getBigCharacterFromIndex( charPositions );

            //String text = getBigCharacterFromIndex( new int[] {
            //    Array.IndexOf(alphabets, "R"),
            //    Array.IndexOf(alphabets, "I"),
            //    Array.IndexOf(alphabets, "Z"),
            //    Array.IndexOf(alphabets, "W"),
            //    Array.IndexOf(alphabets, "A"),
            //    Array.IndexOf(alphabets, "N"),
            //} );

            //Console.WriteLine( text );

            //label1.Text = text;

            //richTextBox1.Text = text;

            //   File.WriteAllText( "E:\\file.txt", text );
            Process.Start( filePath );
        }
    }
}