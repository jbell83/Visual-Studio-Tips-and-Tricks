// <auto-generated> - Template:DTO, Version:2.0, Id:0d58c309-4b48-4464-819d-83c9c87cf463
using System;
namespace CGHClientServer1.DTO.CSC
{
	public partial class City
	{
		public City()
		{
			InitializePartial();
		}

		public Guid CityId { get; set; } // Primary key
		public string Name { get; set; }
		public Guid StateId { get; set; }
		public virtual State State { get; set; } // One to One mapping

		partial void InitializePartial();

	}
}