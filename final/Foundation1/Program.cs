using System;

class Program
{
    static void Main(string[] args)
    {
        Video[] _OSvideos = new Video[3];

        _OSvideos[0] = new Video("Life of Riza", "why hobbies are important", 316);
        _OSvideos[0].OSAddComment("Kable10", "so true!");
        _OSvideos[0].OSAddComment("Preset1", "thanks for sharing");
        _OSvideos[0].OSAddComment("lyramona", "hobbies help me so much!");

        _OSvideos[1] = new Video("KellyStamps", "Stop telling people your bussiness.", 609);
        _OSvideos[1].OSAddComment("Candy2325", "great advice!");
        _OSvideos[1].OSAddComment("keesha", "wish I knew this sooner!");
        _OSvideos[1].OSAddComment("Kourtney37", "nothing bad comes from not telling people your bussiness");

        _OSvideos[2] = new Video("LanaBlakely", "Why I am always so calm", 571);
        _OSvideos[2].OSAddComment("ulayawblog", "Love the vibes in this video. ");
        _OSvideos[2].OSAddComment("brendhaolivebre", "this was increibly inspiring for me to hear.");
        _OSvideos[2].OSAddComment("MisterPol", "Such calming words I feel like we know but need to be told.");


        for (int i = 0; i < _OSvideos.Length; i++)
        {
            Console.WriteLine();
            _OSvideos[i].OSDisplayVideoInfo();
            _OSvideos[i].OSDisplayVideoComments();
        }
    }
}