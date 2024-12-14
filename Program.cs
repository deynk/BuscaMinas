using System;
public class bsuscaMinas{
    public static string[,] setearMapa(string[,] mapa){
        mapa[0, 0]=" ";
        char c='a';  //indice columna
        for(int i=1; i<27; i++){  //Establece el identificador de columna (a,b,c,d,...) y el identificador de fila (1,2,3,...) dentro del mapa
            mapa[0, i]=c.ToString(); //  Columna
            mapa[i, 0]=i.ToString();  // Fila
            c++;
        }

        Random random = new Random();
        for(int i=1; i<27; i++){  //Planta las minas
            for(int j=1; j<27; j++){
                mapa[i,j]=random.Next(10)==0 ? "m" : " ";
            }
        }

        return mapa;
    }

    public static void muestraMapa(string[,] mapa){
        int n;
        Console.WriteLine("|");
        for(int i=0; i<27; i++){
            for(int j=0; j<27; j++){
                
                int.TryParse(mapa[i,j], out n);
                if(j==0 && n<10) Console.Write($"{mapa[i,j],2}");
                else
                Console.Write(mapa[i,j]);
                if(j==26) Console.WriteLine("|");
            }
        }
    }

    public static void Main(string[] args){
        string[,] mapa = new string[27,27];  //Este será el mapa
        setearMapa(mapa);
        muestraMapa(mapa);
    }
    
}