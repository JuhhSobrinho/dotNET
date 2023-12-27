using trilha_net_poo_desafio.models;



Nokia nok = new Nokia("2345678", "Tijolão", "H2K4UP", 88);
nok.InstalarAplicativo("Dio.app");
nok.Ligar();
nok.ReceberLigacao();

Iphone iph = new Iphone("7722998", "acimaDoqueDaparaPagar", "C4RR0", 10);
iph.InstalarAplicativo("Dio.app");
iph.Ligar();
iph.ReceberLigacao();