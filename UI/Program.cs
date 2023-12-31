﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardapio.TiposCardapios;
using GestaoDePedidos.Mesas;
using UI.Menu;

namespace UI;

public class TesteUI
{
    public static void Main(string[] args)
    {
        CardapioLogica cardapio = new CardapioLogica();
        Comanda comanda = new Comanda();

        var recepcao = new MenuRecepcao();
        var atendimento = new MenuGarcom();
        var mesa = recepcao.SelecionaMesa();
        var garcom = atendimento.AtribuiGarcom(mesa);
        atendimento.MostraCardapio(garcom);
        var usuario = new MenuMesa(mesa);
        usuario.MenuLoop(mesa, cardapio, garcom);
    }
}
