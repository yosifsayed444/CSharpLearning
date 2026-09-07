using System.Collections;

namespace ConsoleApp6
{
    public class Employee : IEnumerable<Payitem>
    {
        private readonly List<Payitem> Payitems = new List<Payitem>();
        public string Name { get; set; }
        public int Salary { get; set; }
        public int deductoins { get; set; }
        public Employee()
        {
            Salary = 2000;
        }
        public void AddPayItem(string name, int val)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            Payitems.Add(new Payitem() { Name = name, Value = val });
        }
        public IEnumerator<Payitem> GetEnumerator()
        {
            //return new PayItemsEnumerator(Payitems);

            foreach (var item in Payitems)
                yield return item;
        }
        public Payitem GetPayitem (int index) => Payitems[index];
        public Payitem this [int index] => Payitems[index];
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Payitems.GetEnumerator();
        }

        //private class PayItemsEnumerator : IEnumerator<Payitem>
        //{
        //    private readonly List<Payitem> Payitems;
        //    private int curr = -1;
        //    public PayItemsEnumerator(List<Payitem> payitems)
        //    {
        //        Payitems = payitems;
        //    }
        //    public Payitem Current => Payitems[curr];

        //    object IEnumerator.Current => Current;

        //    public void Dispose()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public bool MoveNext()
        //    {
        //        return ++curr < Payitems.Count;
        //    }

        //    public void Reset()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}


    }
}
