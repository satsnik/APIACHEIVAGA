﻿using AcheiVaga.PI4.Models;
using AcheiVaga.PI4.Models.Estacionamento;
using AcheiVaga.PI4.Models.Mall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static AcheiVaga.PI4.Models.Rotas.Rota;

namespace AcheiVaga.PI4.Controllers
{
    public class EstacionamentoController : ApiController
    {
        //[HttpPost]
        //public string InserirEstacionamento()
        //{

        //    List<Loja> lojas = new List<Loja>();
        //    for (int i = 1; i < 5; i++)
        //    {

        //        Models.Mall.Loja LOJANOVA = new Loja("LOJA" + i, i);
        //        lojas.Add(LOJANOVA);
        //    }

        //    Vaga novovaa = new Vaga();
        //    novovaa.CadastrodeVagaretornalista(10, 0, 0);

        //    List<Piso> Pisos = new List<Piso>();

        //    Piso piso1 = new Piso(1, novovaa.CadastrodeVagaretornalista(10, 1, 0));
        //    Pisos.Add(piso1);
        //    Piso piso2 = new Piso(2, novovaa.CadastrodeVagaretornalista(10, 2, 0));
        //    Pisos.Add(piso2);
        //    Piso piso3 = new Piso(3, novovaa.CadastrodeVagaretornalista(10, 3, 0));
        //    Pisos.Add(piso3);
        //    Piso piso4 = new Piso(4, novovaa.CadastrodeVagaretornalista(10, 4, 0));
        //    Pisos.Add(piso4);
        //    Piso piso5 = new Piso(5, novovaa.CadastrodeVagaretornalista(10, 5, 0));
        //    Pisos.Add(piso5);

        //    Mall novoshopin = new Mall(lojas, Pisos);
        //    novoshopin.InseriShooping(novoshopin);
        //    return "dkamskdm";


        //}

        [HttpGet]
        public Vaga BuscarMelhorVaga(String nomeloja)
        {
            Mall mall = new Mall();
            return mall.MelhorVaga(nomeloja);
        }


        [HttpPost]
        public string OcuparVaga(int codigodopiso,int codigodavaga)
        {
            Mall mall = new Mall();
            return mall.OcuparVaga(codigodavaga,codigodavaga);
        }

        [HttpPost]
        public string desocuparvaga(int codigodopiso, int codigodavaga,string desocupar)
        {
            Mall mall = new Mall();
            return mall.Desocupar(codigodavaga, codigodavaga);
        }

        [HttpGet]
        public string BuscarTodasAsvagas()
        {
            Mall mall = new Mall();
            return mall.GetTodasAsVagas();
        }


        [HttpGet]
        public string BuscarTodasAsvagasporandar(int codigoandar)
        {
            Mall mall = new Mall();
            return mall.GetTodasAsVagasPorAndar(codigoandar);
        }









    }
}
