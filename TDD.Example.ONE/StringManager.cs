using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Example.ONE
{
    public class StringManager
    {
        private string StringValue { get; set; }

        public StringManager()
        {
            //StringValue = string.Empty;
        }
        public StringManager(string startString)
        {
            this.StringValue = startString;
        }

        public StringManager Add(string s)
        {
            StringValue += s;
            return this;
        }

        public StringManager Remove(string s)
        {
            this.StringValue = this.StringValue.Replace(s, string.Empty);

            return this;
        }

        public bool IsNullOrEmpty
        {
            get {
                return string.IsNullOrEmpty(this.StringValue);
            }
        }

        public override string ToString()
        {
            return this.StringValue ?? string.Empty;
        }
    }
}
