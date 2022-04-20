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

            solver = this.CreateForAverageTitleLenghtOfBGGEntries();
            res = solver.Solve();

            solver = this.CreateForAverageTitleLenghtOfToolSongs();
            res = solver.Solve();
        }

        Solver<SongEntry> CreateForAverageTitleLenghtOfToolSongs()
        {
            return new Solver<SongEntry>(
               new SequencialSongEntriesIterator("tool_songs.txt", 70),
               new ToStringRepresentation(),
               new SumOperation());
        }

        Solver<BGGEntry> CreateForAverageTitleLenghtOfBGGEntries()
        {
            return new Solver<BGGEntry>(
               new SequencialBGGEntriesIterator(0, 99),
               new ToStringRepresentation(),
               new AvgOperation());
        }

        Solver<BGGEntry> CreateForAverageFirst100BGGEntries()
        {
            return new Solver<BGGEntry>(
               new SequencialBGGEntriesIterator(0, 99),
               new Rank(),
               new AvgOperation());
        }

        Solver<Number> CreateForAverageFirst100Numbers()
        {
            return new Solver<Number>(
               new SequencialNumbersIterator(1, 100),
               new Rank(),
               new AvgOperation());
        }

        Solver<Number> CreateSolverForProjectEuler()
        {
            return new Solver<Number>(
                new SequencialNumbersIterator(1, 1000), 
                new ToTextRepresentation(),
                new SumOperation());
        }
    }

    public interface ISolver
    {
        object Solve();
    }

    public class Solver<T> : ISolver
        where T : Subject
    {
        private readonly SubjectIterator<T> _iterator;
        private readonly SubjectVisitor _translator;
        private readonly Operation _operation;

        public Solver(SubjectIterator<T> iterator,
            SubjectVisitor translator,
            Operation operation)
        {
            _iterator = iterator;
            _translator = translator;
            _operation = operation;
        }

        public object Solve()
        {
            foreach (var s in _iterator.Next())
            {
                var translated = Translate(s);
                _operation.Push(translated);
            }

            var res = _operation.Pop();
            return res;
        }

        private object Translate(T s)
        {
            var translated = s.Accept(_translator);
            return translated;
        }
    }

}
