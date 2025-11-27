// DESCRIZIONE: Questo file deve contenere l'interfaccia ICategoryRepository.
//
// L'interfaccia deve definire i seguenti metodi per la gestione delle categorie:
//
// 1. GetAllCategories(): metodo che restituisce tutte le categorie disponibili
//    (restituisce una collezione di oggetti Category)
//
// 2. GetCategoryById(int id): metodo che restituisce una categoria specifica
//    in base al suo identificatore (restituisce un oggetto Category o null se non trovata)
//
// 3. AddCategory(Category category): metodo per aggiungere una nuova categoria
//    (restituisce l'oggetto Category creato con l'id assegnato)
//
// 4. UpdateCategory(Category category): metodo per aggiornare una categoria esistente
//    (restituisce l'oggetto Category aggiornato o null se non trovata)
//
// 5. DeleteCategory(int id): metodo per eliminare una categoria
//    (restituisce true se eliminata con successo, false altrimenti)
//
// 6. HasProducts(int categoryId): metodo che verifica se esistono prodotti associati
//    a una categoria specifica (restituisce true se ci sono prodotti, false altrimenti)
//    Questo metodo è importante per impedire la cancellazione di categorie che hanno prodotti associati.
//
// Il candidato deve implementare questa interfaccia con i metodi appropriati,
// considerando i tipi di ritorno e i parametri necessari per ciascuna operazione.

