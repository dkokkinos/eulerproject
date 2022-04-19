using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P17_NumberLetterCounts_DesignPatterns
{
    public class NumberLetterCountsDesignPatternsSolution : ISolvable
    {
        public void Solve()
        {
            ISolver solver = this.CreateSolverForProjectEuler();
            var res = solver.Solve();

            solver = this.CreateForAverageFirst100Numbers();
            res = solver.Solve();

            solver = this.CreateForAverageFirst100BGGEntries();
            res = solver.Solve();

            solver = this.CreateForAverageTitleLenghtOfToolSongs();
            res = solver.Solve();
        }

        NumberLetterCountsDesignPatternsSolver<SongEntry> CreateForAverageTitleLenghtOfToolSongs()
        {
            return new NumberLetterCountsDesignPatternsSolver<SongEntry>(
               new SequencialSongEntriesIterator("tool_songs.txt", 70),
               new ToStringRepresentation(),
               new AvgOperator());
        }

        NumberLetterCountsDesignPatternsSolver<BGGEntry> CreateForAverageTitleLenghtOfBGGEntries()
        {
            return new NumberLetterCountsDesignPatternsSolver<BGGEntry>(
               new SequencialBGGEntriesIterator(0, 99),
               new ToStringRepresentation(),
               new AvgOperator());
        }

        NumberLetterCountsDesignPatternsSolver<BGGEntry> CreateForAverageFirst100BGGEntries()
        {
            return new NumberLetterCountsDesignPatternsSolver<BGGEntry>(
               new SequencialBGGEntriesIterator(0, 99),
               new Rank(),
               new AvgOperator());
        }

        NumberLetterCountsDesignPatternsSolver<Number> CreateForAverageFirst100Numbers()
        {
            return new NumberLetterCountsDesignPatternsSolver<Number>(
               new SequencialNumbersIterator(1, 100),
               new Rank(),
               new AvgOperator());
        }

        NumberLetterCountsDesignPatternsSolver<Number> CreateSolverForProjectEuler()
        {
            return new NumberLetterCountsDesignPatternsSolver<Number>(
                new SequencialNumbersIterator(1, 1000), 
                new ToTextRepresentation(),
                new SumOperator());
        }
    }

    public interface ISolver
    {
        object Solve();
    }

    public class NumberLetterCountsDesignPatternsSolver<T> : ISolver
        where T : Subject
    {
        private readonly SubjectIterator<T> _iterator;
        private readonly SubjectVisitor _translator;
        private readonly Operator _operator;

        public NumberLetterCountsDesignPatternsSolver(SubjectIterator<T> iterator,
            SubjectVisitor translator,
            Operator @operator)
        {
            _iterator = iterator;
            _translator = translator;
            _operator = @operator;
        }

        public object Solve()
        {
            foreach (var s in _iterator.Next())
            {
                var translated = Translate(s);
                _operator.Push(translated);
            }

            var res = _operator.Pop();
            return res;
        }

        private object Translate(T s)
        {
            var translated = s.Accept(_translator);
            return translated;
        }
    }

}
