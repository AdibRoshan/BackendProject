﻿namespace BackendProject.Dto
{
	public class Productviewdto
	{
		public int Id { get; set; }
        public string? Title { get; set; }
		public string? Description { get; set; }
		public decimal? Price { get; set; }
		public int stock {  get; set; }
		public string? Image { get; set; }
	}
}
