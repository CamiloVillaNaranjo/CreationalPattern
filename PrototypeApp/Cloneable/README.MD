# Cloneable Folder

If I only apply the **ICloneable** interface to the Product class, when I create a new product using Clone Method, implemented by the interface "ICloneable", it makes a Shallow Copy, it means, that the property "Category", will be a reference to it original instance, so if I modify it in the clone, it will be affected in the original.
That is why I have to implement the interface **ICLoneable** in both Clases.