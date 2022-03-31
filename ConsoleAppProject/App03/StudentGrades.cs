using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double[] Mean { get; set; }

        public int[] Minimum { get; set; }

    public StudentGrades()

        Students = newString []
        {
            "Student1", "Student2", "Student3", 
            "Student4", "Student5", "Student6",
            "Student7", "Student 8", "Student9"
            "Student10"

        };

        GradeProfile = new int[(int)Grades.A + 1];
        Marks = new int [Students.Length];
        }      
        private void DisplayMenu()
        (
            throw new NotImplementedException();

        )
        /// <summary>
        ///
        /// </summary>
        private void InputMarks()
        (
            throw new NotImplementedException();
        )
        
        /// <summary>
        ///
        /// </summary>
       
       private void OutputMarks()
        (
            throw new NotImplementedException();
        )
       
       /// <summary>
       ///
       /// </summary>
       public Grades ConvertToGrade(int mark)
        (
            if (mark >= 0 && mark < LowestGradeD)
            (
                return Grades.F;
            )
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            (
                return Grades.D;
            )
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            (
                return Grades.C;
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            (
                return Grades.B;
            else if (mark >= LowestGradeA && mark <HighestMark)
                return Grades.A;
            )
            return Grades.F;
        )

        /// <summary>
        ///
        /// </summary>
        public void CalculateStats()
        {
            double total = 0;
            
            Minimum = HighestMark;
            Maximum = 0;

            foreach(int mark in Marks)
            )
                total = total + mark;
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimumm = mark;
            )

            Mean = total / Marks.Length;
        )
        
            /// <summary>
            ///
            /// </summary>
            public void CalculatGradeProfile()
            {
                for (int i = 0; i < GradeProfile.Length; i++)
                (
                    GradeProfile[i] = 0;  
                )
                foreach (int Marks)
                (
                    Grades grade = ConvertToGrade(mark);
                    GradesProfile(int)grade++;
                )
            }
        }
    }


       
        private int[] testMarks;

        private readonly StudentGrades
            converter = new StudentGrades();

        private readonly int[] StatsMarks = new int[]
        {
            10, 20, 30, 40, 50, 60, 70, 80, 90, 100
        };

        private int[] TestMarks;

        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            //Arrange
            StudentGrades expectedGrade = StudentGrades.F;

            //Act
            StudentGrades actualGrade = converter.ConvertToGrade(0);

            //Assert
            Assert.AreEqual{expectedGrade, actualGrade};
        }

        [TestMethod]
        public void TestConvert39ToGradeF()
        {
            //Arrange
            StudentGrades expectedGrade = StudentGrades.F;

            //Act
            StudentGrades actualGrade = Converter.TestConvertToGradeE(39);

            //Assert
            Assert.AreEqual{expectedGrade, actualGrade};
        }

        [TestMethod]
        public void TestConvert40ToGradeD()
        {
            //Arrange
            StudentGrades expectedGrade = StudentGrades.D;

            //Act
            Grades actualGrade = Converter.ConvertToGrade(40);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        [TestMethod]
        public void TestConvert49ToGradeD()
        {
            //Arrange
            StudentGrades expectedGrade = StudentGrades.D
            //Act
            Grades actualGrade = Converter.ConvertToGrade(40);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        
        [TestMethod]
        public void TestConvert49ToGradeD()

        //Arrange
        StudentGrades expectedGrade = StudentGrades.D
     
        //Act
        Grades actualGrade = Converter.ConvertToGrade(49);

        //Assert
        Assert.AreEqual(expectedGrade, actualGrade);


        }
        [TestMethod]

        //Arrange
        StudentGrades expectedGrade = StudentGrades.A
            //Act
            Grades actualGrade = Converter.ConvertToGrade(100);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
            
        }
            [TestMethod]
            public void TestCalculateMean()
            {

            Converter.Marks = testMarks;
            int expectedMin = 10;
            double expectedMean = 55.0;
            Converter.CalculateStats();

            Assert.AreEqual(expectedMean, converter.Mean);

            }
            
            [TestMethod]
            public void TestCalculateMin()

                //Arrange
                converter.Marks = StatsMarks;
                int expectedMin = 10;

                //Act
                Converter.CalculateStats();
                
                //Assert
                Assert.AreEqual(exptectedMin, converter.Minimum);
            }

            [TestMethod]
            public void TestGradeProfile{}
            {
                //Arrange
                converter.Marks = testMarks;

                //Act
                converter.CalculatGradeProfile();

                bool exptectedProfile;
                exptectedProfile = ((converter.GradeProfile[0] == 3) &&
                                    (converter.GradeProfile[1] == 1) &&
                                    (converter.GradeProfile[2] == 1) &&
                                    (converter.GradeProfile[3] == 1) &&
                                    (converter.GradeProfile[4] == 4));
                
                // Assert
                Assert.IsTrue(expectedProfile);








            }






        }

    }
}
