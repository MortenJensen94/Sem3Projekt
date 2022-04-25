﻿using NuGet.Packaging.Rules;
using WebAPI.DataAccess;
using WebAPI.Models;

namespace WebAPI.Managers {
	public class TournamentManager : IManager<Tournament, int> {
		public Tournament GetById(int tournamentId)
		{
			Tournament foundTournament = null;
			IDao<Tournament, int> tournamentDao = DaoFactory.CreateTournamentDao();
			try
			{
				foundTournament = tournamentDao.GetById(tournamentId);
			}
			catch (Exception e)
			{
				throw;
			}

			return foundTournament;
		}

		public List<Tournament> GetAll()
		{
			throw new NotImplementedException();
		}
	}
}
