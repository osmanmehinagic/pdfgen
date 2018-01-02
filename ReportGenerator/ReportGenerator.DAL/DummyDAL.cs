using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReportGenerator.DataObjects;

namespace ReportGenerator.DAL
{
    public class DummyDAL
    {
        public IList<DummyObject> GetDummyObjects(int numberOfItems)
        {
            IList<DummyObject> dummyList = new List<DummyObject>();

            for (int i = 0; i < numberOfItems; i++)
            {
                PopulateDummyList(dummyList, i);
            }

            return dummyList;
        }

        private void PopulateDummyList(IList<DummyObject> dummyList, int points)
        {
            DummyObject dummyObject = new DummyObject
            {
                FirstName = "Osman",
                LastName = "Mehinagic",
                CityName = "Zenica",
                State = "Bosnia and Herzegovina",
                Points = points
            };

            dummyList.Add(dummyObject);
        }
    }
}
