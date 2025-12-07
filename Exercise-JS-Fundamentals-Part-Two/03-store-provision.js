function storeProvision(currentStock, orderedStock){
    let store = {};//празен обект, който ще използваме за речник

    for(let i = 0;i < currentStock.length; i+= 2){
        const productName = currentStock[i];//само четни индекси
        const quantity = Number(currentStock[i + 1]);//само нечетни индекси
        store[productName] = quantity;
    }

    for(let i = 0; i < orderedStock.length; i += 2){
        const productName = orderedStock[i];//само четни индекси
        const quantity = Number(orderedStock[i + 1]);//само нечетни индекси
        if(store.hasOwnProperty(productName)){//проверяваме дали има такъв продукт
            store[productName] += quantity;//добавяме количество към съществуващ продукт
        }
        else{
            store[productName] = quantity;//добавяме нов продукт;
        }
    }

    for(const key in store){
        console.log(`${key} -> ${store[key]}`);
    }
}
storeProvision([
'Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'
],
[
'Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30'
]
);