using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;

using System.Windows.Forms;


namespace PDFTextToSpeech
{
    public partial class Form1 : Form
    {
        //golbal path of file
        string filePathing = "";
        //golbal string for pdf text
        string PdfString = "";
        //golbal SpeechSynthesizer for reading text
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
            //create a list of voice for letter choosing
            IReadOnlyCollection<InstalledVoice> installedVoices = speechSynthesizer.GetInstalledVoices();

            //for every InstalledVoice it will add it to the CmbBxVoiceSelectionInput items
            foreach (InstalledVoice installedVoice in installedVoices)
            {
                VoiceInfo voiceinfo = installedVoice.VoiceInfo;
                CmbBxVoiceSelectionInput.Items.Add(voiceinfo.Name);
            }
            //put it on the first voice
            CmbBxVoiceSelectionInput.SelectedIndex = 0;
            //initalizes the speed of talking           
            trcBarSpeechRate.Value = speechSynthesizer.Rate;

            //dispose of the created SpeechSynthesizer
            speechSynthesizer.Dispose();

        }
        void extractText()
        {
            //create PdfReader using the filePathing
            PdfReader reader = new PdfReader(filePathing);
            //clear PdfString
            PdfString = "";
            //this will loop for as many page there is
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                //create a strategy to extract text from pdf
                ITextExtractionStrategy TextExtractionStrategy = new LocationTextExtractionStrategy();
                //this will extract the text from the current page
                string Extractedtext = PdfTextExtractor.GetTextFromPage(reader, page, TextExtractionStrategy);
                //convert any special character to something in the ascii table
                Extractedtext = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(Extractedtext)));
                //adds Extractedtext to  PdfString
                PdfString += Extractedtext;

            };
            //puts PdfString into the RTxtBxPdfTxtOutput
            RTxtBxPdfTxtOutput.Text = PdfString;



        }


        void ReadTextFromPdf(ref string temp)
        {
            //destory any create SpeechSynthesizer
            speechSynthesizer.Dispose();
            //creates new SpeechSynthesizer
            speechSynthesizer = new SpeechSynthesizer();
            //set the rate of speech 
            speechSynthesizer.Rate = trcBarSpeechRate.Value;
            //changes the voice to what is selected
            speechSynthesizer.SelectVoice(CmbBxVoiceSelectionInput.SelectedItem.ToString());
            //speak with and allow other task to take place
            speechSynthesizer.SpeakAsync(temp);
            // creates a handle for if there is any progress change to call SpeechSynthesizer_SpeakProgress
            speechSynthesizer.SpeakProgress += SpeechSynthesizer_SpeakProgress;

        }
        void PauseAndPlaySpeech()
        {
            //case statment for speechSynthesizer state
            switch (speechSynthesizer.State)
            {
                //if it is speaking
                case SynthesizerState.Speaking:
                    {

                        speechSynthesizer.Pause();
                        //this will disable CmbBxVoiceSelectionInput
                        CmbBxVoiceSelectionInput.Enabled = true;
                        //this will change the appearence of the button
                        BtnResumeAndPaused.Text = "Resume";
                        break;
                    }
                //if it is Paused
                case SynthesizerState.Paused:
                    {

                        speechSynthesizer.Resume();
                        //this will disable CmbBxVoiceSelectionInput
                        CmbBxVoiceSelectionInput.Enabled = false;
                        //this will change the appearence of the BtnResumeAndPaused

                        BtnResumeAndPaused.Text = "Pasued";
                        break;
                    }
            }
        }
        public void StartNewSpeecher()
        {
            //this will call ReadTextFromPdf and pass PdfString
            ReadTextFromPdf(ref PdfString);
            //this will disable CmbBxVoiceSelectionInput
            CmbBxVoiceSelectionInput.Enabled = false;
            //this will change the BtnResumeAndPaused of the button and enable it
            BtnResumeAndPaused.Enabled = true;
            BtnResumeAndPaused.Text = "Pasued";
        }

        private void SpeechSynthesizer_SpeakProgress(object sender, SpeakProgressEventArgs e)
        {
            //this will show which word the SpeechSyntherizer is on
            RTxtBxPdfTxtOutput.Select();
            RTxtBxPdfTxtOutput.Select(e.CharacterPosition, 1);
        }

        void GettingPdfFile()
        {
            try
            {
                //open Dialog so that you get input a pdf
                openFileDialog1.ShowDialog();
                openFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf| ALL Files (*.*)|*.*";
                openFileDialog1.FilterIndex = 0;
                openFileDialog1.OpenFile();

                //put path into textbox for display
                TxtBxFilePathOutput.Text = openFileDialog1.FileName;

                //this will call extractText
                extractText();
                //this will change the BtnStartNewReader of the button and enable it
                BtnStartNewReader.Enabled = true;
                BtnStartNewReader.Text = "Begin Reading";
            }
            catch (Exception t)
            {
                // Shows why there is an error
                MessageBox.Show(t.Message, t.Source);
            }
        }
        private void BtnInputPdf_Click(object sender, EventArgs e)
        {

            GettingPdfFile();



        }

        private void BtnStartNewReader_Click(object sender, EventArgs e)
        {


            StartNewSpeecher();

        }

        private void BtnResumeAndPaused_Click(object sender, EventArgs e)
        {
            PauseAndPlaySpeech();


        }



        private void TxtBxFilePathOutput_Click(object sender, EventArgs e)
        {
            GettingPdfFile();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            speechSynthesizer.Dispose();
        }
    }
}
