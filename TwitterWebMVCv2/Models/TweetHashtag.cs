﻿
using System;

namespace TwitterWebMVCv2.Models
{
    public class TweetHashtag
    {
        public int ID { get; set; }
        public int TweetID { get; set; }
        public int HashtagID { get; set; }
        public int UnixTimeStamp { get; set; }

        public TweetHashtag() { }
    }
}
