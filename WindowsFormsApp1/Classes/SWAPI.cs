using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;

namespace WindowsFormsApp1.Classes
{
    class SWAPI
    {
        SldWorks swApp = default(SldWorks);

        int ProcessID = 0;

        public void AbrirSolidworks(bool Visivel, int Versao)
        {
            try
            {
                swApp = Activator.CreateInstance(Type.GetTypeFromProgID($"SldWorks.Application.{Versao.ToString()}")) as SldWorks;
                swApp.Visible = Visivel;
                ProcessID = swApp.GetProcessID();


                 
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao abrir o Solidworks: {ex.Message}\n{ex.StackTrace}");
            }

        }

        public void FecharSolidworks()
        {
            try
            {
                Process[] processos = Process.GetProcesses();
                var sldworks = processos.FirstOrDefault(x => x.Id == ProcessID);
                sldworks.Kill(0);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao fechar o Solidworks: {ex.Message}\n{ex.StackTrace}");
            }
        }

    }
}
