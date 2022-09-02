int bolasvai=0;
int totalvai=0;
int bolaschoco=0;
int totalcho=0;
int bolasfre=0;
int totalfre=0;
int bolasbrow=0;
int totalbrow=0;
int bolasron=0;
int totalron=0;
int respuesta=0;
do
{
	Console.WriteLine ("Hola buenos días");
	Console.WriteLine ("Que helado quieres hoy?");
	Console.WriteLine ("1. Vainilla");
	Console.WriteLine ("2. Chocolate");
	Console.WriteLine ("3. Fresa");
	Console.WriteLine ("4. Brownie");
	Console.WriteLine("5. Ron con pasas");
	Console.WriteLine ("6. Salir");
	respuesta =Convert.ToInt32(Console.ReadLine());

       switch (respuesta)
{
		case 1:
			Console.WriteLine ("Son 1000 por bola");
			Console.WriteLine ("Cuantas bolas de vainilla quieres?");
			 bolasvai = Convert.ToInt32(Console.ReadLine());
			 totalvai=bolasvai*1000;
                     break;
		case 2:
			Console.WriteLine ("Son 1000 por bola");
			Console.WriteLine ("Cuantas bolas de chocolate quieres?");
			bolaschoco = Convert.ToInt32(Console.ReadLine());
		        totalcho=bolaschoco*1000;
                     break;
		case 3:
			Console.WriteLine ("Son 1000 por bola");
			Console.WriteLine ("Cuantas bolas de fresa quieres");
			 bolasfre = Convert.ToInt32(Console.ReadLine());
			 totalfre=bolasfre*1000;
                     break;

		case 4:   
			Console.WriteLine ("Son 1000 por bola");
			Console.WriteLine ("Cuantas bolas de brownie quieres?");
			 bolasbrow = Convert.ToInt32(Console.ReadLine());
			totalbrow=bolasbrow*1000;
                     break;
		case 5:
			Console.WriteLine ("Son 1000 por bola");
			Console.WriteLine ("Cuantas bolas de ron con pasas quieres?");
                     bolasron = Convert.ToInt32(Console.ReadLine());
			totalron=bolasron*1000;
                     break;
		case 6:     
			Console.WriteLine ("Que tenga un buen día");
                     break;
}
	
	int total=totalbrow+totalcho+totalfre+totalron+totalvai;
	Console.WriteLine("Su total sería de: "+total);
	Console.WriteLine ("Presione ENTER para continual");
}while (respuesta!=6);
