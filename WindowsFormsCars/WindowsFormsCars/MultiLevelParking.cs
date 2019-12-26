using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsCars
{
    class MultiLevelParking
    {
        int pictureWidth;
        int pictureHeight;

        List<Parking<ITransport>> parkingStages;
        private const int countPlaces = 20;

        public MultiLevelParking(int countStages, int pw, int ph)
        {
            pictureWidth = pw;
            pictureHeight = ph;

            parkingStages = new List<Parking<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                //Записываем количество уровней
                sw.WriteLine("CountLeveles:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    //Начинаем уровень
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        try
                        {
                            var car = level[i];
                            if (car != null)
                            {
                                //если место не пустое
                                //Записываем тип мшаины
                                if (car.GetType().Name == "Tractor")
                                {
                                    sw.Write(i + ":Tractor:");
                                }
                                if (car.GetType().Name == "ExcavatorTractor")
                                {
                                    sw.Write(i + ":ExcavatorTractor:");
                                }
                                //Записываемые параметры
                                sw.WriteLine(car);
                            }
                        }
                        finally { }
                    }
                }
            }
            return true;
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            int level = -1;
            using (StreamReader fs = new StreamReader(filename))
            {
                string temp = fs.ReadLine();
                if (temp.Contains("CountLeveles:"))
                {
                    if (parkingStages != null)
                    {

                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport>>();
                }
                else
                {
                    throw new Exception("Неверный формат файла");
                }

                while (!fs.EndOfStream)
                {
                    temp = fs.ReadLine();
                    if (temp.Contains("Level"))
                    {
                        parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        level++;
                    }
                    else if (temp.Contains("Tractor") || temp.Contains("ExcavatorTractor"))
                    {
                        int index = Convert.ToInt32(temp.Split(':')[0]);
                        ITransport tractor = null;
                        if (temp.Contains("ExcavatorTractor"))
                        {
                            tractor = new ExcavatorTractor(temp.Split(':')[2]);
                        }
                        else
                        {
                            tractor = new Tractor(temp.Split(':')[2]);
                        }
                        parkingStages[level][index] = tractor;
                    }
                }
            }
            return true;
        }

        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

        public void Sort()
        {
            parkingStages.Sort();
        }
    }
}
