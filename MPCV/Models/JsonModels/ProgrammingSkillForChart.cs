using System;
using System.Collections.Generic;

namespace MPCV.Models.JsonModels {
    /// <summary>
    ///     ProgrammingSkillForChart class.
    /// </summary>
    [Serializable]
    public class ProgrammingSkillForChart {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ProgrammingSkillForChart" /> class.
        /// </summary>
        public ProgrammingSkillForChart() {
            ProgrammingSkills = new List<ChatSkillSerializable>();
        }

        /// <summary>
        /// Gets or sets the programming skills.
        /// </summary>
        /// <value>
        /// The programming skills.
        /// </value>
        public List<ChatSkillSerializable> ProgrammingSkills { get; }
    }

    [Serializable]
    public class ChatSkillSerializable {
        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        public string name { get; set; }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        /// <value>
        ///     The value.
        /// </value>
        public int value { get; set; }
    }
}