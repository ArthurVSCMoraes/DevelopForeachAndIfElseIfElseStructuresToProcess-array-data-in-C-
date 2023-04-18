//Utilizando código feito no projeto anterior
//Using code of the last project

using System;
Boolean repetir = true;
while (repetir)
{

    int examAssignments = 5;

    int[] sophiaNotes = { 90, 86, 87, 98, 100 };
    int[] andrewNotes = { 92, 89, 81, 96, 90 };
    int[] emmaNotes = { 90, 85, 87, 98, 68 };
    int[] loganNotes = { 90, 95, 87, 88, 96 };
    int[] beckyNotes = { 92, 91, 90, 91, 92 };
    int[] chrisNotes = { 84, 86, 88, 90, 92 };
    int[] ericNotes = { 80, 90, 100, 80, 90 };
    int[] gregorNotes = { 91, 91, 91, 91, 91 };

    int[] sophiaAllNotes = { 90, 86, 87, 98, 100, 94, 90 };
    int[] andrewAllNotes = { 92, 89, 81, 96, 90, 89 };
    int[] emmaAllNotes = { 90, 85, 87, 98, 68, 89, 89, 89 };
    int[] loganAllNotes = { 90, 95, 87, 88, 96, 96 };
    int[] beckyAllNotes = { 92, 91, 90, 91, 92, 92, 92 };
    int[] chrisAllNotes = { 84, 86, 88, 90, 92, 94, 96, 98 };
    int[] ericAllNotes = { 80, 90, 100, 80, 90, 100, 80, 90 };
    int[] gregorAllNotes = { 91, 91, 91, 91, 91, 91, 91 };
    Console.WriteLine("Student\t\tExam Score\t\tOverrall\tGrade\t\tExtra Credits");
    // Console.WriteLine(sophiaAllNotes[4]);

    string[] studentsNames = { "Sophia", "Andrew", "Emma", "Logan", "Becky", " Chris", "Eric", "Gregor" };
    int[] studentScore = new int[10];
    string studentGrading = "";
    int[] examCalScore = new int[10];
    foreach (string names in studentsNames)
    {
        string currentStudant = names;
        if (currentStudant == "Sophia")
        {
            studentScore = sophiaAllNotes;
            examCalScore = sophiaNotes;

        }
        else if (currentStudant == "Andrew")
        {
            studentScore = andrewAllNotes;
            examCalScore = andrewNotes;

        }
        else if (currentStudant == "Emma")
        {
            studentScore = emmaAllNotes;
            examCalScore = emmaNotes;

        }
        else if (currentStudant == "Logan")
        {
            studentScore = loganAllNotes;
            examCalScore = loganNotes;

        }
        else if (currentStudant == "Becky")
        {
            studentScore = beckyAllNotes;
            examCalScore = beckyNotes;
        }
        else if (currentStudant == "Chris")
        {
            studentScore = chrisAllNotes;
            examCalScore = chrisNotes;
        }
        else if (currentStudant == "Eric")
        {
            studentScore = ericAllNotes;
            examCalScore = ericNotes;
        }
        else if (currentStudant == "Gregor")
        {
            studentScore = gregorAllNotes;
            examCalScore = gregorNotes;
        }
        else
            continue;
            int examSum = 0;
            foreach (int examScore in examCalScore)
            {
                examSum += examScore;
            }
        decimal totalSum = 0;
        decimal studentGrade = 0;

        int gradedAssingments = 0;
        foreach (int score in studentScore)
        {
            gradedAssingments += 1;
            if (gradedAssingments <= examAssignments)
            {
                totalSum += score;
            }
            else
            {
                totalSum += score / 10;
            }
        }
        
        studentGrade = (decimal)(totalSum) / examAssignments;

        //Qualificia no método de notas americanas, com base em letras, as  notas dos alunos utilizando o studentGrade como variavel de chamada
        if (studentGrade >= 97)
        {
            studentGrading = "A+";
        }
        else if (studentGrade >= 93)
        {
            studentGrading = "A";
        }
        else if (studentGrade >= 90)
        {
            studentGrading = "A-";
        }
        else if (studentGrade >= 87)
        {
            studentGrading = "B+";
        }
        else if (studentGrade >= 83)
        {
            studentGrading = "B";
        }
        else if (studentGrade >= 80)
        {
            studentGrading = "B-";
        }
        else if (studentGrade >= 77)
        {
            studentGrading = "C+";
        }
        else if (studentGrade >= 73)
        {
            studentGrading = "C";
        }
        else if (studentGrade >= 70)
        {
            studentGrading = "C-";
        }
        else if (studentGrade >= 67)
        {
            studentGrading = "D+";
        }
        else if (studentGrade >= 63)
        {
            studentGrading = "D";
        }
        else if (studentGrade >= 60)
        {
            studentGrading = "D-";
        }
        else
        {
            studentGrading = "F";
        }
        decimal examCalFinal = 0;
        examCalFinal = (decimal)examSum /5;
        decimal extraDifference = (examCalFinal - studentGrade) * -1;
        int extra = (int)examCalFinal;
        Console.WriteLine($"{names}\t\t{examCalFinal}\t\t\t{studentGrade}\t\t{studentGrading}\t\t{extra}({extraDifference}PTS)");

    }
    Console.WriteLine("Press the Enter key to continue or ESC for exit");
    Console.ReadLine();


}