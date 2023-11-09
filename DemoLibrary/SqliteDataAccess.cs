using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SqliteDataAccess
    {
        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("select * from Person", new DynamicParameters());
                return output.ToList();
            }
        }

        public static int SavePerson(PersonModel person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Person (UserId) values (@UserId)", person);
                List<PersonModel> output= cnn.Query<PersonModel>($"select id from Person where UserId = '{person.UserId}'").ToList();
                return output[0].Id;
            }
        }

        public static int SearchPerson(PersonModel person)
        {
            int qryCount = 0;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
               qryCount = cnn.Query($"select id from Person where UserId = '{person.UserId}'").Count();
               return qryCount;
                
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<QuestionsModel> LoadSecurityQuestions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<QuestionsModel>("select * from Questions", new DynamicParameters());
                return output.ToList();
            }
        }

        public static String SaveSecurityAnswers(List<SecAnswersModel> lstAnswers, String varUserName)
        {
            PersonModel p = new PersonModel();
            p.UserId = varUserName;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                using (var tran = cnn.BeginTransaction())
                {
                    cnn.Execute("insert into Person (UserId) values (@UserId)", p);
                    List<PersonModel> output = cnn.Query<PersonModel>($"select id from Person where UserId = '{p.UserId}'").ToList();
                    int personID = output[0].Id;
                    try
                    {
                        for (int i = 0; i < lstAnswers.Count; i++)
                        {
                            lstAnswers[i].PersonId = personID;
                            cnn.Execute("insert into SecAnswers(PersonId, QuestionId, Answer) values (@PersonId,@QuestionId,@Answer)", lstAnswers[i]);
                        }
                        tran.Commit();

                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        return ex.Message;
                    }
                    finally
                    {
                        tran.Dispose();
                    }
                }
                return "Success";
            }
        }



        public static String updateSecurityAnswers(List<SecAnswersModel> lstAnswers, int varUserName)
        {
            int UserId = varUserName;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                using (var tran = cnn.BeginTransaction())
                {
                    cnn.Execute($"delete from SecAnswers where PersonId= '{UserId}'");
                    
                    try
                    {
                        for (int i = 0; i < lstAnswers.Count; i++)
                        {
                            lstAnswers[i].PersonId = UserId;
                            cnn.Execute("insert into SecAnswers(PersonId, QuestionId, Answer) values (@PersonId,@QuestionId,@Answer)", lstAnswers[i]);
                        }
                        tran.Commit();

                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        return ex.Message;
                    }
                    finally
                    {
                        tran.Dispose();
                    }
                }
                return "Success";
            }
        }

        public static List<SecAnswersModel> GetSecurityQuestionAnswers(String userId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SecAnswersModel>($"Select T3.Id PersonId, T1.Id QuestionId, Answer, Question from Questions T1, SecAnswers T2, Person T3 where T1.Id=T2.QuestionId and T3.Id=T2.PersonId and T3.UserId='{userId}'");
                return output.ToList();
            }
        }
    }
}
