// DESCRIZIONE: Questo file deve contenere il punto di ingresso dell'applicazione Web API.
//
// STRUTTURA RICHIESTA:
//
// 1. Configurazione del builder dell'applicazione Web:
//    - Creare un WebApplicationBuilder utilizzando WebApplication.CreateBuilder()
//
// 2. Registrazione dei servizi (Dependency Injection):
//    - Registrare ICategoryRepository con l'implementazione InMemoryCategoryRepository come Singleton
//    - Registrare IProductRepository con l'implementazione InMemoryProductRepository come Singleton
//    - Nota: l'ordine di registrazione è importante perché InMemoryCategoryRepository
//      potrebbe avere una dipendenza da IProductRepository
//
// 3. Costruzione dell'applicazione:
//    - Costruire l'applicazione Web utilizzando builder.Build()
//
// 4. Configurazione degli endpoint REST:
//    - TODO: Il candidato deve implementare gli endpoint REST per Category e Product
//    - Gli endpoint devono supportare le operazioni CRUD complete
//    - Vedere il README.md per la lista completa degli endpoint richiesti
//
// 5. Avvio dell'applicazione:
//    - Eseguire app.Run() per avviare il server
//
// NOTA IMPORTANTE:
// Questo file deve essere un "minimal API" di .NET, quindi utilizzare la sintassi
// moderna con app.MapGet(), app.MapPost(), app.MapPut(), app.MapDelete(), ecc.
//
// Il candidato deve implementare tutti gli endpoint REST necessari per completare l'esercizio.

