using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P17_NumberLetterCounts_DesignPatterns
{
    public abstract class SubjectIterator<T>
        where T : Subject
    {
        public abstract IEnumerable<T> Next();
    }

    public abstract class SequencialIterator<T> : SubjectIterator<T>
        where T : Subject
    {
        public int _min;
        public int _max;

        public SequencialIterator(int min = 0, int max = 1000)
        {
            _min = min;
            _max = max;
        }

        public override sealed IEnumerable<T> Next()
        {
            int index = _min;
            while (index <= this._max)
                yield return this.GetNext(index++);
        }

        protected abstract T GetNext(int index);
    }

    public class SequencialNumbersIterator : SequencialIterator<Number>
    {
        public SequencialNumbersIterator(int min = 1, int max = 1000) : base(min, max)
        {
        }

        protected override Number GetNext(int index)
        {
            return new Number(index++);
        }
    }

    public class SequencialBGGEntriesIterator : SequencialIterator<BGGEntry>
    {
        public SequencialBGGEntriesIterator(int min = 0, int max = 100) : base(min, max)
        {
        }

        protected override BGGEntry GetNext(int index)
        {
            string path = Path.Combine(Path.GetDirectoryName(this.GetType().Assembly.Location), "../../../Resources/bgg_top_100.csv");
            var line = File.ReadLines(path).ElementAt(index + 1).Split(';').ToList();
            return new BGGEntry(line[2], Convert.ToDecimal(line[3]), Convert.ToInt32(line[5]));
        }
    }

    public class SequencialSongEntriesIterator : SequencialIterator<SongEntry>
    {
        private readonly string _file;

        public SequencialSongEntriesIterator(string file, int max) : base(1, max)
        {
            this._file = file;
        }

        protected override SongEntry GetNext(int index)
        {
            string path = Path.Combine(Path.GetDirectoryName(this.GetType().Assembly.Location), "../../../Resources", _file);
            var line = File.ReadLines(path).ElementAt(index).Split(';').ToList();
            return new SongEntry(line[0], line[1], Convert.ToInt32(line[3]));
        }
    }
}
