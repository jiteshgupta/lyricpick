﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LyrickPick.Processors
{
    public class Quiz
    {
        static List<Song> songs;
        static List<Song> selectedSongs;
        static int score = 0;

        public Quiz()
        {
            //songs = fetchsongs
        }
        /*stretch goal
        public Quiz(string Genre)
        {
            
        }
        */

        public void Question()
        {
            //select a song
            Song currentSong = selectSong();
            string json = ""; //=fetchlyrics
            List<String> lines = LyricProcessor.SpliceSong(json);
            List<String> selectedLines = new List<String>();
            string question = LyricProcessor.selectLine(lines, selectedLines);

        }
        public Song selectSong()
        {
            Song song = selectedSongs[0];
            while (selectedSongs.Contains(song))
            {
                song = songs[new Random().Next(0, songs.Count)];
            }
            return song;
        }

    }
}