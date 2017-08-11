using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class TeamMemberService : ITeamMemberService
    {
        public BusinessEntities.TeamMemberEntity GetTeamMembersById(long teamId)
        {
            throw new NotImplementedException();
        }

        public long AddTeamMember(BusinessEntities.TeamMemberEntity teamMemberEntity)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTeamMember(long teamMemberId, BusinessEntities.TeamMemberEntity teamMemberEntity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTeamMember(long teamMemberId)
        {
            throw new NotImplementedException();
        }
    }
}
