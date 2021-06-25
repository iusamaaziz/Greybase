using System;
using System.Collections.Generic;
using System.Text;

using GreyBase.Shared;

using Microsoft.EntityFrameworkCore;

namespace Greybase.Shared
{
	/// <summary>
	/// 
	/// </summary>
	public class GreybaseContext : DbContext
	{
		#region Public Properties

		public DbSet<Greyhound> Greyhounds { get; set; }

		public DbSet<Race> Races { get; set; }

		public DbSet<Trainer> Trainers { get; set; }

		public DbSet<Track> Tracks { get; set; }

		public DbSet<RaceTrap> RaceTraps { get; set; }

		#endregion

		#region Constructor

		public GreybaseContext()
		{
		}

		public GreybaseContext(DbContextOptions<GreybaseContext> options)
			: base(options)
		{

		}

		#endregion

		#region Private Properties

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				// IMPORTANT: To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.

				// TODO -- Update Connection String before run
				optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Greybase;Integrated Security=True;");
			}
		}

		#endregion
	}
}
