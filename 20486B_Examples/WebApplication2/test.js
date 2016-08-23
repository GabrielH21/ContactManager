var itemCount = 0;

function AddItems() {
    
    itemCount++;
    var list = document.getElementById("myList");
    var newItem = document.createElement("li");
    newItem.textContent = "Item #" + itemCount;
    list.appendChild(newItem);

}

var myButton = document.getElementById("addButton");
myButton.addEventListener("mouseover", AddItems, false);