using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_DAL;


namespace StylesProject.BLL
{
    public class ServiceOperator
    {
        public List<Table_Operator> GetOperators()
        {
            using (Model1 db = new Model1())
            {
                return db.Table_Operator.ToList();
            }
        }
    }
}
