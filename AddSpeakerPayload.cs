using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ConferencePlanner.GraphQL.Data;

namespace ConferencePlanner.GraphQL
{
    public class AddSpeakerPayload
    {
        public AddSpeakerPayload(Speaker speaker)
        {
            Speaker = speaker;
        }

        public Speaker Speaker { get; }
    }
}