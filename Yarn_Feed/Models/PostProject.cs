﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yarn_Feed.Models
{
    public class PostProject
    {
        [Key]
        public int Id { get; set; }
        public Project project { get; set; }
    }

    public class Project
    {
        public string completed { get; set; }
        public int? craft_id { get; set; }
        public string created_at { get; set; }
        public int? favorites_count { get; set; }
        public int? id { get; set; }
        public string made_for { get; set; }
        public int? made_for_user_id { get; set; }
        public string name { get; set; }
        public int? pattern_id { get; set; }
        public string permalink { get; set; }
        public int? progress { get; set; }
        public string project_status_changed { get; set; }
        public int? project_status_id { get; set; }
        public int? rating { get; set; }
        public string size { get; set; }
        public string started { get; set; }
        public string updated_at { get; set; }
        public int? user_id { get; set; }
        public string pattern_name { get; set; }
        public string craft_name { get; set; }
        public string status_name { get; set; }
        public string notes_html { get; set; }
        public string notes { get; set; }
        public Needle_Sizes[] needle_sizes { get; set; }
        public int? photos_count { get; set; }
        public Photo[] photos { get; set; }
    }

    public class Needle_Sizes
    {

        public int? id { get; set; }
        public string us { get; set; }
        public float? metric { get; set; }
        public bool? crochet { get; set; }
        public bool? knitting { get; set; }
        public string hook { get; set; }
        public string name { get; set; }
        public string pretty_metric { get; set; }
    }

    public class Photo
    {
        public int? id { get; set; }
        public int? sort_order { get; set; }
        public int? x_offset { get; set; }
        public int? y_offset { get; set; }
        public string square_url { get; set; }
        public string medium_url { get; set; }
        public string thumbnail_url { get; set; }
        public string small_url { get; set; }
        public string shelved_url { get; set; }
        public string medium2_url { get; set; }
        public string small2_url { get; set; }

    }

    public class User
    {
        public string fave_colors { get; set; }
        public string fave_curse { get; set; }
        public string first_name { get; set; }
        public int? id { get; set; }
        public string location { get; set; }
        public string username { get; set; }
        public string tiny_photo_url { get; set; }
        public string small_photo_url { get; set; }
        public string photo_url { get; set; }
        public string large_photo_url { get; set; }
        public string about_me { get; set; }
        public string about_me_html { get; set; }
        //public Pattern_Author pattern_author { get; set; }
    }
}
