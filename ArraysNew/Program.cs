using System.ComponentModel.DataAnnotations;
using static System.Formats.Asn1.AsnWriter;

namespace ArraysNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("Chicago", "WhiteHill", 20, 7);
            Person person1 = new Person("Tom", "Smith", address1);
            SubjectScore[] subjectScore1 = {new SubjectScore(90, "Math"),
            new SubjectScore(70, "Physics"), new SubjectScore(95, "Literature"),
            new SubjectScore(98, "Language")};
            CandidateInfo candidate1 = new CandidateInfo(person1, subjectScore1);

            Address address2 = new Address("Miami", "GoldBridge", 15, 5);
            Person person2 = new Person("Den", "Braun", address2);
            SubjectScore[] subjectScore2 = {new SubjectScore(85, "Math"),
             new SubjectScore(79, "Physics"), new SubjectScore(83, "Literature"),
             new SubjectScore(91, "Language")};
            CandidateInfo candidate2 = new CandidateInfo(person2, subjectScore2);

            Address address3 = new Address("Boston", "SunRise", 3, 99);
            Person person3 = new Person("Govard", "Fray", address3);
            SubjectScore[] subjectScore3 = {new SubjectScore(88, "Math"),
             new SubjectScore(93, "Physics"), new SubjectScore(69, "Literature"),
             new SubjectScore(77, "Language")};
            CandidateInfo candidate3 = new CandidateInfo(person3, subjectScore3);

            Address address4 = new Address("Washington", "BlueValley", 77, 55);
            Person person4 = new Person("Brian", "Ortega", address4);
            SubjectScore[] subjectScore4 = {new SubjectScore(94, "Math"),
             new SubjectScore(81, "Physics"), new SubjectScore(77, "Literature"),
             new SubjectScore(93, "Language")};
            CandidateInfo candidate4 = new CandidateInfo(person4, subjectScore4);

            Address address5 = new Address("SanAntonio", "DragonEye", 6, 3);
            Person person5 = new Person("Tom", "Smith", address5);
            SubjectScore[] subjectScore5 = {new SubjectScore(75, "Math"), new SubjectScore(89, "Physics"),
            new SubjectScore(89, "Literature"), new SubjectScore(99, "Language")};
            CandidateInfo candidate5 = new CandidateInfo(person5, subjectScore5);

            CandidateInfo[] candidates = { candidate1, candidate2, candidate3, candidate4, candidate5 };

            foreach (CandidateInfo candidate in candidates)
            {
                Console.WriteLine(candidate.Person.Address.Street);
            }

            static int GetMaxScore(CandidateInfo[] candidates, string subjectName)
            {
                int ScoreMax = 0;
                foreach (CandidateInfo candidate in candidates)
                {
                    int score = GetScoreForSubject(candidate, subjectName);
                    
                    if (ScoreMax < score)
                    {
                        ScoreMax = score;
                    }                  
                }
                return ScoreMax;
            }

            static int GetScoreForSubject (CandidateInfo candidate, string subjectName)
            {               
                foreach (SubjectScore subjectScore in candidate.subjectScores)
                {                   
                    if (subjectScore.SubjectName == subjectName)
                    {
                        return subjectScore.Score;                                
                    }                
                }
                return -1; //while instead of exception 
            }

             Console.WriteLine(GetMaxScore(candidates, "Physics"));
             Console.WriteLine(GetMaxScore(candidates, "Math"));
             Console.WriteLine(GetMaxScore(candidates, "Literature"));
             Console.WriteLine(GetMaxScore(candidates, "Language"));
        }
    }
}