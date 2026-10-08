using System;

public class Roubo{
        static void Main()
        {    
                string []   bairros ={
                        "Centro","Moema", "Pinheiros","Itaquera",  "Tatuapé", "Santo Amaro", "Vila Mariana",
    "Lapa","Capão Redondo", "Santana"
                };   
                
                int[] roubos = {350,120,210,480,190,310,150,280,520,240};
                double media = calcularMedia(roubos);

                Console.WriteLine("media de roubos por bairro:"+media.ToString("F2"));
                exibirTop3BairrosViolentos(bairros,roubos);
        }
        static double calcularMedia (int[]roubos)
        {
            double soma =0;
                for (int i=0;i<roubos.Length;i++)
                {
                    soma =soma  + roubos [i]; 
                }
                return soma/roubos.Length;        
        }       
        
        static void exibirTop3BairrosViolentos(string[]bairros, int[] roubos) 
        {
            int primeiro = -1;  
            int segundo = -1;  
            int terceiro = -1;  

                for (int i = 0 ;i<roubos.Length;i++)
                {
                        if(primeiro == -1 || roubos[i] > roubos[primeiro])
 {
        terceiro  = segundo;
        segundo  = primeiro;
        primeiro = i;                       
 }
   else if (segundo == -1 || roubos [i] >roubos[segundo])
   {
           terceiro =segundo;
           segundo = i;       
           }
                        else if (terceiro == -1 || roubos [i] >roubos[terceiro])
   {
           terceiro =i;
               
           }
              }
 Console.WriteLine ("primeiro lugar:"+bairros[primeiro]+"(indice"+primeiro +")-"+roubos[primeiro]+"roubos");
 Console.WriteLine ("segundo lugar:"+bairros[segundo]+"(indice"+segundo +")-"+roubos[segundo]+"roubos"); 
Console.WriteLine ("terceiro lugar:"+bairros[terceiro]+"(indice"+terceiro +")-"+roubos[terceiro]+"roubos");
        }
}
