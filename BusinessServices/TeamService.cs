using AutoMapper;
using BusinessEntities;
using DataModel;
using DataModel.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BusinessServices
{
    public class TeamService : ITeamService
    {

        #region Private member variables.
        private readonly UnitOfWork _unitOfWork;
        #endregion

        #region Public constructor.
        /// <summary>  
        /// Public constructor.  
        /// </summary>  
        public TeamService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion


        public BusinessEntities.TeamEntity GetTeamById(long teamId)
        {
            if (teamId == null)
                return null;
            var team = _unitOfWork.TeamRepository.Get(t => t.Id == teamId);

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Team, TeamEntity>();
            });

            var teamModel = Mapper.Map<Team, TeamEntity>(team);
            return teamModel;
        }

        public IEnumerable<BusinessEntities.TeamEntity> GetAllTeams()
        {
            var teams = _unitOfWork.TeamRepository.GetAll().ToList();
            if (teams == null)
                return null;

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Team, TeamEntity>();
            });
            return Mapper.Map<List<Team>, List<TeamEntity>>(teams);

        }

        public IEnumerable<BusinessEntities.TeamEntity> GetAllTeams(long companyId)
        {
            if (companyId == null)
                return null;
            var teams = _unitOfWork.TeamRepository.GetMany(t => t.CompanyId == companyId).ToList();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Team, TeamEntity>();
            });

            return Mapper.Map<List<Team>, List<TeamEntity>>(teams);
        }

        public long CreateTeam(BusinessEntities.TeamEntity teamEntity)
        {
            if (teamEntity == null)
                return 0;
            using (var scope = new TransactionScope())
            {
                var team = new Team
                {
                    Name = teamEntity.Name,
                    Alias = teamEntity.Alias,
                    CompanyId = teamEntity.CompanyId,
                    Enabled = teamEntity.Enabled
                };
                _unitOfWork.TeamRepository.Insert(team);
                _unitOfWork.Save();
                scope.Complete();
                return team.Id;
            }
        }

        public bool UpdateTeam(long teamId, BusinessEntities.TeamEntity teamEntity)
        {
            if (teamEntity == null)
                return false;
             var team = _unitOfWork.TeamRepository.Get(t => t.Id == teamId);
            if(team == null)
                return false;
            using (var scope = new TransactionScope())
            {
               
                team.Name = teamEntity.Name;
                team.Alias = teamEntity.Alias;
                team.CompanyId = teamEntity.CompanyId;
                team.Enabled = teamEntity.Enabled;

                _unitOfWork.TeamRepository.Update(team);
                _unitOfWork.Save();
                scope.Complete();
                return true;
            }
        }

        public bool DeleteTeam(long teamId)
        {
            throw new NotImplementedException();
        }
    }
}
