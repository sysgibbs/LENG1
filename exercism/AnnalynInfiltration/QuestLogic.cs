// En tu archivo Program.cs // 1\. Probar Ataque Rápido
bool puedoAtacar = QuestLogic.CanFastAttack(knightIsAwake: true);
Console.WriteLine($"Ataque rápido: {puedoAtacar}");
// Imprime: False // 2\. Probar Espiar
bool puedoEspiar = QuestLogic.CanSpy(knightIsAwake: false, archerIsAwake: true, prisonerIsAwake: false);
Console.WriteLine($"Puedo espiar: {puedoEspiar}"); // Imprime: True
// 3\. Probar Señal al Prisionero
bool puedoSenalar = QuestLogic.CanSignalPrisoner(archerIsAwake: false, prisonerIsAwake: true);
Console.WriteLine($"Puedo señalar: {puedoSenalar}"); // Imprime: True
// 4\. Probar Liberar Prisionero
bool puedoLiberar = QuestLogic.CanFreePrisoner(knightIsAwake: false, archerIsAwake: true, prisonerIsAwake: false, petDogIsPresent: false);
Console.WriteLine($"Puedo liberar: {puedoLiberar}");
