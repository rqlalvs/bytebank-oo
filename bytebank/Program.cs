﻿using bytebank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();

conta1.titular = "Raquel";
conta1.conta = "12345-5";
conta1.saldo = 100.00;
conta1.numero_agencia = 123456;
conta1.nome_agencia = "Agencia Central";

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Agencia: " + conta1.nome_agencia);
//Console.WriteLine("Numero Agencia: " + conta1.numero_agencia);
//Console.WriteLine("Saldo: " + conta1.saldo);

ContaCorrente conta2 = new ContaCorrente();

Console.WriteLine("Titular: " + conta2.titular);
Console.WriteLine("Conta: " + conta2.conta);
Console.WriteLine("Agencia: " + conta2.nome_agencia);
Console.WriteLine("Numero Agencia: " + conta2.numero_agencia);
Console.WriteLine("Saldo: " + conta2.saldo);
Console.WriteLine("Verificador: " + conta2.verificador);


Console.ReadKey();