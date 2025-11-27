// DESCRIZIONE: Questo file deve contenere l'implementazione della classe InMemoryCategoryRepository.
//
// La classe deve implementare l'interfaccia ICategoryRepository e gestire le categorie in memoria.
//
// COMPORTAMENTO RICHIESTO:
//
// 1. All'avvio dell'applicazione (nel costruttore o in un metodo di inizializzazione):
//    - Leggere il contenuto del file "src/Data/categories.json"
//    - Deserializzare il JSON in una collezione di oggetti Category
//    - Memorizzare questa collezione in una variabile di istanza (es. List<Category>)
//
// 2. Gestione dell'autoincremento dell'Id:
//    - Quando si aggiunge una nuova categoria tramite AddCategory, se la categoria
//      non ha un Id assegnato (o ha Id = 0), calcolare automaticamente il prossimo Id disponibile
//      basandosi sul valore massimo degli Id esistenti nella collezione
//
// 3. Implementazione dei metodi dell'interfaccia:
//    - GetAllCategories(): restituisce tutte le categorie memorizzate in memoria
//    - GetCategoryById(int id): cerca e restituisce la categoria con l'id specificato
//    - AddCategory(Category category): aggiunge una nuova categoria alla collezione in memoria
//      (gestendo l'autoincremento dell'id se necessario)
//    - UpdateCategory(Category category): aggiorna una categoria esistente nella collezione
//    - DeleteCategory(int id): elimina una categoria solo se non esistono prodotti associati
//      (utilizzare il metodo HasProducts per verificare questa condizione)
//    - HasProducts(int categoryId): verifica se esistono prodotti associati a questa categoria
//      (questo metodo richiederà un riferimento a IProductRepository per controllare i prodotti)
//
// 4. Gestione della cancellazione:
//    - Il metodo DeleteCategory deve impedire la cancellazione se HasProducts restituisce true
//    - In caso di tentativo di cancellazione con prodotti associati, restituire false
//
// 5. Iniezione delle dipendenze:
//    - La classe deve ricevere IProductRepository tramite dependency injection nel costruttore
//      per poter verificare l'esistenza di prodotti associati
//
// Il candidato deve implementare questa classe con tutta la logica necessaria,
// gestendo correttamente la lettura del file JSON, la deserializzazione, e tutte le operazioni CRUD.

