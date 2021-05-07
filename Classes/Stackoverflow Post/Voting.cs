using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace Stackoverflow_Post
{
    class Voting
    {
        public List<int> totalUpVotes = new List<int>();
        public List<int> totalDownVotes = new List<int>();
        private int upVotes = 0;
        private int downVotes = 0;

        public int UpVote(int upVote) // Y
        {
            this.upVotes = upVote;
            upVote++;
            totalUpVotes.Add(upVote);

            return totalUpVotes.Count();
        }

        public int DownVote(int downVote) // X
        {
            this.downVotes = downVote;
            downVote++;
            totalDownVotes.Add(downVote);

            return totalDownVotes.Count();
        }
    }
}
