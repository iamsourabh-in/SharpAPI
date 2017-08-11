using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface ITeamService
    {
        TeamEntity GetTeamById(long teamId);
        IEnumerable<TeamEntity> GetAllTeams();
        IEnumerable<TeamEntity> GetAllTeams(long companyId);
        long CreateTeam(TeamEntity teamEntity);
        bool UpdateTeam(long teamId, TeamEntity teamEntity);
        bool DeleteTeam(long teamId);
    }
}
