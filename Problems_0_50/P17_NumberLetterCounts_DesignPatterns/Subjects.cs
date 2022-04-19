using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P17_NumberLetterCounts_DesignPatterns
{
    public abstract class Subject
    {
        public abstract object Accept(SubjectVisitor visitor);
    }

    public class Number : Subject
    {
        public int Value { get; }

        public Number(int value)
        {
            Value = value;
        }

        public override object Accept(SubjectVisitor visitor)
        {
            return visitor.VisitNumber(this);
        }
    }

    public class BGGEntry : Subject
    {
        public string Title { get; set; }
        public decimal Rating { get; set; }
        public int NumOfVotes { get; set; }

        public BGGEntry(string title, decimal rating, int numOfVotes)
        {
            Title = title;
            Rating = rating;
            NumOfVotes = numOfVotes;
        }

        public override object Accept(SubjectVisitor visitor)
        {
            return visitor.VisitBGGEntry(this);
        }
    }

    public class SongEntry : Subject
    {
        public string Title { get; set; }
        public string Writers { get; set; }
        public int Year { get; set; }

        public SongEntry(string title, string writers, int year)
        {
            Title = title;
            Writers = writers;
            Year = year;
        }

        public override object Accept(SubjectVisitor visitor)
        {
            return visitor.VisitSongEntry(this);
        }
    }

}
