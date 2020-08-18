# DeepCopy Folder

## Why IPrototype interface?
Because I create an interface that use Generics approach (instance of T type, where T coul be Product or Category in the current context folder).

### Recapping
If I only apply the **IPrototype** interface to the **Product** class, when I create a new product using __DeepCopy__ method, implemented by the interface, it makes a Shallow Copy of the original, as **ICloneable** does, the big difference here is that I used Generics.
So the property "Category", will be a reference to its original instance, and if I modify it in the copy, it will be affected in the original, until I apply the same interface for Category class, and I modify the DeepCopy method inside Product class.
That is why I have to implement the interface **IPrototype** in both Clases, and taking care in the way that I handle the __DeepCopy__ method.