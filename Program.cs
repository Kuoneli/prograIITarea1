// See https://aka.ms/new-console-template for more information
//Se solicita hacer un programa que calcule los aumentos salariales de los Tecnicos, operarios y profesionales.

//Precio por hora Operario 1600
//Precio por hora Tecnico 2300
//Precio por hora Profesional 3000

//Para manejar acumulados y promedios
double acumuladoOperarios = 0f, acumuladoTecnicos = 0f, acumuladoProfesionales = 0f, promedioOperarios = 0f, promedioTecnicos = 0f, promedioProfesionales = 0f;

//Opcion de menu y conteo de Operarios, Tecnicos y Profesionales
int opcion = 0, cOperarios = 0, cTecnicos = 0, cProfesionales = 0;

//Porcentajes de aumento segun el tipo
double operario = 0.15, tecnico = 0.10, profesional = 0.05;
string tipo = "";
do
{
    Console.WriteLine("Bienvenido al Sistema de calculo de Aumentos Salariales");
    Console.WriteLine("Aumeto para \n1 - Operario\n2 - Tecnico\n3 - Profesional\n4 - Salir");
    opcion = int.Parse(Console.ReadLine());
    if (opcion == 1)
    {
        cOperarios++;
        tipo = "Operario";
        acumuladoOperarios += proceso(operario, tipo);
        promedioOperarios = acumuladoOperarios / cOperarios;

    }
    else if (opcion == 2)
    {
        cTecnicos++;
        tipo = "Tecnico";
        acumuladoTecnicos += proceso(tecnico, tipo);
        promedioTecnicos = acumuladoTecnicos / cTecnicos;
    }
    else if (opcion == 3)
    {
        cProfesionales++;
        tipo = "Profesional";
        acumuladoProfesionales += proceso(profesional, tipo);
        promedioProfesionales = acumuladoProfesionales / cProfesionales;
    }
    else if (opcion == 4)
    {
        Console.WriteLine("Desgloce de Datos\n\n******");
        Console.WriteLine("Cantidad de Operarios {0}\nAcumulado Operarios {1}\nPromedio Operarios {2}\n******", cOperarios,acumuladoOperarios,promedioOperarios);
        Console.WriteLine("Cantidad de Tecnicos {0}\nAcumulado Tecnicos {1}\nPromedio Tecnicos {2}\n******", cTecnicos, acumuladoTecnicos, promedioTecnicos);
        Console.WriteLine("Cantidad de Profesionales {0}\nAcumulado Profesionales {1}\nPromedio Profesionale {2}\n", cProfesionales, acumuladoProfesionales, promedioProfesionales);
        Console.WriteLine("Saliendo del sistema");

    }
    else
    {
        Console.WriteLine("Opcion incorrecta\nIntente de Nuevo");
    }

} while (opcion != 4);


static double proceso(double aumento, string tipoEmpleado)
{
    int cedula = 123456;
    string nombre = "";
    double salarioOrdinario = 0, salarioB = 0, salarioN = 0, horas = 0, precioH = 0, pAumento = 0, caja = 0, pcaja = 0.0917;
    Console.WriteLine("Ingrese el numero de Cedula del Empleado");
    cedula = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el nombre del Empleado");
    nombre = Console.ReadLine();

    Console.WriteLine("Horas laboradas?");
    horas = double.Parse(Console.ReadLine());

    Console.WriteLine("Precio por hora");
    precioH = double.Parse(Console.ReadLine());

    salarioOrdinario = horas * precioH;
    pAumento = salarioOrdinario * aumento;
    salarioB = salarioOrdinario + pAumento;
    caja = salarioB * pcaja;
    salarioN = salarioB - caja;

    Console.WriteLine("************************************* Desgloce *************************************");
    Console.WriteLine("Cedula: {0}\nNombre: {1}\nTipo Empleado: {2}", cedula, nombre, tipoEmpleado);
    Console.WriteLine("Precio por hora: {0}\nHoras laboradas: {1}\nSalario Ordinario: {2}", precioH, horas, salarioOrdinario);
    Console.WriteLine("Aumento: {0}\nSalario Bruto: {1}\nDeduccion CCSS: {2}\nSalario Neto: {3}", pAumento, salarioB, caja, salarioN);
    Console.WriteLine("************************************* Fin *************************************");

    return salarioN;
}
