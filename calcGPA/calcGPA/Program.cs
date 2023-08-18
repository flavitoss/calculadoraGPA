Console.WriteLine("Insira o nome do aluno: ");
//aluno

string studentName = Console.ReadLine();

//disciplinas

string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

//creditos
Console.WriteLine("insira a quatidade de crédito de cada curso (somente 3 ou 4): ");

int course1Credit = int.Parse(Console.ReadLine());
int course2Credit = int.Parse(Console.ReadLine());
int course3Credit = int.Parse(Console.ReadLine());
int course4Credit = int.Parse(Console.ReadLine());
int course5Credit = int.Parse(Console.ReadLine());


//notas

var gradeA = 4;
var gradeB = 3;

var englishGrade = gradeA;
var algebraGrade = gradeB;
var biologyGrade = gradeB;
var csGrade = gradeB;
var psychoGrade = gradeA;

//pontuação

var course1Points = course1Credit * englishGrade;
var course2Points = course2Credit * algebraGrade;
var course3Points = course3Credit * biologyGrade;
var course4Points = course4Credit * csGrade;
var course5Points = course5Credit * psychoGrade;

//horas totais

var totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

//GPA TOTAL

var pontuacaoTotal = course1Points + course2Points + course3Points + course4Points + course5Points;

decimal valorGPA = (decimal) pontuacaoTotal /totalCreditHours;




if (course1Credit == 3 || course1Credit == 4 && course2Credit == 3 || course2Credit == 4 && course3Credit == 3 || course3Credit == 4 && course4Credit == 3 || course4Credit == 4 && course5Credit == 3 || course5Credit == 4)
{
   

    Console.WriteLine($"Curso: {course1Name}     Nota: {englishGrade}    créditos:  {course1Credit}    pontuação:   {course1Points}");
    Console.WriteLine($"Curso: {course2Name}     Nota: {algebraGrade}    créditos:  {course2Credit}    pontuação:   {course2Points}");
    Console.WriteLine($"Curso: {course3Name}     Nota: {biologyGrade}    créditos:  {course3Credit}    pontuação:   {course3Points}");
    Console.WriteLine($"Curso: {course4Name}     Nota: {csGrade}         créditos:  {course4Credit}    pontuação:   {course4Points}");
    Console.WriteLine($"Curso: {course5Name}     Nota: {psychoGrade}     créditos:  {course5Credit}    pontuação:   {course5Points}");

    Console.WriteLine($"Horas totais de crédito: {totalCreditHours}");
    Console.WriteLine($"GPA total: {valorGPA}");
}
else
{ Console.WriteLine("valores inválidos, tente novamente. "); }











