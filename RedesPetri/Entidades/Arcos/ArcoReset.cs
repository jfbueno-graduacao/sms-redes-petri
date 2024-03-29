﻿namespace RedesPetri.Entidades.Arcos
{
    public sealed record ArcoReset(Lugar Lugar, int Peso, Transicao Transicao, DirecaoArco Direcao) : Arco(Lugar, Peso, Transicao, Direcao)
    {
        /// <summary>
        /// Consome todas as marcas do lugar
        /// </summary>
        public override void ConsumirMarcasDoLugar() => Lugar.ConsumirTodasMarcas();
    }
}
