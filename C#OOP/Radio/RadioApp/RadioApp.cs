using System;
using System.Threading;
using System.Collections.Generic;
using WMPLib;
using WMPDXMLib;
using SpotifyAPI;

namespace RadioApp
{
    public class Radio
    {
        string mediapath = @"C:\Users\Bongt\OneDrive\Documents\sparta global\eng86\Eng86\C#OOP\Radio\RadioGUI\media\";


        private List<WindowsMediaPlayerClass> channels;
        //<PackageReference Include="C:\Users\Bongt\Downloads\SpotifyAPI.Web.Auth-net5.0\SpotifyAPI.Web.Auth.dll"/>
        private const string rootAddress = @"C:\Users\Bongt\OneDrive\Music";
        //SpotifyClient session = new SpotifyClient("BQCT0n3SH-PaK70gxTCkYwMG7dfr_AacuH7wqFbYk0AU5OxgYhNv42kADKaoQspCchcygrTjUcyFopSJKH3ohr6jgZsia5THZHQYPLFBXmjY2GooMQduZud5Pj5LLn1XpgIPcCBYZuS1Ke33GgXGpPFOTplXfv9KQLpfnQTvOb_yQT-VNxUdkOWXRh0RTINwnm3qBehK");
        //var track = await session.Tracks.Get("1s6ux0lNiTziSrd7iUAADH");
        
        
        private int _channel = 1;
        private bool _on;

        public Radio()
        {
            channels = new List<WindowsMediaPlayerClass>()
            {
                new WindowsMediaPlayerClass(),
                new WindowsMediaPlayerClass(),
                new WindowsMediaPlayerClass(),
                new WindowsMediaPlayerClass(),

            };
            channels[0].add(mediapath + "2Pac_ft_Eric_Williams_-_Do_For_Love_Qoret.com.mp3");
        }

        public bool On { get => _on; set => _on = value; }

        public int Channel { 
            get => _channel;
            set {
                _channel = value < 5 && value > 0 && On ? value : _channel;
                
            }
        }
        

        public string Play()
        {

            channels[Channel-1].play();
            return On ? $"Playing channel {Channel}": "Radio is off";
        }

        public void TurnOff()
        {
            On = false;
        }

        public void TurnOn()
        {
            On = true;
        }

        //switch(chan)
        //        {
        //            case 1:
        //                mp.Stop();
        //                mp.Open(new Uri(mediapath + "2Pac_ft_Eric_Williams_-_Do_For_Love_Qoret.com.mp3", UriKind.Relative));
                        
        //                mp.Play();
        //                break;

        //            case 2:
        //                mp.Stop();
        //                mp.Open(new Uri(mediapath + "What does the Electoral Commission’s probe mean for Boris Johnson  – BBC Newsnight.mp3", UriKind.Relative));
        //                mp.Play();
        //                break;

        //            case 3:
        //                mp.Stop();
        //                mp.Open(new Uri(mediapath + "hard track 1.mp3", UriKind.Relative));
        //                mp.Play();
        //                break;

        //            case 4:
        //                mp.Stop();
        //                mp.Open(new Uri(mediapath + "Take It to the Lord in Prayer   Aeolians of Oakwood University.wav", UriKind.Relative));
        //                mp.Play();
        //                break;
        //        }


}
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}