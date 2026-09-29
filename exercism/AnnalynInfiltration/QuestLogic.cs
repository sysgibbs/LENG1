
bool puedoAtacar = QuestLogic.CanFastAttack(knightIsAwake: true);
Console.WriteLine($"Ataque rápido: {puedoAtacar}");

bool puedoEspiar = QuestLogic.CanSpy(knightIsAwake: false, archerIsAwake: true, prisonerIsAwake: false);
Console.WriteLine($"Puedo espiar: {puedoEspiar}"); // Imprime: True

bool puedoSenalar = QuestLogic.CanSignalPrisoner(archerIsAwake: false, prisonerIsAwake: true);
Console.WriteLine($"Puedo señalar: {puedoSenalar}"); // Imprime: True

bool puedoLiberar = QuestLogic.CanFreePrisoner(knightIsAwake: false, archerIsAwake: true, prisonerIsAwake: false, petDogIsPresent: false);
Console.WriteLine($"Puedo liberar: {puedoLiberar}");
