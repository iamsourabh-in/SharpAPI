using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface ITeamMemberService
    {
        TeamMemberEntity GetTeamMembersById(long teamId);
        long AddTeamMember(TeamMemberEntity teamMemberEntity);
        bool UpdateTeamMember(long teamMemberId, TeamMemberEntity teamMemberEntity);
        bool DeleteTeamMember(long teamMemberId);
    }
}
