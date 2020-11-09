/* PNW ITS462 
 * Fall 2020
 * Final Project
 *
 * Jeremy Batterbee
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election2k20_Project_ITS462
{
    /// <summary>
    /// Class <c>State</c> represents a US State's presidental vote state.
    /// </summary>
    public class State
    {
        /// <summary>
        /// States name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Vote winnner.
        /// </summary>
        public string Winner { get; set; }
        /// <summary>
        /// Name of the first Candidate.
        /// </summary>
        public string Candidate1 { get; set; }
        /// <summary>
        /// Name of the second Candidate.
        /// </summary>
        public string Candidate2 { get; set; }
        /// <summary>
        /// Party of the first Candidate.
        /// </summary>
        public string Party1 { get; set; }
        /// <summary>
        /// Party of the second Candidate.
        /// </summary>
        public string Party2 { get; set; }
        /// <summary>
        /// Number of votes for the first Candidate.
        /// </summary>
        public int Votes1 { get; set; }
        /// <summary>
        /// Number of votes for the second Candidate.
        /// </summary>
        public int Votes2 { get; set; }
        /// <summary>
        /// Percentage of the vote for the first candidate.
        /// </summary>
        public float Percent1 { get; set; }
        /// <summary>
        /// Percentage of the vote for the second candidate.
        /// </summary>
        public float Percent2 { get; set; }

        /// <summary>
        /// Creates an empty <c>State</c> instance.
        /// </summary>
        public State() {
            Name = null;
            Winner = null;
            Candidate1 = null;
            Candidate2 = null;
            Party1 = null;
            Party2 = null;
            Votes1 = -1;
            Votes2 = -1;
            Percent1 = -1f;
            Percent2 = -1f;
        }

        /// <summary>
        /// Creates a new <c>State</c> instance.
        /// </summary>
        /// <param name="name">Name of the state.</param>
        public State(string name) {
            Name = name;

            Winner = "";
            Candidate1 = "";
            Candidate2 = "";
            Party1 = "";
            Party2 = "";
            Votes1 = -1;
            Votes2 = -1;
            Percent1 = -1f;
            Percent2 = -1f;
        }
    }
}
