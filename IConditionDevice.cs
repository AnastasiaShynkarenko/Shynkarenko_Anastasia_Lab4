using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    interface IConditionDevice
    {
        void TurnOn();
        void TurnOff();
        string GetInfo();
    }
}
