using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Accounter
{
    public class TransactionFilter
    {
        public DateTime? Filter_from;
        public DateTime? Filter_to;
        public bool? Filter_isIncome;
        public string Filter_category;
        public string Filter_type;
        private Regex partnerRegexp;
        public string Filter_partnerName
        {
            get
            {
                if (partnerRegexp == null)
                    return null;
                else
                    return partnerRegexp.ToString();
            }
            set
            {
                if (value != null)
                {
                    if (this.partnerCaseSensitive == false)
                        partnerRegexp = new Regex(value, RegexOptions.IgnoreCase);
                    else
                        partnerRegexp = new Regex(value);
                }
                else
                {
                    partnerRegexp = null;
                }
            }
        }
        public bool partnerCaseSensitive;

        public TransactionFilter()
        {
            Filter_from = new DateTime();
            Filter_to = new DateTime();
            Filter_isIncome = null;
            Filter_category = null;
            Filter_type = null;
            Filter_partnerName = null;
            partnerCaseSensitive = false;
        }

        public TransactionFilter(DateTime? filter_from = null, DateTime? filter_to = null, bool? filter_isIncome = null, string filter_category = null, string filter_type = null, string filter_partnerName = null, bool partnerCaseSensitive = false)
        {
            Filter_from = filter_from;
            Filter_to = filter_to;
            Filter_isIncome = filter_isIncome;
            Filter_category = filter_category;
            Filter_type = filter_type;
            Filter_partnerName = filter_partnerName;
            this.partnerCaseSensitive = partnerCaseSensitive;
        }

        public bool IsTrueForTransaction(Transaction transaction)
        {
            if (Filter_from.HasValue && (transaction.Date < Filter_from))
                return false;
            if (Filter_to.HasValue && (Filter_to < transaction.Date))
                return false;
            if (partnerRegexp != null && (!partnerRegexp.IsMatch(transaction.PartnerName)))
                return false;
            if (Filter_isIncome.HasValue && (((Filter_isIncome == true) && (transaction.Sum < 0)) ||
                                      ((Filter_isIncome == false) && (transaction.Sum > 0))))
                return false;
            if (Filter_category != null && !transaction.Category.Contains(Filter_category))
                return false;
            if (Filter_type != null && !transaction.Type.Contains(Filter_type))
                return false;
           

            // if all filter oprtions are true
            return true;
        }
    }

    public class CategoryDetector
    {
        public TransactionFilter Filter;
        public string TargetCategory;

        public CategoryDetector()
        {
            Filter = new TransactionFilter();
            TargetCategory = null;
        }

        public CategoryDetector(string targetCategory, DateTime? filter_from = null, DateTime? filter_to = null, bool? filter_isIncome = null, string filter_category = null, string filter_type = null,  string filter_partnerName = null, bool partnerCaseSensitive = false)
        {
            Filter = new TransactionFilter(filter_from,filter_to,filter_isIncome,filter_category, filter_type, filter_partnerName, partnerCaseSensitive);
            TargetCategory = targetCategory;
        }

        public void AssignCategory(Transaction tr)
        {
            if ((Filter != null) && (TargetCategory != null) && Filter.IsTrueForTransaction(tr))
                tr.Category = this.TargetCategory;
        }

        public void AssignCategory(List<Transaction> transactions)
        {
            foreach (Transaction tr in transactions)
                AssignCategory(tr);
        }


    }

    public class Transaction
    {
        [XmlElement(DataType ="date")]
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string PartnerName { get; set; }
        public int Sum { get; set; }
        public  string Category;


        public Transaction(DateTime date, string type, string partnerName, int sum, string category)
        {
            Date = date;
            Type = type;
            PartnerName = partnerName;
            Sum = sum;
            this.Category = category;
        }
        public Transaction(): this(new DateTime(), "", "", 0, "none") {}

        public Transaction(string record)
        {
            string[] tags = record.Split('\t');
            if (tags.Length < 3)
                throw new Exception("Invalid transaction record: " + record);

            Date = DateTime.Parse(tags[0]);
            Type = tags[2];
            PartnerName = tags[6];
            Sum = int.Parse(tags[7]);
            Category = "none";
        }


        public string[] getStringArray()
        {
            string[] ret = new string[5];
            ret[0] = this.Date.ToShortDateString();
            ret[1] = this.Type;
            ret[2] = this.PartnerName;
            ret[3] = this.Category;
            ret[4] = this.Sum.ToString();
            return ret;
        }
    }

    public class AccounterDatabase
    {
        public List<Transaction> Transacions;
        public List<CategoryDetector> Detectors;
        public CategoryNode rootCategory;

        public AccounterDatabase()
        {
            this.Transacions = new List<Transaction>();
            this.Detectors = new List<CategoryDetector>();
            this.rootCategory = new CategoryNode(null,"Sum");
        }

        public void AddTransaction(Transaction t)
        {
            this.Transacions.Add(t);
        }

        public void AddTransactions(Transaction[] newElements)
        {
            this.Transacions.AddRange(newElements);
        }

        public void AddTransactions(List<Transaction> newElments)
        {
            this.Transacions.AddRange(newElments);
        }

        public List<Transaction> GetTransactions(TransactionFilter filter)
        {
            List<Transaction> retVal;

            if(filter == null)
            {
                retVal = this.Transacions;
            }
            else
            {
                retVal = this.Transacions.Where(filter.IsTrueForTransaction).ToList();
            }

            return retVal;
        }

        public List<Transaction> GetTransactions(int year, int month)
        {
            TransactionFilter filter = new TransactionFilter();
            filter.Filter_from = new DateTime(year, month, 1);
            filter.Filter_to = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            return GetTransactions(filter);
        }

        public List<Transaction> GetTransactions(DateTime from, DateTime to)
        {
            TransactionFilter filter = new TransactionFilter();
            filter.Filter_from = from;
            filter.Filter_to = to;
            return GetTransactions(filter);
        }

        public int GetSum(TransactionFilter filter)
        {
            int sum = 0;

            List<Transaction> trs = GetTransactions(filter);
            foreach(Transaction tr in trs)
            {
                sum += tr.Sum;
            }

            return sum;
        }

        public void AddDetector(CategoryDetector det)
        {
            this.Detectors.Add(det);
        }
    };

    public class CategoryNode :IComparable
    {
        [XmlIgnore]
        public CategoryNode Parent;
        public string Name;
        public List<CategoryNode> Children;
        [XmlIgnore]
        public int Value;
        [XmlIgnore]
        private static readonly char[] separator = { '/' };

        public CategoryNode() : this(null, null, 0) { }

        public CategoryNode(CategoryNode parent,string name, int val = 0)
        {
            Parent = parent;
            Name = name;
            Value = val;
            Children = new List<CategoryNode>();
        }

        private List<string> SplitPath(string path)
        {
            return path.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private string MergePath(List<string> path)
        {
            return String.Join("/", path.ToArray());
        }

        private CategoryNode GetChild(string name)
        {
            return Children.Find(ch => ch.Name == name);
        }

        private CategoryNode TouchChild(string name)
        {
            CategoryNode c;
            c = GetChild(name);
            if(null == c)
            {
                c = new CategoryNode(this, name);
                Children.Add(c);
                Children.Sort();
            }

            return c;
        }

        private CategoryNode TouchCategory(string path)
        {
            CategoryNode tmp = this;

            foreach(string name in SplitPath(path))
            {
                tmp = tmp.TouchChild(name);
            }

            return tmp;
        }

        void SetValue(string path, int val)
        {
            CategoryNode tmp = TouchCategory(path);
            tmp.Value = val;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            CategoryNode otherCategory = obj as CategoryNode;
            if (otherCategory != null)
                return this.Name.CompareTo(otherCategory.Name);
            else
                throw new ArgumentException("Object is not a CategoryNode");
        }

        public string GetPath()
        {
            CategoryNode tmp = this;
            List<string> path = new List<string>();
            while(tmp != null)
            {
                path.Add(tmp.Name);
                tmp = tmp.Parent;
            }

            path.Reverse();

            return MergePath(path);
        }

        public void InitTree()
        {
            this.Parent = null;
            this.Value = 0;
            foreach(CategoryNode c in Children)
            {
                c.Parent = this;
                c.Value = 0;
                c.InitTree();
            }
        }

        public void AddValueRecursively(string path, int val)
        {
            CategoryNode tmp = this;
            tmp.Value += val;
            foreach(string name in SplitPath(path))
            {
                tmp = tmp.TouchChild(name);
                tmp.Value += val;
            }
        }
    }

    public class AccounterConfig
    {

    };

    public class AccounterWorkspace
    {
        public AccounterDatabase DataBase;
        public AccounterConfig Config;

        public AccounterWorkspace()
        {
            this.DataBase = new AccounterDatabase();
            this.Config = new AccounterConfig();
        }

        public static AccounterWorkspace OpenWorkspace(Stream input)
        {
            XmlSerializer ser = new XmlSerializer(typeof(AccounterWorkspace));
            AccounterWorkspace wp = (AccounterWorkspace)ser.Deserialize(input);
            wp.DataBase.rootCategory.InitTree();
            return wp;
        }

        public static AccounterWorkspace OpenWorkspace(string fileName)
        {
            AccounterWorkspace wp;

            FileStream f = new FileStream(fileName, FileMode.Open);
            wp = OpenWorkspace(f);
            f.Close();
            return wp;
        }

        public void SaveWorkspace(TextWriter output)
        {
            XmlSerializer ser = new XmlSerializer(typeof(AccounterWorkspace));
            ser.Serialize(output, this);
        }
        public void SaveWorkspace(string fname)
        {
           
            TextWriter writer = new StreamWriter(fname);
            SaveWorkspace(writer);
            writer.Close();
        }

        /// <summary>
        /// Import transactions from csv file.
        /// </summary>
        /// <param name="fileStream"> Stream containing the exported data lines. </param>
        /// <returns>List of the imported transactions.</returns>
        public List<Transaction> InportBankReport(StreamReader fileStream)
        {
            List<Transaction> result = new List<Transaction>();
            int lineNumber = 0;
            string line;
            
            while ((line = fileStream.ReadLine()) != null)
            {
                if (lineNumber > 0)
                {
                    // process data line
                    Transaction tr = new Transaction(line);
                    result.Add(tr);
                }
                lineNumber++;
            }
            return result;

        }

        /// <summary>
        /// Import transactions from csv file.
        /// </summary>
        /// <param name="fname">Path to the csv file containing the transaction data.</param>
        /// <returns> List of the imported transactions. </returns>
        public List<Transaction> InportBankReport(string fname)
        {
            List<Transaction> retVal;

            StreamReader fin = new StreamReader(fname);
            retVal = InportBankReport(fin);
            fin.Close();
            return retVal;
        }

        public void AssignCategory(List<Transaction> transactions)
        {
            foreach (CategoryDetector cd in DataBase.Detectors)
                cd.AssignCategory(transactions);
        }

        public Dictionary<string,int> GetCategoryReport(DateTime from, DateTime to, List<string> categories)
        {
            Dictionary<string, int> report = new Dictionary<string, int>();
            TransactionFilter filter = new TransactionFilter();

            filter.Filter_from = from;
            filter.Filter_to = to;
            foreach (string category in categories)
            {
                filter.Filter_category = category;
                report.Add(category, DataBase.GetSum(filter));
            }
            return report;
        }

        public Dictionary<string, int> GetCategoryReport(int year, int month, List<string> categories)
        {
            return GetCategoryReport(new DateTime(year, month, 1), new DateTime(year, month, DateTime.DaysInMonth(year, month)),categories);
        }

        public Dictionary<string, int> GetCategoryReport(int year, int month, string category)
        {
            List<string> cats = new List<string>();
            cats.Add(category);

            return GetCategoryReport(new DateTime(year, month, 1), new DateTime(year, month, DateTime.DaysInMonth(year, month)), cats);
        }

        public Dictionary<string,int> GetFullCategoryReport(int year, int month)
        {
            Dictionary<string, int> report = new Dictionary<string, int>();
            List<Transaction> trs = DataBase.GetTransactions(year, month);
            int sum;

            foreach(Transaction tr in trs)
            {
                string cat = tr.Category;

                while(cat != null)
                {
                    report.TryGetValue(cat, out sum);
                    report[cat] = sum + tr.Sum;
                    cat = GetParentCategory(cat);
                }
            }

            return report; 
        }

        public CategoryNode GetFullCategoryReportTree(int year, int month)
        {
            List<Transaction> trs = DataBase.GetTransactions(year, month);

            DataBase.rootCategory.InitTree();

            foreach (Transaction tr in trs)
            {
                DataBase.rootCategory.AddValueRecursively(tr.Category, tr.Sum);
            }

            return DataBase.rootCategory;
        }

        public Dictionary<DateTime, int> GetMonthlyReport(string category, DateTime from, DateTime to)
        {
            Dictionary<DateTime, int> report = new Dictionary<DateTime, int>();
            TransactionFilter filter = new TransactionFilter();
            DateTime selectedMonth = new DateTime(from.Year, from.Month, 1);

            filter.Filter_category = category;
            while(selectedMonth < to)
            {
                filter.Filter_from = new DateTime(selectedMonth.Year, selectedMonth.Month,1);
                filter.Filter_from = new DateTime(selectedMonth.Year, selectedMonth.Month,DateTime.DaysInMonth(selectedMonth.Year,selectedMonth.Month));
                report.Add(selectedMonth, DataBase.GetSum(filter));

                selectedMonth.AddMonths(1);
            }
            return report;

        }

        public string GetParentCategory(string category)
        {
            if (category == null) return null;

            if (category.Length <= 1) return category;

            int lastIdx;
            if (category.EndsWith("/"))
                lastIdx = category.LastIndexOf('/', category.Length-2);
            else
                lastIdx = category.LastIndexOf('/', category.Length-1);

            if (lastIdx <= 0) return null;
            else return category.Substring(0, lastIdx);
        }
    };

   

   


}
