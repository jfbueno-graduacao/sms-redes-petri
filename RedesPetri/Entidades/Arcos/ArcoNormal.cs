﻿namespace RedesPetri.Entidades.Arcos
{
    public sealed record ArcoNormal(Lugar Lugar, int Peso, Transicao Transicao, DirecaoArco Direcao) : Arco(Lugar, Peso, Transicao, Direcao)
    {
        /// <summary>
        /// tipo normal habilita se estiver com marcas maiores ou igual ao peso do arco
        /// </summary>
        public override bool EstáHabilitado => base.EstáHabilitado && Peso <= Lugar.Marcas;

        /// <summary>
        /// Consome marcas do Lugar de acordo com valor da propriedade Peso
        /// </summary>
        public override void ConsumirMarcasDoLugar() => Lugar.ConsumirMarcas(Peso);
    }
}
