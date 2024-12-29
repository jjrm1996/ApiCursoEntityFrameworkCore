﻿using NetTopologySuite.Geometries;

namespace ApiCursoEntityFrameworkCore.Entities
{
    public class Movie
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public Point Location { get; set; }

        //Propiedades de navegacion
        
        //hacer la relacion (1 a 1)
        public OfferMovie OfferMovie { get; set; }
        
        //hacer la relacion (1 a *)
        public ICollection<MovieTheater> MovieTheaters { get; set; }

    }
}
