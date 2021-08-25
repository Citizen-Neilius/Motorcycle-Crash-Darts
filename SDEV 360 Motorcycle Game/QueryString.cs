using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;




// Neil Little -  SDEV 360 - 
// Final Project: 
// 01 May 2020


namespace SDEV_360_Motorcycle_Game
{
    class QueryString
    {
        public enum QueryType
        {
            Insert = 1,
            Update = 2,
            Delete = 3,
            ReturnData = 4
        };


        private const string sSqlQuotDelimComma = "','";
        private const string sSqlEndStringQuot = "')";


        //Get Records
        private const string sGetMembers = "Select Id, FirstName, Score From UserInfo";

        //Insert Statements
        // private const string sMemberInsert = "Insert into Member (FirstName, LastName, DateOfBirth,SocialSecurityNumber) Values (@FirstName,@LastName,@DateOfBirth,@SocialSecurityNumber) SET @ID = SCOPE_IDENTITY();  ('";
        private const string sMemberInsert = "Insert into UserInfo (FirstName, Score) Values('";
        //Delete Statements
        private const string sDeleteMember = "Delete from UserInfo Where Id = ";


        //Update Statements
        //The update statements are simplistic for the demo. They update everything in the row, except the keys. Update statements
        //can be created to only update information that changed, but that requires a great deal of code and is beyond the scope of this course.
        //The number at the end of the variable name is the order in which to concatenate them for the query. 
        private const string sUpdateMember1 = "Update UserInfo Set FirstName = ' ";
        private const string sUpdateMemberScore2 = "', Score = '";
        //private const string sUpdateMemberDOB3 = "', DateOfBirth = '";
        //private const string sUpdateMemberSSN4 = "', SocialSecurityNumber ='";
        private const string sUpdateMemberWhere5 = "' Where Id =";

        //The Query type is the only mandatory input parameter. The rest are not mandatury due to the different types of queries. This
        //could also be done with multiple methods. Note how the DateTime syntax is different for default.
        public string BuildMemberQuery(QueryType query, string FirstN = "", string Id = "", string Score = "")
        {


            switch (query)
            {
                case QueryType.Insert:
                    {
                        //SSN = SSN.Replace("-", string.Empty);
                        string tmp = sMemberInsert + FirstN + sSqlQuotDelimComma + Score +sSqlEndStringQuot;
                        return tmp;
                    }

                case QueryType.Update:
                    {
                        //SSN = SSN.Replace("-", string.Empty);
                        return sUpdateMember1 + FirstN + sUpdateMemberScore2 + Score+ sUpdateMemberWhere5 + Id;
                    }
                case QueryType.Delete:
                    {
                        return sDeleteMember + Id;
                    }
                case QueryType.ReturnData:
                    {

                        return sGetMembers;
                    }
                default:
                    {
                        return "";
                    }

            }



        }//End BuildMemberQuery





    }
}