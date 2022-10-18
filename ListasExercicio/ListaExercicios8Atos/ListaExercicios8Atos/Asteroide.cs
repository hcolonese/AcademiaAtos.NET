using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios8Atos
{
    public class Asteroide
    {
        private float _x, _y;
        private int _tam, _vel, _energia;
        public Asteroide() { }
        public Asteroide(float x, float y)
        {
            this._x = x;
            this._y = y;
        }
        public Asteroide(float x, float y, int tam, int vel, int energia)
        {
            this._x = x;
            this._y = y;
            if (tam < 0) { tam = 1; }
            if (tam > 10) { tam = 10; }
            this._tam = tam;
            if (vel < 0) { vel = 1; }
            if (vel > 5) { vel = 5; }
            this._vel = vel;
            if (energia < 0) { energia = 1; }
            if (energia > 5) { energia = 5; }
            this._energia = energia;
        }
        public float X { get => _x; set => _x = value; }
        public float Y { get => _y; set => _y = value; }
        public void SetTam(int tam)
        {
            if (tam < 0) { tam = 1; }
            if (tam > 10) { tam = 10; }
            this._tam = tam;
        }
        public void SetVel(int vel)
        {
            if (vel < 0) { vel = 1; }
            if (vel > 5) { vel = 5; }
            this._vel = vel;
        }
        public void SetEnergia(int energia)
        {
            if (energia < 0) { energia = 1; }
            if (energia > 5) { energia = 5; }
            this._energia = energia;
        }
        public int Tam { get => _tam; }
        public int Vel { get => _vel; }
        public int Energia { get => _energia; }
    }
}
