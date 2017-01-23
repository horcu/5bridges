using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using WebApplication.Db;
using WebApplication.Interfaces;

namespace WebApplication.Models
{
    public class CountiesRepository : ICountiesRepository
    {
        private readonly MdDbContext _context;

        public CountiesRepository()
        {
            _context = new MdDbContext();

        }

        //would usually use this code to do seeding in the initializer but for brevity I'll do it here

        readonly List<MarylandCounties> _counties = new List<MarylandCounties>
        {
            new AnnArundel(1,"Ann Arundel", @"The County was named for Lady Ann Arundell, (1615/1616–1649),
                                                         the daughter of Thomas Arundell, 1st Baron Arundell of Wardour,
                                                         members of the ancient family of Arundells in Cornwall, England.
                                                         She married Cecilius Calvert, second Lord Baltimore, (1605–1675),
                                                           and the first Lord Proprietor of the colony, Province of Maryland,
                                                         in an arranged marriage contract in 1627 or 1628.
                                                          Anne Arundel County (modern spelling adds an 'e' to her first name of 'Ann'
                                                         and removes the second 'L' from the family name of 'Arundell' – but the old
                                                          traditional spelling of her name is still used in the title of the local historical
                                                         society, the Ann Arundell County Historical Society) was originally part of St. Mary's
                                                         County in the southern portion of the Province of Maryland which had first been settled
                                                         by the arriving settlers in 1634. In 1650, the year after Lady Ann Arundell's death, the County
                                                        separated from St. Mary's and 'erected' into its own jurisdiction and became the 3rd of the 23 Maryland
                                                         counties. Between 1654 and 1658, the County was known as 'Providence' by many of its early settlers.[citation needed]",537656),

            new Baltimore(2,"Baltimore",@"The earliest known documentary record of the county politically in the Maryland State Archives in the Hall of Records in the state capital of Annapolis is January 12, 1659, when a writ was issued on behald of the General Assembly of Maryland to its sheriff and is considered by historians to be its official year of 'erection' (founding/establishment date) among the now twenty-three counties of the State, as it assumes that a certain amount of organization and appointments in the middle 17th Century had already occurred. Previously, Old Baltimore County was more known as a geographical entity than a political one, with its territorial limits consisting of most of northeastern Maryland, then the northwestern frontier of the Province and included the present day jurisdictions of Baltimore City, Cecil, and Harford Counties, as well as parts of Carroll, Anne Arundel, Frederick, Howard, and Kent Counties. In 1674, a proclamation of the Proprietor, established the then extensive boundary lines for old Baltimore County. Over the next century, various segments of the Old County were sliced off as population and settlements increased in the fringe regions so as to have a shorter distance to newly established county seats with their courts and commercial businesses.",831128),

            new Harford(3,"Harford", @"Harford County was formed in 1773 from the eastern part of Baltimore County. It contains Tudor Hall, birthplace of Abraham Lincoln's assassin, John Wilkes Booth. Harford County also hosted the signers of the Bush Declaration, a precursor document to the American Revolution.
                                                  The county was named for Henry Harford (ca. 1759–1834), the illegitimate son of Frederick Calvert, 6th Baron Baltimore. Henry Harford was born to Calvert's mistress, Hester Whelan, whose residence still stands as part of a private residence on Jarretsville Pike, in Phoenix, Maryland. Harford served as the last Proprietary Governor of Maryland but, because of his illegitimacy, did not inherit his father's title.",244826),

            new Montgomery(4,"Montgomery", @"Before European immigration, the land now known as Montgomery County was covered in a vast swath of forest crossed by the creeks and small streams that feed the Potomac and Patuxent rivers. A few small villages of the Piscataway, members of the Algonquian people, were scattered across the southern portions of the county. North of the Great Falls of the Potomac, there were few permanent settlements, and the Piscataway shared hunting camps and foot paths with members of rival peoples like the Susquehannocks and the Senecas.
                                                        Captain John Smith of the English settlement at Jamestown was probably the first European to explore the area, during his travels along the Potomac River and throughout the Chesapeake region", 971777),

            new PrinceGeorge(5, "Prince George", @"The official name of the county, as specified in the county's charter, is 'Prince George's County, Maryland'.[6] The county is named after Prince George of Denmark (1653–1708), the husband of Anne, Queen of Great Britain, and the brother of King Christian V of Denmark and Norway. The county's demonym is Prince Georgian and its motto is Semper Eadem (English: 'Ever the Same'), a phrase used by Queen Anne. Prince George's County is frequently referred to as 'P.G.' or 'P.G. County', an abbreviation viewed as pejorative by some residents", 863420)
        };

        public async Task<ICounty> GetCountyByIndex(int id)
        {
            //todo add tpl here to make  truely async
            ICounty county = new NullCounty();
            var result = Task.Factory.StartNew(() =>
            {
                county = _context.Counties.ElementAt(id); // _counties.ElementAt(id);
            });

            await result;
            return county;
        }

        public async  Task<ICounty> GetCountyByName(string name)
        {
            //todo add tpl here to make  truely async
            ICounty county = new NullCounty();
            var result = Task.Factory.StartNew(() =>
            {
                county =
                    _context.Counties.FirstOrDefault(
                        c => c.Name.Equals(name));
                  //  _counties.FirstOrDefault(b => b.Name.Equals(name));
            });

            await result;
            return county;
        }
    }
}