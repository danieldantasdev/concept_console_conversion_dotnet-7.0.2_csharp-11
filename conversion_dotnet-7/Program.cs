//conversion implicit

var noteStudent = 10;
double noteStudentDoubleConversionImplicit = noteStudent;

//conversion explicit

int noteStudentDoubleConversionExplicit = (int)noteStudentDoubleConversionImplicit;

//Convert

string noteString = "10j";
int noteConvert = Convert.ToInt32(noteString);

//Parse

int noteParse = int.Parse(noteString);

if (int.TryParse(noteString, out int noteTryParse))
{
    Console.Write(noteTryParse);
}
else
{
    Console.Write("Número em fórmato inválido");
}

// Console.Write(noteParse);