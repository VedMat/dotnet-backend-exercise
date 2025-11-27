# DotNet Backend Exercise

## Introduzione all'esercizio

Questo esercizio è progettato per valutare le competenze nello sviluppo di API REST con .NET. Il candidato dovrà implementare un sistema di gestione prodotti e categorie utilizzando le best practices di .NET, inclusa la dependency injection, i repository pattern e le minimal APIs.

L'esercizio richiede la creazione di un'applicazione Web API che gestisce due entità principali: **Category** (Categoria) e **Product** (Prodotto), con una relazione uno-a-molti tra di esse.

## Descrizione delle entità e della relazione 1-N

### Category (Categoria)
Una categoria rappresenta una classificazione di prodotti. Ogni categoria ha:
- **Id**: Identificatore univoco numerico
- **Name**: Nome della categoria (es. "Laptops", "Accessories")

### Product (Prodotto)
Un prodotto rappresenta un elemento vendibile. Ogni prodotto ha:
- **Id**: Identificatore univoco numerico
- **Name**: Nome del prodotto (es. "MacBook Air", "Wireless Mouse")
- **Price**: Prezzo del prodotto in formato decimale
- **CategoryId**: Riferimento alla categoria di appartenenza

### Relazione 1-N
La relazione tra Category e Product è di tipo **uno-a-molti** (1-N):
- Una categoria può avere **molti** prodotti associati
- Un prodotto appartiene a **una sola** categoria
- Questa relazione è implementata tramite il campo `CategoryId` nella classe Product

**Vincolo importante**: Non è possibile eliminare una categoria se esistono prodotti associati ad essa.

## Istruzioni su cosa deve implementare il candidato

Il candidato deve implementare:

1. **Le classi Model** (`Category.cs` e `Product.cs`) con le proprietà appropriate
2. **Le interfacce Repository** (`ICategoryRepository.cs` e `IProductRepository.cs`) con i metodi necessari
3. **Le implementazioni Repository** (`InMemoryCategoryRepository.cs` e `InMemoryProductRepository.cs`) con tutta la logica CRUD
4. **Gli endpoint REST** in `Program.cs` per esporre le operazioni CRUD tramite HTTP
5. **Gestione degli errori** appropriata (404 per risorse non trovate, 400 per richieste non valide, ecc.)
6. **Validazione dei dati** in input (verificare che i dati siano corretti prima di salvarli)

### Requisiti tecnici

- Utilizzare **.NET 8** o superiore
- Implementare il pattern **Repository** per l'accesso ai dati
- Utilizzare **Dependency Injection** per gestire le dipendenze
- I repository devono essere registrati come **Singleton**
- Utilizzare **Minimal APIs** per gli endpoint REST
- I dati devono essere caricati dai file JSON all'avvio dell'applicazione
- I dati devono essere gestiti **in memoria** (non è richiesta persistenza su database)

## Lista degli endpoint richiesti

### Endpoint per Category

| Metodo HTTP | Endpoint | Descrizione | Codici di risposta |
|-------------|----------|-------------|-------------------|
| GET | `/api/categories` | Ottiene tutte le categorie | 200 OK |
| GET | `/api/categories/{id}` | Ottiene una categoria per ID | 200 OK, 404 Not Found |
| POST | `/api/categories` | Crea una nuova categoria | 201 Created, 400 Bad Request |
| PUT | `/api/categories/{id}` | Aggiorna una categoria esistente | 200 OK, 404 Not Found, 400 Bad Request |
| DELETE | `/api/categories/{id}` | Elimina una categoria | 204 No Content, 404 Not Found, 400 Bad Request (se ha prodotti associati) |

### Endpoint per Product

| Metodo HTTP | Endpoint | Descrizione | Codici di risposta |
|-------------|----------|-------------|-------------------|
| GET | `/api/products` | Ottiene tutti i prodotti | 200 OK |
| GET | `/api/products/{id}` | Ottiene un prodotto per ID | 200 OK, 404 Not Found |
| GET | `/api/products/category/{categoryId}` | Ottiene tutti i prodotti di una categoria | 200 OK |
| POST | `/api/products` | Crea un nuovo prodotto | 201 Created, 400 Bad Request |
| PUT | `/api/products/{id}` | Aggiorna un prodotto esistente | 200 OK, 404 Not Found, 400 Bad Request |
| DELETE | `/api/products/{id}` | Elimina un prodotto | 204 No Content, 404 Not Found |

### Note sugli endpoint

- Tutti gli endpoint devono restituire dati in formato **JSON**
- Gli endpoint POST e PUT devono accettare il body della richiesta in formato JSON
- Gli endpoint DELETE devono restituire **204 No Content** in caso di successo
- Gli endpoint GET devono restituire **404 Not Found** se la risorsa non esiste
- Gli endpoint POST devono restituire **201 Created** con il corpo della risorsa creata
- Gli endpoint PUT devono restituire **400 Bad Request** se il body non è valido o se l'ID nell'URL non corrisponde all'ID nel body

## Istruzioni per eseguire il progetto

1. **Prerequisiti**:
   - Installare [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) o superiore
   - Un editor di codice (Visual Studio, Visual Studio Code, Rider, ecc.)

2. **Preparazione**:
   ```bash
   # Navigare nella cartella del progetto
   cd dotnet-backend-exercise
   
   # Creare un nuovo progetto Web API (se non esiste già)
   dotnet new webapi -n src
   ```

3. **Implementazione**:
   - Implementare tutte le classi e gli endpoint come descritto nei file di descrizione
   - Assicurarsi che tutti i file JSON siano presenti nella cartella `src/Data/`

4. **Esecuzione**:
   ```bash
   # Navigare nella cartella src
   cd src
   
   # Restaurare le dipendenze (se necessario)
   dotnet restore
   
   # Eseguire l'applicazione
   dotnet run
   ```

5. **Test**:
   - L'applicazione sarà disponibile su `http://localhost:5000` o `https://localhost:5001`
   - Utilizzare un client HTTP (Postman, curl, o il browser) per testare gli endpoint
   - Verificare che tutti gli endpoint funzionino correttamente

## Istruzioni per consegnare il lavoro

1. **Completare l'implementazione**:
   - Implementare tutti i file come descritto nelle descrizioni
   - Assicurarsi che il codice sia pulito, ben strutturato e commentato dove necessario

2. **Testare l'applicazione**:
   - Verificare che tutti gli endpoint funzionino correttamente
   - Testare i casi limite (eliminazione categoria con prodotti, prodotti con categoria inesistente, ecc.)

3. **Preparare la consegna**:
   - Assicurarsi che il progetto compili senza errori
   - Verificare che non ci siano file temporanei o di build nel repository
   - Creare un commit con tutte le modifiche

4. **Documentazione aggiuntiva** (opzionale ma consigliata):
   - Aggiungere commenti al codice dove necessario
   - Documentare eventuali scelte architetturali o implementative

5. **Consegna**:
   - Inviare il link al repository Git o un file ZIP con il progetto completo
   - Includere eventuali note o considerazioni sull'implementazione

## Note aggiuntive

- I file JSON (`categories.json` e `products.json`) contengono i dati iniziali che devono essere caricati all'avvio
- I repository devono gestire l'autoincremento degli ID quando si aggiungono nuove entità
- La validazione deve verificare che i CategoryId nei prodotti facciano riferimento a categorie esistenti
- Considerare l'uso di `System.Text.Json` per la serializzazione/deserializzazione JSON

Buon lavoro!
