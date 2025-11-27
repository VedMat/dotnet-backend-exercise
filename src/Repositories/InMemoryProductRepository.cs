// DESCRIZIONE: Questo file deve contenere l'implementazione della classe InMemoryProductRepository.
//
// La classe deve implementare l'interfaccia IProductRepository e gestire i prodotti in memoria.
//
// COMPORTAMENTO RICHIESTO:
//
// 1. All'avvio dell'applicazione (nel costruttore o in un metodo di inizializzazione):
//    - Leggere il contenuto del file "src/Data/products.json"
//    - Deserializzare il JSON in una collezione di oggetti Product
//    - Memorizzare questa collezione in una variabile di istanza (es. List<Product>)
//
// 2. Gestione dell'autoincremento dell'Id:
//    - Quando si aggiunge un nuovo prodotto tramite AddProduct, se il prodotto
//      non ha un Id assegnato (o ha Id = 0), calcolare automaticamente il prossimo Id disponibile
//      basandosi sul valore massimo degli Id esistenti nella collezione
//
// 3. Implementazione dei metodi dell'interfaccia:
//    - GetAllProducts(): restituisce tutti i prodotti memorizzati in memoria
//    - GetProductById(int id): cerca e restituisce il prodotto con l'id specificato
//    - GetProductsByCategoryId(int categoryId): filtra e restituisce tutti i prodotti
//      che hanno il CategoryId corrispondente al parametro fornito
//    - AddProduct(Product product): aggiunge un nuovo prodotto alla collezione in memoria
//      (gestendo l'autoincremento dell'id se necessario)
//    - UpdateProduct(Product product): aggiorna un prodotto esistente nella collezione
//      (verificare che il prodotto con l'id specificato esista prima di aggiornarlo)
//    - DeleteProduct(int id): elimina un prodotto dalla collezione in memoria
//      (verificare che il prodotto esista prima di eliminarlo)
//
// 4. Validazione:
//    - Prima di aggiungere o aggiornare un prodotto, verificare che il CategoryId
//      faccia riferimento a una categoria esistente (potrebbe richiedere un riferimento
//      a ICategoryRepository per questa validazione)
//
// Il candidato deve implementare questa classe con tutta la logica necessaria,
// gestendo correttamente la lettura del file JSON, la deserializzazione, e tutte le operazioni CRUD,
// inclusa la ricerca per categoria.

