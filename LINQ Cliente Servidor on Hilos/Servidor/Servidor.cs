// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 01/07/2016.                                                                              *
// ******************************************************************************************


using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using ObjetoRemoto;
using System.Linq;
using System.Text;
using System;

namespace Servidor
{
    class Servidor
    {
        //Indica que el modelo de subprocesos COM para la aplicación es el apartamento de un único subproceso
        [STAThread]
        static void Main(string[] args)
        {
            //Implementa un canal de cliente para las llamadas a distancia que utiliza el protocolo HTTP para transmitir mensajes.
            HttpChannel canal = new HttpChannel(30000);
            //Registrando el canal HTTP
            ChannelServices.RegisterChannel(canal, false);
            Console.WriteLine("Iniciando el servidor puede tardar unos segundos...");
           //Configurando el objeto remoto de la libreria Objetoremo.objetoremoto usando Singleton
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ObjetoRemoto.ObjetoRemoto), "ObjetoRemoto.Objetoremoto", WellKnownObjectMode.Singleton);
            Console.WriteLine("Presione ENTER para concluir...");
            Console.ReadLine();
        }
    }
}