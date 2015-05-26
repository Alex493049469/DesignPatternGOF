using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternGOF
{
    //Шаблон фасад (англ. Facade) — структурный шаблон проектирования, 
    //позволяющий скрыть сложность системы путем сведения всех возможных внешних вызовов к одному объекту,
    //делегирующему их соответствующим объектам системы.

    /* Различные  подсистемы*/

    internal class CPU
    {
        public void freeze()
        {
            MessageBox.Show("CPU freeze");
        }

        public void jump()
        {
            MessageBox.Show("CPU jump");
        }

        public void execute()
        {
            MessageBox.Show("CPU execute");
        }
    }

    internal class Memory
    {
        public void load(string str)
        {
            MessageBox.Show("Memory loaded " + str);
        }
    }

    internal class HardDrive
    {
        public string read()
        {
          return "HardDrive read";
        }
    }

    /* Фасад */

    internal class Computer
    {
        private CPU cpu;
        private Memory memory;
        private HardDrive hardDrive;

        public Computer()
        {
            this.cpu = new CPU();
            this.memory = new Memory();
            this.hardDrive = new HardDrive();
        }

        public void startComputer()
        {
            cpu.freeze();
            memory.load(hardDrive.read());
            cpu.jump();
            cpu.execute();
        }

    }
}
