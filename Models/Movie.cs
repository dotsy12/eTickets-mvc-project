using eTickets.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.InteropServices;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
       
        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //cinema
        public Cinema Cinema  { get; set; }
        public int CinemaId  { get; set; }  
        
        //Producer
        public Producer Producer { get; set; }
        public int ProducerId { get; set; }
    }
}

